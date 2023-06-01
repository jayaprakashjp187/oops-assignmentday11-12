using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_11_12
{
    internal class MaximumAndMinimumNumber
    {
        public static void FindMaximumNumber(int[] arr)
        {
            int maximum = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > maximum)
                {
                    maximum = arr[i];
                }
            }
            Console.WriteLine("maximum number in array is " +maximum);
        }
        public static void FindMinimumNumber(int[] arr) 
        {
            int minimum = arr[0];
            for(int i=1; i < arr.Length; i++)
            {
                if (arr[i] < minimum)
                {
                    minimum = arr[i];
                }
            }
            Console.WriteLine("minimum number in array is " +minimum);
        }
    }
}
