using System;
using System.Collections.Generic;
using System.Text;

namespace MagusLib
{
    public class AbsztraktSzint
    {
        public delegate void SzintValtozas();
        private event SzintValtozas valtozas;
        protected void valtozasEsemeny()
        {
            valtozas.Invoke();
        }
        public void ValtozasFigyelo(SzintValtozas fn)
        {
            valtozas += fn;
        }
    }
}
