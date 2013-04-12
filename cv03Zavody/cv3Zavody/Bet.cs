using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cv3Zavody
{
    class Bet
    {
        Guy sazkar;
        Dog pes;
        int castka;

        public Bet()
        {          

        }
        public void vsadit(Guy man, Dog dog, int money)
        {
            sazkar = man;
            pes = dog;
            castka = money;

            if(sazkar != null)
                sazkar.odecti(castka);

        }

        public Dog getPes()
        {
            return pes;
        }

        public void vyhra()
        {
            sazkar.pricti(2 * castka);
        }

    }
}
