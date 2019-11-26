using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {   
            System.Console.WriteLine("enter three numbers");
            string[] numbers = Console.ReadLine().Split(' ');
            int number_1 = int.Parse(numbers[0]);
            int number_2 = int.Parse(numbers[1]);
            int number_3 = int.Parse(numbers[2]);

            double result = Maior(number_1, number_2, number_3);
            System.Console.WriteLine(result);
        }
        static int Maior(int a, int b, int c){
            int m;
            if(a>b && a>c){
                m = a;
            }
            else if(b>c)
            {
                m=b;
            }
            else{
                m = c;
            }
            return m;
        }
    }
}
