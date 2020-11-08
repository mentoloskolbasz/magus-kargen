using MagusLib.KarakterKeszites;
using System;
using System.Collections.Generic;
using System.Text;

namespace MagusLib.Ertek
{
    public class KorAlapertekModosito
    {
        public int Ero { get { return modositoKereso(Alapertekek.Erő); } }
        public int Gyorsasag { get { return modositoKereso(Alapertekek.Gyorsaság); } }
        public int Ugyesseg { get { return modositoKereso(Alapertekek.Ügyesség); } }
        public int Allokepesseg { get { return modositoKereso(Alapertekek.Erő); } }
        public int Egeszseg { get { return modositoKereso(Alapertekek.Egészség); } }
        public int Szepseg { get { return modositoKereso(Alapertekek.Szépség); } }

        private KorHatarozo korhatarozo = new KorHatarozo();
        private IKarakter karakter;
        public IKarakter Karakter { set { karakter = value; } }

        private int modositoKereso(Alapertekek tulajdonsag)
        {
            return Allandok.KOR_ALAPERETEK_MODOSITO[korhatarozo.Hataroz(karakter)][tulajdonsag];
        }
    }
}
