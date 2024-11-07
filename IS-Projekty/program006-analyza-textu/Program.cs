string again = "a";
    while(again == "a") {

            Console.Clear();
            Console.WriteLine("****************************");
            Console.WriteLine("******* Analýza textu ******");
            Console.WriteLine("******* Adam Hettler *******");
            Console.WriteLine("****************************");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("\n\nZadejte text pro analýzu:");

            string myText = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine(myText);
            Console.WriteLine(myText[0]);
            Console.WriteLine(myText.Length);
            Console.WriteLine(myText[myText.Length-1]);

            string samohlasky = "aáeéiíúuůyý";
            string souhlasky = "bcčdďfghjklmnňpqrřsštťvwxzž¨BCČDĎFGHJKLMNŇPQRŘSŠTŤVWXZŽ";
            string cislice = "0123456789";

            int pocetSouhlasek = 0;
            int pocetSamohlasek = 0;
            int pocetCislic = 0;
            int pocetOstatnich = 0;


            foreach(char znak in myText) {
                if (souhlasky.Contains(znak)) {
                    pocetSouhlasek++;
                }

                else if (samohlasky.Contains(znak)) {
                    pocetSamohlasek++;
                }

                else if (cislice.Contains(znak)) {
                    pocetCislic++;
                }
                else 
                    pocetOstatnich++;
            }

            Console.WriteLine("\n\nPočet samohlásek: {0}", pocetSamohlasek);
            Console.WriteLine("Počet souhlásek: {0}", pocetSouhlasek);
            Console.WriteLine("Počet cislic: {0}", pocetCislic);
            Console.WriteLine("Počet ostatních znaků: {0}", pocetOstatnich);


            
           
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Program můžete opakovat stiskem klávesy 'a'");
            again = Console.ReadLine();    

        }