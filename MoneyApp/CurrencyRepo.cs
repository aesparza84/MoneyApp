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

        public ICurrency MakeChange(double AmountTendered, double TotalCost)
        {
            if (AmountTendered-TotalCost < 0)
            {
                return (ICurrency);
            }
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
    }
}
