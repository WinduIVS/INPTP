using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace st28677
{
    class Program
    {
        static void vypisOsoby(OsobaPole osoby) 
        {
            int c = 0;
            
            int cislo = dejDelkuPoctu(osoby);
            int jmenoDelka = dejDelkuJmena(osoby);
            int vek = byte.MaxValue.ToString().Length;
            foreach (var osoba in osoby) 
            {
                String pohl =  osoba.Pohlavi.ToString().ToLower().Equals("m") ? "Muž" : "Žena";
                Console.WriteLine(String.Format("{0," + cislo + "}{1," + (-1 * jmenoDelka) + "}{2," + vek + "}{3}{4:d/m/yyyy HH:mm:ss}", ++c, osoba.Jmeno, osoba.Vek, pohl, osoba.PosledeniModifikace.ToLocalTime()));
            }
        }

        static string dosadJmeno(string jmeno, int delka)
        {
            StringBuilder sb = new StringBuilder(jmeno);
            for (int i = jmeno.Length; i < delka; i++)
            {
                sb.Append(' ');
            }

            return sb.ToString();
        }
        static int dejDelkuPoctu(OsobaPole osoby)
        {
            return osoby.Pocet.ToString().Length;
        }

        static int dejDelkuJmena(OsobaPole osoby)
        {
            int d = osoby[0].Jmeno.Length;
            foreach (var osoba in osoby)
            {
                if (osoba.Jmeno.Length > d)
                {
                    d = osoba.Jmeno.Length;
                }
            }

            return d;
        }

        static Osoba najdiStarou(OsobaPole osoby)
        {
            if (osoby.Pocet == 0) return null;

            Osoba o = osoby[0];
            foreach (var osoba in osoby)
            {
                if (osoba.Vek > o.Vek)
                {
                    o = osoba;
                }
            }

            return o;
        }

        static void pridejOsobu(OsobaPole osoby)
        {
            Osoba o = new Osoba();
            String retezec;

            Console.WriteLine("Zadejte jmeno");
            retezec = Console.ReadLine();
            o.Jmeno = retezec;

            Console.WriteLine("Zadejte vek");
            retezec = Console.ReadLine();
            o.Vek= int.Parse(retezec);

            Console.WriteLine("Zadejte pohlavi (m/z)");
            retezec = Console.ReadLine();
            if (retezec.ToLower().Equals("m") || retezec.ToLower().Equals("z"))
            {
                o.Pohlavi = retezec.ToLower().Equals("m") ? Pohlavi.M : Pohlavi.Z;
            }

            osoby.PridejUloz(o);
        }

        static void Main(string[] args)
        {

            OsobaPole osoby = null;
            int volba;

            do
            {
                Console.WriteLine(@"
1. Otevrit soubor
2. Vypis osob
3. Pridani
4. Vymazani
5. Nejstarsi
0. Konec
");
                volba = int.Parse(Console.ReadLine());

                switch (volba)
                {
                    case 1:
                        Console.WriteLine("Zadejte jmeno souboru: ");
                        string soubor = Console.ReadLine();
                        osoby = new OsobaPole(new TextSouborDatovaVrstva(soubor));
                        osoby.Nacti();
                        break;
                    case 2:
                        if (osoby != null)
                        {
                            vypisOsoby(osoby);
                        }
                        break;
                    case 3:
                        if (osoby != null)
                        {
                            pridejOsobu(osoby);
                        }
                        break;
                    case 4:
                        if (osoby != null)
                        {
                            int index = int.Parse(Console.ReadLine());
                            osoby.VymazUloz(index-1);
                        }
                        break;
                    case 5:
                        if (osoby != null)
                        {
                            Osoba o = najdiStarou(osoby);
                            if (o != null)
                            {
                                Console.WriteLine("Nejstarší osoba je {0}, jeji vek je {1}", o.Jmeno, o.Vek);
                            }
                        }
                        break;
                }
            } while (volba != 0);
        }
    }


}
