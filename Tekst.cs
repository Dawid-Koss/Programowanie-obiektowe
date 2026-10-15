using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Tekst
    {
        public static void Zadanie1()
        {
            Console.WriteLine("Zadanie 1\n");
            Console.WriteLine("Wprowadź tekst w celu poadani jego długości");
            string? Tekst_1 = Console.ReadLine() ?? "";
            Console.WriteLine($"Twój tekst ma długość {Tekst_1.Length}");
        }
        public static void Zadanie2()
        {
            Console.WriteLine("\nZadanie 2\n");
            Console.WriteLine("Wprowadź tekst w celu zliecznia 'a'");
            string? Tekst_2 = Console.ReadLine() ?? "";
            int liczba = 0;
            for (int i = 0; i < Tekst_2.Length; i++)
            {
                if (Tekst_2[i] == 'a')
                {
                    liczba++;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine($"W twoim tekście występuje a {liczba} razy");
        }
        public static void Zadanie3()
        {
            Console.WriteLine("\nZadanie 3\n");
            Console.WriteLine("Wprowadź tekst w celu zliecznia poszczególnych liter");
            string? Tekst_3 = Console.ReadLine() ?? "";
            string? sprwadzone = "";
            for (int i = 0; i < Tekst_3.Length; i++)
            {
                char litera = Tekst_3[i];
                if (sprwadzone.Contains(litera))
                {
                    continue;
                }
                else
                {
                    sprwadzone += litera;
                }
                int licznik = 0;
                for (int j = 0; j < Tekst_3.Length; j++)
                {
                    if (Tekst_3[j] == litera)
                    {
                        licznik++;
                    }
                }
                Console.WriteLine($"Litera '{litera}' występuje: {licznik} razy");
            }
        }
        public static void Zadanie4()
        {
            Console.WriteLine("\nZadanie 4\n");
            Console.WriteLine("Wprowadź tekst w celu weryfikacji czy jest on Palindromem");
            string? Tekst_4 = (Console.ReadLine() ?? "").ToLower();
            string? odwrocony = "";
            for (int i = Tekst_4.Length - 1; i >= 0; i--)
            {
                odwrocony += Tekst_4[i];
            }
            if (Tekst_4 == odwrocony)
            {
                Console.WriteLine("Tekst jest palindromem");
            }
            else
            {
                Console.WriteLine("Tekst nie jest palindromem");
            }
        }
    }
}
