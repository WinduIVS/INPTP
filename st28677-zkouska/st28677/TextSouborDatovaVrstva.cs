using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace st28677
{
    class TextSouborDatovaVrstva : IDatovaVrstva
    {

        private string soubor;

        #region IDatovaVrstva Members

        public Osoba[] NactiOsoby()
        {
            if (new FileInfo(soubor).Length == 0)
            {
                return new Osoba[0];
            }
	
            string retezec;
            Osoba[] osoby = new Osoba[0];
            using (StreamReader sr = new StreamReader(File.OpenRead(soubor)))
            {
                
                Osoba o;
                bool prvni = true;
                int i = 0;
                while (!sr.EndOfStream)
                {
                    retezec = sr.ReadLine();
                    if (!String.IsNullOrEmpty(retezec))
                    {
                        //..ctem první řádek.
                        if (prvni)
                        {
                            int pocetOsob = int.Parse(retezec);
                            osoby = new Osoba[pocetOsob];
                            prvni = false;
                        }
                        else
                        {
                            o = new Osoba();
                            string[] udajeOsoba = retezec.Split(';');
                            o.Jmeno = udajeOsoba[0];
                            o.Vek = byte.Parse(udajeOsoba[1]);
                            o.Pohlavi = udajeOsoba[2].Equals("M") ? Pohlavi.M : Pohlavi.Z;
                            o.PosledeniModifikace = new DateTime(long.Parse(udajeOsoba[3]));
                            osoby[i] = o;
                            i++;
                        }
                    }
                    
                }
            }
            return osoby;
        }

        public void UlozOsoby(Osoba[] _osoby)
        {
            StringBuilder sb;
            FileStream fs = File.Open(soubor, FileMode.Open, FileAccess.Write);
            using (StreamWriter sw = new StreamWriter(fs))
            {
                fs.SetLength(0);
                sw.WriteLine(_osoby.Length);
                foreach (Osoba osoba in _osoby)
                {
                    if (osoba != null)
                    {
                        sb = new StringBuilder();
                        sb.Append(osoba.Jmeno).Append(';');
                        sb.Append(osoba.Vek).Append(';');
                        sb.Append(osoba.Pohlavi.ToString()).Append(';');
                        sb.Append(osoba.PosledeniModifikace.Ticks).Append(';');
                        sw.WriteLine(sb.ToString());
                    }
                }
            }
            fs.Close();
        }

        #endregion

        public TextSouborDatovaVrstva(string _jmenoSouboru)
        {
            if (String.IsNullOrEmpty(_jmenoSouboru))
            {
                throw new ArgumentException("Jmeno souboru nemuze byt prazdne");
            }

            this.soubor = _jmenoSouboru;

            //..vytvoří ho, když neexistuje
            if (!File.Exists(_jmenoSouboru))
            {
                FileStream fs = File.Open(_jmenoSouboru, FileMode.CreateNew, FileAccess.Write);
                fs.Close();
            }

        }
    }
}
