using System;
using CiselneSoustavy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CiselneSoustavyTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int cislo = 15;
            Prevod prevod = new Prevod(cislo);
            string vysledek1 = "f";
            string v = prevod.DecToHexa();
            Assert.AreEqual(v, vysledek1);
        }
    }
}
