using System;
using MagusLib;
using System.Collections.Generic;
using System.Text;
using MagusLib.KarakterKeszites;
using System.Linq;

namespace MagusLib
{

    public class AlkasztValaszto : AbsztraktValaszto<KarakterAlkaszt>
    {

        /*private static readonly Dictionary<KarakterKaszt, KarakterAlkaszt[]> LISTA = new Dictionary<KarakterKaszt, KarakterAlkaszt[]>()
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
            get
            {
                if (KasztAlkasztValaszto.LISTA.ContainsKey(kaszt))
                {
                    return KasztAlkasztValaszto.LISTA[kaszt];
                }
                return null;
            }
        }*/

        private static readonly Dictionary<JatszhatoFaj, HashSet<KarakterAlkaszt>> FAJLISTA = new Dictionary<JatszhatoFaj, HashSet<KarakterAlkaszt>>()
        {
            { JatszhatoFaj.Ember, new HashSet<KarakterAlkaszt>((KarakterAlkaszt[])Enum.GetValues(typeof(KarakterAlkaszt)))
            },
            { JatszhatoFaj.Amund, new HashSet<KarakterAlkaszt> {
                KarakterAlkaszt.Harcos,
                KarakterAlkaszt.Gladiátor,
                KarakterAlkaszt.Lovag,
                KarakterAlkaszt.Tolvaj,
                KarakterAlkaszt.Pap,
                KarakterAlkaszt.Boszorkány,
                KarakterAlkaszt.Bajvívó
            } },
            { JatszhatoFaj.Dzsenn, new HashSet<KarakterAlkaszt> {
                KarakterAlkaszt.Harcos,
                KarakterAlkaszt.Gladiátor,
                KarakterAlkaszt.Lovag,
                KarakterAlkaszt.Tolvaj,
                KarakterAlkaszt.Bárd,
                KarakterAlkaszt.Varázsló,
                KarakterAlkaszt.Bajvívó
            } },
            { JatszhatoFaj.Elf, new HashSet<KarakterAlkaszt> {
                KarakterAlkaszt.Harcos,
                KarakterAlkaszt.Gladiátor,
                KarakterAlkaszt.Fejvadász,
                KarakterAlkaszt.Bárd,
                KarakterAlkaszt.Varázsló,
            } },
            { JatszhatoFaj.Félelf, new HashSet<KarakterAlkaszt> {
                KarakterAlkaszt.Harcos,
                KarakterAlkaszt.Gladiátor,
                KarakterAlkaszt.Fejvadász,
                KarakterAlkaszt.Bárd,
                KarakterAlkaszt.Varázsló,
                KarakterAlkaszt.Lovag,
                KarakterAlkaszt.Bajvívó,
                KarakterAlkaszt.Tolvaj,
                KarakterAlkaszt.Harcművész,
                KarakterAlkaszt.Kardművész,
                KarakterAlkaszt.Boszorkány,
                KarakterAlkaszt.Boszorkánymester
            } },
            { JatszhatoFaj.Khal, new HashSet<KarakterAlkaszt> {
                KarakterAlkaszt.Harcos,
                KarakterAlkaszt.Gladiátor,
                KarakterAlkaszt.Fejvadász,
                KarakterAlkaszt.Lovag,
            } },
            { JatszhatoFaj.Törpe, new HashSet<KarakterAlkaszt> {
                KarakterAlkaszt.Harcos,
                KarakterAlkaszt.Gladiátor,
                KarakterAlkaszt.Pap,
                KarakterAlkaszt.Varázsló,
                KarakterAlkaszt.Tolvaj,
            } },
            { JatszhatoFaj.Ork, new HashSet<KarakterAlkaszt> {
                KarakterAlkaszt.Harcos,
                KarakterAlkaszt.Gladiátor,
                KarakterAlkaszt.Boszorkánymester,
                KarakterAlkaszt.Varázsló,
                KarakterAlkaszt.Tolvaj,
                KarakterAlkaszt.Fejvadász,
                KarakterAlkaszt.Bajvívó
            } },
            { JatszhatoFaj.Wier, new HashSet<KarakterAlkaszt> {
                KarakterAlkaszt.Harcos,
                KarakterAlkaszt.Lovag,
                KarakterAlkaszt.Sámán,
                KarakterAlkaszt.Tolvaj,
                KarakterAlkaszt.Fejvadász,
                KarakterAlkaszt.Bajvívó,
                KarakterAlkaszt.Pap,
                KarakterAlkaszt.Paplovag,
                KarakterAlkaszt.Szerzetes,
                KarakterAlkaszt.Boszorkány,
                KarakterAlkaszt.Boszorkánymester,
                KarakterAlkaszt.Varázsló
            } },
            { JatszhatoFaj.Gnóm, new HashSet<KarakterAlkaszt> {
                KarakterAlkaszt.Harcos,
                KarakterAlkaszt.Varázsló,
                KarakterAlkaszt.Tolvaj,
            } },
            { JatszhatoFaj.Goblin, new HashSet<KarakterAlkaszt> {
                KarakterAlkaszt.Harcos,
                KarakterAlkaszt.Sámán,
                KarakterAlkaszt.Tolvaj,
            } },
        };
        private static readonly Dictionary<KarakterNeme, HashSet<KarakterAlkaszt>> NEMESITO = new Dictionary<KarakterNeme, HashSet<KarakterAlkaszt>>()
        {
            { KarakterNeme.Nő, new HashSet<KarakterAlkaszt> {
                KarakterAlkaszt.Boszorkánymester,
            } },
            { KarakterNeme.Férfi, new HashSet<KarakterAlkaszt> {
                KarakterAlkaszt.Boszorkány,
                KarakterAlkaszt.Amazon,
            } },
        };

        public override KarakterAlkaszt[] Felsorolas(IKarakter karakter)
        {
            if (!AlkasztValaszto.FAJLISTA.ContainsKey(karakter.Faj))
            {
                return null;
            }
            if (!AlkasztValaszto.NEMESITO.ContainsKey(karakter.Nem))
            {
                return null;
            }
            var tmpFelsorolas = new HashSet<KarakterAlkaszt>(AlkasztValaszto.FAJLISTA[karakter.Faj]);
            tmpFelsorolas.ExceptWith(AlkasztValaszto.NEMESITO[karakter.Nem]);
            KarakterAlkaszt[] felsorolas = new KarakterAlkaszt[tmpFelsorolas.Count];
            tmpFelsorolas.CopyTo(felsorolas);
            return felsorolas;
        }
    }
}
