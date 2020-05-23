using MagusLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Szerver;

namespace MagusTest
{
    class HarcertekAlapTeszt
    {
        [Test]
        public void EmberHarcosKezdemenyezo()
        {
            IKarakter karakter = new Karakter()
            {
                Faj = JatszhatoFaj.Ember,
                Alkaszt = KarakterAlkaszt.Harcos,
                Ugyesseg = 17,
                Gyorsasag = 16,
            };
            ISzamolo szamolo = new KezdemenyezoSzamolo();

            Assert.AreEqual(22, szamolo.Szamol(karakter).Kezdemenyezo);
        }


    }
}
