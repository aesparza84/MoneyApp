using MoneyApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    [TestClass]
    public class NorwegianCoinTest
    {

        [TestMethod]
        public void DefaultKroneProperties()
        { 
            //arrange
            OneKrone ok = new OneKrone();
            FiveKrone fk = new FiveKrone();
            TenKrone tk = new TenKrone();
            TwentyKrone twk = new TwentyKrone();
            //assert
            double expectedOKValue = 0.1;
            double expectedFKValue = 0.51;
            double expectedTKValue = 1.02;
            double expectedTWKValue = 2.04;
            //act
                //One
            Assert.AreEqual(ok.designMark, DesignMark.IAR);
            Assert.AreEqual(ok.MonetaryValue, expectedOKValue);
                //Five
            Assert.AreEqual(fk.designMark, DesignMark.GJL);
            Assert.AreEqual(fk.MonetaryValue, expectedFKValue);
                //Ten
            Assert.AreEqual(tk.designMark, DesignMark.OH);
            Assert.AreEqual(tk.MonetaryValue, expectedTKValue);
                //Twenty
            Assert.AreEqual(twk.designMark, DesignMark.IT);
            Assert.AreEqual(twk.MonetaryValue, expectedTWKValue);
        
        }
    }
}
