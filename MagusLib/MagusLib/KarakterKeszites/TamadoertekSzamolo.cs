using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MagusLib;

namespace MagusLib.KarakterKeszites
{
    public class TamadoertekSzamolo : ISzamolo
    {
        

        public IKarakter Szamol(IKarakter karakter)
        {
            uint tamadoErtek = 0;
            tamadoErtek += Allandok.TE_ALAP[karakter.Alkaszt];
            tamadoErtek += Math.Min(Math.Max((karakter.Ugyesseg - 10), 0), Allandok.UGYESSEG[karakter.Faj]);
            tamadoErtek += Math.Min(Math.Max((karakter.Gyorsasag - 10), 0), Allandok.GYORSASAG[karakter.Faj]);
            tamadoErtek += Math.Min(Math.Max((karakter.Ero - 10), 0), Allandok.ERO[karakter.Faj]);
            karakter.Tamado = tamadoErtek;
            return karakter;
        }
    }
}