using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Jean", 30000);
            Employee emp2 = new Employee("Elena", 45000);
            SalesEmployee emp3 = new SalesEmployee("Mark", 35000, 3000);
            SalesEmployee emp4 = new SalesEmployee("Christine", 32000, 2000);

            List<Employee> employees = new List<Employee>();
            employees.AddRange(new List<Employee> { emp1, emp2, emp3, emp4 });

            Console.WriteLine("All Employees' salaries:\n");
            foreach (Employee emp in employees)
            {
                Console.WriteLine("Total salary for " + emp.Name + " is " + emp.TotalPay());
            }

            Console.ReadKey();
        }
    }
}
