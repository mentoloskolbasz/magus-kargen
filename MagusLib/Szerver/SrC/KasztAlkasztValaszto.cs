using System;
using MagusLib;
using System.Collections.Generic;
using System.Text;

namespace Szerver.SrC
{

    public class KasztAlkasztValaszto
    {
        /// <summary>
        /// A lehetséges Kaszt - Alkaszt párosítások felsorolása.
        /// </summary>
        private static readonly Dictionary<KarakterKaszt, KarakterAlkaszt[]> LISTA = new Dictionary<KarakterKaszt, KarakterAlkaszt[]>()
        {
            { KarakterKaszt.Harcos, new KarakterAlkaszt[] { 
                KarakterAlkaszt.Harcos, 
                KarakterAlkaszt.Gladiátor,
                KarakterAlkaszt.Fejvadász,
                KarakterAlkaszt.Lovag,                
            } },

            { KarakterKaszt.Harcművész, new KarakterAlkaszt[]  { 
                KarakterAlkaszt.Harcművész,
                KarakterAlkaszt.Kardművész,
            } },


        };

        public KarakterAlkaszt[] this[KarakterKaszt kaszt]
        {
            get => KasztAlkasztValaszto.LISTA[kaszt];
        }
    }


}
