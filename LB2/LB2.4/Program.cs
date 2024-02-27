using System;

namespace LB2._4
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int a=int.Parse(Console.ReadLine());
            for (int i = 1; i <= a; i++) 
            {
                Console.Write(" "+i);
            }
            Console.WriteLine();
            for (int i = a; i > 0; i--) 
            {
                Console.Write(" "+i);
            }

           
        }
    }
}