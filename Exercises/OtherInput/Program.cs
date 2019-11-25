using System;
using System.Globalization;

namespace OtherInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("idade");
            int integer = int.Parse(Console.ReadLine());
            Console.WriteLine("M ou F");
            char charSet = char.Parse(Console.ReadLine());
            Console.WriteLine("Double qualquer");
            double doubl = double.Parse(Console.ReadLine());


            Console.WriteLine("Enter other Date");
            string[] phrase = Console.ReadLine().Split(' ');
            string nome = phrase[0];
            char sexo = char.Parse(phrase[1]);
            int idade = int.Parse(phrase[2]);
            double height = double.Parse(phrase[3], CultureInfo.InvariantCulture);

            Console.WriteLine(integer);
            Console.WriteLine(charSet);
            Console.WriteLine(doubl);

            Console.WriteLine("nome " + nome+ " sexo "
            + sexo + " idade " + idade + " altura " + height);
        }
    }
}
