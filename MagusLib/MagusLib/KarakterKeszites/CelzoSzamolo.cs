using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MagusLib;

namespace MagusLib.KarakterKeszites
{
    public class CelzoSzamolo : ISzamolo
    {
        /// <summary>
        /// Karakter célzó érték kiszámítása.
        /// </summary>
        /// <param name="karakter">Karakterben tárolva.</param>
        /// <returns>Célzó értéket adja vissza, ami a karakter ügyességének 10 feletti részéből és a Kasztból jövő alapértékből adódik össze.</returns>
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