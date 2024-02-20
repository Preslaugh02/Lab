using System;

namespace LB2._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Kvadrat(a);
            Console.WriteLine();
            Pravoagalnik(a, b);
            Console.WriteLine();
            Triagalnik(a);

        }

        static void Kvadrat(int a)
        {
            for (int i = 0; i < a; i++)
            {
                for (int o = 0; o < a; o++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
        static void Pravoagalnik(int a, int b)
        {
            for (int i = 0; i < a; i++)
            {
                for (int o = 0; o < b; o++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
        static void Triagalnik(int a)
        {
            for (int i = 0; i < a; i++)
            {
                for (int o = i; o>=0 ; o--)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
    
}