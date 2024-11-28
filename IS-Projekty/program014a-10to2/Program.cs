using System.Net.Security;

class Program{

    static void Main()
    {

string again = "a";
        while(again == "a") {

            Console.Clear();
            Console.WriteLine("***********************************");
            Console.WriteLine("**** Převod z 10 do 2 soustavy ****");
            Console.WriteLine("********** Adam Hettler ***********");
            Console.WriteLine("***********************************\n\n");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Zadejte číslo v desítkové soustavě (přirozené číslo): ");
            uint number;
            while(!uint.TryParse(Console.ReadLine(), out number)) {
                Console.Write("Špatný vstup. Zadejte číslo v desítkové soustavě (přirozené číslo): ");
            }
            
            uint[] myArray = new uint[32];
            uint zaloha = number;
            uint zbytek;


            uint i = 0;
            while(number > 0) {
                zbytek = number % 2; //zbytek po dělení
                number = (number - zbytek)/2;
                myArray[i] = zbytek;

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Celá část = {0} ; zbytek = {1}", number, zbytek);

                i++;
            }

            Console.ResetColor();

            Console.WriteLine("Poslední využitý index pole: {0}", i-1);
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("\n\nVýsledek: ");

            for(uint j = i - 1; j >= 0 ;j--) {
                Console.Write("{0}", myArray[j]);
            }

            Console.ForegroundColor = ConsoleColor.White;
            
           
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Program můžete opakovat stiskem klávesy 'a'");
            again = Console.ReadLine();    

        }
    }
}