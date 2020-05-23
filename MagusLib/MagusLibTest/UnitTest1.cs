using NUnit.Framework;
using MagusLib;
using Szerver;

namespace MagusLibTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var karakter = new Karakter();
            karakter.Nev = "Misi Mókus";
            Assert.AreEqual("Misi Mókus", karakter.Nev);

            var valaszto = new KasztAlkasztValaszto();
            var alkaszt = valaszto[KarakterKaszt.Harcos][0];
            Assert.AreEqual(KarakterAlkaszt.Harcos, alkaszt);
        }
    }
}