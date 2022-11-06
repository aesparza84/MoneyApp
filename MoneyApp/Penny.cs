using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyApp
{
    public class Penny:Coin
    {

        public Penny()
        { 
            this.MonetaryValue = 0.01;
            this.Name = "Penny";
            this.Year = 2017;
        }

        string About()
        {
            return $"This is a {this.Name} from {this.Year} and is with ${this.MonetaryValue.ToString()} .";
        }
    }
}
