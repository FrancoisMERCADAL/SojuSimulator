using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SojuSimulator3000
{
    class Market
    {
        int valueMachin;//Cost to buy a new machin
        int hireWorker;//Cost to hire someone
        int fireWorker;//Cost to fire someone
        int salaryWorker;//Amount of money he will earn every month
        int maintenanceMachin;//Cost of machin every turn
        float priceIngredientsSojuNormal;
        float priceIngredientsSojuPremium;
        float priceSellBottleSojuNormal;
        float priceSellBottleSojuPremium;
        public Market(int valueMachin, int hireWorker, int fireWorker,int salaryWorker, int maintenanceMachin, float priceIngredientsSojuNormal, float priceIngredientsSojuPremium, float priceSellBottleSojuNormal, float priceSellBottleSojuPremium)
        {
            this.valueMachin = valueMachin;
            this.hireWorker = hireWorker;
            this.fireWorker = fireWorker;
            this.salaryWorker = salaryWorker;
            this.maintenanceMachin = maintenanceMachin;
            this.priceIngredientsSojuNormal = priceIngredientsSojuNormal;
            this.priceIngredientsSojuPremium = priceIngredientsSojuPremium;
            this.priceSellBottleSojuNormal = priceSellBottleSojuNormal;
            this.priceSellBottleSojuPremium = priceSellBottleSojuPremium;
        }

        public int ValueMachin { get => valueMachin; set => valueMachin = value; }
        public int HireWorker { get => hireWorker; set => hireWorker = value; }
        public int FireWorker { get => fireWorker; set => fireWorker = value; }
        public int SalaryWorker { get => salaryWorker; set => salaryWorker = value; }
        public int MaintenanceMachin { get => maintenanceMachin; set => maintenanceMachin = value; }
        public float PriceIngredientsSojuNormal { get => priceIngredientsSojuNormal; set => priceIngredientsSojuNormal = value; }
        public float PriceIngredientsSojuPremium { get => priceIngredientsSojuPremium; set => priceIngredientsSojuPremium = value; }
        public float PriceSellBottleSojuNormal { get => priceSellBottleSojuNormal; set => priceSellBottleSojuNormal = value; }
        public float PriceSellBottleSojuPremium { get => priceSellBottleSojuPremium; set => priceSellBottleSojuPremium = value; }
    }
}
