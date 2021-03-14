using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemuthTriviaGameApp
{
    class Program
    {
        static void Main(string[] args)
        {
            new Info().DisplayInfo("Trivia Game");
            new Controller().Play();
        }
    }
}
