﻿/* Temple University
 * Component Based Software Design (CIS 3309) 
 * Project 4: OwlCommunity
 * Class: FacultyMember
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
    public class FacultyMember : OwlMember
    {
        private string department;
        private string rank;

        // Parameterless Constructor 
        public FacultyMember()
        {
            department = "";
            rank = "";
        }

        // Parameterized Constructor
        public FacultyMember(string name, int id, DateTime dob, string dept, string facultyRank) : base (id, name, dob)
        {
            department = dept;
            rank = facultyRank;
        }

        // Getter and Setter for Department
        public string Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }
        
        // Getter and Setter for Rank
        public string Rank
        {
            get
            {
                return rank;
            }
            set
            {
                rank = value;
            }
        }

        // Enable controls on form to edit object
        public override void Edit(MainForm f)
        {
            base.Edit(f);
            f.gbFaculty.Enabled = true;
            f.txtFacultyDept.Enabled = true;
            f.cbRank.Enabled = true;
        }

        // Save data from form to object
        public override void Save(Views.MainForm f)
        {
            base.Save(f);
            rank = f.cbRank.SelectedItem.ToString();
            department = f.txtFacultyDept.Text;
        }

        // Display data in object on form
        public override void Display(Views.MainForm f)
        {
            base.Display(f);
            f.cbRank.Text = rank.ToString();
            f.txtFacultyDept.Text = department;
        } 


        // This toString function overrides the Object toString function
        // The base refers to Object because this class inherits Object by default
        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "Faculty Info: " + "\n";
            s += "Rank      : " + rank + "\n";
            s += "Department : " + department;
            return s;
        }

    }
}
