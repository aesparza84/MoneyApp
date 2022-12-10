using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyApp
{
    public class CurrencyRepo : ICurrencyRepo
    {
        public List<ICoin> Coins { get; set; }

        public CurrencyRepo()
        {
            Coins = new List<ICoin>();
        }
        public string About()
        {
            return "";
        }

        public void AddCoin(ICoin c)
        {
            Coins.Add(c);
        }

        public int GetCoinCount()
        {
            return Coins.Count;
        }
        public static List<ICoin> SortList()
        {
            ICoin penny = new Penny();
            ICoin nickel = new Nickel();
            ICoin dime = new Dime();
            ICoin quarter = new Quarter();
            ICoin dollar = new DollarCoin();

            List<ICoin> wallet = new List<ICoin> { penny, nickel, dime, quarter, dollar };

            return wallet.OrderByDescending(m => m.MonetaryValue).ToList();
        }

        private double CreateChange(double Amount)
        {
            return Amount;
        }
        private double CreateChange(double AmountTendered, double TotalCost)
        {
            return AmountTendered - TotalCost;
        }       

        public double MakeChange(double AmountTendered, double TotalCost)
        {
            int dc, h, q, d, n, p;
            double remainingChange;

            double x = CreateChange(AmountTendered, TotalCost);
            if (x < 0)
            {
                return 0;
            }
            else
            {
                foreach (ICurrency item in Coins)
                {
                    if (item.MonetaryValue == 1.00)
                    {
                        return item.MonetaryValue;
                    }
                }
            }
            return 0;
        }

        public void RemoveCoin(ICoin c)
        {
            Coins.Remove(c);
        }

        public double TotalValue()
        {
            double n=0, prevN=0;
            foreach (ICoin item in Coins)
            {
                prevN = n;
                n = prevN + item.MonetaryValue;
            }
            return n;
        }

        public double MakeChange(double Amount)
        {
            throw new NotImplementedException();
        }
    }
}
