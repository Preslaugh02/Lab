using System;
namespace LB3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] gradove = {"Novo selo","Vidin","Lom",
                                "Orqhovo","Montana","Vraca",
                                "Kneja","Lovech","Pleven"};
            int[] temperaturi = { 4, 1, 5, 4, 7, 9, 1, 4, 2 };
            minMax(gradove, temperaturi);
        }
        static void minMax(string[] gradove, int[]temperaturi)
        {
            int min = temperaturi[0];
            int max = temperaturi[0];
            for (int i = 1; i < temperaturi.Length; i++)
            {
                if (temperaturi[i]<min)
                {
                    min = temperaturi[i];
                }
                if (temperaturi[i]>max)
                {
                    max = temperaturi[i];
                }
            }
            string[] minTemp=new string[gradove.Length];
            string[] maxTemp=new string[gradove.Length];
            int countMin = 0;
            int countMax = 0;


            for (int i = 0; i < temperaturi.Length; i++)
            {
                if (temperaturi[i]==min)
                {
                    minTemp[countMin] = gradove[i];
                    countMin++;
                }
                if (temperaturi[i] == max)
                {
                    maxTemp[countMax] = gradove[i]; 
                    countMax++;
                }
            }
            Console.WriteLine($"Nai niska izmerena temperatura:{min} gradosa v:{string.Join(", ", minTemp, 0, countMin)}");
            Console.WriteLine();
            Console.WriteLine($"Nai visoka izmerena temperatura:{max} gradosa v:{string.Join(", ", maxTemp, 0, countMax)}");
            Console.WriteLine();
            Console.WriteLine($"Razlika v temperaturata:{max-min} gradosa ");
        }
    }
}