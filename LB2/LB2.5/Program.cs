using System;

namespace LB2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int sum=1;
            for (int i = 1; i <= a; i++)
            {
                sum *= i;
            }
            Console.WriteLine("Sumata="+sum);
        }
    }
}