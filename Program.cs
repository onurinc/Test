using System;

namespace BattleSpace
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("BATLLE START");
            GameMechanics.GameLooper();
            Console.ReadKey();
        }
    }
}
