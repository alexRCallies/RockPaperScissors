using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Rules
    {
        public Rules()
        {

        }
        public void ShowRules(List<Options> options)
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock");
            Console.WriteLine("");
            foreach (Options option in options)
            {
                Console.WriteLine(option.name + " " + option.number);
            }
            Console.WriteLine("");
            Console.WriteLine("Rock crushes Scissors");
            Console.WriteLine("Scissors cuts Paper");
            Console.WriteLine("Paper covers Rock");
            Console.WriteLine("Rock crushes Lizard");
            Console.WriteLine("Lizard poisons Spock");
            Console.WriteLine("Spock vaporizes Scissors");
            Console.WriteLine("Scissors decapitates Lizard");
            Console.WriteLine("Lizard eats Paper");
            Console.WriteLine("Paper disproves Spock");
            Console.WriteLine("Spock vaporizes Rock");
            Console.WriteLine("");
            Console.WriteLine("To play enter the corresponding number with the gesture you wish to play");
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
        }
        public void PrintOptions(List<Options>options)
        {
            foreach (Options option in options)
            {
                Console.WriteLine(option.name + " " + option.number);
            }
        }
    }
}
