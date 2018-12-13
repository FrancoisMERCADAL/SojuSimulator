using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SojuSimulator3000
{
    public class Machin
    {
        int maxSalary;
        int maxProduction;
        int salaryCurrent;
        int priceMaintenance;
        public Machin(int maxSalary, int maxProduction, int priceMaintenance)
        {
            this.maxProduction = maxProduction;
            this.maxSalary = maxSalary;
            this.salaryCurrent = 0;
            this.priceMaintenance = priceMaintenance;
        }

        public int MaxSalary { get => maxSalary; set => maxSalary = value; }
        public int MaxProduction { get => maxProduction; set => maxProduction = value; }
        public int SalaryCurrent { get => salaryCurrent; set => salaryCurrent = value; }
        public int PriceMaintenance { get => priceMaintenance; set => priceMaintenance = value; }
    }
}
