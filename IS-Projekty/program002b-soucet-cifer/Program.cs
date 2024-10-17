Console.ForegroundColor = ConsoleColor.Green;

string again = "a";
while (again == "a") {

    Console.Clear();
    Console.WriteLine("*******************************");
    Console.WriteLine("**** Součet a součin cifer ****");
    Console.WriteLine("******* Adam Hettler **********");
    Console.WriteLine("*******************************");
    Console.WriteLine();

    Console.Write("Zadejte číslo (celé číslo): ");
    int number;
    while (!int.TryParse(Console.ReadLine(), out number)) {
        Console.Write("Nezadali jste celé číslo. Zadejte číslo (celé číslo): ");
    }

    Console.WriteLine();
    Console.WriteLine("========================================================");
    Console.WriteLine("Zadané hodnoty: ");
    Console.WriteLine("Číslo: {0}", number);
    Console.WriteLine("========================================================");

    int suma = 0;
    int multi = 1;
    int numberBackup = Math.Abs(number); // Use absolute value to ignore negative sign

    // Process each digit of the number
    while (numberBackup > 0) {
        int digit = numberBackup % 10; // Get the last digit
        suma += digit; // Add digit to sum
        multi *= digit; // Multiply digit to product
        numberBackup /= 10; // Remove last digit
    }

    Console.WriteLine("\nSoučet cifer čísla {0} je {1}", Math.Abs(number), suma);
    Console.WriteLine("Součin cifer čísla {0} je {1}", Math.Abs(number), multi);

    Console.WriteLine();
    Console.WriteLine("Program můžete opakovat stiskem klávesy 'a'");
    again = Console.ReadLine();
}