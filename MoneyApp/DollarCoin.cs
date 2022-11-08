using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyApp
{
    public class DollarCoin:USCoin
    {
        public DollarCoin()
        {
            this.MonetaryValue = 1.00;
            this.Name = "Dollar Coin";
            this.Year = 2002;
            this.mintMark = MintMark.D;
        }

        public override string About()
        {
            return $"This is a {this.Name} from {this.Year} and is with ${this.MonetaryValue.ToString()} .";
        }
    }
}
