using MoneyApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    [TestClass]
    public class USCoinsTests
    {
        Penny p;

        [TestMethod]
        public void USCoinPennyConstructor()
        {
            //arrange
            p = new Penny();
            //assert

            //act
            Assert.IsNotNull(p);
            Assert.AreEqual(p.mintMark, MintMark.P);
        }

        [TestMethod]
        public void OtherDefaultCoinTests()
        { 
            //arrange
            Nickel n = new Nickel();
            Dime d = new Dime();
            Quarter q = new Quarter();
            HalfDollar hf = new HalfDollar();
            DollarCoin dl = new DollarCoin();
            
            //act
            double expectedNickelVal = 0.05;
            double expectedDimeVal = 0.1;
            double expectedQuarterVal = 0.25;
            double expectedHalfDollarVal = 0.5;
            double expectedDollarCoinVal = 1.0;

            //assert
            Assert.AreEqual(n.MonetaryValue, expectedNickelVal);
            Assert.AreEqual(n.mintMark, MintMark.P);
            //
            Assert.AreEqual(d.MonetaryValue, expectedDimeVal);
            Assert.AreEqual(d.mintMark, MintMark.D);
            //
            Assert.AreEqual(q.MonetaryValue, expectedQuarterVal);
            Assert.AreEqual(q.mintMark, MintMark.W);
            //
            Assert.AreEqual(hf.MonetaryValue, expectedHalfDollarVal);
            Assert.AreEqual(hf.mintMark, MintMark.S);
            //
            Assert.AreEqual(dl.MonetaryValue, expectedDollarCoinVal);
            Assert.AreEqual(dl.mintMark, MintMark.D);
        }
    }
}
