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
        public override void Choice()

        {
            
            Random rng = new Random();
            int selection = rng.Next(0,5);
            choice = selection;
        }

    }
}
