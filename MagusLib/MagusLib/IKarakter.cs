using System;
using System.Collections.Generic;
using MagusLib.Kepzettsegek;

namespace MagusLib
{

    public interface IKarakter
    {
        #region Alap Adatok
        string Nev { get; set; }
        JatszhatoFaj Faj { get; set; }
        KarakterNeme Nem { get; set; }
        int Kor { get; set; }
        Vallas Vallas { get; set; }
        KarakterAlkaszt Alkaszt { get; set; }
        KarakterKaszt Kaszt { get; set; }
        Szintek Szint { get;  }
        PsziSzint PsziSzintek { get; }
        #endregion

        #region Képességek
        int Ero { get; set; }
        int Ugyesseg { get; set; }
        int Gyorsasag { get; set; }
        int Allokepesseg { get; set; }
        int Egeszseg { get; set; }
        int Szepseg { get; set; }
        int Intelligencia { get; set; }
        int Akaratero { get; set; }
        int Asztral { get; set; }
        int Eszleles { get; set; }
        #endregion

        #region Harcértékek
        int Kezdemenyezo { get; set; }
        int Tamado { get; set; }

        int Vedo { get; set; }

        int Celzo { get; set; }

        int HMSzint { get; set; }        

        #endregion

        #region EleteroEsMagia
        int Ep { get; set; }
        int Fp { get; set; }
        #endregion

        #region Képzettségek
        LinkedList<IKepzettseg> Kepzettsegek { get; }

        #endregion
    }
}
