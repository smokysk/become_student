using System;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n to know your divisors");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if(n%i == 0){
                    System.Console.WriteLine(i);
                }
            }
        }
    }
}
