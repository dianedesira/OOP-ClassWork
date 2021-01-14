using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyEmployee
{
    class Employee
    {
        // attributes can only be private or protected
        protected string ni;
        protected string name;
        protected string surname;

        // properties
        public string NI
        {
            get { return ni; }
            set { ni = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public Employee()
        {
            ni = string.Empty;
            name = string.Empty;
            surname = string.Empty;
        }

        public Employee(string pNi, string pName, string pSurname)
        {
            ni = pNi;
            name = pName;
            surname = pSurname;
        }

        // methods
        // GetSalary() is declared as virtual only in the top-most class. Virtual means that this method will be overridden, i.e., its behaviour changed
        // in inheriting classes
        public virtual double GetSalary()
        {
            return 0;
        }

        public virtual string GetDetails()
        {
            //return string.Format("NI: {0}; Name: {1}; Surname: {2}", ni, name, surname);
            //return "NI:" + ni +"; Name: " + name + ";Surname: "+ surname;
            return "Basic:" + ni + ", " + name + " " + surname;
        }
    }
}
