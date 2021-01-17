using System;
using System.Collections.Generic;
using System.Text;

namespace BattleSpace
{
   abstract class SpaceShip : Ship
    {
        const string PrefixName = "Alien ";

        public SpaceShip(string name, int health) : base(PrefixName + name, health)
        {
        }

        public abstract override int Fire();

        public override string ToString()
        {
            return Name;
        }
    }
}
