using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 0, G = 0, D = 0;
            System.Console.WriteLine("Enter your favoutite order betwen 1,2,3 and 4 do finish");
            int number = int.Parse(Console.ReadLine());
            do{
                if(number == 1){
                    A++;
                }
                else if(number == 2){
                    G++;
                }
                else if(number == 3){
                    D++;
                }
                else{
                    System.Console.WriteLine("wrong code enter data again");
                    number = int.Parse(Console.ReadLine());
                }
                System.Console.WriteLine("Enter option or finish press 4");
                number = int.Parse(Console.ReadLine());

            }while(number != 4);

            System.Console.WriteLine("Tank you very much");
            System.Console.WriteLine($"Alcool: {A}");
            System.Console.WriteLine($"Diesel: {D}");
            System.Console.WriteLine($"gasolina: {G}");
        }
    }
}
