using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            Student newStudent = new Student("Billy Joe Bob", 555555);

            newStudent.addCourse("2222", "calculusI", 4, "A", "2", 2012);
            newStudent.addCourse("2222", "calculusII", 3, "A", "2", 2013);
            newStudent.addCourse("2222", "calculusIII", 4, "A", "2", 2014);
            newStudent.addCourse("2222", "calculusIIII", 4, "B", "2", 2014);

            displayTextBox.Text = newStudent.Name + "\r\n";
            displayTextBox.Text += newStudent.IdNumber + "\r\n";
            displayTextBox.Text += "gpa = " + newStudent.getGpa();
            //displayTextBox.Text += String.Format("gpa = {0:0.00}", newStudent.getGpa());
        }
    }
}
