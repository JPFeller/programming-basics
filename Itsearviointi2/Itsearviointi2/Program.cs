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

            int len = userInput.Length;
            int j = 0;

            Console.WriteLine($"Merkkien lukumäärä: {len}");
            for (int i = 0; i < len; i++)
            {
                j = j + 1;
                Console.WriteLine($"{j}. {userInput}");
            }
        }
    }
}
