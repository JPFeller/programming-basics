﻿using System;

namespace LoopTask_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa kertotaulun luvuille 1-9");
            Console.WriteLine("Aloita ohjelman suoritus painamalla jotain näppäintä");
            Console.ReadKey();

            for (int i = 1; i <= 9; i++)
            {
                Console.Write($"{i}\t");
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write($"{i * j}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
