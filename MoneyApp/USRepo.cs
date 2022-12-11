using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyApp
{
    public class USRepo:CurrencyRepo
    {
        public static List<ICoin> ReferenceListByAmount()
        {
            ICoin penny = new Penny();
            ICoin nickel = new Nickel();
            ICoin dime = new Dime();
            ICoin quarter = new Quarter();
            ICoin half = new HalfDollar();
            ICoin dollar = new DollarCoin();

            List<ICoin> reference = new List<ICoin> { penny, nickel, dime, quarter,half, dollar };

            return reference.OrderByDescending(m => m.MonetaryValue).ToList();
        }

        
    }
}
