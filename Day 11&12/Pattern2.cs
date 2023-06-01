using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_11_12
{
    internal class Pattern2
    {
        public static void FindRectangularShapePattern()
        {
            for(int i = 0; i < 7; i++)
            {
                for(int j = 0; j < 7; j++)
                {
                    if (i == 0 || i == 6 || j == 0 || j == 6)
                    {
                        Console.Write("*");
                        
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    
                    
                   
                }
               
                Console.WriteLine();
            }
        }
    }
}
