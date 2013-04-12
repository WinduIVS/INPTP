using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fei.BaseLib;

/*
 * dána třída student obsahující jméno, číslo, fakultu
 * MENU
 * 1)načtení
 * 
 * 
 * */

namespace cviceni7
{
    class Program
    {
        static void Main(string[] args)
        {
            int volba;
            Studenti studenti = new Studenti();
            do
            {
                Console.WriteLine(@"MENU:
1)Nacti studenty z klavesnice
2)Vypis studentu
3)Serad podle cisla
4)Serad podle jmena
5)Serad podle fakulty

                ");
                volba = Cteni.NactiInt("Zadejte volbu z menu");
                switch (volba)
                {
                    case 1:
                        studenti.Nacti();
                        break;
                    case 2:
                        studenti.Vypis();
                            break;
                    case 3:
                        //studenti.serad(delegate(Student a, Student b)
                        //{
                        //    return a.DejCislo() < b.DejCislo();
                        //});

                            studenti.Serad((a, b) => a.DejCislo() < b.DejCislo());

                        break;
                    case 4:
                        studenti.Serad(Student.MensiJmeno);
                        break;
                    case 5:
                        //studenti.Serad(Student.MensiFakulta);
                        MensiStudentCallback mensi = new MensiStudentCallback(Student.MensiFakulta);
                        studenti.Serad(mensi);
                        break;

                }
            } while (volba != 0);
        }
    }
}
