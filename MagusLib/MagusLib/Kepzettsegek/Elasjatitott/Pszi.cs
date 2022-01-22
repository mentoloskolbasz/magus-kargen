using System;
using System.Collections.Generic;
using System.Text;

namespace MagusLib.Kepzettsegek.Elasjatitott
{
    public class Pszi : IPszi
    {
        private Iskola iskola;
        private KepzettsegFoka foka;
       


        public Iskola Iskola { get => iskola; set => iskola = value; }
        public KepzettsegFoka Foka { get => foka; set => foka = value; }
        public KepzettsegTipusa Tipusa { get => KepzettsegTipusa.Pszi;  }
    }
}
