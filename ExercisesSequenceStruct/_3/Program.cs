using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER WITH 4 DATA'S");
            string[] data = Console.ReadLine().Split(' ');
            int A = int.Parse(data[0]);
            int B = int.Parse(data[1]);
            int C = int.Parse(data[2]);
            int D = int.Parse(data[3]);
            int diference = ((A*B)-(C*D));

            System.Console.WriteLine("The diference is: " + diference);
        }
    }
}
