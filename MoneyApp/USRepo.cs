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
            ICoin dollar = new DollarCoin();

            List<ICoin> reference = new List<ICoin> { penny, nickel, dime, quarter, dollar };

            return reference.OrderByDescending(m => m.MonetaryValue).ToList();
        }
        public override CurrencyRepo MakeChange(double AmountTendered, double TotalCost)
        {
            double realChange = CreateChange(AmountTendered, TotalCost);

            CurrencyRepo change = new CurrencyRepo();

            List<ICoin> referenceList = ReferenceListByAmount();

            foreach (ICoin item in referenceList)
            {
                while (realChange >= item.MonetaryValue)
                {
                    change.AddCoin(item);
                    realChange -= item.MonetaryValue;
                }
            }
            return change;
        }
    }
}
