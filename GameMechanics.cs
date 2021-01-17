using System;
using System.Collections.Generic;
using System.Text;

namespace BattleSpace
{

    static class GameMechanics
    {
        const int ShipAmount = 6;
        public static void DisplayBattle(Ship firingShip, Ship hitShip, int fireStrength)
        {
            if (fireStrength == 0)
                Console.WriteLine("\n{0} had to reload {1}\n", firingShip.Name, firingShip.FiredWeapon);
            else
            {
                Console.WriteLine("\n{0} fires: {1}", firingShip, firingShip.FiredWeapon);
                Console.WriteLine("{0}: is HIT. HP is {1}\n", hitShip.Name, hitShip.HealthPoints);
            }
        }

        public static void DisplayStatus(Ship[] ships)
        {
            for (int i = 0; i < ShipAmount; i++)
            {
                if (!ships[i].IsDestroyed)
                    Console.WriteLine("{0} HP is {1}", ships[i].Name, ships[i].HealthPoints);
            }

            for (int i = 0; i < ShipAmount; i++)
            {
                if (ships[i].IsDestroyed)
                    Console.WriteLine("{0} Has FALLEN", ships[i].Name, ships[i].HealthPoints);
            }
        }

        public static bool isGameOver(Ship[] ships)
        {
            bool GameOver = false;

            if (ships[0].IsDestroyed && ships[1].IsDestroyed && ships[2].IsDestroyed)
            {
                Console.WriteLine("Victory for the HUMANS");
                return true;
            }

            if (ships[3].IsDestroyed && ships[4].IsDestroyed && ships[5].IsDestroyed)
            {
                Console.WriteLine("Victory for the ALIENS");
                return true;
            }

            return false;
        }

    }
}
