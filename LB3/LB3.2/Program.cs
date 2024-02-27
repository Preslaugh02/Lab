using System;
namespace LB3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int[] mA=new int[n];
            int positive=0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Stoinost na element {i + 1}: ");
                mA[i] = int.Parse(Console.ReadLine ());
                if (mA[i]>0)
                {
                    positive++;
                }
            }
            int index=0;
            int[] mB=new int[positive];
            for (int i = 0; i < mA.Length; i++)
            {
                if (mA[i]>0)
                {
                    mB[index] = mA[i];
                    index++;
                }
            }
            Console.WriteLine("Normalen masiv:");
            foreach (int element in mA)
            {
                Console.Write(" "+element);
            }
            Console.WriteLine();
            Console.WriteLine("Masiv ot positivni chisla:");
            foreach (int element in mB)
            {
                Console.Write(" "+element);
            }
        }
    }
}