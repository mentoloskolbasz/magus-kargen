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
        public uint kezdemenyezoErtek = 0;
        public uint tamadoErtek = 0;
        public uint vedoErtek = 0;
        public uint celzoErtek = 0;
        public uint keziLevonando = 0;
        public uint levonando
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
