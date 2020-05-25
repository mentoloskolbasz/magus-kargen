using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MagusLib;

namespace Szerver
{
    public class CelzoSzamolo : ISzamolo
    {
        private static readonly Dictionary<KarakterAlkaszt, uint> CE_ALAP = new Dictionary<KarakterAlkaszt, uint>()
        {
            { KarakterAlkaszt.Harcos, 0 },
            { KarakterAlkaszt.Tolvaj, 10 },
            { KarakterAlkaszt.Pap, 0 },
            { KarakterAlkaszt.Harcművész, 0 },
            { KarakterAlkaszt.Boszorkány, 0 },
            { KarakterAlkaszt.Gladiátor, 0 },
            { KarakterAlkaszt.Fejvadász, 0 },
            { KarakterAlkaszt.Lovag, 0 },
            { KarakterAlkaszt.Bárd, 10 },
            { KarakterAlkaszt.Paplovag, 0 },
            { KarakterAlkaszt.Kardművész, 0 },
            { KarakterAlkaszt.Boszorkánymester, 5 },
            { KarakterAlkaszt.Tűzvarázsló, 0 },
            { KarakterAlkaszt.Varázsló, 0 },
        };
        private static readonly Dictionary<JatszhatoFaj, uint> CE_UGYESSEG = new Dictionary<JatszhatoFaj, uint>()
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
        public IKarakter Szamol(IKarakter karakter)
        {
            uint celzoErtek = 0;
            celzoErtek += CE_ALAP[karakter.Alkaszt];
            celzoErtek += Math.Min(Math.Max((karakter.Ugyesseg - 10), 0), CE_UGYESSEG[karakter.Faj]);
            karakter.Celzo = celzoErtek;
            return karakter;
        }
    }
}