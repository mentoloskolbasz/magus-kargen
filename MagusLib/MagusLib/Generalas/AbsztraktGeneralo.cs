using System;
using System.Collections.Generic;
using System.Text;

namespace MagusLib
{
    public abstract class AbsztraktGeneralo : IGeneralo
    {
        protected delegate void Ertekado(IKarakter karakter);
        protected Ertekado ertekadok;
        
        virtual public IKarakter Generalas(IKarakter karakter)
        {
            ertekadok(karakter);
            return karakter;
        }

    }
}
