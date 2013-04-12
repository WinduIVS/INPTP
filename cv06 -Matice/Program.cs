using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fei.BaseLib;

/*
 * 
 * Vytvořte program pro práci s maticí reálných čísel.
 * Program bude obsahovat toto menu:
 * g) Generování matice
 * v) Výpis matice
 * m) Hledání max. prvku
 * k) konec programu
 * 
 * 
 */

namespace Matice
{
    class Program
    {
        
        static double[,] GenerujMatici()
        {
            Random random = new Random();
            int pocetR = Cteni.NactiInt("Zadejte počet řádků");
            int pocetS = Cteni.NactiInt("Zadejte počet sloupců");
            int min = Cteni.NactiInt("Zadejte minimální hodnotu");
            int max = Cteni.NactiInt("Zadejte maximální hodnotu");

            double[,] matice = new double[pocetR, pocetS];
            
            for (int i = 0; i < pocetR; i++)
            {
                for (int j = 0; j < pocetS; i++)
                {
                    matice[i, j] = Matematika.DejNahodneDouble(random, min, max);
                }
            }
            return matice;

        }

        static void VypisMatici(double[,] matice)
        {
            for (int i = 0; i < matice.GetLength(0); i++)
            {
                for (int j = 0; j < matice.GetLength(1); i++)
                {
                    Console.Write("{0,6:F1}", matice[i, j]);
                }
                Console.WriteLine();
            }

        }


        static DvojiceInt NajdiMaxPrvek(double[,] matice)
        {
            
            if (matice.Length == 0) return new DvojiceInt(-1,-1);
            int x = 0, y = 0;
            double max = double.MinValue;

            for (int i = 0; i < matice.GetLength(0); i++)
            {
                for (int j = 0; j < matice.GetLength(1); i++)
                {
                    if (matice[i,j] > max)
                    {
                        max = matice[i, j];
                        x = i;
                        y = j;
                    }
                }
            }
            return new DvojiceInt(x, y);
        }

        static void Main(string[] args)
        {
            char volba;
            double[,] matice = { };

            do
            {
                Console.WriteLine(@"
Menu:
  g) Generování matice
  v) Výpis matice
  m) Hledání max. prvku
  k) konec programu
");
                volba = Cteni.NactiChar("Vyberte volbu z menu");
                switch (volba)
                {
                    case 'g':
                        matice = GenerujMatici();
                        break;
                    case 'v':
                        VypisMatici(matice);
                        break;
                    case 'm':
                        NajdiMaxPrvek(matice);
                        break;
                }

            } while (volba != 'k');


        }
    }
}
