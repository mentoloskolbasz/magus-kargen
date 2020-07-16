using System;
using MagusLib;
using System.Collections.Generic;
using System.Text;

namespace MagusLib.KarakterKeszites
{

    public class PaplovagKasztAlkasztValaszto
    {
       
        private static readonly Dictionary<KarakterAlkaszt, PaplovagKasztAlkasztja[]> LISTA = new Dictionary<KarakterAlkaszt, PaplovagKasztAlkasztja[]>()
        {
            { KarakterAlkaszt.Paplovag, new PaplovagKasztAlkasztja[] {
               PaplovagKasztAlkasztja.Darton,
               PaplovagKasztAlkasztja.Domvik,
               PaplovagKasztAlkasztja.Dreina,
               PaplovagKasztAlkasztja.Főnixek,
               PaplovagKasztAlkasztja.Krad,
               PaplovagKasztAlkasztja.Ranagol,
               PaplovagKasztAlkasztja.Uwel
            } },

            
        };

        public PaplovagKasztAlkasztja[] this[KarakterAlkaszt kaszt]
        {
            get => PaplovagKasztAlkasztValaszto.LISTA[kaszt];
        }
    }


}
