using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Priprava01
{
    class Soubory : ISoubory        
    {
        Osoba[] pole = new Osoba[0];

        public void UlozSoubor(string soubor, Osoba[] osoby)
        {
            using (StreamWriter sw = new StreamWriter(File.Open(soubor, FileMode.Create, FileAccess.Write)))
            {
                sw.WriteLine("Počet osob:" + osoby.Length);

                foreach (Osoba item in osoby)
                {
                    sw.WriteLine("{0};{1};{2};{3}", item.jmeno, item.vek, item.pohl, item.datum.Ticks);
                   //sw.WriteLine(item.ToString(CultureInfo.InvariantCulture));
                }
            }
        }

        public Osoba[] NactiSoubor(string soubor)
        {          
            using (StreamReader sr = new StreamReader(File.OpenRead(soubor)))
            {
                int index = 0;
                if (!sr.EndOfStream)
                {
                    string radek = sr.ReadLine();
                    string[] texty = radek.Split(':');
                    int pocet = int.Parse(texty[1]);
                    Array.Resize(ref pole, pocet);

                }
                while (!sr.EndOfStream)
                {
                    
                    string radek = sr.ReadLine();
                    string[] texty = radek.Split(';');

                    string jmeno = texty[0];
                    byte vek = Convert.ToByte(texty[1]);
                    pohlavi pohl; 

                    if (texty[2] == "muz")
                        pohl = pohlavi.muz;
                    else
                        pohl = pohlavi.zena;

                    DateTime datum = new DateTime(long.Parse(texty[3]));

                    Osoba os = new Osoba(jmeno, vek, pohl, datum);
                    pole[index] = os;
                    index++;
                }
            }
            return pole;
        }
    }
}
