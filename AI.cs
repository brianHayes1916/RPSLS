using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class AI : Player
    {
        public AI(string name)
            :base(name){}
        public override void ChooseGesture(List<string> gestures)
        {
            Random random = new Random();
            int rndHold = random.Next(6);
            chosenValue = gestures[rndHold];
        }

    }
}
