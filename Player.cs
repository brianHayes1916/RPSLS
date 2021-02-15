using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Player
    {
        public string name;
        public string chosenValue;
        public int score;

        // constructor
        public Player(string name)
        {
            this.name = name;
            chosenValue = null;
            score = 0;
        }

        //put this bad boy in a while loop until chosenValue is a valid choice
        public virtual void ChooseGesture(List<string> gestures)
        {
            bool goodChoice = false;
            while (goodChoice == false)
            {
                int showIndex = 0;
                Console.WriteLine("Please choose one of the options below by entering the number beside it.");
                foreach (string gesture in gestures)
                {
                    Console.WriteLine($"{ gesture} {showIndex}");
                    showIndex++;
                }
                int choice = int.Parse(Console.ReadLine());
                if(choice >= 0 && choice <= 4)
                {
                    Console.WriteLine("Good choice");
                    goodChoice = true;
                }
                else
                {
                    Console.WriteLine("Invalid response please try again");
                    continue;
                }
                string choiceString = gestures[choice];
                chosenValue = choiceString;
            }

        }





    }
}
