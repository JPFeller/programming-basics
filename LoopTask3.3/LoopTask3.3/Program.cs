using System;

namespace LoopTask3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee ensimmäisten parittomien ja parillisten positiivisten lukujen summan");
            int number = 0;
            int i = 1;
            int evenSum = 0;
            int oddSum = 0;

            Console.Write("Syötä luku: ");
            number = int.Parse(Console.ReadLine());

            while (i <= number)
            {
                if (i % 2 == 0)
                {
                    evenSum = evenSum + i;
                }
                else
                {
                    oddSum = oddSum + i;
                }
                i++;
            }
            Console.WriteLine($"Parillisten summa on {evenSum}");
            Console.WriteLine($"Parittomien summa on {oddSum}");

        }
    }
}
