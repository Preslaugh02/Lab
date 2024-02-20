using System;

namespace LB2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());//vavejda stoinost na a
            double b = 3;
            double c = 7;
            
            switch (a)
            {
                case 1:
                   if((b > 0) && (c > 0))
                    {
                        Console.WriteLine("Demonstartion for &&");
                    }
                    break;
                case 2:
                    if((b>0) || (c > 0))
                    {
                        Console.WriteLine("Demonstartion for ||");
                    }
                    break;
                case 3:
                    if (b!=0)
                    {
                        Console.WriteLine("Demonstartion for !");
                    }
                    break;
                case 4:
                    if ((b > 0)^(c<0))
                    {
                        Console.WriteLine("Demonstartion for ^");
                    }
                    break;
                default: Console.WriteLine("Write a number from 1 to 4");
                    break;
            }
        }
    }
}