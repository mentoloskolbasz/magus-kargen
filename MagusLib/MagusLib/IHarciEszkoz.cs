using System;
using System.Collections.Generic;
using System.Text;

namespace MagusLib
{

    interface IHarciEszkoz
    {
        Fegyvernem Fegyverneme { get; }
        string Nev { get; }
        int Kezdemenyezo { get; }
        double Suly { get; }
        uint Sebzes { get; set; }
        int TamPerKor { get; }
    }
}
