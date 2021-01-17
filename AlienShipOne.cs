using System;
using System.Collections.Generic;
using System.Text;

namespace BattleSpace
{
    class AlienShipOne : SpaceShip
    {
        private int CannonballAmmo;
        private int SuperCannonballAmmo;
        const int FireballDamage = 1;
        const int CannonBallDamage = 2;
        const int SuperCannonballDamage = 4;


        public AlienShipOne(string name, int health) : base(name, health)
        {
            CannonballAmmo = 1;
            SuperCannonballAmmo = 1;
        }

        public override int WeaponPicker()
        {
            Random rand = new Random();
            int weapon = rand.Next(300);

            if(weapon < 100)
            {
                FiredWeapon = "Fireball";
                return FireballDamage;
            }
            else if (weapon <200)
            {
                if (CannonballAmmo == 0)
                {
                    FiredWeapon = "Cannonball";
                    CannonballAmmo = 1;
                    return 0;
                }
                FiredWeapon = "Cannonball";
                CannonballAmmo--;
                return CannonBallDamage;
            }
            else
            {
                if (SuperCannonballAmmo == 0)
                {
                    FiredWeapon = "Super Cannonball";
                    SuperCannonballAmmo = 1;
                    return 0;
                }
                FiredWeapon = "Super Cannonball";
                CannonballAmmo--;
                return SuperCannonballDamage;
            }
        }
    }
}
