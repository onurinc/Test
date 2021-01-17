using System;
using System.Collections.Generic;
using System.Text;

namespace BattleSpace
{
    class HumanShipTwo : EarthShip
    {
        private int CannonballAmmo;
        const int FireballDamage = 1;
        const int CannonballDamage = 6;

        public HumanShipTwo(string name, int health) : base(name, health)
        {
            CannonballAmmo = 10;
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
                    CannonballAmmo = 10;
                    return 0;
                }
                FiredWeapon = "Fireball";
                CannonballAmmo--;
                return CannonballDamage;
            }
        }
    }
}

