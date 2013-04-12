using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace st28677
{
    class Osoba
    {
        const int MAX_DELKA_JMENA = 20;

        string jmeno;
        byte vek;
        Pohlavi pohlavi;
        DateTime posledniModifikace;

        /// <summary>
        /// Umožňuje osobě nastavit jméno
        /// </summary>
        public string Jmeno {
            get
            {
                return jmeno;
            }

            set
            {
                if (value.Length <= MAX_DELKA_JMENA)
                {
                    this.jmeno = value;
                }
                else
                {
                    this.jmeno = value.Substring(0, MAX_DELKA_JMENA);
                }
            }
        }

        /// <summary>
        /// Umožňuje osobě nastavit věk
        /// </summary>
        public int Vek
        {
            get { return (int)vek; }
            set { vek = (byte)value; }
        }

        /// <summary>
        /// Umožňuje osobě nastavit pohlaví. <typeparamref name="Pohlavi"/>
        /// </summary>
        public Pohlavi Pohlavi
        {
            get { return pohlavi; }
            set { pohlavi = value; }
        }

        /// <summary>
        /// Umožňuje osobě nastavit datum modifikace
        /// </summary>
        public DateTime PosledeniModifikace
        {
            get { return posledniModifikace; }
            set { posledniModifikace = value; }
        }
        
        
    }

    enum Pohlavi
    {
        M,
        Z
    }
}
