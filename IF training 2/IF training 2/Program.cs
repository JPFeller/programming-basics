﻿using System;

namespace IF_training_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma selvittää onko luku parillinen vai pariton");
            Console.Write("Syötä numero: ");
            string userInput = Console.ReadLine();
            int number = 0;
            int.TryParse(userInput, out number);
            bool isNumber = int.TryParse(userInput, out number);

            if (isNumber)
                if (number % 2 == 0)
                    Console.WriteLine($"Numero {number} on parillinen");
                else
                    Console.WriteLine($"Numero {number} on pariton");
            else
                Console.WriteLine("Väärä syöte");
        }
    }
}