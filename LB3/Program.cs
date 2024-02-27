using System;

namespace LB3

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());//promenliva pazeshta razmera na masiva
            double[] mA = new double[n];//deklarirane na masiv s razmer n
            for (int i = 0; i < mA.Length; i++)//prezapisvane
            {
                int num = int.Parse(Console.ReadLine());//promenliva pazeshta stoinost na i
                mA[i] = num;//na i zapisvame promenlivata num
            }
            foreach (var item in mA)//samo pechatane
            {
                Console.Write(item +" ");
                
            }
            Console.WriteLine( );
            for (int i = mA.Length; i >0; i--)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            foreach (var item in mA)
            {
                if (item % 2 == 0)
                {
                    Console.Write("Chetno:"+item);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Nechetno:"+item);
                }
               

            }


        }
    }
}