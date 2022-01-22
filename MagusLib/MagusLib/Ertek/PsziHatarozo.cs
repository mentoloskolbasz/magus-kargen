using MagusLib.KarakterKeszites;
using System;
using System.Collections.Generic;
using System.Text;

namespace MagusLib.Ertek
{
    public class PsziHatarozo : IHatarozo<int>
    {
        public int Hataroz(IKarakter karakter)
        {
            try
            {
                int pszi = 0;
                bool elsoElem = true;
                foreach (var item in karakter.PsziSzintek)
                {
                    pszi += Allandok.PSZI_SZINTENKENT[item.Iskola][item.Foka](elsoElem);
                    elsoElem = false;

                }
                return pszi;
            }
            catch (Exception)
            {
                
                throw new NemDefinialtErtekKivetel();
            }
        }
    }
}
