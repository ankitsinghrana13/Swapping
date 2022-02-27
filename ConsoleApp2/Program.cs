using System;

namespace ConsoleApp2
{
    class swapping
    {

        public static void Main(String[] args)
        {

            Console.WriteLine("Enter the first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second value");
            int b = Convert.ToInt32(Console.ReadLine());
            a = a - b;
            b = a + b;
            a = b - a;

            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);

        }


    }
}