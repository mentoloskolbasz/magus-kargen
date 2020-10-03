using System;
using System.Collections.Generic;
using System.Text;

namespace MagusLib
{
    public class AlapKepessegGeneralo : AbsztraktGeneralo
    {
        public AlapKepessegGeneralo()
        {
            ertekadok = karakter =>
            {
                
                
                Func<int> eroKaszt;
                if (!KarakterKeszites.Allandok.ERO.TryGetValue(karakter.Alkaszt, out eroKaszt))
                {
                    throw new NemDefinialtErtekKivetel();
                }
                int eroFaj;
                if (!KarakterKeszites.Allandok.ERO_FAJ.TryGetValue(karakter.Faj, out eroFaj))
                {
                    throw new NemDefinialtErtekKivetel();
                }
                karakter.Ero =  (uint)(eroKaszt() + eroFaj);
            };

            ertekadok += karakter => karakter.Gyorsasag = 5;
            ertekadok += karakter => karakter.Szepseg = 18;
        }

    }
}
