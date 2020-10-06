using System;
using System.Collections.Generic;
using System.Text;

namespace MagusLib.KarakterKeszites
{
    public abstract class AbsztraktValaszto<T> : ITulajdonsagValaszto<T>
    {
        private static Random r = new Random();
        public abstract T[] Felsorolas(IKarakter karakter);

        public virtual T Valaszt(IKarakter karakter)
        {
            //throw new NotImplementedException();
            var felsorolas = Felsorolas(karakter);
            
            return felsorolas[r.Next(0, felsorolas.Length)];
        }
    }
}
