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
        uint Tamado { get; set; }

        uint Vedo { get; set; }

        uint Celzo { get; set; }

        uint HMSzint { get; set; }
        uint TamPerKor { get; set; }

        #endregion

        #region EleteroEsMagia
        uint Ep { get; set; }
        uint Fp { get; set; }
        uint Pszi { get; set; }
        uint Mana { get; set; }
        #endregion
    }
}
