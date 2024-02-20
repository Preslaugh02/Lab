using System;

namespace LB2._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=int.Parse(Console.ReadLine());
            zvezdi(a);
            chisla(a);
        }
        static void zvezdi(int a)
        {
            for (int i = 0; i <= a; i++)
            {
                for (int b = 1; b <=a-i ; b++)
                {
                    Console.Write(" ");
                }
                for (int c = 1; c <= i*2-1; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
        static void chisla(int a)
        {
            for (int i = 0; i <a; i++)
            {
                for (int b = 1; b < a - i; b++)
                {
                    Console.Write(" ");
                }
                for (int c = i; c >= 0; c--)
                {
                    Console.Write(c);
                }
                for (int d = 1; d <=i ; d++)
                {
                    Console.Write(d);
                }
                Console.WriteLine();
            }
        }
    }
}