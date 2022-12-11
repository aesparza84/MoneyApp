using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyApp
{
    public class NWRepo:CurrencyRepo
    {
        public static List<ICoin> ReferenceListByAmount()
        {
            ICoin one = new OneKrone();
            ICoin five = new FiveKrone();
            ICoin ten = new TenKrone();
            ICoin twenty = new TwentyKrone();

            List<ICoin> reference = new List<ICoin> { one,five,ten,twenty };

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
