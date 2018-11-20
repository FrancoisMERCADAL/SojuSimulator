using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SojuSimulator3000
{
    public class Market
    {
        int valueMachin;//Cost to buy a new machin
        int hireWorker;//Cost to hire someone
        int fireWorker;//Cost to fire someone
        int salaryWorker;//Amount of money he will earn every month
        int maintenanceMachin;//Cost of machin every turn
        float priceIngredientsSojuNormal;
        float priceIngredientsSojuPremium;
        List<int> estimationSojuNormalSell;
        List<int> estimationSojuPremiumSell;
        public Market(int valueMachin, int hireWorker, int fireWorker,int salaryWorker, int maintenanceMachin, float priceIngredientsSojuNormal, float priceIngredientsSojuPremium)
        {
            estimationSojuNormalSell = new List<int>();
            estimationSojuPremiumSell = new List<int>();
            this.valueMachin = valueMachin;
            this.hireWorker = hireWorker;
            this.fireWorker = fireWorker;
            this.salaryWorker = salaryWorker;
            this.maintenanceMachin = maintenanceMachin;
            this.priceIngredientsSojuNormal = priceIngredientsSojuNormal;
            this.priceIngredientsSojuPremium = priceIngredientsSojuPremium;
        }

        public int ValueMachin { get => valueMachin; set => valueMachin = value; }
        public int HireWorker { get => hireWorker; set => hireWorker = value; }
        public int FireWorker { get => fireWorker; set => fireWorker = value; }
        public int SalaryWorker { get => salaryWorker; set => salaryWorker = value; }
        public int MaintenanceMachin { get => maintenanceMachin; set => maintenanceMachin = value; }
        public float PriceIngredientsSojuNormal { get => priceIngredientsSojuNormal; set => priceIngredientsSojuNormal = value; }
        public float PriceIngredientsSojuPremium { get => priceIngredientsSojuPremium; set => priceIngredientsSojuPremium = value; }
        public List<int> EstimationSojuNormalSell { get => estimationSojuNormalSell; set => estimationSojuNormalSell = value; }
        public List<int> EstimationSojuPremiumSell { get => estimationSojuPremiumSell; set => estimationSojuPremiumSell = value; }
    }
}
