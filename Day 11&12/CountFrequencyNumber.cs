using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_11_12
{
    internal class CountFrequencyNumber
    {
        

         public static Dictionary<int, int> CountFrequency(int[] arr)
         {
            Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

            foreach (int num in arr)
            {
                if (frequencyMap.ContainsKey(num))
                {
                    frequencyMap[num]++;
                }
                else
                {
                    frequencyMap[num] = 1;
                }
            }

            return frequencyMap;
         }
    }
}
