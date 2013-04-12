using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace st28677
{
    class OsobaPole : IEnumerable<Osoba>
    {

        private Osoba[] poleOsob;

        #region IEnumerable<Osoba> Members

        public IEnumerator<Osoba> GetEnumerator()
        {
            return new List<Osoba>(poleOsob).GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion

        private IDatovaVrstva datovaVrstva;

        private int pocet = 0;

        public int Pocet
        {
            get { return pocet; }
            set { pocet = value; }
        }

        public OsobaPole(IDatovaVrstva _idatovaVrstva)
        {
            this.datovaVrstva = _idatovaVrstva;
            this.poleOsob = new Osoba[0];
        }

        public Osoba this[int i]
        {
            get
            {
                return poleOsob[i];
            }
            set
            {
                poleOsob[i] = value;
            }
        }

        public void Nacti()
        {
            this.poleOsob = datovaVrstva.NactiOsoby();
            this.pocet = poleOsob.Length;
        }

        public void Uloz()
        {
            datovaVrstva.UlozOsoby(poleOsob);
        }

        public void VymazUloz(int _index)
        {
            if (_index < 0) return;

            if ((_index + 1) > pocet) return;
 
            var os = new List<Osoba>(poleOsob);
            os.RemoveAt(_index);

            this.pocet = os.Count;

            this.poleOsob = os.ToArray();

            this.Uloz();
        }

        public void PridejUloz(Osoba _os)
        {
            if (_os == null) return;

            _os.PosledeniModifikace = DateTime.UtcNow;

            var os = new List<Osoba>(poleOsob);
            os.Add(_os);

            this.pocet = os.Count;
            this.poleOsob = os.ToArray();

            try
            {
                this.Uloz();
            }
            catch (Exception ex)
            {
                os.Remove(_os);
                this.pocet = os.Count;
                this.poleOsob = os.ToArray();
                throw ex;
            }
        }
    }
}
