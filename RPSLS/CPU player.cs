using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class CPU_player : Player
    {
        Random rng; 

        public CPU_player(Random rng1)
        {
            this.name = "CPU";
            this.rng = rng1;
        }
        public override void Choice()

        {
            
           
            int selection = rng.Next(1,6);
            choice = selection;
        }

    }
}
