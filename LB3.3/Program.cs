using System;
namespace LB3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] meseciDni = { { "January", "31" },
                                    { "February","28 or 29" },
                                    { "March", "31" },
                                    { "April","30" },
                                    { "May","31"},
                                    { "June","30"},
                                    { "July","31"},
                                    { "August","31"},
                                    { "September","30"},
                                    { "October","31"},
                                    { "November","30"},
                                    { "December","31"} 
                                };
            for (int i = 0; i < 12; i++)
            {
                string name = meseciDni[i, 0];
                string days = meseciDni[i,1];
                Console.WriteLine($"{name} has {days} days.");
            }

        }
    }
}