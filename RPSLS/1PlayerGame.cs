using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class _1PlayerGame
    {
        //Human_Player1 player1 = new Human_Player1();
        CPU_player cpu = new CPU_player();


       public _1PlayerGame()
        {

        }
        public void RunCpuGame(List<Options> options)
        {
            int cpuCounter = 0;
            int playerCounter = 0;
            Console.WriteLine("What is your name?");
                 Human_Player1 player1 = new Human_Player1();
            foreach (Options option in options)
            {
                Console.WriteLine(option.name);
            }
           
            do
            {
                player1.choice = int.Parse(Console.ReadLine());
               
                if (player1.choice== 1 && cpu.CPUChoice() == 1)
                {
                    Console.WriteLine("Draw");
                    Console.WriteLine(playerCounter + "-" + cpuCounter);

                }
                if (player1.choice == 2 && cpu.CPUChoice() == 2)
                {
                    Console.WriteLine("Draw");
                    Console.WriteLine(playerCounter + "-" + cpuCounter);

                }
                if (player1.choice == 3 && cpu.CPUChoice() == 3)
                {
                    Console.WriteLine("Draw");
                    Console.WriteLine(playerCounter + "-" + cpuCounter);

                }
                if (player1.choice == 4 && cpu.CPUChoice() == 4)
                {
                    Console.WriteLine("Draw");
                    Console.WriteLine(playerCounter + "-" + cpuCounter);

                }
                if (player1.choice == 5 && cpu.CPUChoice() == 5)
                {
                    Console.WriteLine("Draw");
                    Console.WriteLine(playerCounter + "-" + cpuCounter);

                }
                if (player1.choice == 1 && cpu.CPUChoice() == 2)
                {
                    Console.WriteLine("Rock is covered by Paper");
                    cpuCounter += 1;
                    Console.WriteLine(playerCounter + "-" + cpuCounter);

                }
                if (player1.choice == 1 && cpu.CPUChoice() == 3)
                {
                    Console.WriteLine(options[0].name + " crushes " + options[2].name);
                    playerCounter += 1;
                    Console.WriteLine(playerCounter + "-" + cpuCounter);

                }
                if (player1.choice == 1 && cpu.CPUChoice() == 4)
                {
                    Console.WriteLine(options[0].name + " crushes " + options[3].name);
                    playerCounter += 1;
                    Console.WriteLine(playerCounter + "-" + cpuCounter);


                }
                if (player1.choice == 1 && cpu.CPUChoice() == 5)
                {
                    Console.WriteLine(options[0].name + " vaporized by " + options[4].name);
                    cpuCounter += 1;
                    Console.WriteLine(playerCounter + "-" + cpuCounter);

                }
                if (player1.choice == 2 && cpu.CPUChoice() == 1)
                {
                    Console.WriteLine("Paper covers Rock");
                    playerCounter += 1;
                    Console.WriteLine(playerCounter + "-" + cpuCounter);

                }
                if (player1.choice == 2 && cpu.CPUChoice() == 3)
                {
                    Console.WriteLine("Paper is cut by Scissors");
                    cpuCounter += 1;
                    Console.WriteLine(playerCounter + "-" + cpuCounter);
                }
                if (player1.choice == 2 && cpu.CPUChoice() == 4)
                {
                    Console.WriteLine("Paper is eaten by Lizard");
                    cpuCounter += 1;
                    Console.WriteLine(playerCounter + "-" + cpuCounter);

                }
                if (player1.choice == 2 && cpu.CPUChoice() == 5)
                {
                    Console.WriteLine("Paper disproves Spock");
                    playerCounter += 1;
                    Console.WriteLine(playerCounter + "-" + cpuCounter);

                }
                if (player1.choice == 3 && cpu.CPUChoice() == 1)
                {
                    Console.WriteLine("Scissors is crushed by Rock");
                    cpuCounter += 1;
                    Console.WriteLine(playerCounter + "-" + cpuCounter);

                }
                if (player1.choice == 3 && cpu.CPUChoice() == 2)
                {
                    Console.WriteLine("Scissors cuts Paper");
                    playerCounter += 1;
                    Console.WriteLine(playerCounter + "-" + cpuCounter);

                }
                if (player1.choice == 3 && cpu.CPUChoice() == 4)
                {
                    Console.WriteLine("Scissors decapitates Lizard");
                    playerCounter += 1;
                    Console.WriteLine(playerCounter + "-" + cpuCounter);

                }
                if (player1.choice == 3 && cpu.CPUChoice() == 5)
                {
                    Console.WriteLine("Scissors is smashed by Spock");
                    cpuCounter += 1;
                    Console.WriteLine(playerCounter + "-" + cpuCounter);
                }
                if (player1.choice == 4 && cpu.CPUChoice() == 1)
                {
                    Console.WriteLine("Lizard is crushed by Rock");
                    cpuCounter += 1;
                    Console.WriteLine(playerCounter + "-" + cpuCounter);

                }
                if (player1.choice == 4 && cpu.CPUChoice() == 2)
                {
                    Console.WriteLine("Lizard eats Paper");
                    playerCounter += 1;

                    Console.WriteLine(playerCounter + "-" + cpuCounter);
                }
                if (player1.choice == 4 && cpu.CPUChoice() == 3)
                {
                    Console.WriteLine("Lizard is decapitated by Scissors");
                    cpuCounter += 1;
                    Console.WriteLine(playerCounter + "-" + cpuCounter);
                }
                if (player1.choice == 4 && cpu.CPUChoice() == 5)
                {
                    Console.WriteLine("Lizard poisons Spock");
                    playerCounter += 1;
                    Console.WriteLine(playerCounter + "-" + cpuCounter);
                }
                if (player1.choice == 5 && cpu.CPUChoice() == 1)
                {
                    Console.WriteLine("Spock vaporizes Rock");
                    playerCounter += 1;
                    Console.WriteLine(playerCounter + "-" + cpuCounter);
                }
                if (player1.choice == 5 && cpu.CPUChoice() == 2)
                {
                    Console.WriteLine("Spock is disproved by Paper");
                    cpuCounter += 1;
                    Console.WriteLine(playerCounter + "-" + cpuCounter);
                }
                if (player1.choice == 5 && cpu.CPUChoice() == 3)
                {
                    Console.WriteLine("Spock vaporises Scissors");
                    playerCounter += 1;
                    Console.WriteLine(playerCounter + "-" + cpuCounter);
                }
                if (player1.choice == 5 && cpu.CPUChoice() == 4)
                {
                    Console.WriteLine("Spock is poisoned by Lizard");
                    cpuCounter += 1;

                    Console.WriteLine(playerCounter + "-" + cpuCounter);
                }
            }
            while (playerCounter < 3 || cpuCounter < 3);
            if (
        }
    }
}
