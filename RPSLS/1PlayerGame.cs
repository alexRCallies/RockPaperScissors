using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class _1PlayerGame
    {


        Player player1;
        Player player2;
        PlayerSelector playerSelector = new PlayerSelector();

        public _1PlayerGame()
        {

        }
        public void RunGame(List<Options> options)
        {
            //Console.WriteLine("How many players will there be 1 or 2");
            //if(playerSelector == 1)
            //{
            //    player2 = new CPU_player();
            //}
            //if(playerSelector == 2)
            //{
            //    player2 = new Human_Player1();
            //}
            //Console.WriteLine("What is your name?");
            //player1 = new Human_Player1();
            playerSelector.HowManyPlayers();
            if (playerSelector.choice == 1) 
            {
                Console.WriteLine("What is your name?:");
                player1 = new Human_Player1();
                player2 = new CPU_player();
            }
            if (playerSelector.choice == 2) 
            {
                Console.WriteLine("What is your name p1?:");
                player1 = new Human_Player1();
                Console.WriteLine("What is your name p2?:");
                player2 = new Human_Player1();
            }
            foreach (Options option in options)
            {
                Console.WriteLine(option.name + option.number);
            }


            //while (cpuCounter < 2 && playerCounter < 2)
            //{
                player1.Choice();
                if (player1.choice == options[0].number)
                {
                    Console.WriteLine(player1.name + " you chose:" + options[0].name);

                }
                if (player1.choice == options[1].number)
                {
                    Console.WriteLine(player1.name + " you chose:" + options[1].name);

                }
                if (player1.choice == options[2].number)
                {
                    Console.WriteLine(player1.name + " you chose:" + options[2].name);

                }
                if (player1.choice == options[3].number)
                {
                    Console.WriteLine(player1.name + " you chose:" + options[3].name);

                }
                if (player1.choice == options[4].number)
                {
                    Console.WriteLine(player1.name+" you chose:" + options[4].name);

                }
            player2.Choice();
            if (player2.choice == options[0].number) 
            {
                Console.WriteLine(player2.name+" you chose:"+options[0].name);
            }
            if (player2.choice == options[1].number)
            {
                Console.WriteLine(player2.name + " you chose:" + options[1].name);
            }
            if (player2.choice == options[2].number)
            {
                Console.WriteLine(player2.name + " you chose:" + options[2].name);
            }
            if (player2.choice == options[3].number)
            {
                Console.WriteLine(player2.name + " you chose:" + options[3].name);
            }
            if (player2.choice == options[4].number)
            {
                Console.WriteLine(player2.name + " you chose:" + options[4].name);
            }

        }
    }


    }

               
        
    

