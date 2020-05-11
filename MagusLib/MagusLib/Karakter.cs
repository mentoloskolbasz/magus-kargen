using System;
using System.Collections.Generic;
using System.Text;

namespace MagusLib
{
    public class Karakter : IKarakter
    {
        public string Nev { get; set; }
        public JatszhatoFaj Faj { get; set; }
        public KarakterNeme Nem { get; set; }
        public KarakterKorosztaly Kor { get; set; }
    }
}
