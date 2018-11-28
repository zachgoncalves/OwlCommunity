using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OwlCommunity.Views;

namespace OwlCommunity.Models
{
    [Serializable()]

    public class GraduateStudent : Student
    {
        private decimal stipend;
        private string degreeProgram;

        public GraduateStudent()
        {
            stipend = 0;
            degreeProgram = "";
        }

        public GraduateStudent(string name, int id, DateTime dob, string major, decimal gpa,
            decimal stip, string dp) : base (name, id, dob, major, gpa)
        {
            stipend = stip;
            degreeProgram = dp;
        }
        // Getter and setter for Stipend
        public decimal Stipend
        {
            get {
                return stipend;
            }
            set {
                stipend = value;
            }
        }

        // Getter and setter for degreeProgram
        public string DegreePrime
        {
            get
            {
                return degreeProgram;
            }
            set
            {
                degreeProgram = value;
            }
        }

        // Enable controls on form to edit object
        public override void Edit(MainForm f)
        {
            base.Edit(f);
            f.gbGraduate.Enabled = true;
            f.txtGradStipend.Enabled = true;
            f.cbProgram.Enabled = true;
        }
        // Save data from form to object
        public override void Save(Views.MainForm f)
        {
            base.Save(f);
            stipend = Convert.ToDecimal(f.txtGradStipend.Text);
            degreeProgram = f.cbProgram.SelectedItem.ToString();
        
        }

        // Display data in object on form
        public override void Display(Views.MainForm f)
        {
            base.Display(f);
            f.txtGradStipend.Text = stipend.ToString();
            f.cbProgram.Text = degreeProgram;
        }

        // This toString function overrides the Object toString
        //     function.  The base refers to Object because this class
        //     inherits Object by default.
        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "Graduate Student Info: " + "\n";
            s += "Stipend: " + stipend.ToString() + "\n";
            s += "Program: " + degreeProgram;
            return s;
        }
    }
}
