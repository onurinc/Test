using System;
using System.Collections.Generic;
using System.Text;

namespace BattleSpace
{
    abstract class Ship
    {

        // Voor constructor overloading, een constructor met 1 parameter en de 2e parameter een bepaalde waarde
        public readonly string Name;
        // Even goed kijken hoe dingen private worden gemaakt
        public int HealthPoints { get; private set; }
        public bool IsDestroyed { get; private set; }

        public Ship(string name, int health)
        {
            Name = name;
            HealthPoints = health;
            IsDestroyed = false;
        }

        public void Hit(int damage)
        {
            HealthPoints -= damage;

            if (HealthPoints <= 0)
            {
                IsDestroyed = true;
            }
        }

        public abstract int Fire();

        public string FiredWeapon { get; set; }
        

    }
}
