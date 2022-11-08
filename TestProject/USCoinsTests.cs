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
    }
}
