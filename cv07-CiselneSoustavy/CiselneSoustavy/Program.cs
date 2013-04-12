using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fei.BaseLib;

/*
 * Vytvořte program s následujícím menu
 * 1) Převod z 10 do 2 soustavy
 * 2) převod z 2 do 10 soustavy
 * 3) převod z 10 do římské
 * 4) převod z římské do desítkové
 * 0) konec programu
 * 
 * Využijte třídu MathConvert, která bude součást knihovny BaseLib
 * a bude obsahovat metody
 * string ToBinary(int val)
 * int FromBinary(string val)
 * string ToRoman(int val)
 * int FromRoman(string val)
 * 
 * 
 * */
namespace CiselneSoustavy
{
    class Program
    {
        static void Main(string[] args)
        {
            int volba, cislo;
            string retezec;
            do
            {
                Console.WriteLine(@"
Menu:
 * 1) Převod z 10 do 2 soustavy
 * 2) převod z 2 do 10 soustavy
 * 3) převod z 10 do římské
 * 4) převod z římské do desítkové
 * 0) konec programu
");
                volba = Cteni.NactiInt("Vyberte volbu z menu");
                switch (volba)
                {
                    case 1:
                        cislo = Cteni.NactiInt("Zadejte celé číslo:");
                        retezec = MathConvert.ToBinary(cislo);
                        if (retezec == null) Console.WriteLine("Převod nelze uskutečnit");
                        else Console.WriteLine("Číslo v binární soustavě je {0}", retezec);
                        break;
                    case 2:
                        retezec = Cteni.NactiString("Zadejte číslo ve dvojkové soustavě");
                        cislo = MathConvert.FromBinary(retezec);
                        if (cislo == -1) Console.WriteLine("Převod nelze uskutečnit");
                        else Console.WriteLine("Číslo v desítkové soustavě je {0}", cislo);
                        break;
                    case 3:

                        break;
                }
            } while (volba !=0);
        }
    }
}
