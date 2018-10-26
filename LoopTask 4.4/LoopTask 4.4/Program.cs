using System;

namespace LoopTask_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma simuloi kolikon heittämistä");
            Console.WriteLine("Kuinka monta kertaa kolikkoa heitetään:  ");
            int counter = int.Parse(Console.ReadLine());
            int heads = 0;
            int tails = 0;
            Random rnd = new Random();

            for (int i = 0; i < counter; i++)
            {
                int rndNumber = rnd.Next(2);
                if (rndNumber == 0)
                    tails++;
                else
                    heads++;
            }
            Console.WriteLine($"Kolikkoa heitettiin {counter} kertaa");
            Console.WriteLine($"Klaavoja tuli {tails} ja kruunuja {heads}");
        }
    
    }
}
