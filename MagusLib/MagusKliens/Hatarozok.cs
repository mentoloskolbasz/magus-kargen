using MagusLib.Ertek;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagusKliens
{
    public sealed class Hatarozok
    {
        public readonly IHatarozo<int> celzoHatarozo = new CelzoErtekHatarozo();
        public readonly IHatarozo<int> kezdemenyezoHatarozo = new KezdemenyezoErtekHatarozo();
        public readonly IHatarozo<int> tamadoHatarozo = new TamadoErtekHatarozo();
        public readonly IHatarozo<int> vedoHatarozo = new VedoErtekHatarozo();
        public readonly IHatarozo<int> epHatarozo = new EPHatarozo();
        public readonly IHatarozo<int> fpHatarozo = new FPHatarozo();
        public readonly IHatarozo<int> mpHatarozo = new MPHatarozo();

        private Hatarozok()
        {

        }

        public static Hatarozok Instance
        {
            get
            {
                return Nested.instance;
            }
        }

        class Nested
        {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            static Nested()
            {
            }

            internal static readonly Hatarozok instance = new Hatarozok();
        }
    }
}
