using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que2
{
    class SalesEmployee : Employee
    {
        double salesBonus;

        public double SalesBonus { get; set; }

        public SalesEmployee(string name, double basePay, double salesBonus) :
            base(name, basePay)
        {
            this.salesBonus = salesBonus;
        }

        public override double TotalPay()
        {
            return (base.TotalPay() + salesBonus);
        }
            
    }
}
