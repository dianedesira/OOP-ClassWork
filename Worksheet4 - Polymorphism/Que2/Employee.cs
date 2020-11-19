using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que2
{
    class Employee
    {
       // string name;
        double basePay; // (CTRL + R, E)

        public string Name  { get;  set;  }
        public double BasePay { get => basePay; set => basePay = value; }

        public Employee(string name, double basePay)
        {
            Name = name;
            this.basePay = basePay;
        }

        public virtual double TotalPay()
        {
            return basePay;
        }
    }
}
