using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
   class Human_Player1 : Player
    {
       
        
        public Human_Player1()
        {
            this.name = Console.ReadLine();
        }
        public override void Choice()
        {
            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("Enter between 1-5");
            }
        }

    }
}
