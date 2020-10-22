using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MagusLib;

namespace MagusLib.KarakterKeszites
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
        public static readonly Dictionary<KarakterAlkaszt, int> CE_ALAP = new Dictionary<KarakterAlkaszt, int>()
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
       public static readonly Dictionary<JatszhatoFaj, int> UGYESSEG_FAJ = new Dictionary<JatszhatoFaj, int>()
        {
            { JatszhatoFaj.Ember, 0 },
            { JatszhatoFaj.Félelf, 0 },
            { JatszhatoFaj.Elf, 1 },
            { JatszhatoFaj.Törpe, 0 },
            { JatszhatoFaj.Ork, 0 },
            { JatszhatoFaj.Dzsenn, 0 },
            { JatszhatoFaj.Dzsad, 0 },
            { JatszhatoFaj.Wier, 0 },
            { JatszhatoFaj.Khal, 1 },
            { JatszhatoFaj.Amund, 0 },
            { JatszhatoFaj.Gnóm, 1 },
            { JatszhatoFaj.Goblin, 0 }
        };
        /// <summary>
        /// Karakter fajából adódó gyorsaság módosító. (Gyorsaság fajából adódó maximum értékét adja meg.)
        /// </summary>
        public static readonly Dictionary<JatszhatoFaj, int> GYORSASAG_FAJ = new Dictionary<JatszhatoFaj, int>()
        {
            { JatszhatoFaj.Ember, 0 },
            { JatszhatoFaj.Félelf, 1 },
            { JatszhatoFaj.Elf, 1 },
            { JatszhatoFaj.Törpe, 0 },
            { JatszhatoFaj.Ork, 0 },
            { JatszhatoFaj.Dzsenn, 0 },
            { JatszhatoFaj.Dzsad, 0 },
            { JatszhatoFaj.Wier, 0 },
            { JatszhatoFaj.Khal, 2 },
            { JatszhatoFaj.Amund, 0 },
            { JatszhatoFaj.Gnóm, 0 },
            { JatszhatoFaj.Goblin, 0 }
        };
        /// <summary>
        /// Karakter fajából adódó erő módosító. (Erő fajából adódó maximum értékét adja meg.
        /// </summary>
        public static readonly Dictionary<JatszhatoFaj, int> ERO_FAJ = new Dictionary<JatszhatoFaj, int>()
        {
            { JatszhatoFaj.Ember, 0 },
            { JatszhatoFaj.Félelf, -1 },
            { JatszhatoFaj.Elf, -2 },
            { JatszhatoFaj.Törpe, 1 },
            { JatszhatoFaj.Ork, 2 },
            { JatszhatoFaj.Dzsenn, 0 },
            { JatszhatoFaj.Dzsad, 0 },
            { JatszhatoFaj.Wier, 0 },
            { JatszhatoFaj.Khal, 3 },
            { JatszhatoFaj.Amund, 1 },
            { JatszhatoFaj.Gnóm, -1 },
            { JatszhatoFaj.Goblin, -2 }
        };

        public static readonly Dictionary<JatszhatoFaj, int> ALLOKEPESSEG_FAJ = new Dictionary<JatszhatoFaj, int>()
        {
            { JatszhatoFaj.Ember, 0 },
            { JatszhatoFaj.Félelf, 0 },
            { JatszhatoFaj.Elf, -1 },
            { JatszhatoFaj.Törpe, 1 },
            { JatszhatoFaj.Ork, 1 },
            { JatszhatoFaj.Dzsenn, 0 },
            { JatszhatoFaj.Dzsad, 0 },
            { JatszhatoFaj.Wier, 0 },
            { JatszhatoFaj.Khal, 2 },
            { JatszhatoFaj.Amund, 1 },
            { JatszhatoFaj.Gnóm, 0 },
            { JatszhatoFaj.Goblin, 1 }
        };
        public static readonly Dictionary<JatszhatoFaj, int> EGESZSEG_FAJ = new Dictionary<JatszhatoFaj, int>()
        {
            { JatszhatoFaj.Ember, 0 },
            { JatszhatoFaj.Félelf, 0 },
            { JatszhatoFaj.Elf, 0 },
            { JatszhatoFaj.Törpe, 1 },
            { JatszhatoFaj.Ork, 2 },
            { JatszhatoFaj.Dzsenn, 0 },
            { JatszhatoFaj.Dzsad, 0 },
            { JatszhatoFaj.Wier, 0 },
            { JatszhatoFaj.Khal, 3 },
            { JatszhatoFaj.Amund, 0 },
            { JatszhatoFaj.Gnóm, 0 },
            { JatszhatoFaj.Goblin, 1 }
        };
        public static readonly Dictionary<JatszhatoFaj, int> SZEPSEG_FAJ = new Dictionary<JatszhatoFaj, int>()
        {
            { JatszhatoFaj.Ember, 0 },
            { JatszhatoFaj.Félelf, 0 },
            { JatszhatoFaj.Elf, 1 },
            { JatszhatoFaj.Törpe, -2 },
            { JatszhatoFaj.Ork, -3 },
            { JatszhatoFaj.Dzsenn, 0 },
            { JatszhatoFaj.Dzsad, 0 },
            { JatszhatoFaj.Wier, 1 },
            { JatszhatoFaj.Khal, 0 },
            { JatszhatoFaj.Amund, 2 },
            { JatszhatoFaj.Gnóm, 0 },
            { JatszhatoFaj.Goblin, -2 }
        };
        public static readonly Dictionary<JatszhatoFaj, int> INTELLIGENCIA_FAJ = new Dictionary<JatszhatoFaj, int>()
        {
            { JatszhatoFaj.Ember, 0 },
            { JatszhatoFaj.Félelf, 0 },
            { JatszhatoFaj.Elf, 0 },
            { JatszhatoFaj.Törpe, -1 },
            { JatszhatoFaj.Ork, -1 },
            { JatszhatoFaj.Dzsenn, 2 },
            { JatszhatoFaj.Dzsad, 0 },
            { JatszhatoFaj.Wier, 1 },
            { JatszhatoFaj.Khal, -1 },
            { JatszhatoFaj.Amund, 0 },
            { JatszhatoFaj.Gnóm, 1 },
            { JatszhatoFaj.Goblin, -1 }
        };
        public static readonly Dictionary<JatszhatoFaj, int> AKARATERO_FAJ = new Dictionary<JatszhatoFaj, int>()
        {
           { JatszhatoFaj.Ember, 0 },
            { JatszhatoFaj.Félelf, 0 },
            { JatszhatoFaj.Elf, 0 },
            { JatszhatoFaj.Törpe, 0 },
            { JatszhatoFaj.Ork, 0 },
            { JatszhatoFaj.Dzsenn, 0 },
            { JatszhatoFaj.Dzsad, 0 },
            { JatszhatoFaj.Wier, 0 },
            { JatszhatoFaj.Khal, 0 },
            { JatszhatoFaj.Amund, 0 },
            { JatszhatoFaj.Gnóm, 0 },
            { JatszhatoFaj.Goblin, 0 }
        };
        public static readonly Dictionary<JatszhatoFaj, int> ASZTRAL_FAJ = new Dictionary<JatszhatoFaj, int>()
        {
            { JatszhatoFaj.Ember, 0 },
            { JatszhatoFaj.Félelf, 0 },
            { JatszhatoFaj.Elf, 0 },
            { JatszhatoFaj.Törpe, -1 },
            { JatszhatoFaj.Ork, -3 },
            { JatszhatoFaj.Dzsenn, 0 },
            { JatszhatoFaj.Dzsad, 0 },
            { JatszhatoFaj.Wier, 0 },
            { JatszhatoFaj.Khal, -5 },
            { JatszhatoFaj.Amund, -1 },
            { JatszhatoFaj.Gnóm, 0 },
            { JatszhatoFaj.Goblin, -2 }
        };
        public static readonly Dictionary<JatszhatoFaj, int> ESZLELES_FAJ = new Dictionary<JatszhatoFaj, int>()
        {
            { JatszhatoFaj.Ember, 0 },
            { JatszhatoFaj.Félelf, 0 },
            { JatszhatoFaj.Elf, 0 },
            { JatszhatoFaj.Törpe, 0 },
            { JatszhatoFaj.Ork, 0 },
            { JatszhatoFaj.Dzsenn, 0 },
            { JatszhatoFaj.Dzsad, 0 },
            { JatszhatoFaj.Wier, 0 },
            { JatszhatoFaj.Khal, 0 },
            { JatszhatoFaj.Amund, 0 },
            { JatszhatoFaj.Gnóm, 0 },
            { JatszhatoFaj.Goblin, 0 }
        };

        public static readonly Dictionary<KarakterAlkaszt, Func<int>> ERO = new Dictionary<KarakterAlkaszt, Func<int>>()
        {
            { KarakterAlkaszt.Harcos, ()=>(new K6()).Dobas()+12 },
            { KarakterAlkaszt.Amazon, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Bajvívó, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Barbár, ()=>(new K6()).Dobas()+14 },
            { KarakterAlkaszt.Boszorkány, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Boszorkánymester, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Bárd, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Fejvadász, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Gladiátor, ()=>(new K6()).Dobas()+12 },
            { KarakterAlkaszt.Harcművész, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Kardművész, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Lovag, ()=>(new K6()).Dobas()+12 },
            { KarakterAlkaszt.Pap, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Paplovag, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Szerzetes, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Sámán, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Tolvaj, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Tűzvarázsló, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Varázsló, ()=>(new K6x3()).Dobas() },                        
        };

        public static readonly Dictionary<KarakterAlkaszt, Func<int>> GYORSASAG = new Dictionary<KarakterAlkaszt, Func<int>>()
        {
            { KarakterAlkaszt.Harcos, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Amazon, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Bajvívó, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Barbár, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Boszorkány, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Boszorkánymester, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Bárd, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Fejvadász, ()=>(new K6()).Dobas()+12 },
            { KarakterAlkaszt.Gladiátor, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Harcművész, ()=>(new K6()).Dobas()+14 },
            { KarakterAlkaszt.Kardművész, ()=>(new K6()).Dobas()+12 },
            { KarakterAlkaszt.Lovag, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Pap, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Paplovag, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Szerzetes, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Sámán, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Tolvaj, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Tűzvarázsló, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Varázsló, ()=>(new K6x3()).Dobas() },
        };

        public static readonly Dictionary<KarakterAlkaszt, Func<int>> UGYESSEG = new Dictionary<KarakterAlkaszt, Func<int>>()
        {
            { KarakterAlkaszt.Harcos, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Amazon, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Bajvívó, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Barbár, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Boszorkány, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Boszorkánymester, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Bárd, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Fejvadász, ()=>(new K6()).Dobas()+12 },
            { KarakterAlkaszt.Gladiátor, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Harcművész, ()=>(new K6()).Dobas()+14 },
            { KarakterAlkaszt.Kardművész, ()=>(new K6()).Dobas()+12 },
            { KarakterAlkaszt.Lovag, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Pap, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Paplovag, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Szerzetes, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Sámán, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Tolvaj, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Tűzvarázsló, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Varázsló, ()=>(new K6x3()).Dobas() },
        };

        public static readonly Dictionary<KarakterAlkaszt, Func<int>> ALLOKEPESSEG = new Dictionary<KarakterAlkaszt, Func<int>>()
        {
            { KarakterAlkaszt.Harcos, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Amazon, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Bajvívó, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Barbár, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Boszorkány, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Boszorkánymester, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Bárd, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Fejvadász, ()=>(new K6()).Dobas()+12 },
            { KarakterAlkaszt.Gladiátor, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Harcművész, ()=>(new K6()).Dobas()+14 },
            { KarakterAlkaszt.Kardművész, ()=>(new K6()).Dobas()+12 },
            { KarakterAlkaszt.Lovag, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Pap, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Paplovag, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Szerzetes, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Sámán, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Tolvaj, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Tűzvarázsló, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Varázsló, ()=>(new K6x3()).Dobas() },
        };

        public static readonly Dictionary<KarakterAlkaszt, Func<int>> EGESZSEG = new Dictionary<KarakterAlkaszt, Func<int>>()
        {
            { KarakterAlkaszt.Harcos, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Amazon, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Bajvívó, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Barbár, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Boszorkány, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Boszorkánymester, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Bárd, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Fejvadász, ()=>(new K6()).Dobas()+12 },
            { KarakterAlkaszt.Gladiátor, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Harcművész, ()=>(new K6()).Dobas()+14 },
            { KarakterAlkaszt.Kardművész, ()=>(new K6()).Dobas()+12 },
            { KarakterAlkaszt.Lovag, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Pap, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Paplovag, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Szerzetes, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Sámán, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Tolvaj, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Tűzvarázsló, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Varázsló, ()=>(new K6x3()).Dobas() },
        };

        public static readonly Dictionary<KarakterAlkaszt, Func<int>> SZEPSEG = new Dictionary<KarakterAlkaszt, Func<int>>()
        {
            { KarakterAlkaszt.Harcos, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Amazon, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Bajvívó, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Barbár, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Boszorkány, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Boszorkánymester, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Bárd, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Fejvadász, ()=>(new K6()).Dobas()+12 },
            { KarakterAlkaszt.Gladiátor, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Harcművész, ()=>(new K6()).Dobas()+14 },
            { KarakterAlkaszt.Kardművész, ()=>(new K6()).Dobas()+12 },
            { KarakterAlkaszt.Lovag, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Pap, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Paplovag, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Szerzetes, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Sámán, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Tolvaj, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Tűzvarázsló, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Varázsló, ()=>(new K6x3()).Dobas() },
        };

        public static readonly Dictionary<KarakterAlkaszt, Func<int>> INTELLIGENCIA = new Dictionary<KarakterAlkaszt, Func<int>>()
        {
            { KarakterAlkaszt.Harcos, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Amazon, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Bajvívó, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Barbár, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Boszorkány, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Boszorkánymester, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Bárd, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Fejvadász, ()=>(new K6()).Dobas()+12 },
            { KarakterAlkaszt.Gladiátor, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Harcművész, ()=>(new K6()).Dobas()+14 },
            { KarakterAlkaszt.Kardművész, ()=>(new K6()).Dobas()+12 },
            { KarakterAlkaszt.Lovag, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Pap, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Paplovag, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Szerzetes, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Sámán, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Tolvaj, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Tűzvarázsló, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Varázsló, ()=>(new K6x3()).Dobas() },
        };

        public static readonly Dictionary<KarakterAlkaszt, Func<int>> AKARATERO = new Dictionary<KarakterAlkaszt, Func<int>>()
        {
            { KarakterAlkaszt.Harcos, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Amazon, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Bajvívó, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Barbár, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Boszorkány, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Boszorkánymester, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Bárd, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Fejvadász, ()=>(new K6()).Dobas()+12 },
            { KarakterAlkaszt.Gladiátor, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Harcművész, ()=>(new K6()).Dobas()+14 },
            { KarakterAlkaszt.Kardművész, ()=>(new K6()).Dobas()+12 },
            { KarakterAlkaszt.Lovag, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Pap, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Paplovag, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Szerzetes, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Sámán, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Tolvaj, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Tűzvarázsló, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Varázsló, ()=>(new K6x3()).Dobas() },
        };

        public static readonly Dictionary<KarakterAlkaszt, Func<int>> ASZTRAL = new Dictionary<KarakterAlkaszt, Func<int>>()
        {
            { KarakterAlkaszt.Harcos, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Amazon, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Bajvívó, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Barbár, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Boszorkány, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Boszorkánymester, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Bárd, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Fejvadász, ()=>(new K6()).Dobas()+12 },
            { KarakterAlkaszt.Gladiátor, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Harcművész, ()=>(new K6()).Dobas()+14 },
            { KarakterAlkaszt.Kardművész, ()=>(new K6()).Dobas()+12 },
            { KarakterAlkaszt.Lovag, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Pap, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Paplovag, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Szerzetes, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Sámán, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Tolvaj, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Tűzvarázsló, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Varázsló, ()=>(new K6x3()).Dobas() },
        };

        public static readonly Dictionary<KarakterAlkaszt, Func<int>> ESZLELES = new Dictionary<KarakterAlkaszt, Func<int>>()
        {
            { KarakterAlkaszt.Harcos, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Amazon, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Bajvívó, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Barbár, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Boszorkány, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Boszorkánymester, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Bárd, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Fejvadász, ()=>(new K6()).Dobas()+12 },
            { KarakterAlkaszt.Gladiátor, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Harcművész, ()=>(new K6()).Dobas()+14 },
            { KarakterAlkaszt.Kardművész, ()=>(new K6()).Dobas()+12 },
            { KarakterAlkaszt.Lovag, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Pap, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Paplovag, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Szerzetes, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Sámán, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Tolvaj, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Tűzvarázsló, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Varázsló, ()=>(new K6x3()).Dobas() },
        };
    }
}