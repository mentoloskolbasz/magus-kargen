using System;
using System.Collections.Generic;
using System.Text;
using MagusLib.KarakterKeszites;

namespace MagusLib.Ertek
{
    public class VedoErtekHatarozo : IHatarozo<int>
    {
        private readonly KorAlapertekModosito korAlapertekModosito = new KorAlapertekModosito();
        public int Hataroz(IKarakter karakter)
        {
            try
            {
                
                korAlapertekModosito.Karakter = karakter;
               

                int ertek = Math.Max((karakter.Ugyesseg + korAlapertekModosito.Ugyesseg - 10), 0);

                ertek += Math.Max((karakter.Gyorsasag + korAlapertekModosito.Gyorsasag - 10), 0);

                ertek += Allandok.VE_ALAP[karakter.Alkaszt];

                ertek += karakter.Szint.VeSzint;

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
