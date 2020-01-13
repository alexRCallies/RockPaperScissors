using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human_Player2 : Player
    {
        public Human_Player2()
        {
            this.name = Console.ReadLine();
        }
        public void Player1Select(Selection options)
        {

            int choice;
            do
            {
                Console.WriteLine("Enter a number 1-5");
                choice = int.Parse(Console.ReadLine());
            }
            while (choice > 5);

        }
    }

}
