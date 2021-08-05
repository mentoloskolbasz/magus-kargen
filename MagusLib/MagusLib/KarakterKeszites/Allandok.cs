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
        #region Harcértékek alapok
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
            { KarakterAlkaszt.Barbár, 10 },
            { KarakterAlkaszt.Amazon, 8 },
            { KarakterAlkaszt.Szerzetes, 5 },
            { KarakterAlkaszt.Sámán, 4 },
            { KarakterAlkaszt.Bajvívó, 9 },
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
            { KarakterAlkaszt.Barbár, 26 },
            { KarakterAlkaszt.Amazon, 22 },
            { KarakterAlkaszt.Szerzetes, 15 },
            { KarakterAlkaszt.Sámán, 15 },
            { KarakterAlkaszt.Bajvívó, 20 },
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
            { KarakterAlkaszt.Barbár, 70 },
            { KarakterAlkaszt.Amazon, 73 },
            { KarakterAlkaszt.Szerzetes, 75 },
            { KarakterAlkaszt.Sámán, 70 },
            { KarakterAlkaszt.Bajvívó, 75 },
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
            { KarakterAlkaszt.Barbár, 0 },
            { KarakterAlkaszt.Amazon, 10 },
            { KarakterAlkaszt.Szerzetes, 0 },
            { KarakterAlkaszt.Sámán, 0 },
            { KarakterAlkaszt.Bajvívó, 0 },
        };
        public static readonly Dictionary<JatszhatoFaj, uint> CE_FAJ = new Dictionary<JatszhatoFaj, uint>()
        {
            {JatszhatoFaj.Elf, 20},
            {JatszhatoFaj.Félelf, 10},

        };
        public static readonly HashSet<KarakterAlkaszt> CE_TILTOTT = new HashSet<KarakterAlkaszt>
        {
            KarakterAlkaszt.Bajvívó,
            KarakterAlkaszt.Lovag,
            KarakterAlkaszt.Paplovag,
        };
        /// <summary>
        /// Szintenkénti harcérték módosító értéke
        /// </summary>
        public static readonly Dictionary<KarakterAlkaszt, uint> HM_PER_SZINT = new Dictionary<KarakterAlkaszt, uint>()
        {
            { KarakterAlkaszt.Harcos, 11 },
            { KarakterAlkaszt.Tolvaj, 6 },
            { KarakterAlkaszt.Pap, 8 },
            { KarakterAlkaszt.Harcművész, 8 },
            { KarakterAlkaszt.Boszorkány, 4 },
            { KarakterAlkaszt.Gladiátor, 12 },
            { KarakterAlkaszt.Fejvadász, 11 },
            { KarakterAlkaszt.Lovag, 12 },
            { KarakterAlkaszt.Bárd, 9 },
            { KarakterAlkaszt.Paplovag, 9 },
            { KarakterAlkaszt.Kardművész, 8 },
            { KarakterAlkaszt.Boszorkánymester, 7 },
            { KarakterAlkaszt.Tűzvarázsló, 8 },
            { KarakterAlkaszt.Varázsló, 4 },
            { KarakterAlkaszt.Barbár, 12 },
            { KarakterAlkaszt.Amazon, 10 },
            { KarakterAlkaszt.Szerzetes, 8 },
            { KarakterAlkaszt.Sámán, 5 },
            { KarakterAlkaszt.Bajvívó, 12 },
        };

        public static readonly Dictionary<KarakterAlkaszt, KotelezoEloallito> KOTELEZO_HM_PER_SZINT = new Dictionary<KarakterAlkaszt, KotelezoEloallito>()
        {
            { KarakterAlkaszt.Harcos, (karakter) => new KotelezoHM{tamadoErtek = 3, vedoErtek =3 } },
            { KarakterAlkaszt.Tolvaj, (karakter) => new KotelezoHM{tamadoErtek = 1, vedoErtek = 1, kezdemenyezoErtek = 1, keziLevonando = 2} },
            { KarakterAlkaszt.Pap, (karakter) => new KotelezoHM{tamadoErtek = 3, vedoErtek = 3} },
            { KarakterAlkaszt.Harcművész, (karakter) => new KotelezoHM{tamadoErtek = 3, vedoErtek = 3} },
            { KarakterAlkaszt.Boszorkány, (karakter) => new KotelezoHM{tamadoErtek = 1, vedoErtek = 1} },
            { KarakterAlkaszt.Gladiátor, (karakter) => new KotelezoHM{tamadoErtek = 4, vedoErtek = 4} },
            { KarakterAlkaszt.Fejvadász, (karakter) => new KotelezoHM{tamadoErtek = 4, vedoErtek = 4, keziLevonando = 8, kezdemenyezoErtek = (uint)(karakter.Szint.Szint % 2 == 0 ? 0 : 1)} },
            { KarakterAlkaszt.Lovag, (karakter) => new KotelezoHM{tamadoErtek = 5, vedoErtek = 5}},
            { KarakterAlkaszt.Bárd, (karakter) => new KotelezoHM{tamadoErtek = 2, vedoErtek = 2} },
            { KarakterAlkaszt.Paplovag, (karakter) => new KotelezoHM{tamadoErtek = 3, vedoErtek = 3} },
            { KarakterAlkaszt.Kardművész, (karakter) => new KotelezoHM{tamadoErtek = 3, vedoErtek = 3} },
            { KarakterAlkaszt.Boszorkánymester, (karakter) => new KotelezoHM{tamadoErtek = 1, vedoErtek = 1, kezdemenyezoErtek = 1, keziLevonando = 2} },
            { KarakterAlkaszt.Tűzvarázsló, (karakter) => new KotelezoHM{tamadoErtek = 3, vedoErtek = 3} },
            { KarakterAlkaszt.Varázsló, (karakter) => new KotelezoHM{tamadoErtek = 1, vedoErtek = 1} },
            { KarakterAlkaszt.Barbár, (karakter) => new KotelezoHM{tamadoErtek = 5, kezdemenyezoErtek = 3} },
            { KarakterAlkaszt.Amazon, (karakter) => new KotelezoHM{ } },
            { KarakterAlkaszt.Szerzetes, (karakter) => new KotelezoHM{ tamadoErtek = 2, vedoErtek = 4} },
            { KarakterAlkaszt.Sámán, (karakter) => new KotelezoHM{ tamadoErtek = 1, vedoErtek = 1} },
            { KarakterAlkaszt.Bajvívó, (karakter) => new KotelezoHM{tamadoErtek = 3, vedoErtek = 3} },
        };


        #endregion

        #region Képességek Faji Módosítói
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
        #endregion

        #region Képességek Kaszt Módosítói
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
            { KarakterAlkaszt.Barbár, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Boszorkány, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Boszorkánymester, ()=>(new K6()).Dobas()+12 },
            { KarakterAlkaszt.Bárd, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Fejvadász, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Gladiátor, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Harcművész, ()=>(new K6()).Dobas()+12 },
            { KarakterAlkaszt.Kardművész, ()=>(new K6()).Dobas()+14 },
            { KarakterAlkaszt.Lovag, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Pap, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Paplovag, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Szerzetes, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Sámán, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Tolvaj, ()=>(new K6()).Dobas()+12 },
            { KarakterAlkaszt.Tűzvarázsló, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Varázsló, ()=>(new K6x3()).Dobas() },
        };

        public static readonly Dictionary<KarakterAlkaszt, Func<int>> ALLOKEPESSEG = new Dictionary<KarakterAlkaszt, Func<int>>()
        {
            { KarakterAlkaszt.Harcos, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Amazon, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Bajvívó, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Barbár, ()=>(new K6()).Dobas()+14 },
            { KarakterAlkaszt.Boszorkány, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Boszorkánymester, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Bárd, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Fejvadász, ()=>(new K6()).Dobas()+12 },
            { KarakterAlkaszt.Gladiátor, ()=>(new K6()).Dobas()+12 },
            { KarakterAlkaszt.Harcművész, ()=>(new K6()).Dobas()+12 },
            { KarakterAlkaszt.Kardművész, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Lovag, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Pap, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Paplovag, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Szerzetes, ()=>(new K6()).Dobas()+12 },
            { KarakterAlkaszt.Sámán, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Tolvaj, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Tűzvarázsló, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Varázsló, ()=>(new K6x3()).Dobas() },
        };

        public static readonly Dictionary<KarakterAlkaszt, Func<int>> EGESZSEG = new Dictionary<KarakterAlkaszt, Func<int>>()
        {
            { KarakterAlkaszt.Harcos, ()=>(new K10()).Dobas()+10 },
            { KarakterAlkaszt.Amazon, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Bajvívó, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Barbár, ()=>(new K10()).Dobas()+10 },
            { KarakterAlkaszt.Boszorkány, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Boszorkánymester, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Bárd, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Fejvadász, ()=>(new K10()).Dobas()+10 },
            { KarakterAlkaszt.Gladiátor, ()=>(new K10()).Dobas()+10 },
            { KarakterAlkaszt.Harcművész, ()=>(new K6()).Dobas()+14 },
            { KarakterAlkaszt.Kardművész, ()=>(new K6()).Dobas()+12 },
            { KarakterAlkaszt.Lovag, ()=>(new K10()).Dobas()+10 },
            { KarakterAlkaszt.Pap, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Paplovag, ()=>(new K10()).Dobas()+10 },
            { KarakterAlkaszt.Szerzetes, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Sámán, ()=>(new K10()).Dobas()+6 },
            { KarakterAlkaszt.Tolvaj, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Tűzvarázsló, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Varázsló, ()=>(new K6x3()).Dobas() },
        };

        public static readonly Dictionary<KarakterAlkaszt, Func<int>> SZEPSEG = new Dictionary<KarakterAlkaszt, Func<int>>()
        {
            { KarakterAlkaszt.Harcos, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Amazon, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Bajvívó, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Barbár, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Boszorkány, ()=>(new K6()).Dobas()+14 },
            { KarakterAlkaszt.Boszorkánymester, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Bárd, ()=>(new K6()).Dobas()+12 },
            { KarakterAlkaszt.Fejvadász, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Gladiátor, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Harcművész, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Kardművész, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Lovag, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Pap, ()=>(new K10()).Dobas()+10 },
            { KarakterAlkaszt.Paplovag, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Szerzetes, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Sámán, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Tolvaj, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Tűzvarázsló, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Varázsló, ()=>(new K6x3()).Dobas() },
        };

        public static readonly Dictionary<KarakterAlkaszt, Func<int>> INTELLIGENCIA = new Dictionary<KarakterAlkaszt, Func<int>>()
        {
            { KarakterAlkaszt.Harcos, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Amazon, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Bajvívó, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Barbár, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Boszorkány, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Boszorkánymester, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Bárd, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Fejvadász, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Gladiátor, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Harcművész, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Kardművész, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Lovag, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Pap, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Paplovag, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Szerzetes, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Sámán, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Tolvaj, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Tűzvarázsló, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Varázsló, ()=>(new K6()).Dobas()+12 },
        };

        public static readonly Dictionary<KarakterAlkaszt, Func<int>> AKARATERO = new Dictionary<KarakterAlkaszt, Func<int>>()
        {
            { KarakterAlkaszt.Harcos, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Amazon, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Bajvívó, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Barbár, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Boszorkány, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Boszorkánymester, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Bárd, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Fejvadász, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Gladiátor, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Harcművész, ()=>(new K6()).Dobas()+12 },
            { KarakterAlkaszt.Kardművész, ()=>(new K6()).Dobas()+12 },
            { KarakterAlkaszt.Lovag, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Pap, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Paplovag, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Szerzetes, ()=>(new K6()).Dobas()+12 },
            { KarakterAlkaszt.Sámán, ()=>(new K6()).Dobas()+12 },
            { KarakterAlkaszt.Tolvaj, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Tűzvarázsló, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Varázsló, ()=>(new K6()).Dobas()+12 },
        };

        public static readonly Dictionary<KarakterAlkaszt, Func<int>> ASZTRAL = new Dictionary<KarakterAlkaszt, Func<int>>()
        {
            { KarakterAlkaszt.Harcos, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Amazon, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Bajvívó, ()=>(new K6()).Dobas()+12 },
            { KarakterAlkaszt.Barbár, ()=>(new K6x3()).Dobas()-1 },
            { KarakterAlkaszt.Boszorkány, ()=>(new K6()).Dobas()+12 },
            { KarakterAlkaszt.Boszorkánymester, ()=>(new K6()).Dobas()+12 },
            { KarakterAlkaszt.Bárd, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Fejvadász, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Gladiátor, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Harcművész, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Kardművész, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Lovag, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Pap, ()=>(new K6()).Dobas()+12 },
            { KarakterAlkaszt.Paplovag, ()=>(new K6()).Dobas()+12 },
            { KarakterAlkaszt.Szerzetes, ()=>(new K6()).Dobas()+12 },
            { KarakterAlkaszt.Sámán, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Tolvaj, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Tűzvarázsló, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Varázsló, ()=>(new K6x2()).Dobas()+12},
        };

        public static readonly Dictionary<KarakterAlkaszt, Func<int>> ESZLELES = new Dictionary<KarakterAlkaszt, Func<int>>()
        {
            { KarakterAlkaszt.Harcos, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Amazon, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Bajvívó, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Barbár, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Boszorkány, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Boszorkánymester, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Bárd, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Fejvadász, ()=>(new K6()).Dobas()+12 },
            { KarakterAlkaszt.Gladiátor, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Harcművész, ()=>(new K6()).Dobas()+12 },
            { KarakterAlkaszt.Kardművész, ()=>(new K6()).Dobas()+12 },
            { KarakterAlkaszt.Lovag, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Pap, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Paplovag, ()=>(new K10()).Dobas()+8 },
            { KarakterAlkaszt.Szerzetes, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Sámán, ()=>(new K6x3()).Dobas() },
            { KarakterAlkaszt.Tolvaj, ()=>(new K6()).Dobas()+12 },
            { KarakterAlkaszt.Tűzvarázsló, ()=>(new K6x2()).Dobas()+6 },
            { KarakterAlkaszt.Varázsló, ()=>(new K6x2()).Dobas()+6 },
        };
        #endregion

        # region Képességek Kor módosítói
        public static readonly Dictionary<KarakterKorosztaly, Dictionary<Alapertekek, int>> KOR_ALAPERETEK_MODOSITO = new Dictionary<KarakterKorosztaly, Dictionary<Alapertekek, int>>()
        {
            { KarakterKorosztaly.Serdülő, new Dictionary<Alapertekek, int>{
                {Alapertekek.Erő, -2},
                {Alapertekek.Állóképesség, -1},
                {Alapertekek.Gyorsaság, 0},
                {Alapertekek.Ügyesség, 0},
                {Alapertekek.Egészség, 0},
                {Alapertekek.Szépség, 0},
                }
            },

             { KarakterKorosztaly.Ifjú, new Dictionary<Alapertekek, int>{
                {Alapertekek.Erő, 0},
                {Alapertekek.Állóképesség, 0},
                {Alapertekek.Gyorsaság, 0},
                {Alapertekek.Ügyesség, 0},
                {Alapertekek.Egészség, 0},
                {Alapertekek.Szépség, 0},
                }
            },

             { KarakterKorosztaly.Középkorú, new Dictionary<Alapertekek, int>{
                {Alapertekek.Erő, 0},
                {Alapertekek.Állóképesség, 0},
                {Alapertekek.Gyorsaság, -1},
                {Alapertekek.Ügyesség, -1},
                {Alapertekek.Egészség, 0},
                {Alapertekek.Szépség, -1},
                }
            },

             { KarakterKorosztaly.Meglett, new Dictionary<Alapertekek, int>{
                {Alapertekek.Erő, -1},
                {Alapertekek.Állóképesség, -1},
                {Alapertekek.Gyorsaság, -3},
                {Alapertekek.Ügyesség, -2},
                {Alapertekek.Egészség, -1},
                {Alapertekek.Szépség, -3},
                }
            },

             { KarakterKorosztaly.Idős, new Dictionary<Alapertekek, int>{
                {Alapertekek.Erő, -3},
                {Alapertekek.Állóképesség, -3},
                {Alapertekek.Gyorsaság, -5},
                {Alapertekek.Ügyesség, -4},
                {Alapertekek.Egészség, -2},
                {Alapertekek.Szépség, -3},
                }
            },

             { KarakterKorosztaly.Aggastyán, new Dictionary<Alapertekek, int>{
                {Alapertekek.Erő, -5},
                {Alapertekek.Állóképesség, -5},
                {Alapertekek.Gyorsaság, -7},
                {Alapertekek.Ügyesség, -6},
                {Alapertekek.Egészség, -4},
                {Alapertekek.Szépség, -4},
                }
            },
        };

        #endregion

        #region Életerő és Fájdalomtűrés
        public static readonly Dictionary<KarakterAlkaszt, uint> EP_ALAP = new Dictionary<KarakterAlkaszt, uint>()
        {
            { KarakterAlkaszt.Harcos, 7 },
            { KarakterAlkaszt.Tolvaj, 4 },
            { KarakterAlkaszt.Pap, 6 },
            { KarakterAlkaszt.Harcművész, 4 },
            { KarakterAlkaszt.Boszorkány, 3 },
            { KarakterAlkaszt.Gladiátor, 8 },
            { KarakterAlkaszt.Fejvadász, 6 },
            { KarakterAlkaszt.Lovag, 7 },
            { KarakterAlkaszt.Bárd, 5 },
            { KarakterAlkaszt.Paplovag, 8 },
            { KarakterAlkaszt.Kardművész, 4 },
            { KarakterAlkaszt.Boszorkánymester, 3 },
            { KarakterAlkaszt.Tűzvarázsló, 5 },
            { KarakterAlkaszt.Varázsló, 3 },
            { KarakterAlkaszt.Barbár, 8 },
            { KarakterAlkaszt.Amazon, 7 },
            { KarakterAlkaszt.Szerzetes, 4 },
            { KarakterAlkaszt.Sámán, 4 },
            { KarakterAlkaszt.Bajvívó, 5 },
        };

        public static readonly Dictionary<KarakterAlkaszt, uint> FP_ALAP = new Dictionary<KarakterAlkaszt, uint>()
        {
            { KarakterAlkaszt.Harcos, 6 },
            { KarakterAlkaszt.Tolvaj, 5 },
            { KarakterAlkaszt.Pap, 6 },
            { KarakterAlkaszt.Harcművész, 8 },
            { KarakterAlkaszt.Boszorkány, 1 },
            { KarakterAlkaszt.Gladiátor, 7 },
            { KarakterAlkaszt.Fejvadász, 7 },
            { KarakterAlkaszt.Lovag, 6 },
            { KarakterAlkaszt.Bárd, 6 },
            { KarakterAlkaszt.Paplovag, 7 },
            { KarakterAlkaszt.Kardművész, 8 },
            { KarakterAlkaszt.Boszorkánymester, 4 },
            { KarakterAlkaszt.Tűzvarázsló, 4 },
            { KarakterAlkaszt.Varázsló, 2 },
            { KarakterAlkaszt.Barbár, 7 },
            { KarakterAlkaszt.Amazon, 7 },
            { KarakterAlkaszt.Szerzetes, 8 },
            { KarakterAlkaszt.Sámán, 6 },
            { KarakterAlkaszt.Bajvívó, 5 },
        };

        public static readonly Dictionary<KarakterAlkaszt, Func<int>> FP_PER_SZINT = new Dictionary<KarakterAlkaszt, Func<int>>()
        {
            { KarakterAlkaszt.Harcos, ()=>(new K6()).Dobas() + 4 },
            { KarakterAlkaszt.Tolvaj,  ()=>(new K6()).Dobas() + 3 },
            { KarakterAlkaszt.Pap,  ()=>(new K6()).Dobas() + 2 },
            { KarakterAlkaszt.Harcművész, ()=>(new K6()).Dobas() + 5 },
            { KarakterAlkaszt.Boszorkány, ()=>(new K6()).Dobas() },
            { KarakterAlkaszt.Gladiátor, ()=>(new K6()).Dobas() + 5 },
            { KarakterAlkaszt.Fejvadász, ()=>(new K6()).Dobas() + 5  },
            { KarakterAlkaszt.Lovag,  ()=>(new K6()).Dobas() + 5 },
            { KarakterAlkaszt.Bárd,  ()=>(new K6()).Dobas() + 3 },
            { KarakterAlkaszt.Paplovag,  ()=>(new K6()).Dobas() + 5 },
            { KarakterAlkaszt.Kardművész, ()=>(new K6()).Dobas() + 5 },
            { KarakterAlkaszt.Boszorkánymester, ()=>(new K6()).Dobas() + 1 },
            { KarakterAlkaszt.Tűzvarázsló, ()=>(new K6()).Dobas() + 1 },
            { KarakterAlkaszt.Varázsló, ()=>(new K6()).Dobas() },
            { KarakterAlkaszt.Barbár,  ()=>(new K6()).Dobas() + 5 },
            { KarakterAlkaszt.Amazon,  ()=>(new K6()).Dobas() + 4 },
            { KarakterAlkaszt.Szerzetes, ()=>(new K6()).Dobas() + 5 },
            { KarakterAlkaszt.Sámán,  ()=>(new K6()).Dobas() + 2 },
            { KarakterAlkaszt.Bajvívó,  ()=>(new K6()).Dobas() + 3 },
        };
        #endregion
    }
}