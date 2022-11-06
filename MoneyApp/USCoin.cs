using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyApp
{
    enum MintMark {P,D,S,W }
    public class USCoin:Coin
    {
        string About()
        {
            return $"This is a {this.Name} from {this.Year} and is with ${this.MonetaryValue.ToString()} .";
        }
    }
}
