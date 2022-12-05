using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyApp
{
    public class Quarter:USCoin
    {
        public Quarter()
        {
            this.MonetaryValue = 0.25;
            this.Name = "Quarter";
            this.Year = 1984;
            this.mintMark = MintMark.W;
        }

        public override string About()
        {
            return $"This is a {this.Name} from {this.Year} and is with ${this.MonetaryValue.ToString()} .";
        }
    }
}
