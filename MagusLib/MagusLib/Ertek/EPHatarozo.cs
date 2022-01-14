using System;
using System.Collections.Generic;
using System.Text;
using MagusLib.KarakterKeszites;

namespace MagusLib.Ertek
{
    public class EPHatarozo : IHatarozo<int>
    {
        private readonly KorAlapertekModosito korAlapertekModosito = new KorAlapertekModosito();
        public int Hataroz(IKarakter karakter)
        {
            try
            {
                
                korAlapertekModosito.Karakter = karakter;
               

                int ertek = Math.Max((karakter.Egeszseg + korAlapertekModosito.Egeszseg - 10), 0);
                
                ertek += Allandok.EP_ALAP[karakter.Alkaszt];

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
