using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter password");
            string password = Console.ReadLine();
            do{
                System.Console.WriteLine("wrong try again");
                password = Console.ReadLine();

            }while(password != "2002");
            System.Console.WriteLine("Correct!");
        }
    }
}
