using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MagusLib;

namespace MagusLib.KarakterKeszites
{
    public class VedoSzamolo : ISzamolo
    {
        /// <summary>
        /// Karakter Védő érték kiszámítása.
        /// </summary>
        /// <param name="karakter">Karakterben tárolva.</param>
        /// <returns>Védő értéket adja vissza, ami a karakter ügyességének és gyorsaságának 10 feletti részéből és a Kasztból jövő alapértékből adódik össze.</returns>
        public IKarakter Szamol(IKarakter karakter)
        {
            uint vedoErtek = 0;
            vedoErtek += Allandok.VE_ALAP[karakter.Alkaszt];
            vedoErtek += Math.Min(Math.Max((karakter.Ugyesseg - 10), 0), Allandok.UGYESSEG[karakter.Faj]);
            vedoErtek += Math.Min(Math.Max((karakter.Gyorsasag - 10), 0), Allandok.GYORSASAG[karakter.Faj]);
            karakter.Vedo = vedoErtek;
            return karakter;
        }
    }
}