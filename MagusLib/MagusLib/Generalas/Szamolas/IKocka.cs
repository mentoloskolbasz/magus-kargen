using System;
using System.Collections.Generic;
using System.Text;

namespace MagusLib
{
    public interface IKocka
    {
        int Minimum { get; }
        int Maximum { get; }
        int Dobas();
    }
}
