using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyApp
{
    
    public abstract class USCoin:Coin
    {
        public MintMark mintMark { get; set; }

        public USCoin()
        { 
            this.Year= 0;
            this.mintMark = MintMark.P;
            this.MonetaryValue = 0;
        }

        public static List<ICoin> SortList()
        {
            ICoin penny = new Penny();
            ICoin nickel= new Nickel();
            ICoin dime = new Dime();    
            ICoin quarter = new Quarter();
            ICoin dollar = new DollarCoin();

            List<ICoin> wallet = new List<ICoin> { penny, nickel, dime, quarter, dollar };

            return wallet.OrderByDescending(m => m.MonetaryValue).ToList();
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
