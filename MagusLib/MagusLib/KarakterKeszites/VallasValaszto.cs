using System;
using MagusLib;
using System.Collections.Generic;
using System.Text;
using MagusLib.KarakterKeszites;
using System.Linq;

namespace MagusLib
{

    public class VallasValaszto : AbsztraktValaszto<Vallas>
    {     
        
        public override Vallas[] Felsorolas(IKarakter karakter)
        {
            switch (karakter.Alkaszt)
            {
                case KarakterAlkaszt.Paplovag:
                    return PaplovagVallas.ISTEN;
                case KarakterAlkaszt.Pap:
                    var tmpFelsorolas = new HashSet<Vallas>(PapVallas.ISTEN);
                    if (PapVallas.FAJITO.ContainsKey(karakter.Faj))
                    {
                        tmpFelsorolas.UnionWith(PapVallas.FAJITO[karakter.Faj]);
                    }
                    tmpFelsorolas.ExceptWith(PapVallas.NEMESITO[karakter.Nem]);
                    Vallas[] felsorolas = new Vallas[tmpFelsorolas.Count];
                    tmpFelsorolas.CopyTo(felsorolas);
                    return felsorolas;
                default:
                    return (Vallas[])Enum.GetValues(typeof(Vallas));
            }            
        }
    }
}
