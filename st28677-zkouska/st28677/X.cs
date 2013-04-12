using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace st28677
{
    class X : IEnumerable<Osoba>
    {
        #region IEnumerable<Osoba> Members

        public IEnumerator<Osoba> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
