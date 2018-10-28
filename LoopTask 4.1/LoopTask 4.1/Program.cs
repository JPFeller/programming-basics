using System;

namespace LoopTask_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa 10 arvottua kokonaislukua ja niiden neliöjuuret.");
            Console.WriteLine("#\tRND\tSQRT");
            Random rnd = new Random();
            int rndNumber;
            int i = 0;

            do
            {
                rndNumber = rnd.Next(2, 10);
                Console.WriteLine($"{i + 1}.\t" +
                    $"{rndNumber}\t" +
                    $"{Math.Sqrt(rndNumber)}");
                i = i + 1; //i++
            } while (i < 10);


        }
    }
}
