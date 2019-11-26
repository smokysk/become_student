using System;
using System.Globalization;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number to take your equare root");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            do{
                double root = Math.Sqrt(x);
                System.Console.WriteLine(root.ToString("F3"), CultureInfo.InvariantCulture);
                System.Console.WriteLine("Continuer Enter other numbers");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }while(x >= 0.0);
            System.Console.WriteLine("doesn't exists negative square root");
        }
    }
}
