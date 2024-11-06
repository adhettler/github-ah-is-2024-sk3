using System;

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Green;

        string again = "a";
        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("****************************");
            Console.WriteLine("******** Písmeno N *********");
            Console.WriteLine("******* Adam Hettler *******");
            Console.WriteLine("****************************");
            Console.WriteLine();

            Console.Write("Zadejte výšku obrazce (kladné celé číslo): ");
            uint height;
            while (!uint.TryParse(Console.ReadLine(), out height) || height == 0)
            {
                Console.Write("Nezadali jste kladné celé číslo. Zadejte číslo (celé číslo): ");
            }



            Console.WriteLine();
            Console.WriteLine("========================================================");
            Console.WriteLine("Zadaná výška: {0}", height);
            Console.WriteLine("========================================================");

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (j == 0 || j == height - 1 || j == i) // vykreslení N
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
                System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));
            }



            Console.WriteLine();
            Console.WriteLine("Program můžete opakovat stiskem klávesy 'a'");
            again = Console.ReadLine();
        }
    }
}