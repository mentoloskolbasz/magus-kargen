using MagusLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MagusLib.KarakterKeszites
{
    public interface ISzamolo
    {
        IKarakter Szamol(IKarakter karakter);

    }
}