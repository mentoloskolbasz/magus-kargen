using System;
using MagusLib;
using System.Collections.Generic;
using System.Text;

namespace Szerver.SrC
{

    public class PapKasztAlkasztValaszto
    {
       
        private static readonly Dictionary<KarakterAlkaszt, PapKasztAlkasztja[]> LISTA = new Dictionary<KarakterAlkaszt, PapKasztAlkasztja[]>()
        {
            { KarakterAlkaszt.Pap, new PapKasztAlkasztja[] {
                PapKasztAlkasztja.Adron,
                PapKasztAlkasztja.Antoh,
                PapKasztAlkasztja.Arel,
                PapKasztAlkasztja.Doldzsah,
                PapKasztAlkasztja.Domvik,
                PapKasztAlkasztja.Dzsah,
                PapKasztAlkasztja.Galradzsa,
                PapKasztAlkasztja.Kadal,
                PapKasztAlkasztja.Kyel,
                PapKasztAlkasztja.Orwella,
                PapKasztAlkasztja.Ranagol,
                PapKasztAlkasztja.Sogron,
                PapKasztAlkasztja.Tharr,
                PapKasztAlkasztja.Tooma,
            } },            
        };
        
        public PapKasztAlkasztja[] this[KarakterAlkaszt kaszt]
        {
            get => PapKasztAlkasztValaszto.LISTA[kaszt];
        }
    }


}
