using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyApp
{
    public class HalfDollar:USCoin
    {
        public HalfDollar()
        {
            this.MonetaryValue = 0.50;
            this.Name = "Half Dollar";
            this.Year = 2005;
            this.mintMark = MintMark.S;
        }

        public override string About()
        {
            return $"This is a {this.Name} from {this.Year} and is with ${this.MonetaryValue.ToString()} .";
        }
    }
}
