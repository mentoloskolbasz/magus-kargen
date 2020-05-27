using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MagusLib;

namespace Szerver.SrC
{
    public class CelzoSzamolo : ISzamolo
    {
        
        public IKarakter Szamol(IKarakter karakter)
        {
            uint celzoErtek = 0;
            celzoErtek += Allandok.CE_ALAP[karakter.Alkaszt];
            celzoErtek += Math.Min(Math.Max((karakter.Ugyesseg - 10), 0), Allandok.UGYESSEG[karakter.Faj]);
            karakter.Celzo = celzoErtek;
            return karakter;
        }
    }
}