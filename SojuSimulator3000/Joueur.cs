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
        Market market;

        public string Name { get => name; set => name = value; }
        public float Money { get => money; set => money = value; }
        public int NumberOfSalary { get => numberOfSalary; set => numberOfSalary = value; }
        public List<Machin> NumberOfMachin { get => numberOfMachin; set => numberOfMachin = value; }

        public Joueur(string name, float money, Market market)
        {
            this.name = name;
            this.money = money;
            numberOfMachin = new List<Machin>();
            numberOfSalary = 0;
            stockNormalSoju = 0;
            stockPremiumSoju = 0;
            this.market = market;
        }
        public void ProductSoju(int numberOfNormalSoju, int numberOfPremiumSoju)
        {
            stockNormalSoju += numberOfNormalSoju;
            stockPremiumSoju += numberOfPremiumSoju;
            money -= numberOfSalary * market.SalaryWorker;
            for(int i =0;i<numberOfMachin.Count;i++)
                money -= numberOfMachin[i].PriceMaintenance;
            money -= numberOfNormalSoju * market.PriceIngredientsSojuNormal;
            money -= numberOfPremiumSoju * market.PriceIngredientsSojuPremium;
        }
        public void SellSoju(int sellNormalSoju, int sellPremiumSoju)
        {
            stockNormalSoju -= sellNormalSoju;
            stockPremiumSoju -= sellPremiumSoju;
            money += sellNormalSoju * priceSellBottleSojuNormal;
            money += sellPremiumSoju * priceSellBottleSojuPremium;
        }
        public void BuyANewMachinClassic()
        {
            numberOfMachin.Add(new Machin(5,2000,1000));
            money -= market.ValueMachin;
        }
        public void HireNewSalary()
        {
            numberOfSalary++;
            money -= market.HireWorker;
        }
        public void FireSalary()
        {
            numberOfSalary--;
            money -= market.FireWorker;
        }
        public int CompareTo(Joueur autre)
        {
            int val = 0;
            if (this.money.CompareTo(autre.money) < 0)
                val = -1;
            if (this.money.CompareTo(autre.money) > 0)
                val = 1;
            return val;

        }
    }
}
