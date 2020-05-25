using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MagusLib;

namespace Szerver
{
    public class TamadoertekSzamolo : ISzamolo
    {
        private static readonly Dictionary<KarakterAlkaszt, uint> TE_ALAP = new Dictionary<KarakterAlkaszt, uint>()
        {
            { KarakterAlkaszt.Harcos, 20 },
            { KarakterAlkaszt.Tolvaj, 17 },
            { KarakterAlkaszt.Pap, 17 },
            { KarakterAlkaszt.Harcművész, 20 },
            { KarakterAlkaszt.Boszorkány, 14 },
            { KarakterAlkaszt.Gladiátor, 20 },
            { KarakterAlkaszt.Fejvadász, 20 },
            { KarakterAlkaszt.Lovag, 20 },
            { KarakterAlkaszt.Bárd, 20 },
            { KarakterAlkaszt.Paplovag, 20 },
            { KarakterAlkaszt.Kardművész, 20 },
            { KarakterAlkaszt.Boszorkánymester, 17 },
            { KarakterAlkaszt.Tűzvarázsló, 17 },
            { KarakterAlkaszt.Varázsló, 15 },
        };
        private static readonly Dictionary<JatszhatoFaj, uint> TE_UGYESSEG = new Dictionary<JatszhatoFaj, uint>()
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
        private static readonly Dictionary<JatszhatoFaj, uint> TE_GYORSASAG = new Dictionary<JatszhatoFaj, uint>()
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
        private static readonly Dictionary<JatszhatoFaj, uint> TE_ERO = new Dictionary<JatszhatoFaj, uint>()
        {
            { JatszhatoFaj.Ember, 10 },
            { JatszhatoFaj.Félelf, 9 },
            { JatszhatoFaj.Elf, 8 },
            { JatszhatoFaj.Törpe, 11 },
            { JatszhatoFaj.Ork, 12 },
            { JatszhatoFaj.Dzsenn, 10 },
            { JatszhatoFaj.Dzsad, 10 },
            { JatszhatoFaj.Wier, 10 },
            { JatszhatoFaj.Khal, 13 },
            { JatszhatoFaj.Amund, 11 },
            { JatszhatoFaj.Gnóm, 9 },
            { JatszhatoFaj.Goblin, 8 }
        };

        public IKarakter Szamol(IKarakter karakter)
        {
            uint tamadoErtek = 0;
            tamadoErtek += TE_ALAP[karakter.Alkaszt];
            tamadoErtek += Math.Min(Math.Max((karakter.Ugyesseg - 10), 0), TE_UGYESSEG[karakter.Faj]);
            tamadoErtek += Math.Min(Math.Max((karakter.Gyorsasag - 10), 0), TE_GYORSASAG[karakter.Faj]);
            tamadoErtek += Math.Min(Math.Max((karakter.Ero - 10), 0), TE_ERO[karakter.Faj]);
            karakter.Tamado = tamadoErtek;
            return karakter;
        }
    }
}