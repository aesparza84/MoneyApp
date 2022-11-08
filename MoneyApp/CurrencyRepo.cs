using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyApp
{
    public class CurrencyRepo : ICurrencyRepo
    {
        public List<Coin> Coins { get; set; }

        public CurrencyRepo()
        {
            Coins = new List<Coin>();
        }
        public string About()
        {
            return "";
        }

        public void AddCoin(Coin c)
        {
            Coins.Add(c);
        }

        public int GetCoinCount()
        {
            return Coins.Count;
        }

        //public ICurrencyRepo MakeChange(double Amount)
        //{

        //}

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

        public void RemoveCoin(Coin c)
        {
            Coins.Remove(c);
        }

        public double TotalValue()
        {
            double n=0, prevN=0;
            foreach (Coin item in Coins)
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
