using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm
{
    class Student
    {
        private string name;
        private int idNumber;
        private double gpa;
        private List<CourseCompleted> coursesTaken;


        public Student()
        {
            name = null;
            idNumber = 0;
            coursesTaken = new List<CourseCompleted>();
        }

        public Student(string _name, int _idNumber)
        {
            Name = _name;
            IdNumber = _idNumber;
            coursesTaken = new List<CourseCompleted>();
        }


        public string Name
        {
            get { return name; }
            set
            {
                if(name != "")
                {
                    name = value;
                }
            }
        }

        public int IdNumber
        {
            get { return idNumber; }
            set
            {
                if(value > 0)
                {
                    idNumber = value;
                } 
            }
        }


        public void addCourse(string _courseNumber, string _courseName, int _credits,
                       string _grade, string _semester, int _year)
        {
            CourseCompleted newCourseCompleted = new CourseCompleted(_courseNumber, _courseName, _credits,
                       _grade, _semester, _year);
            coursesTaken.Add(newCourseCompleted);
        }

        public double getGpa()
        {
            int totalPoints = 0;
            int totalCredits = 0;

            for (int ndx = 0; ndx < coursesTaken.Count; ndx++)
            {
                totalPoints += coursesTaken[ndx].getPoints();
            }

            for (int ndx = 0; ndx < coursesTaken.Count; ndx++)
            {
                totalCredits += coursesTaken[ndx].CourseTaken.Credits;
            }

            gpa =  (double)totalPoints / (double)totalCredits;

            gpa = Math.Round(gpa, 2);

            return gpa;
        }

    }
}
