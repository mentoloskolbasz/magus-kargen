using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MagusLib;

namespace Szerver
{
    public class VedoSzamolo : ISzamolo
    {
        private static readonly Dictionary<KarakterAlkaszt, uint> VE_ALAP = new Dictionary<KarakterAlkaszt, uint>()
        {
            { KarakterAlkaszt.Harcos, 75 },
            { KarakterAlkaszt.Tolvaj, 72 },
            { KarakterAlkaszt.Pap, 72 },
            { KarakterAlkaszt.Harcművész, 75 },
            { KarakterAlkaszt.Boszorkány, 69 },
            { KarakterAlkaszt.Gladiátor, 75 },
            { KarakterAlkaszt.Fejvadász, 75 },
            { KarakterAlkaszt.Lovag, 75 },
            { KarakterAlkaszt.Bárd, 75 },
            { KarakterAlkaszt.Paplovag, 75 },
            { KarakterAlkaszt.Kardművész, 75 },
            { KarakterAlkaszt.Boszorkánymester, 72 },
            { KarakterAlkaszt.Tűzvarázsló, 72 },
            { KarakterAlkaszt.Varázsló, 70 },
        };
        private static readonly Dictionary<JatszhatoFaj, uint> VE_UGYESSEG = new Dictionary<JatszhatoFaj, uint>()
        {
            { JatszhatoFaj.Ember, 10 },
            { JatszhatoFaj.Félelf, 10 },
            { JatszhatoFaj.Elf, 11 },
            { JatszhatoFaj.Törpe, 10 },
            { JatszhatoFaj.Ork, 10 },
            { JatszhatoFaj.Dzsenn, 10 },
            { JatszhatoFaj.Dzsad, 10 },
            { JatszhatoFaj.Wier, 10 },
            { JatszhatoFaj.Khal, 11 },
            { JatszhatoFaj.Amund, 10 },
            { JatszhatoFaj.Gnóm, 11 },
            { JatszhatoFaj.Goblin, 10 }
        };
        private static readonly Dictionary<JatszhatoFaj, uint> VE_GYORSASAG = new Dictionary<JatszhatoFaj, uint>()
        {
            { JatszhatoFaj.Ember, 10 },
            { JatszhatoFaj.Félelf, 11 },
            { JatszhatoFaj.Elf, 11 },
            { JatszhatoFaj.Törpe, 10 },
            { JatszhatoFaj.Ork, 10 },
            { JatszhatoFaj.Dzsenn, 10 },
            { JatszhatoFaj.Dzsad, 10 },
            { JatszhatoFaj.Wier, 10 },
            { JatszhatoFaj.Khal, 12 },
            { JatszhatoFaj.Amund, 10 },
            { JatszhatoFaj.Gnóm, 10 },
            { JatszhatoFaj.Goblin, 10 }
        };

        public IKarakter Szamol(IKarakter karakter)
        {
            uint vedoErtek = 0;
            vedoErtek += VE_ALAP[karakter.Alkaszt];
            vedoErtek += Math.Min(Math.Max((karakter.Ugyesseg - 10), 0), VE_UGYESSEG[karakter.Faj]);
            vedoErtek += Math.Min(Math.Max((karakter.Gyorsasag - 10), 0), VE_GYORSASAG[karakter.Faj]);
            karakter.Vedo = vedoErtek;
            return karakter;
        }
    }
}