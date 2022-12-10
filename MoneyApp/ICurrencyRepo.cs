using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyApp
{
    internal interface ICurrencyRepo
    {
        List<ICoin> Coins { get; set; }

        int GetCoinCount();
        string About();

        void AddCoin(ICoin c); //adds Coins to list
        void RemoveCoin(ICoin c); //removes coins from list
        double TotalValue();

        double MakeChange(double Amount);
        double MakeChange(double AmountTendered, double TotalCost);
    }
}
