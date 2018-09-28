using System;

namespace IF_harjoitus_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma järjestää kolme lukua nousevaan järjestykseen");
            Console.Write("Syötä 1. luku: ");
            string userInput = Console.ReadLine();
            int a = int.Parse(userInput);

            Console.Write("Syötä 2. luku: ");
            userInput = Console.ReadLine();
            int b = int.Parse(userInput);

            Console.Write("Syötä 3. luku: ");
            userInput = Console.ReadLine();
            int c = int.Parse(userInput);


            if (a < b && a < c)
                if (b < c)
                    Console.WriteLine($"{a},{b},{c}");
            else
                    Console.WriteLine($"{a},{c},{b}");

            else if (b < a && b < c)
                if (a < c)
                    Console.WriteLine($"{b},{a},{c}");

            else
                Console.WriteLine($"{b},{c},{a}");
            
            else if (c < a && c < b)
                if (a < b)
                    Console.WriteLine($"{c},{a},{b}");

            else
                Console.WriteLine($"{c},{b},{a}");


        }
    }
}
