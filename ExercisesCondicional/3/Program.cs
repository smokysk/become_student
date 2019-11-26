using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 numbers");
            string[] hours = Console.ReadLine().Split(' ');
            int begin = int.Parse(hours[0]);
            int finish = int.Parse(hours[1]);

            int duration;
            if(begin < finish){
                duration = finish - begin;
            }
            else{
                duration = 24 - begin + finish;
            }

            System.Console.WriteLine("A duraçao do jogo foi "+ duration );
        }
    }
}
