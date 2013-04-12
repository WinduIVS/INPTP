using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Priprava01
{
    class Program
    {
        private static SeznamOsob osoby = new SeznamOsob();

        private static Osoba NactiOsobu()
        {
            Console.Write("Zadejte jméno a příjmení: ");
            String jmeno = Console.ReadLine();

            Console.Write("Zadejte věk: ");
            byte vek = Convert.ToByte(Console.ReadLine());

            Console.Write("Zadejte pohlavi (muz X zena): ");
            pohlavi pohl;

            if (Console.ReadLine() == "muz")
                pohl = pohlavi.muz;
            else
                pohl = pohlavi.zena;

            Osoba os1 = new Osoba(jmeno, vek, pohl, DateTime.UtcNow);

            return os1;
        }

        private static Osoba NajdiNejstarsiho()
        {
            byte max = 0;
            Osoba os = null;

            foreach (Osoba item in osoby)
            {
                if (item.vek > max)
                {
                    max = item.vek;
                    os = item;
                }                
            }            
            return os;
        }

        private static void VypisOsob()
        {
            foreach (Osoba item in osoby)
            {
                Console.WriteLine("Jméno: {0}, vek: {1}, pohlavi: {2}, datum: {3}", 
                                    item.jmeno, item.vek, item.pohl, item.datum);
            } 
        }
       
        static void Main(string[] args)
        {
            int volba;

            do
            {
                Console.WriteLine(@"MENU:
1)Zadej novou osobu
2)Nacti ze souboru
3)Uloz do souboru
4)Najdi nejstarsiho
5)Vypis seznam osob
0)Ukonči program

                ");

                volba = int.Parse(Console.ReadLine());

                switch (volba)
                {
                    case 1:
                        Osoba os = NactiOsobu();
                        osoby.PridejUloz(os);
                        break;
                    case 2:
                        osoby.Nacti();
                        break;
                    case 3:
                        osoby.Uloz();
                        break;
                    case 4:
                        Osoba nejstarsi = NajdiNejstarsiho();
                        
                        if (nejstarsi == null)
                        {
                            Console.WriteLine("Prázdný seznam");
                            break;
                        }
                        Console.WriteLine("Nejstarší osoba: " + nejstarsi.jmeno);

                        break;
                    case 5:
                        VypisOsob();
                        break;

                }
            } while (volba != 0);

            //Console.ReadKey();
        }
    }
}
