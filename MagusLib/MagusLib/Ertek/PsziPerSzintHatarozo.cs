using MagusLib.KarakterKeszites;
using System;
using System.Collections.Generic;
using System.Text;

namespace MagusLib.Ertek
{
    public class PsziPerSzintHatarozo : IHatarozo<int>
    {
        public int Hataroz(IKarakter karakter)
        {
            
            try
            {
                var item = karakter.PsziSzintek.AktualisIskola;
                if (item == null)
                {
                    return 0;
                }                
                return Allandok.PSZI_SZINTENKENT[item.Iskola][item.Foka](false);                  
            }
            catch (Exception)
            {
                
                throw new NemDefinialtErtekKivetel();
            }
        }
    }
}
