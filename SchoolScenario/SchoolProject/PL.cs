using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    /* Presentation layer is only responsible with the user communication. Therefore, there should be 
     * no access to the database and also no access to the Data Layer.
     * In this class we should find all the Input and Output (Writelines & Readlines) which are found
     * in the project.
     * The PL shouldn't have any data validations the only accepted checks are checks related to method 
     * returns e.g. to check if there was an error so that the appropriate error handling technique can be
     * executed.
     * The Presentation layer should access the Business layer to pass and retrieve necessary data in the
     * most secure way.
     */
    class PL
    {
        static BL bl = new BL();
        static void Main(string[] args)
        {
            //bl.AddInitialData();
            Console.WriteLine(bl.StudentsInCourse(2));

            string editResult = bl.EditStudentName(3333, "Antoine");

            if (editResult != "")
                Console.WriteLine(editResult);

            Console.ReadKey();
        }
    }
}
