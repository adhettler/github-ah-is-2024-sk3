string again = "a";
while (again == "a") {

    Console.Clear();
    Console.WriteLine("*****************************************");
    Console.WriteLine("**** Generátor pseudonáhodných čísel ****");
    Console.WriteLine("************** Adam Hettler *************");
    Console.WriteLine("*****************************************");
    Console.WriteLine();
    Console.WriteLine();

    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n)) {
        Console.Write("Nezadali jste celé číslo. Zadejte počet čísel znovu (celé číslo): ");
    }

    Console.Write("Zadejte dolní mez (celé číslo): ");
    int dm;
    while (!int.TryParse(Console.ReadLine(), out dm)) {
        Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu (celé číslo): ");
    }

    Console.Write("Zadejte horní mez (celé číslo): ");
    int hm;
    while (!int.TryParse(Console.ReadLine(), out hm)) {
        Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu (celé číslo): ");
    }

    Console.WriteLine();
    Console.WriteLine("========================================================");
    Console.WriteLine("Zadané hodnoty: ");
    Console.WriteLine("Počet čísel: {0}, dolní mez {1}, horní mez {2}", n, dm, hm);
    Console.WriteLine("========================================================\n\n");

    // deklarace pole o velikosti n prvků
    int[] myArray = new int[n];

    // příprava pro generátor náhodných čísel
    Random randomnumber = new Random();

    for (int i = 0; i < n; i++) {
        myArray[i] = randomnumber.Next(dm, hm + 1);
        Console.Write("{0};", myArray[i]);
    }

    int max = myArray[0];
    int min = myArray[0];
    int posMax = 0;
    int posMin = 0;
    int countMax = 1; // proměnná pro počet maximálních hodnot
    int countMin = 1; // proměnná pro počet minimálních hodnot

    for (int i = 1; i < n; i++) {
        if (myArray[i] > max) {
            max = myArray[i];
            posMax = i;
            countMax = 1; // reset počítadla, pokud je nové maximum
        } else if (myArray[i] == max) {
            countMax++; // zvýšení počtu, pokud je hodnota rovna maximu
        }

        if (myArray[i] < min) {
            min = myArray[i];
            posMin = i;
            countMin = 1; // reset počítadla, pokud je nové minimum
        } else if (myArray[i] == min) {
            countMin++; // zvýšení počtu, pokud je hodnota rovna minimu
        }
    }

    Console.WriteLine("\n\nMaximum = {0}, Pozice prvního maxima v poli = {1}, Počet maximálních hodnot = {2}", max, posMax, countMax);
    Console.WriteLine("Minimum = {0}, Pozice prvního minima v poli = {1}, Počet minimálních hodnot = {2}", min, posMin, countMin);

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Program můžete opakovat stiskem klávesy 'a'");
    again = Console.ReadLine();
}