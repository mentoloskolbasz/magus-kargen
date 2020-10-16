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
                
                
                Func<int> kaszt;
                if (!KarakterKeszites.Allandok.ERO.TryGetValue(karakter.Alkaszt, out kaszt))
                {
                    throw new NemDefinialtErtekKivetel();
                }
                int faj;
                if (!KarakterKeszites.Allandok.ERO_FAJ.TryGetValue(karakter.Faj, out faj))
                {
                    throw new NemDefinialtErtekKivetel();
                }
                karakter.Ero =  (uint)(kaszt() + faj);
            };

            ertekadok += karakter =>
            {
                Func<int> kaszt;
                if (!KarakterKeszites.Allandok.GYORS.TryGetValue(karakter.Alkaszt, out kaszt))
                {
                    throw new NemDefinialtErtekKivetel();
                }
                int faj;
                if (!KarakterKeszites.Allandok.GYORSASAG_FAJ.TryGetValue(karakter.Faj, out faj))
                {
                    throw new NemDefinialtErtekKivetel();
                }
                karakter.Gyorsasag = (uint)(kaszt() + faj);
            };
            ertekadok += karakter => karakter.Szepseg = 18;
        }

    }
}
