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
        Rules rules = new Rules();
        Selection selection = new Selection();
        Random rng;


        public _1PlayerGame()
        {
            rng = new Random();
        }
       
        public void SetNumOfPlayers()
        {
           
           
                Console.WriteLine("How many players 0/1/2?");
                string numOfPlayers = Console.ReadLine();
                if (numOfPlayers == "0")
                {
                    player1 = new CPU_player(rng);
                    player2 = new CPU_player(rng);
                }
               else if (numOfPlayers == "1")
                {
                    Console.WriteLine("What is your name?");
                    player1 = new Human_Player1();
                    player2 = new CPU_player(rng);
                }
               else if (numOfPlayers == "2")
                {
                    Console.WriteLine("P1 What is your name>");
                    player1 = new Human_Player1();
                    Console.WriteLine("P2 What is your name?");
                    player2 = new Human_Player1();
                    Console.WriteLine("Welcome, " + player1.name + " and, " + player2.name);
                }
            else
            {
                SetNumOfPlayers();
            }
                
            
           
        }
        public void FindPlayerChoice(List<Options> options)
        {
            Console.WriteLine("What are you choosing");
            //rules.PrintOptions(selection.options);
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
                Console.WriteLine(player1.name + " you chose:" + options[4].name);
                
            }
            //rules.PrintOptions(selection.options);
            player2.Choice();
            if (player2.choice == options[0].number)
            {
                Console.WriteLine(player2.name + " you chose:" + options[0].name);
                
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
        public void ShowCounter()
        {
            Console.WriteLine(player1.counter+"-"+player2.counter);
        }
        public void CompareChoices(List<Options> options)
        {

            
            do
            {
                
                FindPlayerChoice(selection.options);
                if (player1.choice == options[0].number)
                {
                    if (player2.choice == options[0].number)
                    {
                        Console.WriteLine("Draw!");
                        ShowCounter();

                    }
                    else if (player2.choice == options[1].number)
                    {
                        player2.counter++;
                        Console.WriteLine("Rock is Covered by Paper");
                        ShowCounter();
                    }
                    else if (player2.choice == options[2].number)
                    {
                        player1.counter++;
                        Console.WriteLine("Rock crushes scissors");
                        ShowCounter();
                    }
                    else if (player2.choice == options[3].number)
                    {
                        player1.counter++;
                        Console.WriteLine("Rock crushes Lizard");
                        ShowCounter();
                    }
                    else if (player2.choice == options[4].number)
                    {
                        player2.counter++;
                        Console.WriteLine("Rock is vaporized by Spock");
                        ShowCounter();
                    }
                    else
                    {
                        CompareChoices(selection.options);
                    }
                }
                
               else if (player1.choice == options[1].number)
                {
                    if (player2.choice == options[0].number)
                    {
                        player1.counter++;
                        Console.WriteLine("Paper covers Rock");
                        ShowCounter();

                    }
                    else if (player2.choice == options[1].number)
                    {

                        Console.WriteLine("Draw!");
                        ShowCounter();
                    }
                    else if (player2.choice == options[2].number)
                    {
                        player2.counter++;
                        Console.WriteLine("Paper is cut by Scissors");
                        ShowCounter();
                    }
                    else if (player2.choice == options[3].number)
                    {
                        player2.counter++;
                        Console.WriteLine("Paper is eaten by Lizard");
                        ShowCounter();
                    }
                    else if (player2.choice == options[4].number)
                    {
                        player1.counter++;
                        Console.WriteLine("Paper disproves Spock");
                        ShowCounter();
                    }
                    else
                    {
                        CompareChoices(selection.options);
                    }
                }
                
               else if (player1.choice == options[2].number)
                {
                    if (player2.choice == options[0].number)
                    {
                        player2.counter++;
                        Console.WriteLine("Scissors is crushed by Rock");
                        ShowCounter();
                    }
                    else if (player2.choice == options[1].number)
                    {
                        player1.counter++;
                        Console.WriteLine("Scissors cuts Paper");
                        ShowCounter();
                    }
                    else if (player2.choice == options[2].number)
                    {
                        Console.WriteLine("Draw!");
                        ShowCounter();
                    }
                    else if (player2.choice == options[3].number)
                    {
                        player1.counter++;
                        Console.WriteLine("Scissors decapitates Lizard");
                        ShowCounter();
                    }
                    else if (player2.choice == options[4].number)
                    {
                        player2.counter++;
                        Console.WriteLine("Scissors is vaporized by Spock");
                        ShowCounter();
                    }
                    else
                    {
                        CompareChoices(selection.options);
                    }
                }
                
               else if (player1.choice == options[3].number)
                {
                    if (player2.choice == options[0].number)
                    {
                        player2.counter++;
                        Console.WriteLine("Lizard is crushed by Rock");
                        ShowCounter();
                    }
                    else if (player2.choice == options[1].number)
                    {
                        player1.counter++;
                        Console.WriteLine("Lizard eats Paper");
                        ShowCounter();
                    }
                    else if (player2.choice == options[2].number)
                    {
                        player2.counter++;
                        Console.WriteLine("Lizard is decapitated by Scissors");
                        ShowCounter();
                    }
                    else if (player2.choice == options[3].number)
                    {
                        Console.WriteLine("Draw!");
                        ShowCounter();
                    }
                    else if (player2.choice == options[4].number)
                    {
                        player1.counter++;
                        Console.WriteLine("Lizard poisons Spock");
                        ShowCounter();
                    }
                    else
                    {
                        CompareChoices(selection.options);
                    }
                }
               
               else if (player1.choice == options[4].number)
                {
                    if (player2.choice == options[0].number)
                    {
                        player1.counter++;
                        Console.WriteLine("Spock vaporizes Rock");
                        ShowCounter();
                    }
                    else if (player2.choice == options[1].number)
                    {
                        player2.counter++;
                        Console.WriteLine("Spock is disproved by Paper");
                        ShowCounter();
                    }
                    else if (player2.choice == options[2].number)
                    {
                        player1.counter++;
                        Console.WriteLine("Spock vaporizes Scissors");
                        ShowCounter();
                    }
                    else if (player2.choice == options[3].number)
                    {
                        player2.counter++;
                        Console.WriteLine("Spock is poisoned by Lizard");
                        ShowCounter();
                    }
                    else if (player2.choice == options[4].number)
                    {
                        Console.WriteLine("Draw!");
                        ShowCounter();
                    }
                    else
                    {
                        CompareChoices(selection.options);
                    }
                }
               
              if (player1.counter == 2)
                {
                    Console.WriteLine(player1.name + " is the WINNER!!!");
                    break;
                }
                if (player2.counter == 2)
                {
                    Console.WriteLine(player2.name + " is the WINNER!!!");
                    break;
                }

            }
            while (player1.counter < 2 || player2.counter < 2);
        }
        public void RestartGame()
        {
            string restartChoice;
            if(player1.counter == 2 || player2.counter == 2)
            {
                Console.WriteLine("Would you like to play again? Yes/No");
                restartChoice = Console.ReadLine();
                if(restartChoice == "Yes")
                {
                    player1.counter = 0;
                    player2.counter = 0;
                    CompareChoices(selection.options);
                   
                }
                if(restartChoice == "No")
                {
                    Console.WriteLine("Have a nice day.");
                }
                else
                {
                    RestartGame();
                }
            }
        }
        public void RunGame(List<Options> options)
        {
            rules.ShowRules(selection.options);
           SetNumOfPlayers();
            CompareChoices(selection.options);
            RestartGame();
        }
    }


    }

               
        
    

