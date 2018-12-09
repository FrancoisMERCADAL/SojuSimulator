using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SojuSimulator3000
{
    public class Joueur : IComparable<Joueur>
    {
        float money;
        int numberOfSalary;
        List<Machin> numberOfMachin;
        int spendMarketing;
        string name;
        int stockNormalSoju;
        int stockPremiumSoju;
        float priceSellBottleSojuNormal;
        float priceSellBottleSojuPremium;
        float proportionSellOfThisTurnNormalSoju;
        Market market;

        public string Name { get => name; set => name = value; }
        public float Money { get => money; set => money = value; }
        public int NumberOfSalary { get => numberOfSalary; set => numberOfSalary = value; }
        public List<Machin> NumberOfMachin { get => numberOfMachin; set => numberOfMachin = value; }
        public int SpendMarketing { get => spendMarketing; set => spendMarketing = value; }
        public float ProportionSellOfThisTurnNormalSoju { get => proportionSellOfThisTurnNormalSoju; set => proportionSellOfThisTurnNormalSoju = value; }
        public int StockNormalSoju { get => stockNormalSoju; set => stockNormalSoju = value; }
        public float PriceSellBottleSojuNormal { get => priceSellBottleSojuNormal; set => priceSellBottleSojuNormal = value; }
        public float PriceSellBottleSojuPremium { get => priceSellBottleSojuPremium; set => priceSellBottleSojuPremium = value; }
        public int StockPremiumSoju { get => stockPremiumSoju; set => stockPremiumSoju = value; }

        public Joueur(string name, float money, Market market)
        {
            this.name = name;
            this.money = money;
            numberOfMachin = new List<Machin>();
            numberOfSalary = 0;
            spendMarketing = 0;
            priceSellBottleSojuNormal = 0;
            priceSellBottleSojuPremium = 0;
            stockNormalSoju = 0;
            stockPremiumSoju = 0;
            this.market = market;
        }
        public void ProductSoju(int numberOfNormalSoju)
        {
            numberOfNormalSoju = BottleToProduct(numberOfNormalSoju);
            stockNormalSoju += numberOfNormalSoju;
            money -= numberOfSalary * market.SalaryWorker;
            for(int i =0;i<numberOfMachin.Count;i++)
                money -= numberOfMachin[i].PriceMaintenance;
            money -= numberOfNormalSoju * market.PriceIngredientsSojuNormal;
        }
        public int SellSoju(int turn)
        {
            int reste = 0;
            stockNormalSoju -= Convert.ToInt32(market.EstimationSojuNormalSell[turn-1]*proportionSellOfThisTurnNormalSoju);
            int vente = Convert.ToInt32(market.EstimationSojuNormalSell[turn - 1] * proportionSellOfThisTurnNormalSoju);
            if(stockNormalSoju<0)
            {
                reste = -stockNormalSoju;
                vente += stockNormalSoju;
                stockNormalSoju = 0;
            }
            //stockPremiumSoju -= Convert.ToInt32(market.EstimationSojuPremiumSell[turn - 1] * proportionSellOfThisTurnPremiumSoju;
            money += vente * priceSellBottleSojuNormal;
            //money += ventePremiumSoju * priceSellBottleSojuPremium;
            return reste;
        }

        public void FeeDebt()
        {
            float inter = 0;
            if(money<0)
            {
                inter = -money;
                inter = inter * 0.15f;
                money -= inter;
            }
        }
        /// <summary>
        /// Function to buy the classic machin and add it to the company
        /// </summary>
        public void BuyANewMachinClassic()
        {
            numberOfMachin.Add(new Machin(5,80000,5000000));
            money -= market.ValueMachin;
        }
        public void SellMachineClassic()
        {
            numberOfMachin.RemoveAt(0);
            money += 15000000;
        }
        public void GiveMachineBack()
        {
            numberOfMachin.RemoveAt(0);
            money += 40000000;
        }
        /// <summary>
        /// Method to add a salary to the company
        /// </summary>
        public void HireNewSalary()
        {
            numberOfSalary++;
        }
        /// <summary>
        /// Function to fire a salary of the company
        /// </summary>
        public void FireSalary()
        {
            numberOfSalary--;
            money -= market.FireWorker;
        }
        public int CompareTo(Joueur autre)
        {
            int val = 0;
            if (this.money.CompareTo(autre.money) > 0)
                val = -1;
            if (this.money.CompareTo(autre.money) < 0)
                val = 1;
            return val;

        }
        /// <summary>
        /// Sort the list of player according to marketing
        /// </summary>
        /// <param name="j1"></param>
        /// <param name="j2"></param>
        /// <returns></returns>
        static public int TriMarketing(Joueur j1, Joueur j2)
        {
            return j1.spendMarketing.CompareTo(j2.spendMarketing);
        }

        /// <summary>
        /// Sort the list of player according to price of normal soju that each player choose
        /// </summary>
        /// <param name="j1"></param>
        /// <param name="j2"></param>
        /// <returns></returns>
        static public int TriSellNormalSoju(Joueur j1, Joueur j2)
        {
            return j1.priceSellBottleSojuNormal.CompareTo(j2.priceSellBottleSojuNormal);
        }

        /// <summary>
        /// Sort the list of player according to price of premium soju that each player choose
        /// </summary>
        /// <param name="j1"></param>
        /// <param name="j2"></param>
        /// <returns></returns>
        static public int TriSellPremiumSoju(Joueur j1, Joueur j2)
        {
            return j1.priceSellBottleSojuPremium.CompareTo(j2.priceSellBottleSojuPremium);
        }

        /// <summary>
        /// Sort the list of player according to the stock of normal soju
        /// </summary>
        /// <param name="j1"></param>
        /// <param name="j2"></param>
        /// <returns></returns>
        static public int TriStockNormalSoju(Joueur j1, Joueur j2)
        {
            return j1.stockNormalSoju.CompareTo(j2.stockNormalSoju);
        }

        /// <summary>
        /// Sort the list of player according to the stock of premium soju
        /// </summary>
        /// <param name="j1"></param>
        /// <param name="j2"></param>
        /// <returns></returns>
        static public int TriStockPremiumSoju(Joueur j1, Joueur j2)
        {
            return j1.stockPremiumSoju.CompareTo(j2.stockPremiumSoju);
        }

        public int BottleToProduct(int number)
        {
            if (number < 0)
                number = 0;

            if (number > numberOfSalary * 16000)
                number = numberOfSalary * 16000;
            return number;
                
        }
    }
}
