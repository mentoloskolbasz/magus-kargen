using MagusLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Szerver;
using Szerver.SrC;

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
        [Test]
        public void EmberHarcosTamado()
        {
            IKarakter karakter = new Karakter()
            {
                Faj = JatszhatoFaj.Ember,
                Alkaszt = KarakterAlkaszt.Harcos,
                Ugyesseg = 17,
                Gyorsasag = 16,
                Ero = 18
            };
            ISzamolo szamolo = new TamadoertekSzamolo();

            Assert.AreEqual(41, szamolo.Szamol(karakter).Tamado);
        }
        [Test]
        public void EmberHarcosVedo()
        {
            IKarakter karakter = new Karakter()
            {
                Faj = JatszhatoFaj.Ember,
                Alkaszt = KarakterAlkaszt.Harcos,
                Ugyesseg = 17,
                Gyorsasag = 16,                
            };
            ISzamolo szamolo = new VedoSzamolo();

            Assert.AreEqual(88, szamolo.Szamol(karakter).Vedo);
        }
        [Test]
        public void EmberHarcosCelzo()
        {
            IKarakter karakter = new Karakter()
            {
                Faj = JatszhatoFaj.Ember,
                Alkaszt = KarakterAlkaszt.Harcos,
                Ugyesseg = 17,
                Gyorsasag = 16,                
            };
            ISzamolo szamolo = new CelzoSzamolo();

            Assert.AreEqual(7, szamolo.Szamol(karakter).Celzo);
        }
    }
}
