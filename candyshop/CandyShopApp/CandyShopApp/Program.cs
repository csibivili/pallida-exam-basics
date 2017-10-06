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
            candyShop.CreateSweets(CandyShop.CANDY);
            candyShop.CreateSweets(CandyShop.CANDY);
            candyShop.CreateSweets(CandyShop.LOLLIPOP);
            candyShop.CreateSweets(CandyShop.LOLLIPOP);
            candyShop.PrintInfo();
            // Should print out:
            // Invetory: 2 candies, 2 lollipops, Income: 0$, Sugar: 270gr
            candyShop.Sell(CandyShop.CANDY, 1);
            candyShop.PrintInfo();
            // Should print out:
            // "Invetory: 1 candies, 2 lollipops, Income: 20$, Sugar: 270gr"
            candyShop.Raise(50);
            candyShop.Sell(CandyShop.LOLLIPOP, 1);
            candyShop.PrintInfo();
            // Should print out:
            // "Invetory: 1 candies, 1 lollipops, Income: 35$, Sugar: 270gr"
            candyShop.BuySugar(300);
            candyShop.PrintInfo();
            // Should print out:
            // "Invetory: 1 candies, 1 lollipops, Income: 5$, Sugar: 570gr"
            Console.ReadLine();
        }
    }
}
