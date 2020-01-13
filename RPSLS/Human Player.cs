using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human_Player1 : Player
    {
        public int choice;
        public Human_Player1()
        {
            this.name = Console.ReadLine();
            
        }
        //public int PlayerSelect()
        //{

        //    int choice;
            
        //        Console.WriteLine("Enter a number 1-5");
        //        choice = int.Parse(Console.ReadLine());
           
            
        //    return choice;
        //}
    }
}
