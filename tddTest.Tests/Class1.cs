using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace tddTest.Tests
{
    
    [TestFixture]
    public class KontoTests
    {
        //[Test]
        //public void AFirstTest()
        //{
        //    Assert.IsTrue(true, "true is true!");
        //}

        //[Test]
        //public void AddMoney()
        //{
        //    Konto mittKonto = new Konto();
        //    mittKonto.Insattning(7000);
        //    Assert.AreEqual(7000, mittKonto.SaldoBesked(), 2); //kollar en double
        //}

        [Test]
        public void Uttag()
        {
            Konto mittKonto = new Konto();
            mittKonto.Insattning(3000);
            bool finnsPengar = mittKonto.Uttag(2000);
            Assert.IsTrue(finnsPengar); //kolla en bool
        }
    }
}
