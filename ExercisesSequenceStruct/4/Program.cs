using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14;

            Console.WriteLine("Enter data");
            string[] data = Console.ReadLine().Split(' ');
            double A = double.Parse(data[0]);
            double B = double.Parse(data[1]);
            double C = double.Parse(data[2]);

            double retangulo = A*C;
            double circulo = C*pi;
            double trapesio = (A+B)*C/2;
            double quadrado = B *B * B *B;

            Console.WriteLine(retangulo);
            Console.WriteLine(circulo);
            Console.WriteLine(trapesio);
            Console.WriteLine(quadrado);


        }
    }
}
