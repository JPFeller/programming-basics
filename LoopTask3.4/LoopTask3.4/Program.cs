using System;

namespace LoopTask3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee N ensimmäistä lukua yhteen positiivisilla ja negatiivisilla luvuilla");
            int number = 0;
            int i = 0;
            int sum = 0;
            do
            {
                Console.Write("Syötä luku: ");
                number = int.Parse(Console.ReadLine());

                if (number == 0)
                {
                    Console.WriteLine("Virheelinen syöte");
                }
            } while (number == 0);

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
                    sum = sum + i;

                }
                Console.WriteLine($"Lukujen summa on {sum}");
            
        }

    }
}
