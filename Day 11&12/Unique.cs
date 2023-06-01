using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_11_12
{
    internal class Unique
    {
        public static void FindingUniqueNumbers()
        {
            {
                int[] numbers = { 1, 2, 3, 4, 5, 1, 2, 3, 6, 7 };

                int[] uniqueNumbers = numbers.Distinct().ToArray();

                Console.WriteLine("Unique numbers:");
                foreach (int num in uniqueNumbers)
                {
                    Console.WriteLine(num);
                }

            }
        }
    }
}
