using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopApp
{
    public class Lollipop : Sweets
    {
        public Lollipop()
        {
            Sugar = 5;
            Price = 10;
        }

        public Lollipop(double percentage)
        {
            Sugar = 5;
            Price = (percentage / 100 + 1) * 10;
        }
    }
}
