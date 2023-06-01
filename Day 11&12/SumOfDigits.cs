using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_11_12
{
    internal class SumOfDigits
    {
        public static void FindingSumOfDigits(int num)
        {
            int sum = 0;
          
            int ld = 0;
            while(num!=0)
            {
                ld = num % 10;
                sum += ld;
                num = num / 10;
            }
            
            Console.WriteLine("sum of digits number is " +sum);
        }
    }
}
