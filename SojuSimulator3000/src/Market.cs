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
        int fireWorker;//Cost to fire someone
        int salaryWorker;//Amount of money he will earn every month
        int maintenanceMachin;//Cost of machin every turn
        float priceIngredientsSojuNormal;
        List<int> estimationSojuNormalSell;
        public Market(int valueMachin, int fireWorker,int salaryWorker, int maintenanceMachin, float priceIngredientsSojuNormal)
        {
            estimationSojuNormalSell = new List<int>();
            this.valueMachin = valueMachin;
            this.fireWorker = fireWorker;
            this.salaryWorker = salaryWorker;
            this.maintenanceMachin = maintenanceMachin;
            this.priceIngredientsSojuNormal = priceIngredientsSojuNormal;
        }

        public int ValueMachin { get => valueMachin; set => valueMachin = value; }
        public int FireWorker { get => fireWorker; set => fireWorker = value; }
        public int SalaryWorker { get => salaryWorker; set => salaryWorker = value; }
        public int MaintenanceMachin { get => maintenanceMachin; set => maintenanceMachin = value; }
        public float PriceIngredientsSojuNormal { get => priceIngredientsSojuNormal; set => priceIngredientsSojuNormal = value; }
        public List<int> EstimationSojuNormalSell { get => estimationSojuNormalSell; set => estimationSojuNormalSell = value; }
    }
}
