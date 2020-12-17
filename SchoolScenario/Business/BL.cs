using Data;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    /* Business Layer is responsible for the data validations and logical executions. There should be
     * no input and output and also no direct access to the database (and no queries).
     * The Business Layer will be accessed by the Presentation layer and the BL should be able to access
     * the Data Layer.
     */
    public class BL
    {
        static DL dl = new DL();

        public void AddInitialData()
        {
            dl.AddInitialData();
        }

        public string StudentsInCourse(int courseID)
        {
            if (dl.ExistingCourseID(courseID) != null)
            {
                string result = "Students in Course " + courseID;
                foreach (Student s in dl.StudentsInCourse(courseID))
                {
                    result += "\nName: " + s.Name + " " + " Surname: " + s.Surname;
                }
                return result;
            }

            return "Course does not exist!";
        }

        public string EditStudentName(int id, string newName)
        {
            if (dl.ExistingStudentID(id) != null)
            {
                dl.EditStudentName(id, newName);
                return "";
            }
            else
                return "ID does not exist!";
        }

    }
}
