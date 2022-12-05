using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyApp
{
    public class OneKrone:NorwegianCoin
    {
        public OneKrone() 
        {
            this.MonetaryValue = 0.1;
            this.Name = "One Nok";
            this.Year= 1994;
            this.designMark= DesignMark.IAR;
        }

        public override string About()
        {
            return base.About();
        }
    }
}
