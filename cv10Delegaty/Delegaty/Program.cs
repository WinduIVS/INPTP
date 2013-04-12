using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegaty
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabelace t = new Tabelace();
            FunkceCallback f = new FunkceCallback(Math.Sin);			// Funkce Sin je statická metoda třídy Math
            // FunkceCallback f = Math.Sin; // dtto předchozí příkaz
            Console.WriteLine("Tabulka funkce sinus");
            t.Tabulka(f, 0, 1, 0.2);
            Console.WriteLine("\nTabulka funkce druhé mocniny");
            t.Tabulka(new FunkceCallback(t.Mocnina), 0, 5, 1);
            // t.Tabulka(t.Mocnina, 0, 5, 1); // dtto předchozí příkaz
            Console.ReadKey();

        }
    }
}



