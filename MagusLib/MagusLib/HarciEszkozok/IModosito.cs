using System;
using System.Collections.Generic;
using System.Text;

namespace MagusLib.HarciEszkozok
{
    interface IModosito <TErtek>
    {
        string Nev { get; set; }
        TErtek Szamol(TErtek ertek);

    }
}
