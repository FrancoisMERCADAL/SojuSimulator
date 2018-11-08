using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SojuSimulator3000
{
    class Joueur
    {
        float money;
        int numberOfSalary;
        int numberOfMachin;
        int spendMarketing;
        string name;
        int stockNormalSoju;
        int stockPremiumSoju;
        Market market;
        public Joueur(string name, float money, Market market)
        {
            this.name = name;
            this.money = money;
            numberOfMachin = 0;
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
            money -= numberOfMachin * market.MaintenanceMachin;
            money -= numberOfNormalSoju * market.PriceIngredientsSojuNormal;
            money -= numberOfPremiumSoju * market.PriceIngredientsSojuPremium;
        }
        public void SellSoju(int sellNormalSoju, int sellPremiumSoju)
        {
            stockNormalSoju -= sellNormalSoju;
            stockPremiumSoju -= sellPremiumSoju;
            money += sellNormalSoju * market.PriceSellBottleSojuNormal;
            money += sellPremiumSoju * market.PriceSellBottleSojuPremium;
        }
        public void BuyANewMachin()
        {
            numberOfMachin++;
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
    }
}
