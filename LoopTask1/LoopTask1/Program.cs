﻿using System;

namespace LoopTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa N! kertoman arvon");
            int number = 0;
            int i = 1;
            int fact = 1;
            do
            {
                Console.Write("Syötä luku: ");
                number = int.Parse(Console.ReadLine());

                if (number <= 0)
                {
                    Console.WriteLine("Virheellinen syöte");
                }
            } while (number <= 0);

            while (i <= number)
            {
                fact = fact * i;
                i = i + 1;
            }
            Console.WriteLine($"Luvun {number}! = {fact}");
        }
    }
}
