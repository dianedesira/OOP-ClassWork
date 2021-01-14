using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class SalariedEmployee : Employee
    {
        double baseSalary;

        public SalariedEmployee() : base()
        {
            baseSalary = 0;
        }

        public SalariedEmployee(string pNi, string pName, string pSurname, double pBaseSalary) 
            : base(pNi, pName, pSurname)
        {
            baseSalary = pBaseSalary;
        }

        public override double GetSalary()
        {
            return baseSalary;
        }

        public override string GetDetails()
        {
            // accessing base class' attributes is problematic since there are private.
            // so we have to declare them as protected
            //return "NI:" + ni + "; Name: " + name + ";Surname: " + surname 
            //   + ";Base Salary: " + baseSalary;
            // use properties
            //return "NI:" + NI + "; Name: " + Name + ";Surname: " + Surname 
            //    + ";Base Salary: " + baseSalary;
            return base.GetDetails() + "; Base Salary: " + baseSalary;
                 
        }
    }
}
