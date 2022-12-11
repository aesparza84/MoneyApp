using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyApp
{
    public class CurrencyRepo : ICurrencyRepo
    {
        public List<ICurrency> Coins { get; set; }
        ICurrencyRepo change { get; set; }
        public CurrencyRepo()
        {
            Coins = new List<ICurrency>();
        }
        public string About()
        {
            return "";
        }

        public void AddCoin(ICurrency c)
        {
            Coins.Add(c);
        }
        public void RemoveCoin(ICurrency c)
        {
            Coins.Remove(c);
        }

        public int GetCoinCount()
        {
            return Coins.Count;
        }
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

        protected double CreateChange(double Amount)
        {
            return Amount;
        }
        protected double CreateChange(double AmountTendered, double TotalCost)
        {
            return AmountTendered - TotalCost;
        }

        //public CurrencyRepo GetRepoType()
        //{            
        //    return this.GetType();
        //}

        public virtual CurrencyRepo MakeChange(double AmountTendered, double TotalCost)
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

        

        public string TotalValue()
        {
            double n=0, prevN=0;
            foreach (ICoin item in Coins)
            {
                prevN = n;
                n = prevN + item.MonetaryValue;
            }
            return string.Format("{0:N2}", n);
        }

        public CurrencyRepo MakeChange( double Amount)
        {
            return MakeChange(Amount, 0);   
        }
    }
}
