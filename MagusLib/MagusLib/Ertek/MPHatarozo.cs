using System;
using System.Collections.Generic;
using System.Text;
using MagusLib.KarakterKeszites;

namespace MagusLib.Ertek
{
    public class MPHatarozo : IHatarozo<int>
    {

        public int Hataroz(IKarakter karakter)
        {
            try
            {
                int ertek = karakter.Szint.ManaSzint;
               
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
