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
       public List<Options> options= new List<Options>();
        public Selection()
        {
            rock = new Options("Rock");
            paper = new Options("Paper");
            scissors = new Options("Scissors");
            lizard = new Options("Lizard");
            spock = new Options("Spock");
           options.Add(rock);
            options.Add(paper);
            options.Add(scissors);
            options.Add(lizard);
            options.Add(spock);
        }
    }
}
