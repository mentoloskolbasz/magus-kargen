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
        public readonly IHatarozo<uint> celzoHatarozo = new CelzoErtekHatarozo();
        public readonly IHatarozo<uint> kezdemenyezoHatarozo = new KezdemenyezoErtekHatarozo();
        public readonly IHatarozo<uint> tamadoHatarozo = new TamadoErtekHatarozo();
        public readonly IHatarozo<uint> vedoHatarozo = new VedoErtekHatarozo();
        public readonly IHatarozo<uint> epHatarozo = new MPHatarozo();
        public readonly IHatarozo<uint> fpHatarozo = new FPHatarozo();
        public readonly IHatarozo<uint> mpHatarozo = new MPHatarozo();

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
