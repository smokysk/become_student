using System;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n to know your factorial");
            int n = int.Parse(Console.ReadLine());
            int fat = 1;
            for (int i = 1; i <= n; i++)
            {
                fat = fat * i;
            }
            System.Console.WriteLine(fat);
        }
    }
}
