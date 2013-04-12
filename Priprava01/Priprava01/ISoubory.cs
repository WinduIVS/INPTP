using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Priprava01
{
    interface ISoubory
    {
        void UlozSoubor(string soubor, Osoba[] osoby);
        Osoba[] NactiSoubor(string soubor);
    }
}
