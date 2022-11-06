using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyApp
{
    public class Coin : ICoin
    {
        public int Year { get; set; }
        public double MonetaryValue { get; set; }
        public string Name { get; set; }

        public Coin()
        { 
        
        }

        string About()
        {
            return $"A {this.Year.ToString()} {Name} worth ${this.MonetaryValue.ToString()}";
        }
    }
}
