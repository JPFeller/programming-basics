using System;

namespace LoopTask_4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int numberSix = 0;

            Console.WriteLine("Ohjelma heitää noppaa 1000 kertaa ja tulostaa kuutosen esiintymiskertojen lukumäärän");

            for (int i = 1; i <= 1000; i++)
            {
                int x = rnd.Next(1, 7);

                if (x == 6)
                {
                    numberSix++;
                }
                Console.WriteLine("{0}. {1}", i, x);
            }
            Console.WriteLine("Kutonen arvottiin {0} kertaa.", numberSix);
        }
    }
}
