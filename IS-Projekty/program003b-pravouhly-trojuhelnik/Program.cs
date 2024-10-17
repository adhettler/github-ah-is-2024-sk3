using System;

Console.ForegroundColor = ConsoleColor.Green;
class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Green;

        string again = "a";
        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("*************************");
            Console.WriteLine("****** Trojúhelník ******");
            Console.WriteLine("****** Adam Hettler *****");
            Console.WriteLine("*************************");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Zadejte výšku obrazce (kladné celé číslo): ");
            uint height;
            while (!uint.TryParse(Console.ReadLine(), out height))
            {
                Console.Write("Nezadali jste kladné celé číslo. Zadejte číslo (celé číslo): ");
            }

            Console.Write("Zadejte šířku (základnu) obrazce (kladné celé číslo): ");
            uint width;
            while (!uint.TryParse(Console.ReadLine(), out width))
            {
                Console.Write("Nezadali jste kladné celé číslo. Zadejte číslo (celé číslo): ");
            }

            Console.WriteLine();
            Console.WriteLine("========================================================");
            Console.WriteLine("Zadané hodnoty: ");
            Console.WriteLine("výška: {0}", height);
            Console.WriteLine("šířka (základna): {0}", width);
            Console.WriteLine("========================================================");

            for (int i = 1; i <= height; i++)
            {
            // Počet hvězd pro aktuální řádek               
                int stars = (int)(i * width / height);
                for (int j = 1; j <= stars; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Program můžete opakovat stiskem klávesy 'a'");
            again = Console.ReadLine();
        }
    }
}