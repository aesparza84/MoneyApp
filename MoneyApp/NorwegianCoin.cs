using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyApp
{
    
    public enum DesignMark{NA,OH,GJL,IAR,IT,JV}
    public class NorwegianCoin:Coin
    {
        //https://markyourcoin.weebly.com/norway-norge-noreg.html
        public DesignMark designMark { get; set; }
        public NorwegianCoin()
        {

        }
        public virtual string About()
        {
            return $"This is a {this.Name} from {this.Year} and is with ${this.MonetaryValue.ToString()} .";
        }
        
        public virtual string GetDesignFromMark()
        {
            string n = "";
            switch (designMark)
            {
                case DesignMark.NA:
                    n = "Aas"; //OH,GJL,IAR,IT,JV
                    break;
                case DesignMark.GJL:
                    n = "Lindau";
                    break;
                case DesignMark.OH:
                    n = "Hansen";
                    break;
                case DesignMark.IAR:
                    n = "Rise";
                    break;
                case DesignMark.IT:
                    n = "Throndsen";
                    break;
                case DesignMark.JV:
                    n = "Visdal";
                    break;
            }
            return n;
        }
    }
}
