using System;
using System.Collections.Generic;
using System.Text;

namespace BattleSpace
{

    static class GameMechanics
    {
        const int ShipAmount = 6;

        //The loop of the game & decides which ships turn it is and which ship takes damage.
        public static void GameLooper()
        {
            const int Health = 15;
            Ship[] ships = new Ship[6];
            bool GameOver = false;

            ships[0] = new AlienShipOne("Aeryn", Health);
            ships[1] = new AlienShipOne("Jubal", Health);
            ships[2] = new AlienShipTwo("Lapis", Health);
            ships[3] = new HumanShipOne("Excalibur", Health);
            ships[4] = new HumanShipOne("Odyssey", Health);
            ships[5] = new HumanShipTwo("Link", Health);

            while (!GameOver)
            {
                Random rand = new Random();
                Ship firingShip;
                Ship hitShip;

                int shipIndex = rand.Next(0, 6);

                firingShip = ships[shipIndex];

                if (shipIndex < 3)
                {
                    hitShip = ships[rand.Next(3, 6)];
                }

                else
                {
                    hitShip = ships[rand.Next(0, 3)];
                }

                if (!firingShip.IsDestroyed && !hitShip.IsDestroyed)
                {
                    int fireStrength = firingShip.WeaponPicker();
                    hitShip.TakeDamage(fireStrength);
                    GameMechanics.DisplayBattle(firingShip, hitShip, fireStrength);
                    GameMechanics.DisplayStatus(ships);
                }

                GameOver = GameMechanics.isGameOver(ships);
            }
        }

        // Displays battle info
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

        // Displays status of all the ships
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


        // Checks who won the game
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
