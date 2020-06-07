using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagusLib.HarciEszkozok
{
    abstract class HarciEszkoz : IHarciEszkoz
    {
        public abstract Fegyvernem Fegyverneme { get; }
        public abstract string Nev { get; }
        public virtual double Suly
        {
            get
            {
                return sulyModositok.Aggregate(sulyAlap, (double eredmeny, IModosito<double> modosito) => modosito.Szamol(eredmeny));
            }
        }
        public virtual int Kezdemenyezo 
        {
            get
            {
                int eredmeny = kezdemenyezoAlap;
                for (int i = 0; i < kezdemenyezoModositok.Count; i++)
                {
                    IModosito<int> modosito = kezdemenyezoModositok[i];
                    eredmeny = modosito.Szamol(eredmeny);
                }
                return eredmeny;
            }
        }
        public abstract uint Sebzes { get; set; }
        public abstract int TamPerKor { get; }

        protected double sulyAlap;
        protected int kezdemenyezoAlap;
        protected uint sebzesAlap;
        protected int tamPerKorAlap;

        protected List<IModosito<double>> sulyModositok = new List<IModosito<double>>();
        protected List<IModosito<int>> kezdemenyezoModositok = new List<IModosito<int>>();
        protected List<IModosito<uint>> sebzesModositok = new List<IModosito<uint>>();
        protected List<IModosito<int>> tamPerKorModositok = new List<IModosito<int>>();

    }
}
