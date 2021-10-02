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
        public virtual uint Kor { get; set; }
        public virtual Vallas Vallas { get; set; }
        public virtual KarakterKaszt Kaszt { get; set; }
        public virtual KarakterAlkaszt Alkaszt { get; set; }
        public Szintek Szint { get; } = new Szintek();

        #endregion

        #region Képességek
        public virtual uint Ero { get; set; }
        public virtual uint Ugyesseg { get; set; }
        public virtual uint Gyorsasag { get; set; }
        public virtual uint Allokepesseg { get; set; }
        public virtual uint Egeszseg { get; set; }
        public virtual uint Szepseg { get; set; }
        public virtual uint Intelligencia { get; set; }
        public virtual uint Akaratero { get; set; }
        public virtual uint Asztral { get; set; }
        public virtual uint Eszleles { get; set; }
        #endregion

        #region Harcértékek
        public virtual uint Kezdemenyezo { get; set; }

        public virtual uint Tamado { get; set; }

        public virtual uint Vedo { get; set; }

        public virtual uint Celzo { get; set; }
        public virtual uint HMSzint { get; set; }
        #endregion

        #region EleteroEsMagia        
        public virtual uint Ep { get; set; }
        public virtual uint Fp { get; set; }
        public virtual uint Pszi { get; set; }
        public virtual uint Mana { get; set; }
        #endregion
    }
}
