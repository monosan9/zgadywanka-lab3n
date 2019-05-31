
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraMonolitycznie
{
    class Program
    {
        /// <summary>
        /// Generuje liczbę pseudolosową z podanego zakresu włącznie z krańcami
        /// </summary>
        /// <param name="min">Dowolna liczba całkowita</param>
        /// <param name="max">Dowolna liczba całkowita</param>
        /// <returns>liczba całkowita z podanego zakresu</returns>
        
        static int Losuj(int min =1, int max =100) //nagłówek funkcji, sygnatura

               {
            if (min > max)
            { //swap, zamiana liczb
                int temp = min; //dodatkowa zmienna zeby zapamietac wartosc min i jej nie zmieniac pozniej, zeby nie bylo dwoch min
                min = max;
                max = temp;
            }

            Random generator = new Random();
            return generator.Next(min, max+1);
        }

        /// <summary>
        /// Wczytuje z konsoli liczbę lub znak X
        /// </summary>
        /// <returns>liczba całkowita odpowiadająca podanej wartości na konsoli </returns>
        /// <exception cref="OperationCanceledException">Gdy wprowadzono "X" lub "x"</exception>
        static int WczytajLiczbe( string prompt ="Podaj liczbę (lub X aby zakończyć): ")
        {
            int propozycja = 0;
            while (true)
            {
                Console.Write(prompt);
                string tekst = Console.ReadLine();
                if (tekst.ToLower() == "x")
                    throw new OperationCanceledException("wprowadzono X");
               
                try
                {
                    propozycja = Convert.ToInt32(tekst);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nie podano liczby! Spróbuj jeszcze raz");
                    continue; //przechodzi na poczatek petli
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Liczba nie mieści się w rejestrze! Spróbuj jeszcze raz");
                    continue;
                }
            }
            return propozycja;

        }

        static string Ocena(int propozycja)
        {
            if (propozycja < wylosowana)
                return "za mało";
            else if (propozycja > wylosowana)
               return "za dużo";
            else
              return"trafiono";
                         
        }

        static int wylosowana = 0;

        static void Main(string[] args) //elementy statyczne z zewnatrz tez musza byc w Mainie zeby nie podkreslal Losuj ktore jest z zewnatrz
        {

            int min = WczytajLiczbe("Podaj zakres - min: "); //w bloku try jeszcze
            int max = WczytajLiczbe("Podaj zakres - max: ");
            wylosowana = Losuj(min,max);
            Console.WriteLine($"Wylosowałem liczbę od {min} do {max}. \n Odgadnij ją");

#if(DEBUG)
            Console.WriteLine(wylosowana);
#endif

 
         
            do
            {
                int propozycja = 0;
                try
                {
                    propozycja = WczytajLiczbe("Podaj swoją propozycję (lub X aby poddać się: ");
                }
                catch (OperationCanceledException)
                {
                    Console.WriteLine("Szkoda, że tak szybko kończymy. Wyjście awaryjne");
                }
                
                Console.WriteLine($"Przyjąłem wartość {propozycja}");

                string wynik = Ocena(propozycja);
                Console.WriteLine(wynik);
                if (wynik == "trafiono")
                    break;

            }
            while (true);
       
            Console.WriteLine("Koniec gry");
        }
    }
}

