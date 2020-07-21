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

        public override string Nev { get => base.Nev; set {
                base.Nev = value;
                this.setProperty("Nev");
            } }

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
