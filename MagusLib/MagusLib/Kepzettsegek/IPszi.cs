﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MagusLib.Kepzettsegek
{
    public interface IPszi : IKepzettseg
    {
        Iskola Iskola { get; set; }
    }
}
