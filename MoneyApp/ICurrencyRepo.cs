using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyApp
{
    public interface ICurrencyRepo
    {
        List<ICurrency> Coins { get; set; }

        int GetCoinCount();
        string About();

        void AddCoin(ICurrency c); //adds Coins to list
        void RemoveCoin(ICurrency c); //removes coins from list
        double TotalValue();

        ICurrencyRepo MakeChange(double Amount);
        ICurrencyRepo MakeChange(double AmountTendered, double TotalCost);
    }
}
