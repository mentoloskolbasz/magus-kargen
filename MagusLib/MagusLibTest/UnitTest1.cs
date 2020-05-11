using NUnit.Framework;
using MagusLib;

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
        }
    }
}