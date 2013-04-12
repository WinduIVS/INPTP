using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Priprava01
{
    class SeznamOsob : IEnumerable
    {
        Osoba[] pole = new Osoba[0];
        Soubory soubor = new Soubory();

        public void Uloz() {

            soubor.UlozSoubor("soubor.txt", pole);
                    
        }

        public void Nacti() { 
        
            pole = soubor.NactiSoubor("soubor.txt");
        
        }
        
        public void PridejUloz(Osoba osoba) {

            Array.Resize(ref pole, pole.Length + 1);
            pole[pole.Length -1] = osoba;
            Uloz();

        }
        
        public void VymazUloz(int index) {

            for (int i = index; i < (pole.Length-1); i++)
            {
                pole[i] = pole[i + 1];
   
            }
            Array.Resize(ref pole, pole.Length - 1);
            Uloz();

        }

        public Osoba this[int index]
        {
            get { return pole[index]; }
            set { pole[index] = value; }
        }

        
        public IEnumerator GetEnumerator()
        {
            foreach (Osoba item in pole)
            {
                yield return item;
            }

        }

    }
}
