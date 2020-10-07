using System;
using System.Collections.Generic;
using System.Text;

namespace MagusLib.KarakterKeszites
{
    public class KasztValaszto : AbsztraktValaszto<KarakterKaszt>
    {
        private static readonly Dictionary<KarakterAlkaszt, KarakterKaszt> KASZTLISTA = new Dictionary<KarakterAlkaszt, KarakterKaszt>()
        {
            {KarakterAlkaszt.Harcos, KarakterKaszt.Harcos },
            {KarakterAlkaszt.Gladiátor, KarakterKaszt.Harcos },
            {KarakterAlkaszt.Fejvadász, KarakterKaszt.Harcos },
            {KarakterAlkaszt.Lovag, KarakterKaszt.Harcos },
            {KarakterAlkaszt.Amazon, KarakterKaszt.Harcos },
            {KarakterAlkaszt.Barbár, KarakterKaszt.Harcos },
            {KarakterAlkaszt.Bajvívó, KarakterKaszt.Harcos },

            {KarakterAlkaszt.Tolvaj, KarakterKaszt.Szerencsevadász },
            {KarakterAlkaszt.Bárd, KarakterKaszt.Szerencsevadász },

            {KarakterAlkaszt.Pap, KarakterKaszt.Pap },
            {KarakterAlkaszt.Paplovag, KarakterKaszt.Pap },
            {KarakterAlkaszt.Szerzetes, KarakterKaszt.Pap },
            {KarakterAlkaszt.Sámán, KarakterKaszt.Pap },

            {KarakterAlkaszt.Harcművész, KarakterKaszt.Harcművész },
            {KarakterAlkaszt.Kardművész, KarakterKaszt.Harcművész },

            {KarakterAlkaszt.Boszorkány, KarakterKaszt.Varázshasználó },
            {KarakterAlkaszt.Boszorkánymester, KarakterKaszt.Varázshasználó },
            {KarakterAlkaszt.Tűzvarázsló, KarakterKaszt.Varázshasználó },
            {KarakterAlkaszt.Varázsló, KarakterKaszt.Varázshasználó },
        };

        public override KarakterKaszt[] Felsorolas(IKarakter karakter)
        {
            if (!KasztValaszto.KASZTLISTA.ContainsKey(karakter.Alkaszt))
            {
                return null;
            }           
            
            return new KarakterKaszt[1] { KasztValaszto.KASZTLISTA[karakter.Alkaszt]};
        }
    }
}
