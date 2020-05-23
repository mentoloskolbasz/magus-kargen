using MagusLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Szerver
{
    public interface ISzamolo
    {
        IKarakter Szamol(IKarakter karakter);

    }
}