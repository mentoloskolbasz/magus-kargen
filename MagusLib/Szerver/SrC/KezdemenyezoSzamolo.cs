using MagusLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Szerver.SrC
{
    public class KezdemenyezoSzamolo : ISzamolo
    {
        

        public IKarakter Szamol(IKarakter karakter)
        {
            uint kezdemenyezoErtek = 0;
            kezdemenyezoErtek += Allandok.KE_ALAP[karakter.Alkaszt];
            kezdemenyezoErtek += Math.Min(Math.Max(karakter.Ugyesseg - 10, 0), Allandok.UGYESSEG[karakter.Faj]);
            kezdemenyezoErtek += Math.Min(Math.Max(karakter.Gyorsasag - 10, 0), Allandok.GYORSASAG[karakter.Faj]);
            karakter.Kezdemenyezo = kezdemenyezoErtek;
            return karakter;
        }        
    }
}