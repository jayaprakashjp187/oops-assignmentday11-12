using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_11_12
{
    internal class ReverseWord
    {
        public static void FindingReverseWord()
        {
            Console.WriteLine("enter the word");
            string word=Console.ReadLine();
            string rev = "";
            for(int i=word.Length-1;i>=0;i--)
            {
                rev+= word[i];
            }
            Console.WriteLine("reverse of word is =  "  +rev);
        }
    }
}
