using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value of N");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                System.Console.WriteLine("Enter whith three notes");
                string[] notes = Console.ReadLine().Split(' ');
                double nota_1 = double.Parse(notes[0]);
                double nota_2 = double.Parse(notes[1]);
                double nota_3 = double.Parse(notes[2]);

                double media = (nota_1*2.0 + nota_2 *3.0 + nota_3 *5)/10;

                System.Console.WriteLine("media ponderada: " + media);
            }
        }
    }
}
