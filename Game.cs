using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        public Player playerOne;
        public Player playerTwo;
        public List<string> gestures;

        //constructor

        public Game(Player pOne, Player pTwo)
        {
            playerOne = pOne;
            playerTwo = pTwo;
            gestures = new List<string>();
            gestures.Add("Rock");
            gestures.Add("Paper");
            gestures.Add("Scissors");
            gestures.Add("Lizard");
            gestures.Add("Spock");
        }

        public void Welcome()
        {
            Console.WriteLine("Welcome to RPSLS!");
            Console.WriteLine("Also know as rock paper scissors lizard spock!");
            Console.WriteLine("In This game you will choose which gesture you would like to use and your oponent will do the same.");
            Console.WriteLine("Whoever has the winning gesture will get a point! First to three points wins!");
            Console.WriteLine("The relationships are as follows:");
            Console.WriteLine("Rock crushes Scissors");
            Console.WriteLine("Scissors cut paper");
            Console.WriteLine("Paper covers Rock");
            Console.WriteLine("Rock crushes Lizard");
            Console.WriteLine("Lizard poisons Spock");
            Console.WriteLine("Spock smashes Scissors");
            Console.WriteLine("Scissors decapitate Lizard");
            Console.WriteLine("Lizard eats Paper");
            Console.WriteLine("Paper disproves Spock");
            Console.WriteLine("Spock vaporizes Rock");
        }


        
    }
}
