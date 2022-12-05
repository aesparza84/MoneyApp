using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyApp
{
    public class TwentyKrone : NorwegianCoin
    {
        public TwentyKrone()
        {
            this.MonetaryValue = 2.04;
            this.Name = "Twenty Nok";
            this.Year = 1994;
            this.designMark = DesignMark.IT;
        }

        public override string About()
        {
            return base.About();
        }
    }
}
