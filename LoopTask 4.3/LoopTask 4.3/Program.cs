using System;

namespace LoopTask_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa 20 satunnaista kokonaislukua väliltä 0 - 50");
            Console.WriteLine("Jokaiselle tulostetulle riville tulostetaan 5 lukua");
            Random rnd = new Random();
            int number = 1;

            for (int i = 1; i <= 4; i++)
            {
                Console.Write($"Rivi {i} ");
                for (int j = 1; j <= 5; j++)
                {
                    number = rnd.Next(0, 51);
                    if (j == 5)
                        Console.WriteLine($"{number}");
                    else
                        Console.Write($"{number},");
                }
            }
        }
    }
}
