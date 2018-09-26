using System;

namespace IF_harjoitus_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma selvittää onko luku parillinen, pariton, negatiivinen, positiivinen tai nolla");
            Console.Write("Syötä numero: ");
            string userInput = Console.ReadLine();
            int number = 0;
            int.TryParse(userInput, out number);
            bool isNumber = int.TryParse(userInput, out number);

            if (isNumber)
                if (number < 0)
                    Console.WriteLine($"Numero {number} on negatiivinen");
                    else if (number == 0)
                        Console.WriteLine($"Numero {number} on nolla");
                    else
                        Console.WriteLine($"Numero {number} on positiivinen");
            if (isNumber)
                if (number % 2 == 0 && number != 0)
                    Console.WriteLine($"Numero {number} on parillinen");
                    else if (number == 0)
                        Console.WriteLine($"Numero {number} on jakautumaton");
                    else
                        Console.WriteLine($"Numero {number} on pariton");
            else
                Console.WriteLine($"Väärä syöte");
        }
    }
}
