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
                KarakterAlkaszt.Amazon,
                KarakterAlkaszt.Barbár,
                KarakterAlkaszt.Bajvívó
            } },

            {KarakterKaszt.Szerencsevadász, new KarakterAlkaszt[]{
                KarakterAlkaszt.Tolvaj,
                KarakterAlkaszt.Bárd
            }},

            {KarakterKaszt.Pap, new KarakterAlkaszt[]{
                KarakterAlkaszt.Pap,
                KarakterAlkaszt.Paplovag,
                KarakterAlkaszt.Sámán,
                KarakterAlkaszt.Szerzetes
            }},            

            { KarakterKaszt.Harcművész, new KarakterAlkaszt[]  { 
                KarakterAlkaszt.Harcművész,
                KarakterAlkaszt.Kardművész
            } },

            { KarakterKaszt.Varázshasználó, new KarakterAlkaszt[]  {
                KarakterAlkaszt.Boszorkány,
                KarakterAlkaszt.Boszorkánymester,
                KarakterAlkaszt.Tűzvarázsló,
                KarakterAlkaszt.Varázsló
            } },
        };

        public KarakterAlkaszt[] this[KarakterKaszt kaszt]
        {
            get => KasztAlkasztValaszto.LISTA[kaszt];
        }
    }


}
