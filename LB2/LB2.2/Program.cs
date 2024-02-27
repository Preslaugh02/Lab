using System;

namespace LB2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a=");             
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("b=");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("c=");
            double c = double.Parse(Console.ReadLine());

            if ((a == b)&& (b== c) )
            {
                Console.WriteLine("Ravnostranen");
            }
            else if ((a != b) && (b!=c)&&(a!=c))
            {
                Console.WriteLine("Raznostranen");
            }else if (((a == b) && (b != c)) || ((a == c) && (c != b))||((b==c)&&(c!=a)))
            {
                Console.WriteLine("Ravnobedren");
            }
        }
    }
}