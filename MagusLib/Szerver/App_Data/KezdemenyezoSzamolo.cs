using MagusLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Szerver
{
    public class KezdemenyezoSzamolo : ISzamolo
    {
        private static readonly Dictionary<KarakterAlkaszt, uint> KE_ALAP = new Dictionary<KarakterAlkaszt, uint>()
        { private static readonly Dictionary<KarakterAlkaszt, uint> KE_ALAP = new Dictionary<KarakterAlkaszt, uint>()
        {
            { KarakterAlkaszt.Harcos, 9 },
            { KarakterAlkaszt.Tolvaj, 8 },
            { KarakterAlkaszt.Pap, 5 },
            { KarakterAlkaszt.Harcművész, 10 },
            { KarakterAlkaszt.Boszorkány, 6 },
            { KarakterAlkaszt.Gladiátor, 9 },
            { KarakterAlkaszt.Fejvadász, 10 },
            { KarakterAlkaszt.Lovag, 5 },
            { KarakterAlkaszt.Bárd, 10 },
            { KarakterAlkaszt.Paplovag, 5 },
            { KarakterAlkaszt.Kardművész, 10 },
            { KarakterAlkaszt.Boszorkánymester, 7 },
            { KarakterAlkaszt.Tűzvarázsló, 6 },
            { KarakterAlkaszt.Varázsló, 2 },
        };
        private static readonly Dictionary<JatszhatoFaj, uint> KE_UGYESSEG = new Dictionary<JatszhatoFaj, uint>()
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
        private static readonly Dictionary<JatszhatoFaj, uint> KE_GYORSASAG = new Dictionary<JatszhatoFaj, uint>()
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
            uint kezdemenyezoErtek = 0;
            kezdemenyezoErtek += KE_ALAP[karakter.Alkaszt];
            kezdemenyezoErtek += Math.Min(Math.Max((karakter.Ugyesseg - 10), 0), KE_UGYESSEG[karakter.Faj]);
            kezdemenyezoErtek += Math.Min(Math.Max((karakter.Gyorsasag - 10), 0), KE_GYORSASAG[karakter.Faj]);
            karakter.Kezdemenyezo = kezdemenyezoErtek;
            return karakter;
        }
        }
            { KarakterAlkaszt.Harcos, 9 },
            { KarakterAlkaszt.Tolvaj, 8 },
            { KarakterAlkaszt.Pap, 5 },
            { KarakterAlkaszt.Harcművész, 10 },            
            { KarakterAlkaszt.Boszorkány, 6 },
            { KarakterAlkaszt.Gladiátor, 9 },
            { KarakterAlkaszt.Fejvadász, 10 },
            { KarakterAlkaszt.Lovag, 5 },
            { KarakterAlkaszt.Bárd, 10 },
            { KarakterAlkaszt.Paplovag, 5 },
            { KarakterAlkaszt.Kardművész, 10 },
            { KarakterAlkaszt.Boszorkánymester, 7 },
            { KarakterAlkaszt.Tűzvarázsló, 6 },
            { KarakterAlkaszt.Varázsló, 2 },
        };
        private static readonly Dictionary<JatszhatoFaj, uint> KE_UGYESSEG = new Dictionary<JatszhatoFaj, uint>()
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
        private static readonly Dictionary<JatszhatoFaj, uint> KE_GYORSASAG = new Dictionary<JatszhatoFaj, uint>()
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
            uint kezdemenyezoErtek = 0;
            kezdemenyezoErtek += KE_ALAP[karakter.Alkaszt];
            kezdemenyezoErtek += Math.Min(Math.Max((karakter.Ugyesseg - 10), 0),KE_UGYESSEG[karakter.Faj]);
            kezdemenyezoErtek += Math.Min(Math.Max((karakter.Gyorsasag - 10), 0), KE_GYORSASAG[karakter.Faj]);
            karakter.Kezdemenyezo = kezdemenyezoErtek;
            return karakter;
        }
    }
}