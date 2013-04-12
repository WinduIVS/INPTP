using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

/*
 * Je dán výčtový typ FotbalovyKlub s těmito konstantami
 * None, FC Porto, Arsenal, Real Madrid, Chelsea, Barcelona.
 * Je dána statická třída FotbalovyKlubInfo, poskytující informace
 * k výčtovému typu FotbalovyKlub:
 * - readonly datová složek Pocet - počet výčtových konstant
 * - metoda DejNazev - vrací název zadané výčtové konstanty.
 * Je dána třída Hrac, obsahující tyto složky:
 * - konstatní datová složka MaxJmeno - maximální délka jména hráče
 * - vlastnost Jmeno typu string - poskytuje nebo nastavuje jméno hráče
 * - vlastnost Klub typu FotbalovyKlub - poskytuje nebo nastavuje klub hráče
 * - vlastnost GolPocet - poskytuje nebo nastavuje počet nastřílených gólů
 * Je dána třída Hraci, která zapouzdřuje pole hráčů s kapacitou, obsahující tyto složky:
 * - vlastnost Pocet - poskytuje počet hráčů
 * - metoda Vymaz - vymaže hráče na zadaném indexu
 * - metoda Pridej - přidá hráče na konec pole
 * - metoda DejHrace - vrací hráče na zadaném indexu
 * - metoda NajdiNejlepsiKluby(kluby, golPocet) - hledá kluby, které mají největší počet bodů. 
 *   V parametru kluby vrací pole těchto klubů a v parametru
 *   golPocet vrací počet gólů.
 * - událost PocetZmenen - vyvolá se, pokud došlo ke změně počtu hráčů.
 *   Parametr události obsahuje původní počet hráčů.
 * Vytvořte formulářovou aplikaci, obsahující tyto ovládací prvky:
 * - seznam hráčů
 * - tlačítko Přidat - přidá hráče do seznamu
 * - tlačítko Vymazat - vymaže vybrané hráče ze seznamu
 * - tlačítko Upravit - upraví údaje vybraného hráče
 * - tlačítko Nejlepší klub - zobrazí dialogové okno, obsahující seznam
 *   nejlepších klubů a počet gólů
 * - tlačítko Registrovat - registruje handler pro příjem události 
 *   PocetZmenen. Handler vypíše do textového pole informaci o změně
 *   počtu hráčů.
 * - tlačítko Zrušit registraci - zruší registraci handleru pro příjem 
 *   události PocetZmenen.
 * - tlačítko Ukončit - ukončí program.
 */
namespace LigaMistru
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LigaMistruForm());
        }
    }
}
