using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using MagusLib;

namespace MagusKliens
{
    //Forrás: https://docs.microsoft.com/en-us/dotnet/framework/winforms/how-to-implement-the-inotifypropertychanged-interface?fbclid=IwAR2GWzY4nHXoVvwcncVdPSpsFoJsFAwgM0DRVW15Z7YOoWP5K2Voqn-k5QQ
    public class KarakterFigyelo : IKarakter, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Type tipus;

        private IKarakter karakter = new Karakter();

        public KarakterFigyelo()
        {
            tipus = typeof(Karakter);
        }

        public string Nev { get => karakter.Nev; set => setProperty(value); }
        public JatszhatoFaj Faj { get => karakter.Faj; set => setProperty(value); }
        public KarakterNeme Nem { get => karakter.Nem; set => setProperty(value); }
        public KarakterKorosztaly Kor { get => karakter.Kor; set => setProperty(value); }
        public KarakterAlkaszt Alkaszt { get => karakter.Alkaszt; set => setProperty(value); }
        public KarakterKaszt Kaszt { get => karakter.Kaszt; set => setProperty(value); }
        public uint Ero { get => karakter.Ero; set => setProperty(value); }
        public uint Ugyesseg { get => karakter.Ugyesseg; set => setProperty(value); }
        public uint Gyorsasag { get => karakter.Gyorsasag; set => setProperty(value); }
        public uint Alokepesseg { get => karakter.Alokepesseg; set => setProperty(value); }
        public uint Egeszseg { get => karakter.Egeszseg; set => setProperty(value); }
        public uint Szepseg { get => karakter.Szepseg; set => setProperty(value); }
        public uint Intelligencia { get => karakter.Intelligencia; set => setProperty(value); }
        public uint Akaratero { get => karakter.Akaratero; set => setProperty(value); }
        public uint Asztral { get => karakter.Asztral; set => setProperty(value); }
        public uint Eszleles { get => karakter.Eszleles; set => setProperty(value); }
        public uint Kezdemenyezo { get => karakter.Kezdemenyezo; set => setProperty(value); }
        public uint Tamado { get => karakter.Tamado; set => setProperty(value); }
        public uint Vedo { get => karakter.Vedo; set => setProperty(value); }
        public uint Celzo { get => karakter.Celzo; set => setProperty(value); }

        /// <summary>
        /// Egy erre az osztályra specializált property setter. Reflection-t használ, hogy kitalálja az aktuálisan használt property-t
        /// </summary>
        /// <param name="val"></param>
        private void setProperty(object val)
        {
            // A híváslistából kinyeri a setter-t, ami meghívta ezt a függvényt
            var method = (new StackTrace()).GetFrame(1).GetMethod();
            // Meghívja a megfelelő setter-t a karakter-en, hogy eltárolja az értéket
            tipus.GetMethod(method.Name).Invoke(karakter, new object[] { val });
            if (PropertyChanged != null)
            {
                // Trigger-eli a PropertyChanged event-et, hogy a Form frissüljön
                // A Split szükséges, mert az auto-property ilyen konvencióval fordul le
                PropertyChanged(this, new PropertyChangedEventArgs(method.Name.Split('_')[1]));
            }
        }
    }
}
