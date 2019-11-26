using System;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter n to know you pow, be second ou thirty pow");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int first = i;
                int second = (int)Math.Pow(i, 2);
                int thirty = (int)Math.Pow(i, 3);
                int nth = (int)Math.Pow(i, i);
                System.Console.WriteLine($"{first} {second} {thirty} {nth}");
            }
        }
    }
}
