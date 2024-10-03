using System;

class Program
{
    
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("**************************************");
        Console.WriteLine("******* Výpis číselné řady ***********");
        Console.WriteLine("********** Adam hettler **************");
        Console.WriteLine("**************************************");
        Console.WriteLine();
        Console.WriteLine();
        // Vstup od uživatele

        // Console.Write("Zadejte první číslo: ");
        // int first = int.Parse(Console.ReadLine());

        // Vstup od uživatele - lépe řešený

        Console.Write("Zadejte první číslo: ");
        int first;
        while(!int.TryParse(Console.ReadLine(), out first))
            {
                Console.Write("Nezadali jste celé číslo, zadejte první číslo znovu: ");
            }

                
        Console.ReadKey();
    }
}