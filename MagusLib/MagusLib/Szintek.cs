using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagusLib
{
   
    public class Szintek
    {
        public delegate void SzintValtozas();
        private event SzintValtozas valtozas;
        public void ValtozasFigyelo(SzintValtozas fn)
        {
            valtozas += fn;
        }
        public class Argumentumok
        {
            public int keSzint = 0;
            public int teSzint = 0;
            public int veSzint = 0;
            public int ceSzint = 0;
            public int fpSzint = 0;
            //public int manaSzint = 0;
        }

        private readonly List<int> keSzint = new List<int>();
        private readonly List<int> teSzint = new List<int>();
        private readonly List<int> veSzint = new List<int>();
        private readonly List<int> ceSzint = new List<int>();
        private readonly List<int> fpSzint = new List<int>();
        //private readonly List<int> manaSzint = new List<int>();

        public int Szint
        {
            get
            {
                return keSzint.Count;
            }
        }
        public int KeSzint
        {
            get
            {
                return keSzint.Sum();
            }
        }
        public int TeSzint
        {
            get
            {
                return teSzint.Sum();
            }
        }
        public int VeSzint
        {
            get
            {
                return veSzint.Sum();
            }
        }
        public int CeSzint
        {
            get
            {
                return ceSzint.Sum();
            }
        }
        public int FpSzint
        {
            get
            {
                return fpSzint.Sum();
            }
        }
        /*public int ManaSzint
        {
            get
            {
                return manaSzint.Sum();
            }
        }*/

        public void Lepes(Argumentumok arg)
        {
            keSzint.Add(arg.keSzint);
            teSzint.Add(arg.teSzint);
            veSzint.Add(arg.veSzint);
            ceSzint.Add(arg.ceSzint);
            fpSzint.Add(arg.fpSzint);
            //manaSzint.Add(arg.manaSzint);
            valtozas.Invoke();
        }
        public void VisszaLepes(int szintek)
        {
            var kezdoIndex = Szint - szintek;
            keSzint.RemoveRange(kezdoIndex, szintek);
            teSzint.RemoveRange(kezdoIndex, szintek);
            veSzint.RemoveRange(kezdoIndex, szintek);
            ceSzint.RemoveRange(kezdoIndex, szintek);
            fpSzint.RemoveRange(kezdoIndex, szintek);
            //manaSzint.RemoveRange(kezdoIndex, szintek);
            valtozas.Invoke();
        }

    }
}
