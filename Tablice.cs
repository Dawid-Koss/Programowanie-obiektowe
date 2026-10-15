using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Tablice
    {
        public static void Zadanie1()
        {
            int[] tablica = new int[5];
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.WriteLine($"Wprowadź liczbę {i+1} do tablicy: ");
                tablica[i] = int.Parse(Console.ReadLine() ?? "0");
            }
            int max = tablica[0];
            int min = tablica[0];
            int suma = 0;
            for (int j = 0; j < tablica.Length; j++)
            {
                if( tablica[j] > max )
                {
                    max = tablica[j];
                }
                if( tablica[j] < min )
                {
                    min = tablica[j];
                }
                suma += tablica[j];
            }
            Console.WriteLine($"Liczba maksymalna w tablicy to {max}, liczba minimalna w tablicy to {min}, suma liczb w tablicy wynosi {suma}");
        }
        public static void Zadanie2()
        {
            List<int> lista = new List<int>();
            while (true)
            {
                Console.WriteLine("Podaj liczbę do listy, jak chcesz zakończyć wpisz 'end'");
                string koniec = Console.ReadLine() ?? "";
                if (koniec.ToLower() == "end")
                {
                    break;
                }
                lista.Add(int.Parse(koniec));
            }
            if (lista.Count > 0)
            {
                int max = lista[0];
                int min = lista[0];
                int suma = 0;
                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista[i] > max)
                    {
                        max = lista[i];
                    }
                    if (lista[i] < min)
                    {
                        min = lista[i];
                    }
                    suma += lista[i];
                }
                Console.WriteLine($"Liczba maksymalna w liście to {max}, liczba minimalna w liście to {min}, suma liczb w liście wynosi {suma}");
            }
            else
            {
                Console.WriteLine("Lista jest pusta");
            }
        }
    }
}
