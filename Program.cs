using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            bool playGame = true;
            while(playGame == true)
            {
                game.FullGame();
                Console.WriteLine("Would you like toplay again? Enter 1 for yes or a 2 for no.");
                int playInput = int.Parse(Console.ReadLine());
                if(playInput == 2)
                {
                    Console.WriteLine("Thank you for playing RPSLS");
                    playGame = false;
                }
                else
                {
                    Console.WriteLine("Good Luck!");
                }
            }
            Console.ReadLine();
        }
    }
}
