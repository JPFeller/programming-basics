using System;

namespace Itsearviointi2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma kysyy käyttäjältä sanan tai lauseen ja tulostaa sen niin monta kertaa näytölle, kun sanassa on kirjaimia");
            Console.WriteLine("Syötä sana tai lause: ");
            string userInput = Console.ReadLine();

            int k = userInput.Length;
            int j = 0;

            Console.WriteLine($"Merkkien lukumäärä: {k}");
            for (int i = 0; i < k; i++)
            {
                j = j + 1;
                Console.WriteLine($"{j}. {userInput}");
            }
        }
    }
}
