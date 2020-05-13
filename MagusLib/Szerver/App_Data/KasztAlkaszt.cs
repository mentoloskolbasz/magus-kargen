using System;
using MagusLib;
using System.Collections.Generic;
using System.Text;

namespace Szerver
{

    public class KasztAlkasztValaszto
    {
        private static readonly Dictionary<KarakterKaszt, KarakterAlkaszt[]> LISTA = new Dictionary<KarakterKaszt, KarakterAlkaszt[]>()
        {
            { KarakterKaszt.Harcos, new KarakterAlkaszt[] { KarakterAlkaszt.Harcos, KarakterAlkaszt.Tolvaj } },

            { KarakterKaszt.Harcművész, new KarakterAlkaszt[]  { KarakterAlkaszt.Harcművész } }
        };

        public KarakterAlkaszt[] this[KarakterKaszt kaszt]
        {
            get => KasztAlkasztValaszto.LISTA[kaszt];
        }
    }


}
