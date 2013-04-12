using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fei.BaseLib;

/*
 * Vytvořte program, který bude pracovat s polem celých čísel a bude nabízet následující menu: 
 * 1) Načtení pole z klávesnice
 * 2) Výpis pole na obrazovku
 * 3) utřídění pole vzestupně
 * 4) Vyhledání min. prvku
 * 5) Hledání prvního výskytu zadaného čísla
 * 6) Hledání posledního výskytu zadaného čísla
 * 0) Konec programu
 */
  
namespace Pole
{
    class Program
    {
        static int[] NactiPole()
        {
            int pocet = Cteni.NactiInt("Zadejte počet prvků");
            int[] pole = new int[pocet];
            for (int i = 0; i < pocet; i++)
            {
                pole[i] = Cteni.NactiInt("Zadejte " + (i + 1) + ". prvek");
            }
            return pole;
        }

        static void VypisPole(int[] pole)
        {
            for (int i = 0; i < pole.Length; i++)
            {
                Console.Write(pole[i]);
                if (i < pole.Length - 1) Console.Write(", ");
            }
            Console.WriteLine();
        }

        static int NajdiMinPrvek(int[] pole)
        {
            if (pole.Length == 0) return -1;
            int min = int.MaxValue;
            int index = 0;
            for (int i = 0; i < pole.Length; i++)
            {
                if (pole[i] < min)
                {
                    min = pole[i];
                    index = i;
                }
            }
            return index;
        }

        static void Main(string[] args)
        {
            int volba, index, cislo;
            int[] pole = { };

            do
            {
                Console.WriteLine(@"
Menu:
1) Načtení pole z klávesnice
2) Výpis pole na obrazovku
3) utřídění pole vzestupně
4) Vyhledání min. prvku
5) Hledání prvního výskytu zadaného čísla
6) Hledání posledního výskytu zadaného čísla
0) Konec programu
");
                volba = Cteni.NactiInt("Vyberte volbu z menu");
                switch (volba)
                {
                    case 1:
                        pole = NactiPole();
                        break;
                    case 2:
                        VypisPole(pole);
                        break;
                    case 3:
                        Array.Sort(pole);
                        break;
                    case 4:
                        index = NajdiMinPrvek(pole);
                        if (index == -1) Console.WriteLine("Pole je prazdne.");
                        else Console.WriteLine("minimalni prvek je " + pole[index] + "a nachází se na pozici " + (index + 1) + ".");
                        break;
                    case 5:
                        cislo = Cteni.NactiInt("Zadejte hledané číslo");
                        index = Array.IndexOf(pole, cislo);
                        if (index == -1)
                            Console.WriteLine("Hledané číslo"+cislo+" se v poli nevyskytuje");
                        else
                            Console.WriteLine("První výskyt čísla" + cislo + " se v poli vyskytuje na pozici " + (index+1) + ".");
                        break;
                    case 6:
                        cislo = Cteni.NactiInt("Zadejte hledané číslo");
                        index = Array.LastIndexOf(pole, cislo);
                        if (index == -1)
                            Console.WriteLine("Hledané číslo"+cislo+" se v poli nevyskytuje");
                        else
                            Console.WriteLine("Poslední výskyt čísla" + cislo + " se v poli vyskytuje na pozici " + (index+1) + ".");
                        break;


                }

            } while (volba != 0);
        }
    }
}
