using System;

namespace MagusLib
{
    public interface IKarakter
    {
        #region Alap Adatok
        string Nev { get; set; }
        JatszhatoFaj Faj { get; set; }
        KarakterNeme Nem { get; set; }
        KarakterKorosztaly Kor { get; set; }
        KarakterAlkaszt Alkaszt { get; set; }
        KarakterKaszt Kaszt { get; set; }
        #endregion

        #region Képességek
        uint Ero { get; set; }
        uint Ugyesseg { get; set; }
        uint Gyorsasag { get; set; }
        uint Alokepesseg { get; set; }
        uint Egeszseg { get; set; }
        uint Szepseg { get; set; }
        uint Intelligencia { get; set; }
        uint Akaratero { get; set; }
        uint Asztral { get; set; }
        uint Eszleles { get; set; }
        #endregion

        #region Harcértékek
        uint Kezdemenyezo { get; set; }
        #endregion
    }
}
