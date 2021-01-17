using System;

namespace BattleSpace
{
    class Program
    {
        const int Health = 15;
        static void Main(string[] args)
        {
            Ship[] ships = new Ship[6];
            bool GameOver = false;

            ships[0] = new AlienShipOne("Aeryn", Health);
            ships[1] = new AlienShipOne("Jubal", Health);
            ships[2] = new AlienShipTwo("Lapis", Health);
            ships[3] = new HumanShipOne("Excalibur", Health);
            ships[4] = new HumanShipOne("Odyssey", Health);
            ships[5] = new HumanShipTwo("Link", Health);

            Console.WriteLine("BATLLE START");

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
                    int fireStrength = firingShip.Fire();
                    hitShip.Hit(fireStrength);
                    GameMechanics.DisplayBattle(firingShip, hitShip, fireStrength);
                    GameMechanics.DisplayStatus(ships);
                }



                GameOver = GameMechanics.isGameOver(ships);
            }

            Console.ReadKey();
        }




    }
}
