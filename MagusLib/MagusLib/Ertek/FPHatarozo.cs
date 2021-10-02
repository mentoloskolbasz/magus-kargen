using System;
using System.Collections.Generic;
using System.Text;
using MagusLib.KarakterKeszites;

namespace MagusLib.Ertek
{
    public class FPHatarozo : IHatarozo<uint>
    {
        private readonly KorAlapertekModosito korAlapertekModosito = new KorAlapertekModosito();
        public uint Hataroz(IKarakter karakter)
        {
            try
            {
                
                korAlapertekModosito.Karakter = karakter;
               

                uint ertek = (uint)Math.Max((karakter.Allokepesseg + korAlapertekModosito.Ugyesseg - 10), 0);

                ertek += (uint)Math.Max((karakter.Akaratero + korAlapertekModosito.Ugyesseg - 10), 0);

                ertek += Allandok.FP_ALAP[karakter.Alkaszt];

                ertek += (uint)karakter.Szint.FpSzint;

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
