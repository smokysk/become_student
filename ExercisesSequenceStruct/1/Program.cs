using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number to sum");
            int number_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int number_2 = int.Parse(Console.ReadLine());
            int sum = number_1 + number_2;
            Console.WriteLine($"the sum equal: {sum}");

        }
    }
}
