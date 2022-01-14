using System;
using System.Collections.Generic;
using System.Text;
using MagusLib.KarakterKeszites;

namespace MagusLib.Ertek
{
    public class FPHatarozo : IHatarozo<int>
    {
        private readonly KorAlapertekModosito korAlapertekModosito = new KorAlapertekModosito();
        public int Hataroz(IKarakter karakter)
        {
            try
            {
                
                korAlapertekModosito.Karakter = karakter;
               

                int ertek = Math.Max((karakter.Allokepesseg + korAlapertekModosito.Allokepesseg - 10), 0);

                ertek += Math.Max((karakter.Akaratero - 10), 0);

                ertek += Allandok.FP_ALAP[karakter.Alkaszt];

                ertek += karakter.Szint.FpSzint;

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
