using System;
using System.Collections.Generic;
using System.Text;
using MagusLib.KarakterKeszites;

namespace MagusLib.Ertek
{
    public class MPHatarozo : IHatarozo<uint>
    {

        public uint Hataroz(IKarakter karakter)
        {
            try
            {
                uint ertek = (uint)karakter.Szint.ManaSzint;
               
                return ertek;
            }
            catch (NemMegfeleloKorKivetel)
            {
                //Ezt a hibát elnyeljük, mert máshol lekezeljük!
                return 0;
            }
            //throw new NotImplementedException();
        }
    }
}
