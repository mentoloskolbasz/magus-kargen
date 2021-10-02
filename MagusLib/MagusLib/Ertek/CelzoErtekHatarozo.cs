using MagusLib.KarakterKeszites;
using System;
using System.Collections.Generic;
using System.Text;

namespace MagusLib.Ertek
{
    public class CelzoErtekHatarozo : IHatarozo<uint>
    {
        private readonly KorAlapertekModosito korAlapertekModosito = new KorAlapertekModosito();
        public uint Hataroz(IKarakter karakter)
        {
            try
            {
                if (Allandok.CE_TILTOTT.Contains(karakter.Alkaszt))
                {
                    return 0;
                }

                korAlapertekModosito.Karakter = karakter;

                uint ertek = (uint)Math.Max((karakter.Ugyesseg + korAlapertekModosito.Ugyesseg - 10), 0);

                if (Allandok.CE_FAJ.ContainsKey(karakter.Faj))
	            {
                    ertek += Allandok.CE_FAJ[karakter.Faj];
	            }
                else
	            {
                     ertek += Allandok.CE_ALAP[karakter.Alkaszt];
	            }
                ertek += (uint)karakter.Szint.CeSzint;

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
