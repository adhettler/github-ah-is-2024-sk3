﻿using System.Globalization;

Console.ForegroundColor = ConsoleColor.Green;

string again = "a";
        while(again == "a") {

            Console.Clear();
            Console.WriteLine("****************************");
            Console.WriteLine("********* Obdelník *********");
            Console.WriteLine("******* Adam Hettler *******");
            Console.WriteLine("****************************");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Zadejte šířku obrazce (kladné celé číslo): ");
            uint width;
            while(!uint.TryParse(Console.ReadLine(), out width)) {
                Console.Write("Nezadali jste kladné celé číslo. Zadejte číslo (celé číslo): ");
            }

            Console.Write("Zadejte výšku obrazce (kladné celé číslo): ");
            uint height;
            while(!uint.TryParse(Console.ReadLine(), out height)) {
                Console.Write("Nezadali jste kladné celé číslo. Zadejte číslo (celé číslo): ");
            }


            
            Console.WriteLine();
            Console.WriteLine("========================================================");
            Console.WriteLine("Zadané hodnoty: ");
            Console.WriteLine("šířka: {0}", width);
            Console.WriteLine("výška: {0}", height);
            Console.WriteLine("========================================================");
            
            // for(int = 1; i <=10 ; i++)
            // {
            //     Console.WriteLine(i);
            // }

            // int j = int;
            // while(j<=10)
            // {
            //     Console.WriteLine(j);
            //     j++;
            // }
            

            for(int i = 1; i <=height; i++)  {
                for(int j = 1; j<=width; j++){
                    Console.Write("*");
                    
                }
                Console.WriteLine();
                System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));
            }



           
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Program můžete opakovat stiskem klávesy 'a' ");
            again = Console.ReadLine();    

        }