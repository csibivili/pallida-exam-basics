using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopApp
{
    public class CandyShop
    {
        public static Candy CANDY = new Candy();
        public static Lollipop LOLLIPOP = new Lollipop();
        public static List<Sweets> Sweets; 

        public double Money, Sugar;

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
            if (sweet == CANDY)
            {
                if (InventoryCheck()["candies"] >= pieces)
                {
                    Selling(sweet, pieces);
                }
            }
            else
            {
                if (InventoryCheck()["lollipops"] >= pieces)
                {
                    Selling(sweet, pieces);
                }
            }
        }

        public void Raise(double percentage)
        {
            foreach (var sweet in Sweets)
            {
                sweet.Price *= (percentage / 100.00);
            }
        }

        public void Selling(Sweets sweet, int pieces)
        {
            for (int i = 0; i < pieces; i++)
            {
                Sweets.Remove(sweet);
                Money += sweet.Price;
            }
        }

        public Dictionary<string, int> InventoryCheck()
        {
            Dictionary<string, int> inventory = new Dictionary<string, int>();
            int numberOfCandies = 0, numberOfLollipops = 0;
            for (int i = 0; i < Sweets.Count; i++)
            {
                if (Sweets[i] == CANDY)
                {
                    numberOfCandies++;
                }
                else
                {
                    numberOfLollipops++;
                }
            }
            inventory.Add("candies", numberOfCandies);
            inventory.Add("lollipops", numberOfLollipops);
            return inventory;
        }

        public void PrintInfo()
        {
            Console.WriteLine(
                "Inventory: {0} candies, {1} lollipops, " +
                "Income: {2}$, Sugar: {3}gr", 
                InventoryCheck()["candies"], InventoryCheck()["lollipops"], Money, Sugar);
        }

        public void BuySugar(int sugar)
        {
            if (Money >= sugar /10)
            {
                Sugar += sugar;
                Money -= sugar / 10;
            }
        }
    }
}
