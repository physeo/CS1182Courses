using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class CourseCompleted
    {
        // -----------------------------------------------------------
        // Valid letter grades
        // -----------------------------------------------------------
        private const string GRADE_LIST = "FDCBA";

        // -----------------------------------------------------------
        // Instance data
        // -----------------------------------------------------------
        private Course courseTaken;
        private string grade;
        private string semester;
        private int year;

        // -----------------------------------------------------------
        // Default constructor
        // -----------------------------------------------------------
        public CourseCompleted()
        {
            courseTaken = new Course();
            grade = null;
            semester = null;
            year = 0;
        }

        // -----------------------------------------------------------
        // Overloaded constructor
        // -----------------------------------------------------------
        public CourseCompleted(string courseNumber, string courseName, int credits,
                       string _grade, string _semester, int _year)
        {
            courseTaken = new Course(courseNumber, courseName, credits);
            Grade = _grade;
            Semester = _semester;
            Year = _year;
        }

        // -----------------------------------------------------------
        // Readonly Property for courseTaken
        // -----------------------------------------------------------
        public Course CourseTaken
        {
            get { return courseTaken; }
        }



        // -----------------------------------------------------------
        // Grade Property
        // -----------------------------------------------------------
        public string Grade
        {
            get { return grade; }
            set
            {
                if (GRADE_LIST.IndexOf(value.ToUpper()) >= 0)
                {
                    grade = value;
                }
                else
                {
                    grade = "F";
                }
            }
        }

        // -----------------------------------------------------------
        // Semester Property
        // -----------------------------------------------------------
        public string Semester
        {
            get { return semester; }
            set
            {
                if (value.Trim() != string.Empty)
                {
                    semester = value;
                }
            }
        }

        // -----------------------------------------------------------
        // Year Property - First course was taken in 1901
        // -----------------------------------------------------------
        public int Year
        {
            get { return year; }
            set
            {
                if (value > 1900 && value < DateTime.Now.Year)
                {
                    year = value;
                }
            }
        }

        // -----------------------------------------------------------
        // Member method to return the number of points for the given grade
        // -----------------------------------------------------------
        public int getPoints()
        {
            int points = GRADE_LIST.IndexOf(grade) * CourseTaken.Credits;

            return points;
        }
    }   

}
