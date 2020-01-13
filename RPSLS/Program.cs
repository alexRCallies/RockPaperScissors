using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            _1PlayerGame game = new _1PlayerGame();
            Selection selections = new Selection();
            game.RunGame(selections.options);
            Console.ReadLine();
        }
    }
}
