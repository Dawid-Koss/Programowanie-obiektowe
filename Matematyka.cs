using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Matematyka
    {
        public static void Zadanie1()
        {
            Console.WriteLine("Zadanie 1 - Matematyka\n");
            Console.WriteLine("Podaj pierwszą liczbę: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("\nPodaj drugą liczbę: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("\nPodaj znak operacji którą chcesz wykonać (+,-,/,*)");
            string? znak = Console.ReadLine() ?? "";
            double wynik = 0;
            switch (znak)
            {
                case "+":
                    wynik = a + b;
                    Console.WriteLine($"Wynik twojego dodawania to: {wynik}");
                    break;
                case "-":
                    wynik = a - b;
                    Console.WriteLine($"Wynik twojego odejmowania to: {wynik}");
                    break;
                case "*":
                    wynik = a * b;
                    Console.WriteLine($"Wynik twojego mnożenia to: {wynik}");
                    break;
                case "/":
                    if (b == 0)
                    {
                        Console.WriteLine("Nie wolno dzielić przez 0!!!");
                    }
                    else 
                    {
                        wynik = a / b;
                        Console.WriteLine($"Wynik twojego dzielenia to: {wynik}");
                    }
                    break;
                default:
                    Console.WriteLine("Podałeś błedny typ danych");
                    break;
            }
            
        }
        public static void Zadanie2()
        {
            Console.WriteLine("Podaj liczbę do weryfikacji czy ona jest parzysta");
            int a = int.Parse(Console.ReadLine() ?? "");
            if ((a % 2) == 0)
            {
                Console.WriteLine($"Liczba {a} jest liczbą parzystą");
            }
            else
            {
                Console.WriteLine($"Liczba {a} jest liczbą nieparzystą ");
            }
        }
        public static void Zadanie3()
        {
            Console.WriteLine("Wprowadź liczbę w celu weryfikacji czy jest ona liczbą pierwszą");
            int a = int.Parse(Console.ReadLine() ?? "");
            if (a <= 1)
            {
                Console.WriteLine("Liczba nie jest pierwszą");
            }
            else
            {
                bool pierwsza = true;
                for (int i = 2; i < a; i++)
                {
                    if (a % i == 0)
                    {
                        pierwsza = false;
                        break;
                    }
                }
                if (pierwsza)
                {
                    Console.WriteLine("Liczba jest pierwsza");
                }
                else
                {
                    Console.WriteLine("Liczba nie jest pierwsza");
                }
            }
        }
        public static void Zadanie4()
        {
            Console.WriteLine("Podaj liczbę a w celu policzenia miesjca zerowego funkcji liniowej");
            double a = double.Parse(Console.ReadLine() ?? "");
            Console.WriteLine("Podaj liczbę b w celu policzenia miesjca zerowego funkcji liniowej");
            double b = double.Parse(Console.ReadLine() ?? "");
            double x0 = 0;
            if (a == 0)
            {
                Console.WriteLine("Nie mozna dzielic przez 0 !!!");
            }
            else
            {
                x0 = -(b / a);
                Console.WriteLine($"Miejsce zerowe funkcji wynosi {x0}");
            }
        }
        public static void Zadanie5()
        {
            Console.WriteLine("Podaj liczbę a w celu policzenia miesjc zerowych funkcji kwadratwoej");
            double a = double.Parse(Console.ReadLine() ?? "");
            Console.WriteLine("Podaj liczbę b w celu policzenia miesjc zerowych funkcji kwadratwoej");
            double b = double.Parse(Console.ReadLine() ?? "");
            Console.WriteLine("Podaj liczbę c w celu policzenia miesjc zerowych funkcji kwadratwoej");
            double c = double.Parse(Console.ReadLine() ?? "");
            double x0 = 0;
            double x1 = 0;
            double x2 = 0;
            double delta = b*b - 4 * a * c;
            if (delta < 0)
            {
                Console.WriteLine($"{delta} mniejsza od 0 nie ma miejsc zerowych");
            }
            else if (delta == 0)
            {
                x0 = -b / (2 * a);
                Console.WriteLine($"{delta} ma jedno miejsce zerowe: {x0}");
            }
            else
            {
                x1 = (-b -Math.Sqrt(delta))/(2*a);
                x2 = (-b + Math.Sqrt(delta))/(2 * a);
                Console.WriteLine($"{delta} ma dwa miejsca zerowe x1 = {x1} i x2 = {x2}");
            }


        }
    }
}
