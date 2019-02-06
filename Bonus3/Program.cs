using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus3
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new BruteForce();
            Player p2 = new RandomPlayer();
            Player p3 = new HigherOrLower();
            NumberGuesser ng = new NumberGuesser();
            NumberGuesser.NumberGuess();
            
        }
    }
}
