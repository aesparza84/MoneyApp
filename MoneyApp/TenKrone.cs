using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyApp
{
    public class TenKrone : NorwegianCoin
    {
        public TenKrone()
        {
            this.MonetaryValue = 1.02;
            this.Name = "Ten Nok";
            this.Year = 1999;
            this.designMark = DesignMark.OH;
        }

        public override string About()
        {
            return base.About();
        }
    }
}
