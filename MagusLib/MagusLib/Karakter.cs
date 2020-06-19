using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace MagusLib
{
    // Karakterbe menteni mindent! Rúna definíciókat is...
    
    public class Karakter : IKarakter
    {

        #region Alap adatok
        public string Nev { get; set; }
        public JatszhatoFaj Faj { get; set; }
        public KarakterNeme Nem { get; set; }
        public KarakterKorosztaly Kor { get; set; }
        public KarakterAlkaszt Alkaszt { get; set; }
        public KarakterKaszt Kaszt { get; set; }
        #endregion

        #region Képességek
        public uint Ero { get; set; }
        public uint Ugyesseg { get; set; }
        public uint Gyorsasag { get; set; }
        public uint Alokepesseg { get; set; }
        public uint Egeszseg { get; set; }
        public uint Szepseg { get; set; }
        public uint Intelligencia { get; set; }
        public uint Akaratero { get; set; }
        public uint Asztral { get; set; }
        public uint Eszleles { get; set; }
        #endregion

        #region Harcértékek
        public uint Kezdemenyezo { get; set; }

        public uint Tamado { get; set; }

        public uint Vedo { get; set; }

        public uint Celzo { get; set; }
        #endregion
    }
}
