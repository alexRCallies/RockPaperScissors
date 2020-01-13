using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class PlayerSelector
    {
       // public Player player1;
       //public Player player2;
       public int choice;
        public PlayerSelector()
        {

        }
        public void HowManyPlayers()
        {
            Console.WriteLine("How many players?");
            choice = int.Parse(Console.ReadLine());
            //if (choice == 1)
            //{
            //    player1 = new Human_Player1();
            //    player2 = new CPU_player();
            //}
            //if (choice == 2)
            //{
            //    player1 = new Human_Player1();
            //    player2 = new Human_Player1();
            //}

        }
       

    }
}
