using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            CandyShop candyShop = new CandyShop(300);
            candyShop.PrintInfo();
            for (int i = 0; i < 15; i++)
            {
                candyShop.CreateSweets(CandyShop.CANDY);
            }           
            candyShop.PrintInfo();
            for (int i = 0; i < 15; i++)
            {
                candyShop.CreateSweets(CandyShop.LOLLIPOP);
            }
            candyShop.PrintInfo();
            candyShop.Sell(CandyShop.CANDY,5);
            candyShop.PrintInfo();
            candyShop.Sell(CandyShop.CANDY, 20);
            candyShop.PrintInfo();
            candyShop.Sell(CandyShop.LOLLIPOP, 10);
            candyShop.PrintInfo();
            candyShop.BuySugar(600);
            candyShop.PrintInfo();
            Console.ReadLine();
        }
    }
}
