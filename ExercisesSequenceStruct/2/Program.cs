using System;
using System.Globalization;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            double R, A, pi = 3.14;
            Console.WriteLine("Circle area");
            R = double.Parse(Console.ReadLine());
            A = pi * R * R;
            Console.WriteLine("AREA: " + A.ToString("F4"), CultureInfo.InvariantCulture);
        }
    }
}
