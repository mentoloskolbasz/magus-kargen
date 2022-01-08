using System;
using System.Collections.Generic;
using System.Text;

namespace MagusLib.Kepzettsegek
{
    public interface IKepzettseg
    {
        KepzettsegFoka Foka { get; }
        KepzettsegTipusa Tipusa { get; }

    }
}
