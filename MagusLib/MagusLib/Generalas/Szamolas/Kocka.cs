using System;
using System.Collections.Generic;
using System.Text;

namespace MagusLib
{
    abstract class Kocka : IKocka
    {

        private static Random random = new Random();

        virtual protected Random r { get { return Kocka.random; } }

        abstract public int Minimum
        {
            get;
        }
        abstract public int Maximum
        {
            get;
        }
        virtual public int Dobas()
        {
            utolsoErtek = r.Next(Minimum, Maximum + 1);
            Console.WriteLine("Kocka: " + utolsoErtek);
            return utolsoErtek;
        }
        protected int utolsoErtek;
    }
}
