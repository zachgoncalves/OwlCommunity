/* Temple University
 * Component Based Software Design (CIS 3309) 
 * Project 4: OwlCommunity
 * Class: FacultyChairperson
 * Written by: Zachary Goncalves
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OwlCommunity.Views;

namespace OwlCommunity.Models
{
    [Serializable()]
    public class FacultyChairperson : FacultyMember
    {
        private decimal stipend;

        // Parameterless Constructor 
        public FacultyChairperson()
        {
            stipend = 0;
        }

        // Parameterized Consutrctor 
        public FacultyChairperson(string name, int id, DateTime dob, string rank, 
            string department, decimal chairStipend ) : base (name, id, dob, department, rank)
        {
            stipend = chairStipend;
        }

        // Getter and Setter for Stipend
        public decimal Stipend
        {
            get
            {
                return stipend;
            }
            set
            {
                stipend = value;
            }
        }

        // Enable controls on form to edit object
        public override void Edit(MainForm f)
        {
            base.Edit(f);
            f.gbChair.Enabled = true;
            f.txtChairStipend.Enabled = true;
        }

        // Save data from form to object
        public override void Save(Views.MainForm f)
        {
            base.Save(f);
            stipend = Convert.ToDecimal(f.txtChairStipend.Text);
        }

        // Display data in object on form
        public override void Display(Views.MainForm f)
        {
            base.Display(f);
            f.txtChairStipend.Text = stipend.ToString();
        }

        // This toString function overrides the Object toString function
        // The base refers to Object because this class inherits Object by default
        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "Chairperson Info: " + "\n";
            s += "Stupend: " + stipend.ToString() + "\n";
            return s;
        }

    }
}
