using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagusLib
{
    public abstract class TobbKocka : IKocka
    {
        protected List<IKocka> kockakok = new List<IKocka>();
        virtual public int Minimum
        {
            get => (from kocka in kockakok select kocka.Minimum).Sum();
        }
        virtual public int Maximum
        {
            get => (from kocka in kockakok select kocka.Maximum).Sum();
        }
        virtual public int Dobas()
        {
            return (from kocka in kockakok select kocka.Dobas()).Sum();
        }
    }
}
