using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fei.BaseLib;

namespace cviceni7
{
    class Studenti
    {
        private Student[] pole;

        public void Nacti()
        {
            int pocet = Cteni.NactiInt("Zadejte počet studentů");
            pole = new Student[pocet];
            for (int i = 0; i < pocet; i++)
            {
                pole[i] = new Student();
                pole[i].Nacti();
                
            }

        }

        public void Vypis()
        {
            foreach (var item in pole)
            {
                item.Vypis();
            }
        }

        public void Serad(MensiStudentCallback mensiStudent)
        {
            bool vymena;
            for (int i = 0; i < pole.Length - 1; i++)
            {
                vymena = false;
                for (int j = 0; j < pole.Length - 1 - i; j++)
                {
                    if (mensiStudent(pole[j + 1], pole[j]))
                    {
                        Student pom = pole[j + 1];
                        pole[j + 1] = pole[j];
                        pole[j] = pom;
                        vymena = true;
                    }
                }
                if (!vymena) return;
            }

        }

    }
}
