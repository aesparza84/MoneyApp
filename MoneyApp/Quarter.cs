using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyApp
{
    internal class Quarter:Coin
    {
        public Quarter()
        {
            this.MonetaryValue = 0.25;
            this.Name = "Quarter";
            this.Year = 1984;
        }

        string About()
        {
            return $"This is a {this.Name} from {this.Year} and is with ${this.MonetaryValue.ToString()} .";
        }
    }
}
