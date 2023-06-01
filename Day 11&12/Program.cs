using System.Data;
using System.Transactions;
using System.Xml.Schema;

namespace Day_11_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Duplicate Program\n2.UniqueElements\n3.count frequency program\n4.Finding max and min numbers in array\n5.pattern program\n6.patternprogram rectangular shape\n7.reverse of word\n8.sum of digits in a number");
            Console.WriteLine("please choose what program u want");
            int choose =Convert.ToInt32(Console.ReadLine());
            switch(choose)
            {
                case 1:
                    Console.WriteLine("welcome to the duplicate program");
                    Duplicate.FindingDuplicateNumber();
                    break;
                case 2:
                    Console.WriteLine("welcome to the unique elements program");
                    Unique.FindingUniqueNumbers();
                    break;
                case 3:
                    Console.WriteLine("welcome to the count frequency of each element");
         
                    {
                        int[] numbers = { 1, 2, 3, 4, 5, 1, 2, 3, 6, 7 };

                        Dictionary<int, int> frequencyMap =CountFrequencyNumber.CountFrequency(numbers);

                        Console.WriteLine("Element\tFrequency");
                        foreach (KeyValuePair<int, int> pair in frequencyMap)
                        {
                            Console.WriteLine($"{pair.Key}\t{pair.Value}");
                        }
                    }
                    break;
                case 4:
                    Console.WriteLine("welcome to the maximum and minimum finding a number in a array");
                    int[] nums = { 5, 2, 8, 3, 9, 1, 4, 7, 6 };

                    MaximumAndMinimumNumber.FindMaximumNumber(nums);
                    MaximumAndMinimumNumber.FindMinimumNumber(nums);
                    break;
                case 5:
                    Console.WriteLine("welcome to the pattern program");
                    Pattern.FindingStarsPattern();
                    break;
                 case 6:
                    Console.WriteLine("welcome to the pattern program2");
                    Pattern2.FindRectangularShapePattern();
                    break;
                case 7:
                    Console.WriteLine("welcome to the reverse word");
                    ReverseWord.FindingReverseWord();
                    break;
                case 8:
                    Console.WriteLine("welcome to the sum of digits number");
                    Console.WriteLine("enter the number" );
                    int c=Convert.ToInt32(Console.ReadLine());
                    SumOfDigits.FindingSumOfDigits(c);
                    break;
            }
        }
    }
}