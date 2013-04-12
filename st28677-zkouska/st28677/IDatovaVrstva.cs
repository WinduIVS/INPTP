using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace st28677
{
    interface IDatovaVrstva
    {
        /// <summary>
        /// Metoda čte ze souboru osoby, ty vloží do pole a pole vrátí
        /// </summary>
        /// <returns>Pole načtených osob ze souboru</returns>
        Osoba[] NactiOsoby();

        /// <summary>
        /// Ukládá pole osob <paramref name="_osoby"/> do souboru
        /// </summary>
        /// <param name="_osoby">Pole osob k uložení</param>
        void UlozOsoby(Osoba[] _osoby);
    }
}
