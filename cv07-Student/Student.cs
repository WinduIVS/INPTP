using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fei.BaseLib;

namespace cviceni7
{
    class Student
    {
        private string jmeno;
        private int cislo;
        private Fakulta fakulta;

        public void Nacti()
        {
            jmeno = Cteni.NactiString("Zadejte jméno");
            cislo = Cteni.NactiInt("Zadejte cislo studenta");
            int cisloFakulty;
            do
            {
                cisloFakulty = Cteni.NactiInt("Zadejte fakultu (1 - FES, 2 - FF, 3 - Fei, 4 - Fcht)");
                switch (cisloFakulty)
                {
                    case 1: fakulta = Fakulta.Fes;break;
                    case 2: fakulta = Fakulta.FF;break;
                    case 3: fakulta = Fakulta.Fei;break;
                    case 4: fakulta = Fakulta.Fcht; break;
                }

            }while(cisloFakulty > 4 || cisloFakulty <1);


        }

        public void Vypis()
        {
            Console.WriteLine("{0,5} {1,5} {2}", cislo, fakulta.ToString(), jmeno);
        }

        public static bool MensiFakulta(Student a, Student b)
        {
            return a.fakulta.ToString().CompareTo(b.fakulta.ToString()) < 0;
        }

        public static bool MensiJmeno(Student a, Student b)
        {
            return string.Compare(a.jmeno, b.jmeno)< 0;
        }

        public int DejCislo() { return cislo; }

    }
}
