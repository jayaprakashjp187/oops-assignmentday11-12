using System.Data;

namespace Day_11_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Duplicate Program\n2.UniqueElements");
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
            }
        }
    }
}