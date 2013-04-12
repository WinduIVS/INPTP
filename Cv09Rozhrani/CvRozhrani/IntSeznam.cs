// -----------------------------------------------------------------------
// <copyright file="IntSeznam.cs" company="UPa">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace CvRozhrani
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class IntSeznam : Seznam
    {
        public void PridejNaZacatek(int prvek)
        {
            base.PridejNaZacatek(prvek);
        }

        public void PridejNaKonec(int prvek)
        {
            base.PridejNaKonec(prvek);
        }

        public void Vymaz(int prvek)
        {
            base.Vymaz(prvek);
        }

        public new void PridejNaZacatek(object prvek)
        {
            throw new InvalidOperationException();
        }

        public new void PridejNaKonec(object prvek)
        {
            throw new InvalidOperationException();
        }

        public new void Vymaz(object prvek)
        {
            throw new InvalidOperationException();
        }
    }
}
