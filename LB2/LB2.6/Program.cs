using System;

namespace LB2._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int sum=0;
            do
            {
                a=int.Parse(Console.ReadLine());
                sum += a;
            }while (a!=0);
            Console.WriteLine("suma = " + sum);
        }
    }
}