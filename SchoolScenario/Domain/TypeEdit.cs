using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class TypeEdit
    {
    }

    public partial class Teacher
    {
        public Teacher(int id, string teacherName)
        {
            ID = id;
            TeacherName = teacherName;
        }
    }

    public partial class Course
    {
        public Course(int id, string name, int teacherID)
        {
            ID = id;
            CourseName = name;
            TeacherID = teacherID;
        }
    }

    public partial class Student
    {
        public Student()
        { }
        public Student(int id, string name, string surname, int courseID)
        {
            ID = id;
            Name = name;
            Surname = surname;
            CourseID = courseID;
        }
    }
}
