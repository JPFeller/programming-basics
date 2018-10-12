using System;

namespace LoopTask3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee N ensimmäistä lukua yhteen");
            int number = 0;
            int i = 1;
            int sum = 0;
            do
            {
                Console.Write("Syötä luku: ");
                number = int.Parse(Console.ReadLine());

                if (number <= 0)
                {
                    Console.WriteLine("Virheellinen syötä");
                }
            } while (number <= 0);

            while (i <= number)
            {
                sum = sum + i;
                i = i + 1;
            }
            Console.WriteLine($"Luvun {number} summa = {sum}");

        }
    }
}
