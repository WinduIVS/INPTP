using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Priprava01
{
    enum pohlavi { muz, zena };

    class Osoba
    {
        const int maxDelka = 20;
        public string jmeno;
        public byte vek;
        public pohlavi pohl;
        public DateTime datum;

        public Osoba(string jm, byte vek, pohlavi poh, DateTime datum)
        {
            if (jm.Length > maxDelka)
            {
                Console.WriteLine("Příliš dlouhé jméno");
                return;
            }
            jmeno = jm;
            this.vek = vek;
            pohl = poh;
            this.datum = datum;

        }
    }
}
