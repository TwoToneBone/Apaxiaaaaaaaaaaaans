using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apaxiaaaaaaaaaaaans
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = string.Empty;
            char comparer = ' ';

            foreach (var c in input)
            {
                if (c == comparer)
                {
                    continue;
                }
                else
                {
                    comparer = c;
                    output += c;
                }
            }

            Console.WriteLine(output);
        }
    }
}
