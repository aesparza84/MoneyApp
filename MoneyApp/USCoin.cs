using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyApp
{
    public class USCoin:Coin
    {
        public MintMark mintMark { get; set; }

        public USCoin()
        { 
            
        }
        public virtual string About()
        {
            return $"This is a {this.Name} from {this.Year} and is with ${this.MonetaryValue.ToString()} .";
        }

        public virtual string GetMintFromMark()
        {
            string n = "";
            switch (mintMark)
            {
                case MintMark.P: n = "Philadelphia";
                    break;
                case MintMark.D:
                    n =  "Denver";
                    break;
                case MintMark.W:
                    n =  "West Point";
                    break;
                case MintMark.S:
                    n =  "San Francisco";
                    break;
            }
            return n;
        }

    }
}
