using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MagusLib;

namespace Szerver.SrC
{
    /// <summary>
    /// Játszható fajok felsorolása és alapértékeik meghatározása.
    /// </summary>
    public static class Allandok
    {
        /// <summary>
        /// Karakter kezdeményező értékének alkasztból származó alapértéke.
        /// </summary>
        public static readonly Dictionary<KarakterAlkaszt, uint> KE_ALAP = new Dictionary<KarakterAlkaszt, uint>()
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

        /// <summary>
        /// Karakter támadó értékének alkasztból származó alapértéke.
        /// </summary>
        public static readonly Dictionary<KarakterAlkaszt, uint> TE_ALAP = new Dictionary<KarakterAlkaszt, uint>()
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
        /// <summary>
        /// Karakter védő értékének alkasztból származó alapértéke.
        /// </summary>
        public static readonly Dictionary<KarakterAlkaszt, uint> VE_ALAP = new Dictionary<KarakterAlkaszt, uint>()
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
        /// <summary>
        /// Karakter célzó értékének alkasztból származó alapértéke.
        /// </summary>
        public static readonly Dictionary<KarakterAlkaszt, uint> CE_ALAP = new Dictionary<KarakterAlkaszt, uint>()
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
        /// <summary>
        /// Karakter fajából adódó ügyesség módosító. (Ügyesség fajából adódó maximum értékét adja meg.)
        /// </summary>
        public static readonly Dictionary<JatszhatoFaj, uint> UGYESSEG = new Dictionary<JatszhatoFaj, uint>()
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
        /// <summary>
        /// Karakter fajából adódó gyorsaság módosító. (Gyorsaság fajából adódó maximum értékét adja meg.)
        /// </summary>
        public static readonly Dictionary<JatszhatoFaj, uint> GYORSASAG = new Dictionary<JatszhatoFaj, uint>()
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
        /// <summary>
        /// Karakter fajából adódó erő módosító. (Erő fajából adódó maximum értékét adja meg.
        /// </summary>
        public static readonly Dictionary<JatszhatoFaj, uint> ERO = new Dictionary<JatszhatoFaj, uint>()
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
    }
}