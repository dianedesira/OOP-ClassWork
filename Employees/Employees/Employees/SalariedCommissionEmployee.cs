using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class SalariedCommissionEmployee : CommissionEmployee
    {
        double baseSalary;
        double bonusPercentage;

        public SalariedCommissionEmployee() : base()
        {
            baseSalary = 0;
            bonusPercentage = 0;
        }

        public SalariedCommissionEmployee(string pNi, string pName, string pSurname,
            double pSales, double pSalesCommissionPercentage,
            double pBaseSalary, double pBonusPercentage)
            : base(pNi, pName, pSurname, pSales, pSalesCommissionPercentage)
        {
            baseSalary = pBaseSalary;
            bonusPercentage = pBonusPercentage;
        }

        public override double GetSalary()
        {
            return baseSalary +
                (baseSalary * (bonusPercentage / 100)) +
                base.GetSalary();
        }

        public override string GetDetails()
        {
            return base.GetDetails() +
                ";Base Salary: " + baseSalary +
                ";Bonus (%): " + bonusPercentage;
        }
    }
}
