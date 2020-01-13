using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
  public class Selection
    {
        public Options rock;
        public Options paper;
        public Options scissors;
        public Options lizard;
        public Options spock;
        public List<Options> options;
        public Selection()
        {
            rock = new Options("Rock",1);
            paper = new Options("Paper",2);
            scissors = new Options("Scissors",3);
            lizard = new Options("Lizard",4);
            spock = new Options("Spock",5);
            options = new List<Options>() { rock, paper, scissors, lizard, spock };
          
        }
    }
}
