using System;

namespace MagusLib
{
    public interface IKarakter
    {
        string Nev { get; set; }
        JatszhatoFaj Faj { get; set; }
        KarakterNeme Nem { get; set; }
        KarakterKorosztaly Kor { get; set; }
    }
}
