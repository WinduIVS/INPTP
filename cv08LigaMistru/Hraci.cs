using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LigaMistru
{
    class Hraci
    {
      private const int implicitniKapacita = 3;
      private Hrac[] pole;
      public int Pocet { get; private set; }
      public event PocetZmenenEventHandler PocetZmenen;
      public Hraci(int kapacita)
      {
         pole = new Hrac[kapacita];
      }
      public Hraci() {
          pole = new Hrac[implicitniKapacita];
      }

      public Hrac DejHrace(int index)
      {
         return pole[index];
      }

      public void Pridej(Hrac prvek)
      {
         if (pole == null || pole.Length == 0) {
            pole = new Hrac[implicitniKapacita];
         }
         if (pole.Length == Pocet) {
            Hrac[] pomPole = new Hrac[Pocet * 2];
            Array.Copy(pole, pomPole, Pocet);
            pole = pomPole;
         }
         pole[Pocet++] = prvek;
         OnPocetZmenen(new PocetEventArgs(Pocet - 1));
      }

      public void Vymaz(int index)
      {
         if (index >= 0 && index < Pocet) {
            for (int i = index; i < Pocet - 1; i++) {
               pole[i] = pole[i + 1];
            }
            pole[--Pocet] = null;
            OnPocetZmenen(new PocetEventArgs(Pocet + 1));
         }
      }

      public void NajdiNejlepsiKluby(out FotbalovyKlub[] kluby, out int golPocet)
      {
         if (Pocet == 0) {
            kluby = new FotbalovyKlub[0];
            golPocet = 0;
            return;
         }
         int[] klubGolPocet = new int[FotbalovyKlubInfo.Pocet];
         for (int i = 0; i < Pocet; i++) {
             klubGolPocet[FotbalovyKlubInfo.DejIndex(pole[i].Klub)] += pole[i].GolPocet;
         }
         int maximum = int.MinValue;
         foreach (var item in klubGolPocet) {
            if (item > maximum) maximum = item;
         }
         int klubPocet = 0;
         foreach (var item in klubGolPocet) {
            if (item == maximum) klubPocet++;
         }
         kluby = new FotbalovyKlub[klubPocet];
         int j = 0;
         for (int i = 0; i < klubGolPocet.Length; i++) {
            if (klubGolPocet[i] == maximum)
               kluby[j++] = FotbalovyKlubInfo.DejKlub(i);
         }
         golPocet = maximum;
      }

      protected virtual void OnPocetZmenen(PocetEventArgs e)
      {
          PocetZmenenEventHandler handler = PocetZmenen;
          if (handler != null) handler(this, e);
      }
    }
}
