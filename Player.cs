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

        // constructor
        public Player(string name)
        {
            this.name = name;
            chosenValue = null;
        }

        public virtual void ChooseGesture(List<string> gestures)
        {
            int showIndex = 0;
            Console.WriteLine("Please choose one of the options below by entering the number beside it.");
            foreach(string gesture in gestures)
            {
                Console.WriteLine($"{ gesture} {showIndex}");
                showIndex++;
            }
            string choice = Console.ReadLine();
            chosenValue =  choice;
        }





    }
}
