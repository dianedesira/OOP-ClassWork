using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    /* The Data Layer is responsible to access the database and to query the database and manipulating
     * data by adding, editing and deleting records. --> LINQ 
     */
    public class DL
    {
        public static SchoolDatabaseEntities db = new SchoolDatabaseEntities(); // connection to the database

        public void AddInitialData() // to be called once!!
        {/*
            Teacher teach1 = new Teacher(233999, "Andy Piscopo");
            Teacher teach2 = new Teacher(43389, "Kelly Zarb");

            //adding new objects / records to the Teachers DBSet which will then be mapped to the
            // Teacher table in our database
            db.Teachers.Add(teach1); db.Teachers.Add(teach2);
            // After adding, editing and deleting records, the db always needs to be saved.
            db.SaveChanges();
            */


            Course c1 = new Course(1, "BSc in Software Development", 233999);
            Course c2 = new Course(2, "BSc in Networking", 43389);
            Student s1 = new Student(7888, "Tim", "Cauchi", 1);
            Student s2 = new Student(4221, "Michela", "Borg", 1);
            Student s3 = new Student(38899, "Luke", "Bezzina", 2);
            Student s4 = new Student(2118, "Elena", "Desira", 2);

            db.Courses.Add(c1); db.Courses.Add(c2);
            db.Students.Add(s1); db.Students.Add(s2); db.Students.Add(s3); db.Students.Add(s4);
            //db.Students.AddRange(new List<Student> {s1, s2, s3, s4});
            db.SaveChanges();
        }

        public List<Student> StudentsInCourse(int courseID)
        {
            /*var studInCourse = from student in db.Students
                               where student.CourseID == courseID
                               select student;*/

             List<Student> studentList = new List<Student>( from student in db.Students
                                           where student.CourseID == courseID
                                           select student);

               return studentList;
             

            /* // just in case casting is not working properly  
              List<Student> studsToReturn = new List<Student>();

              foreach (var s in studInCourse)
              {
                  studsToReturn.Add(s);
              }

              return studsToReturn;*/

          //  return (List<Student>)studInCourse;
        }

        public Course ExistingCourseID(int courseID)
        {
            var checkCourseID = from course in db.Courses
                                where course.ID == courseID
                                select course;

            return checkCourseID.SingleOrDefault();
        }

        public Student ExistingStudentID(int studID)
        {
            var checkStudID = from stud in db.Students
                                where stud.ID == studID
                              select stud;

            return checkStudID.SingleOrDefault();
        }

        public void EditStudentName(int id, string nameToEdit)
        {
            Student stud = db.Students.SingleOrDefault(s => s.ID == id);

            stud.Name = nameToEdit;

            db.SaveChanges();
        }
    }
}
