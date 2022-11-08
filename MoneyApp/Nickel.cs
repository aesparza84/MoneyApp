using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyApp
{
    public class Nickel:USCoin
    {
        public Nickel()
        {
            this.MonetaryValue = 0.05;
            this.Name = "Nickel";
            this.Year = 2011;
            this.mintMark = MintMark.P;
        }

        public override string About()
        {
            return $"This is a {this.Name} from {this.Year} and is with ${this.MonetaryValue.ToString()} .";
        }
    }
}
