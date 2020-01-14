using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
   abstract class Player
    {
       public string name;
        public int choice;
        public int counter;

        public Player()
        {
            this.counter = 0;
        }
        public abstract void Choice();
        //{
        //    choice = int.Parse(Console.ReadLine());
        //}
        

        
    }
}
