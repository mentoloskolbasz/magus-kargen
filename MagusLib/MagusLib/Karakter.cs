using MagusLib.Kepzettsegek;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Xml.Linq;

namespace MagusLib
{
    // Karakterbe menteni mindent! Rúna definíciókat is...

    public class Karakter : IKarakter
    {

        #region Alap adatok
        public virtual string Nev { get; set; }
        public virtual JatszhatoFaj Faj { get; set; }
        public virtual KarakterNeme Nem { get; set; }
        public virtual int Kor { get; set; }
        public virtual Vallas Vallas { get; set; }
        public virtual KarakterKaszt Kaszt { get; set; }
        public virtual KarakterAlkaszt Alkaszt { get; set; }
        public Szintek Szint { get; } = new Szintek();
        public PsziSzint PsziSzintek { get; } = new PsziSzint();

        #endregion

        #region Képességek
        public virtual int Ero { get; set; }
        public virtual int Ugyesseg { get; set; }
        public virtual int Gyorsasag { get; set; }
        public virtual int Allokepesseg { get; set; }
        public virtual int Egeszseg { get; set; }
        public virtual int Szepseg { get; set; }
        public virtual int Intelligencia { get; set; }
        public virtual int Akaratero { get; set; }
        public virtual int Asztral { get; set; }
        public virtual int Eszleles { get; set; }
        #endregion

        #region Harcértékek
        public virtual int Kezdemenyezo { get; set; }

        public virtual int Tamado { get; set; }

        public virtual int Vedo { get; set; }

        public virtual int Celzo { get; set; }
        public virtual int HMSzint { get; set; }
        #endregion

        #region EleteroEsMagia        
        public virtual int Ep { get; set; }
        public virtual int Fp { get; set; }

        #endregion
        #region Képzettségek

        private LinkedList<IKepzettseg> kepzettsegek = new LinkedList<IKepzettseg>();

        public LinkedList<IKepzettseg> Kepzettsegek { get => kepzettsegek; }

        #endregion

    }
}
