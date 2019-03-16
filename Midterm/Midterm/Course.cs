using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class Course
    {
        // -----------------------------------------------------------
        // Instance Data
        // ----------------------------------------------------------
        private string courseNumber;
        private string courseName;
        private int credits;

        // -----------------------------------------------------------
        // Default constructor
        // -----------------------------------------------------------
        public Course()
        {
            courseNumber = null;
            courseName = null;
            credits = 0;
        }

        // -----------------------------------------------------------
        // Overloaded constructor
        // -----------------------------------------------------------
        public Course(string _courseNumber, string _courseName,
                   int _credits)
        {
            CourseNumber = _courseNumber;
            CourseName = _courseName;
            Credits = _credits;
        }

        // -----------------------------------------------------------
        // Course Number property
        // -----------------------------------------------------------
        public string CourseNumber
        {
            get { return courseNumber; }
            set
            {
                if (value.Trim() != string.Empty)
                {
                    courseNumber = value;
                }
            }
        }

        // -----------------------------------------------------------
        // Course Name Property
        // -----------------------------------------------------------
        public string CourseName
        {
            get { return courseName; }
            set
            {
                if (value.Trim() != string.Empty)
                {
                    courseName = value;
                }
            }
        }

        // -----------------------------------------------------------
        // Credits Property
        // -----------------------------------------------------------
        public int Credits
        {
            get { return credits; }
            set
            {
                if (value > 0)
                {
                    credits = value;
                }
            }
        }
    }
}


