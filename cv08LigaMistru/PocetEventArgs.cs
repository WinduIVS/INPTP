using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LigaMistru
{
    class PocetEventArgs : EventArgs
    {
        int pocet;

        public int Pocet
        {
            get { return pocet; }
        }

        public PocetEventArgs(int pocet)
        {
            this.pocet = pocet;
        }
    }

    delegate void PocetZmenenEventHandler(object sender, PocetEventArgs e);
}
