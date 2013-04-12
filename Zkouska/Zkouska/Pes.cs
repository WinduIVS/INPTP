using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zkouska
{
    public class Pes
    {
        string jmeno;
        DateTime narozen;
        byte nalada;
        byte laska;
        byte stavZaludku;
        bool zivot;

        public Pes(string jmeno, DateTime narozen)
        {
            this.jmeno = jmeno;
            this.narozen = narozen;
            nalada = 50;
            laska = 50;
            stavZaludku = 50;
            zivot = true;
            
        }

        public Pes() { 
        
        }

        /// <summary>
        /// Uchovává jméno psa. <typeparamref name="string"/>
        /// </summary>
        public string Jmeno
        {
            get { return jmeno; }
            set { jmeno = value; }
        }
        /// <summary>
        /// Uchovává datum narození. <typeparamref name="DateTime"/>
        /// </summary>
        public DateTime Narozen
        {
            get { return narozen; }
            set { narozen = value; }
        }

        /// <summary>
        /// Uchovává náladu psa. <typeparamref name="byte"/>
        /// </summary>
        public byte Nalada
        {
            get { return nalada; }
            set { nalada = value; }
        }

        public byte Laska
        {
            get { return laska; }
            set { laska = value; }
        }

        public byte StavZaludku
        {
            get { return stavZaludku; }
            set { stavZaludku = value; }
        }

        public bool Zivot
        {
            get { return zivot; }
            set { zivot = value; }
        }


        public void Nakrmit()
        {
            if (stavZaludku >= 90)
            {
                stavZaludku = 50;
                nalada -= 30;
            }
            else
            {
                stavZaludku = 100;
                nalada += 20;
            }

        }

        public void Pochvalit()
        {
            if (nalada >= 90)
                nalada = 100;
            else
                nalada += 10;

            if (laska >= 99)
                laska = 100;
            else
                laska += 1;

            if (stavZaludku >= 99)
                stavZaludku = 100;
            else
                stavZaludku += 1;
            
        }

        public void Pomazlit()
        {
            if (nalada >= 80)
                nalada = 100;
            else
                nalada += 20;

            if (laska >= 95)
                laska = 100;
            else
                laska += 5;

        }

        public void Potrestat()
        {
            if (nalada <= 10){
                if (laska <= 5)
                    laska = 0;
                else
                    laska -= 5;

                nalada -= 0;
            }
                
            else 
                nalada -= 10;

            if (laska <= 1)
                laska = 0;
            else
                laska -= 1;

        }

        public void Vyvencit()
        {
            if (nalada >= 80)
                nalada = 100;
            else
                nalada += 20;

            if (laska >= 95)
                laska = 100;
            else
                laska += 5;

            if (stavZaludku <= 25)
                stavZaludku = 0;
            else
                stavZaludku -= 25;

        }

        public void Opustit()
        {
            //?????

        }

        public void Utratit()
        {
            zivot = false;
        }


    }
}
