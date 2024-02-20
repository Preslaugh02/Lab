using System;

namespace LB2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1;
            double x2;
            Console.WriteLine("a=");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("b=");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("D=");
            double D = double.Parse(Console.ReadLine());
           

            x1 = ((Math.Pow(b,2)) + Math.Sqrt(D))/ 2 * a;
            Console.WriteLine("x1="+ x1);
            x2=((b*b)-Math.Sqrt(D))/2 * a;
            Console.WriteLine("x2="+ x2);
        }
    }
}