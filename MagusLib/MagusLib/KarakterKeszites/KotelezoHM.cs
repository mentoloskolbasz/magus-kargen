using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagusLib;

namespace MagusLib.KarakterKeszites
{
    public class KotelezoHM
    {
        public int kezdemenyezoErtek = 0;
        public int tamadoErtek = 0;
        public int vedoErtek = 0;
        public int celzoErtek = 0;
        public int keziLevonando = 0;
        public int levonando
        {
            get
            {
                if (keziLevonando != 0)
                {
                    return keziLevonando;
                }
                return kezdemenyezoErtek + celzoErtek + tamadoErtek + vedoErtek;
            }
        }
    }

    public delegate KotelezoHM KotelezoEloallito(IKarakter karakter);

}
