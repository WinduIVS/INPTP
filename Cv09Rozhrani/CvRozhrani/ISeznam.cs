// -----------------------------------------------------------------------
// <copyright file="ISeznam.cs" company="UPa">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace CvRozhrani
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Collections;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public interface ISeznam : ICollection
    {
        void Pridej(object prvek);
        void Vymaz(object prvek);
        void VymazVse();
    }
}
