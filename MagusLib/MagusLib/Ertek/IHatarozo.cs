using System;
using System.Collections.Generic;
using System.Text;

namespace MagusLib.Ertek
{
    public interface IHatarozo<T>
    {
        T Hataroz(IKarakter karakter);
    }
    /*public interface IHatarozo : IHatarozo<int>
    {

    }*/
}
