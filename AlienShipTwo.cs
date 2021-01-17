using System;
using System.Collections.Generic;
using System.Text;

namespace BattleSpace
{
    class AlienShipTwo : SpaceShip
    {
        private int FireballAmmo;
        const int FireballDamage = 1;
        const int CannonballDamage = 2;

        public AlienShipTwo(string name, int health) : base(name, health)
        {
            FireballAmmo = 10;
        }

        public override int WeaponPicker()
        {
            Random rand = new Random();
            int weapon = rand.Next(200);

            if (weapon < 100)
            {
                FiredWeapon = "Cannonball";
                return CannonballDamage;
            }
            else
            {
                if (FireballAmmo == 0)
                {
                    FiredWeapon = "Fireball";
                    FireballAmmo = 10;
                    return 0;
                }
                FiredWeapon = "Fireball";
                FireballAmmo--;
                return FireballDamage;
            }
        }
    }
}
