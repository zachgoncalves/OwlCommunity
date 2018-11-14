using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwlCommunity.Models
{
    class UndergraduateStudent : Student
    {
        private decimal studentTuition;
        private int studentCredits;
        private string studentYear;

        // Default Constructor
        public UndergraduateStudent()
        {
            studentTuition = 0;
            studentCredits = 0;
            studentYear = "";
        }

        // Constructor that sets attributes 
        public UndergraduateStudent(int id, string name, DateTime dob, decimal gpa, string major, 
            decimal tuition, int credits, string year) : base(name, id, dob, major, gpa)
        {
            studentTuition = tuition;
            studentCredits = credits;
            studentYear = year;
        }

        // Get and Set Student Tuition
        public decimal StudentTuition
        {
            get {
                return studentTuition;
            }
            set {
                studentTuition = value;
            }
        }

        // Get and Set Credits
        public int StudentCredits
        {
            get
            {
                return studentCredits;
            }
            set
            {
                studentCredits = value;
            }
        }

        // Get and Set Student Class Year 
        public string StudentYear
        {
            get
            {
                return studentYear;
            }
            set
            {
                studentYear = value;
            }
        }

        // Save data from form to object
        public override void Save(Views.MainForm f)
        {
            base.Save(f);
            studentTuition = Convert.ToDecimal(f.txtStudentTuition.Text);
            studentCredits = Convert.ToInt32(f.txtStudentCredits.Text);
            studentYear = f.cbYear.SelectedItem.ToString();
        }


        // Display data in object on form
        public override void Display(Views.MainForm f)
        {
            base.Display(f);
            f.txtStudentTuition.Text = studentTuition.ToString();
            f.txtStudentGPA.Text = studentGPA.ToString();
            f.txtStudentCredits.Text = studentCredits.ToString();
        }

        // This toString function overrides the Object toString
        //     function.  The base refers to Object because this class
        //     inherits Object by default.
        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "Undergraduate Student Info: " + "Tuition: " + studentTuition.ToString() + "Credits: " + studentCredits.ToString() + "Year: " + studentYear;
            return s;
        }
    }
}
