using System;
using System.Collections.Generic;
using System.Text;

namespace BattleSpace
{
    abstract class EarthShip : Ship
    {
        const string Prefix = "Human ";

        public EarthShip(string name, int health) : base(Prefix + name, health)
        {
        }

        public abstract override int WeaponPicker();

        public override string ToString()
        {
            return Name;
        }

    }
}
