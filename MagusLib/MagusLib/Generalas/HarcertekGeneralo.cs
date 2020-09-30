using System;
using System.Collections.Generic;
using System.Text;

namespace MagusLib
{
    public class HarcertekGeneralo : AbsztraktGeneralo
    {
        public HarcertekGeneralo()
        {
            ertekadok = karakter =>
            {
                
                
                uint eroFaj;
                if (!KarakterKeszites.Allandok.ERO.TryGetValue(karakter.Faj, out eroFaj))
                {
                    throw new NemDefinialtErtekKivetel();
                } 
                uint eroAlap = (uint)r.Next(3, 11);
                karakter.Ero = eroAlap + (uint)r.Next(0, (int)eroFaj + 1);
            };

            ertekadok += karakter => karakter.Gyorsasag = 5;
            ertekadok += karakter => karakter.Szepseg = 18;
        }

    }
}
