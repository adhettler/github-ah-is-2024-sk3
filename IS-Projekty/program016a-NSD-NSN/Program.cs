using System.Reflection;

string again = "a";
        while(again == "a") {

            Console.Clear();

            razitko();

            ulong a = ziskatCislo("Zadejte přirozené číslo a: ");
            ulong b = ziskatCislo("Zadejte přirozené číslo b: ");

            ulong nsd = vypocitatNsd(a, b);

            ulong nsn = vypocitatNsn(a, b, nsd);

            zobrazitVysledky(a, b, nsd, nsn);
            
           // opakování příkazu
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Program můžete opakovat stiskem klávesy 'a'");
            again = Console.ReadLine();    

        }

        static void razitko() {
             Console.WriteLine("****************************");
            Console.WriteLine("********* NSD a NSN *********");
            Console.WriteLine("******** Adam Hettler *******");
            Console.WriteLine("*****************************");
            Console.WriteLine();
            Console.WriteLine();
        }

        static ulong ziskatCislo(string zprava) {
             // vstup od uživatele
            Console.Write(zprava);
            ulong cislo;
            while(!ulong.TryParse(Console.ReadLine(), out cislo)) {
                Console.Write("Nezadali jste celé přirozené číslo. Zadejte číslo): ");
            }
            return cislo;
        }

        static ulong vypocitatNsd(ulong a, ulong b) {
            while (a != b) {
                if (a > b) {
                    a = a - b;
                    }
                    else
                    {
                        b = b - a;
                        }
                        }
        }

        static ulong vypocitatNsn(ulong a, ulong b, ulong nsd) {
            return (a * b)/nsd;
        }

        static void zobrazitVysledky(ulong a, ulong b, ulong nsd, ulong nsn) {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("NSD čísel {0} a {1} je {2}: ", a, b, nsd);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"NSN čísel {a} a {b} je {nsn}.\n");
            Console.ForegroundColor = ConsoleColor.White;
        }