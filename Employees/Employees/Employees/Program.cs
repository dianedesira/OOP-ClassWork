using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        static Employee[] employees = new Employee[5];

        static void AddToArray(Employee employee)
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

        static string ShowMainMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("----");
            Console.WriteLine("1.. Add Employee");
            Console.WriteLine("2.. Calculate Salary");
            Console.WriteLine("3.. Quit");
            Console.Write("Your choice: ");
            string choice = Console.ReadLine();
            return choice;
        }

        static string ShowEmployeeMenu()
        {
            Console.Clear();
            Console.WriteLine("Menu");
            Console.WriteLine("----");
            Console.WriteLine("1.. Salaried Employee");
            Console.WriteLine("2.. Hourly Employee");
            Console.Write("Your choice: ");
            string choice = Console.ReadLine();
            return choice;
        }

        static void AddSalariedEmployee()
        {
            Console.Clear();
            Console.Write("NI: ");
            string NI = Console.ReadLine();
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Surname: ");
            string surname = Console.ReadLine();
            Console.Write("Base Salary: ");
            double baseSalary = Convert.ToDouble(Console.ReadLine());
            SalariedEmployee salEmployee = new SalariedEmployee(NI, name, surname, baseSalary);
            AddToArray(salEmployee);
        }

        static void AddHourlyEmployee()
        {
            Console.Clear();
            Console.Write("NI: ");
            string NI = Console.ReadLine();
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Surname: ");
            string surname = Console.ReadLine();
            Console.Write("Hours Worked: ");
            double hoursWorked = Convert.ToDouble(Console.ReadLine());
            Console.Write("Pay per Hour: ");
            double payPerHour = Convert.ToDouble(Console.ReadLine());
            Console.Write("Overtime Multiplier: ");
            double overtimeMultiplier = Convert.ToDouble(Console.ReadLine());
            HourlyEmployee houEmployee = new HourlyEmployee(NI, name, surname, hoursWorked, payPerHour, overtimeMultiplier);
            AddToArray(houEmployee);
        }

        static void ShowDetails()
        {
            Console.Clear();
            Console.WriteLine("Current Employees");
            Console.WriteLine("-----------------");
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i] != null)
                    Console.WriteLine(employees[i].GetDetails());
            }
            Console.WriteLine();
        }

        static void CalculateSalary()
        {
            Console.Clear();
            Console.WriteLine("Payroll");
            Console.WriteLine("-------");
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i] != null)
                {
                    if (employees[i] is SalariedEmployee)
                        Console.WriteLine("Salaried Employee "+ employees[i].Name + " " + employees[i].Surname 
                            + "\t" + employees[i].GetSalary());
                    else if (employees[i] is HourlyEmployee)
                        Console.WriteLine("Hourly Employee " + employees[i].Name + " " + employees[i].Surname 
                            + "\t" + employees[i].GetSalary());
                }
                    
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            //Employee e = new Employee("001", "Joe", "Borg");
            //Console.WriteLine(e.GetDetails());
            //SalariedEmployee e2 = new SalariedEmployee("001", "Joe", "Borg",3000);
            //Console.WriteLine(e2.GetDetails());
            //Console.ReadKey();


            string choice = string.Empty;
            do
            {
                ShowDetails();
                choice = ShowMainMenu();
                if (choice == "1") // Add Employee
                {
                    string employeeTypeChoice = ShowEmployeeMenu();
                    if (employeeTypeChoice == "1")
                        AddSalariedEmployee();
                    else if (employeeTypeChoice == "2")
                        AddHourlyEmployee();
                }
                else if (choice == "2") // Calculate Salary
                {
                    CalculateSalary();
                }
                Console.WriteLine();
                Console.WriteLine("Press any key...");
                Console.ReadLine();
            } while (choice != "3");

        }
    }
}
