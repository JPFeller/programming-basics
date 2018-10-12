using System;

namespace LoopTask3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee ensimmäisten parittomien ja parillisten lukujen summan positiivisilla ja negatiivisilla luvuilla");
            int number = 0;
            int i = 0;
            int evenSum = 0;
            int oddSum = 0;

            Console.Write("Syötä luku: ");
            number = int.Parse(Console.ReadLine());

            while (i != number)
            {
                if (number > 0)
                {
                    i++;
                }
                else
                {
                    i--;
                }
                
                if (i % 2 == 0)
                {
                    evenSum = evenSum + i;
                }
                else
                {
                    oddSum = oddSum + i;
                }

            }
            Console.WriteLine($"Parillisten summa on {evenSum}");
            Console.WriteLine($"Parittomien summa on {oddSum}");
        }
    }
}
