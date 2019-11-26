using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter coordinates");
            string[] coordinates = Console.ReadLine().Split(' ');
            int X = int.Parse(coordinates[0]);
            int Y = int.Parse(coordinates[1]);
            if(X != 0 && Y !=0){
            do{
                if(X>0 && Y > 0){
                    System.Console.WriteLine("First quadrant");
                }
                else if(X> 0 && Y < 0){
                    System.Console.WriteLine("Second quadrant");
                }
                else if(X<0 && Y < 0){
                    System.Console.WriteLine("Thirty quadrant");
                }
                else{
                    System.Console.WriteLine("Fourth quadrant");
                }
                Console.WriteLine("Enter coordinates");
                coordinates = Console.ReadLine().Split(' ');
                X = int.Parse(coordinates[0]);
                Y = int.Parse(coordinates[1]);

            }while(X != 0 && Y !=0);
            }
            else{

            }
        }
    }
}
