using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyApp
{
    public interface ICurrency
    {
        double MonetaryValue { get; set; }
        string Name { get; set; }
    }
}
