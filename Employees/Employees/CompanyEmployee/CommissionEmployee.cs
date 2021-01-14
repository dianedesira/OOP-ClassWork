using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyEmployee
{
    class CommissionEmployee : Employee
    {
        protected double sales;
        protected double salesCommissionPercentage;

        public CommissionEmployee() : base()
        {
            sales = 0;
            salesCommissionPercentage = 0;
        }

        public CommissionEmployee(string pNi, string pName, string pSurname,
            double pSales, double pSalesCommissionPercentage)
            : base(pNi, pName, pSurname)
        {
            sales = pSales;
            salesCommissionPercentage = pSalesCommissionPercentage;
        }

        public override double GetSalary()
        {
            // assume salesCommissionPercentage 10%
            return sales * (salesCommissionPercentage / 100);
        }

        public override string GetDetails()
        {
            return base.GetDetails()
                + "; Sales: " + sales
                + "; Sales Commission (%): " + salesCommissionPercentage;
        }
    }
}
