using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cv3Zavody
{
    
    class Guy
    {
        int money;

        public Guy()
        {
            money = 100;
        }

        public void pricti(int plus)
        {
            money += plus;
        }

        public void odecti(int minus)
        {
            money -= minus;
        }
        public int getMoney()
        {
            return money;
        }

    }
}
