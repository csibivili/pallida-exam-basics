using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopApp
{
    public class CandyShop
    {
        public int Money, Sugar;
        public List<Sweets> Sweets;

        public CandyShop(int sugar)
        {
            Sugar = sugar;
            Sweets = new List<Sweets>();
        }

        public void CreateSweets(Sweets sweet)
        {
            if (Sugar >= sweet.Sugar)
            {
                Sweets.Add(sweet);
                Sugar -= sweet.Sugar;
            }
        }

        public void Sell(Sweets sweet, int pieces)
        {
            int howMany = 0;
            for (int i = 0; i < Sweets.Count; i++)
            {
                if (Sweets[i] == sweet)
                {
                    howMany++;
                }
            }
            if (howMany >= pieces)
            {
                for (int i = 0; i < pieces; i++)
                {
                    Sweets.Remove(sweet);
                    Money += sweet.Price;
                }               
            }
        }

        public void PrintInfo()
        {

        }

        public void BuySugar(int sugar)
        {

        }
    }
}
