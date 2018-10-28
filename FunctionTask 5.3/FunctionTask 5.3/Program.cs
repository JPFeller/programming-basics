using System;

namespace FunctionTask_5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Käyttäjältä pyydetän luku, joka on väliltä 1-10 ja ohjelma tarkistaa, onko luku sallittu");
                int number = numberFromRange(1, 10);
                Console.WriteLine($"Luku {number} on sallittu");
            }
            int numberFromRange(int lowerBound, int upperBound)
            {
                int allowedNumber;
                while (true)
                {
                    Console.Write("Syötä luku: ");
                    bool isNumber = int.TryParse(Console.ReadLine(), out int userInput);

                    if (userInput >= lowerBound && userInput <= upperBound)
                    {
                        allowedNumber = userInput;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Luku ei ole sallittu");
                    }
                }
                return allowedNumber;
            }

        }
    }
}
