using System;
using System.Collections.Generic;
using System.Text;

namespace BattleSpace
{
    class HumanShipOne : EarthShip
    {
        private int CannonballAmmo;
        const int FireballDamage = 1;
        const int CannonballDamage = 4;

        public HumanShipOne(string name, int health) : base(name, health)
        {
            CannonballAmmo = 3;
        }

        public override int Fire()
        {
            Random rand = new Random();
            int weapon = rand.Next(200);

            if (weapon < 100)
            {
                FiredWeapon = "Fireball";
                return FireballDamage;
            }
            else
            {
                if (CannonballAmmo == 0)
                {
                    FiredWeapon = "Cannonball";
                    CannonballAmmo = 3;
                    return 0;
                }
                FiredWeapon = "Cannonball";
                CannonballAmmo--;
                return CannonballDamage;
            }
        }
    }
}
