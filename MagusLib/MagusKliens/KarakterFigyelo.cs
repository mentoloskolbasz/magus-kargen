using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using MagusLib;

namespace MagusKliens
{
    //Forrás: https://docs.microsoft.com/en-us/dotnet/framework/winforms/how-to-implement-the-inotifypropertychanged-interface?fbclid=IwAR2GWzY4nHXoVvwcncVdPSpsFoJsFAwgM0DRVW15Z7YOoWP5K2Voqn-k5QQ
    public class KarakterFigyelo : Karakter, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        // private Type tipus;

        public KarakterFigyelo()
        {
            // tipus = this.GetType().BaseType;
        }

        #region Alap Adatok
        public override string Nev
        {
            get => base.Nev;
            set
            {
                base.Nev = value;
                this.setProperty("Nev");
            }
        }
        public override JatszhatoFaj Faj
        {
            get => base.Faj;
            set
            {
                base.Faj = value;
                this.setProperty("Faj");
            }
        }
        public override KarakterNeme Nem
        {
            get => base.Nem;
            set
            {
                base.Nem = value;
                this.setProperty("Nem");
            }
        }
        public override uint Kor
        {
            get => base.Kor;
            set
            {
                base.Kor = value;
                this.setProperty("Kor");
            }
        }
        public override Vallas Vallas
        {
            get => base.Vallas;
            set
            {
                base.Vallas = value;
                this.setProperty("Vallas");
            }
        }
        public override KarakterKaszt Kaszt
        {
            get => base.Kaszt;
            set
            {
                base.Kaszt = value;
                this.setProperty("Kaszt");
            }
        }
        public override KarakterAlkaszt Alkaszt
        {
            get => base.Alkaszt;
            set
            {
                base.Alkaszt = value;
                this.setProperty("Alkaszt");
            }
        }
        #endregion

        #region Képességek
        public override uint Ero
        {
            get => base.Ero;
            set
            {
                base.Ero = value;
                this.setProperty("Ero");
            }
        }
        public override uint Ugyesseg
        {
            get => base.Ugyesseg;
            set
            {
                base.Ugyesseg = value;
                this.setProperty("Ugyesseg");
            }
        }
        public override uint Gyorsasag
        {
            get => base.Gyorsasag;
            set
            {
                base.Gyorsasag = value;
                this.setProperty("Gyorsasag");
            }
        }
        public override uint Allokepesseg
        {
            get => base.Allokepesseg;
            set
            {
                base.Allokepesseg = value;
                this.setProperty("Allokepesseg");
            }
        }
        public override uint Egeszseg
        {
            get => base.Egeszseg;
            set
            {
                base.Egeszseg = value;
                this.setProperty("Egeszseg");
            }
        }
        public override uint Szepseg
        {
            get => base.Szepseg;
            set
            {
                base.Szepseg = value;
                this.setProperty("Szepseg");
            }
        }
        public override uint Intelligencia
        {
            get => base.Intelligencia;
            set
            {
                base.Intelligencia = value;
                this.setProperty("Intelligencia");
            }
        }
        public override uint Akaratero
        {
            get => base.Akaratero;
            set
            {
                base.Akaratero = value;
                this.setProperty("Akaratero");
            }
        }
        public override uint Asztral
        {
            get => base.Asztral;
            set
            {
                base.Asztral = value;
                this.setProperty("Asztral");
            }
        }
        public override uint Eszleles
        {
            get => base.Eszleles;
            set
            {
                base.Eszleles = value;
                this.setProperty("Eszleles");
            }
        }
        #endregion

        #region Harcértékek
        public override uint Kezdemenyezo
        {
            get => base.Kezdemenyezo;
            set
            {
                base.Kezdemenyezo = value;
                this.setProperty("Kezdemenyezo");
            }
        }
        public override uint Tamado
        {
            get => base.Tamado;
            set
            {
                base.Tamado = value;
                this.setProperty("Tamado");
            }
        }
        public override uint Vedo
        {
            get => base.Vedo;
            set
            {
                base.Vedo = value;
                this.setProperty("Vedo");
            }
        }
        public override uint Celzo
        {
            get => base.Celzo;
            set
            {
                base.Celzo = value;
                this.setProperty("Celzo");
            }
        }
        public override uint HMSzint
        {
            get => base.HMSzint;
            set
            {
                base.HMSzint = value;
                this.setProperty("HMSzint");
            }
        }
        
        #endregion

        #region Életerő és Mágia
        public override uint Ep
        {
            get => base.Ep;
            set
            {
                base.Ep = value;
                this.setProperty("Ep");
            }
        }
        public override uint Fp
        {
            get => base.Fp;
            set
            {
                base.Fp = value;
                this.setProperty("Fp");
            }
        }
        public override uint FpPerSzint
        {
            get => base.FpPerSzint;
            set
            {
                base.FpPerSzint = value;
                this.setProperty("Fp");
            }
        }
        public override uint Pszi
        {
            get => base.Pszi;
            set
            {
                base.Pszi = value;
                this.setProperty("Pszi");
            }
        }
        public override uint Mana
        {
            get => base.Mana;
            set
            {
                base.Mana = value;
                this.setProperty("Mana");
            }
        }
        #endregion

        private void setProperty(string name)
        {
            // tipus.GetProperty(name).SetValue((Karakter)this, val);
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

    }
}
