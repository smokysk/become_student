using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter data");
            int x = int.Parse(Console.ReadLine());

            for(int i=1; i<x; i++){
                if(i%2 != 0){
                    System.Console.WriteLine(i);
                }
            }
        }
    }
}
