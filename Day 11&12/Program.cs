using System.Data;

namespace Day_11_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Duplicate Program\n2.UniqueElements\n3.count frequency program");
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
            }
        }
    }
}