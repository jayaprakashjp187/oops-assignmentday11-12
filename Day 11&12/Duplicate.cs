using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_11_12
{
    internal class Duplicate
    {
        public static void FindingDuplicateNumber()
        {
            int[] duplicate = { 1, 2, 3, 4,  4, 5, 3, 5, 7, 9, 6, 7 };
            int count = 0;
          
            for(int i=0; i<duplicate.Length; i++)
            {
                for (int j=i+1; j<duplicate.Length; j++)
                {
                    if (duplicate[j] == duplicate[i])
                    {
                        count++;
                    }
                  
                }
            }
            Console.WriteLine(count);
        }
    }
}
