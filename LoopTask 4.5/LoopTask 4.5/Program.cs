using System;

namespace LoopTask_4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.WriteLine("Ohjelma tulostaa vakioveikkauksen rivin");

            for (int i = 1; i <= 13; i++)
            {
                double number = rnd.NextDouble();

                if (number >= 0 && number <= 0.4)
                {
                    Console.WriteLine("{0}. \t1", i);
                }
                else if (number > 0.4 && number <= 0.6)
                {
                    Console.WriteLine("{0}. \tX", i);
                }
                else
                {
                    Console.WriteLine("{0}. \t2", i);
                }
            }
        }
    }
}
