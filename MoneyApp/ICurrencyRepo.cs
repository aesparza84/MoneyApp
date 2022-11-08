using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyApp
{
    internal interface ICurrencyRepo
    {
        List<Coin> Coins { get; set; }

        int GetCoinCount();
        string About();

        void AddCoin(Coin c); //adds Coins to list
        void RemoveCoin(Coin c); //removes coins from list
        double TotalValue();

        double MakeChange(double Amount);
        double MakeChange(double AmountTendered, double TotalCost);
    }
}
