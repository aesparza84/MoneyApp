using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyApp
{
    internal class Dime:USCoin
    {
        public Dime()
        {
            this.MonetaryValue = 0.10;
            this.Name = "Dime";
            this.Year = 2020;
        }

        string About()
        {
            return $"This is a {this.Name} from {this.Year} and is with ${this.MonetaryValue.ToString()} .";
        }
    }
}
