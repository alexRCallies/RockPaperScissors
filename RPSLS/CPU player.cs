using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class CPU_player : Player
    {
        public CPU_player()
        {
            this.name = "CPU";
        }
        public int CPUChoice()

        {
            
            Random rng = new Random();
            int selection = rng.Next(1,6);
            return selection;
        }

    }
}
