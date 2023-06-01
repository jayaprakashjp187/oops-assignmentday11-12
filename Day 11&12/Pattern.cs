using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_11_12
{
    internal class Pattern
    {
        public static void FindingStarsPattern()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 8; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
