using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyApp
{
    public class FiveKrone : NorwegianCoin
    {
        public FiveKrone()
        {
            this.MonetaryValue = 0.51;
            this.Name = "Five Nok";
            this.Year = 2002;
            this.designMark = DesignMark.GJL;
        }

        public override string About()
        {
            return base.About();
        }
    }
}
