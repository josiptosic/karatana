using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoljeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> polje = new List<string>();
            polje.Add("    ▓    ");
            polje.Add("▓▓▓▓▓▓▓▓▓");
            polje.Add("    ▓    ");
            for (int i = 0; i < 3; i++) 
            {
                Console.WriteLine(polje[i]);
            }

        }
    }
}
