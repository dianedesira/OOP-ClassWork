using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            Company airbus = new Company("Airbus", "Airbus", "Green", "White", "001", new Employee[5]);
            Company boeing = new Company("Boeing", "Boeing", "Red", "White", "002", new Employee[5]);
            SalariedEmployee se = new SalariedEmployee("001", "Elon", "Musk", 5000);
            HourlyEmployee he = new HourlyEmployee("002", "Joe", "Borg", 50, 25, 1.5);

            airbus.AddEmployee(se);
            boeing.AddEmployee(he);

            //airbus = null; // once I delete the company, its brand is also deleted.
            // however, its employees can be assigned to a different company
            boeing.AddEmployee(se);

            // convert from string to colour
            ConsoleColor cc = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), airbus.BrandColour);
            Console.ForegroundColor = cc;
            Console.WriteLine("Airbus Payroll");
            Console.WriteLine("==============");
            Console.WriteLine(airbus.ShowPayroll());
            Console.WriteLine();

            cc = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), boeing.BrandColour);
            Console.ForegroundColor = cc;
            Console.WriteLine("Boeing Payroll");
            Console.WriteLine("==============");
            Console.WriteLine(boeing.ShowPayroll());

            Console.WriteLine("Airbus Brand's Primary colour: " + airbus.Brand.PrimaryColour);

            Console.ReadKey();
        }
    }
}
