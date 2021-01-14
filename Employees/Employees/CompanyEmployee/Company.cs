using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyEmployee
{
    class Company
    {
        Brand brand; // composition
        string vatNo;
        Employee[] employees; // aggregation

        public string BrandColour
        {
            get
            {
                return brand.PrimaryColour;
            }
        }

        public Company()
        {
            brand = new Brand(); // for a composition, the Brand is instantiated within the constructor
            vatNo = string.Empty;
            employees = new Employee[5];
        }

        public Company(string pName, string pSlogan, string pPrimaryColour, string pSecondaryColour, string pVatNo, Employee[] pEmployees)
        {
            brand = new Brand(pName, pSlogan, pPrimaryColour, pSecondaryColour);
            vatNo = pVatNo;
            employees = pEmployees;
        }

        // for an aggregation, provide a method that allows adding from the main program
        public void AddEmployee(Employee employee)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i] == null)
                {
                    employees[i] = employee;
                    break;
                }
            }
        }

        public void RemoveEmployee(Employee employee)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i] == null)
                {
                    if (employees[i].NI == employee.NI)
                    {
                        employees[i] = null;
                        break;
                    }
                }
            }
        }

        public string ShowPayroll()
        {
            string result = string.Empty;
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i] != null)
                {
                    result += employees[i].GetDetails() + "\nSalary: " + employees[i].GetSalary() + "\n\n";
                }
            }
            return result;
        }
    }
}
