using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyEmployee
{
    class HourlyEmployee : Employee
    {
        double hoursWorked;
        double payPerHour;
        double overtimeMultiplier; // e.g., 1.5

        public HourlyEmployee() : base()
        {
            hoursWorked = 0;
            payPerHour = 0;
            overtimeMultiplier = 0;
        }

        public HourlyEmployee(string pNi, string pName, string pSurname,
            double pHoursWorked, double pPayPerHour, double pOvertimeMultiplier)
            : base(pNi, pName, pSurname)
        {
            hoursWorked = pHoursWorked;
            payPerHour = pPayPerHour;
            overtimeMultiplier = pOvertimeMultiplier;
        }

        public override double GetSalary()
        {
            double result = 0;
            if (hoursWorked > 40)
            {
                double overtimeHours = hoursWorked - 40;
                result = overtimeHours * payPerHour * overtimeMultiplier;
                result += 40 * payPerHour;
            }
            else
            {
                result = hoursWorked * payPerHour;
            }
            return result;
        }

        public override string GetDetails()
        {
            return base.GetDetails() 
                + "; Hours Worked: " + hoursWorked 
                + "; Pay per Hour: " + payPerHour
                + "; Overtime Multiplier: " + overtimeMultiplier;
        }

    }
}
