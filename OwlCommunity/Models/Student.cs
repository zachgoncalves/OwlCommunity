using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using OwlCommunity.Views;

namespace OwlCommunity.Models
{
    // Client inherits the data and methods in Person
    [Serializable()]
    public class Student : OwlMember
    {
        private string hiddenStudentMajor;
        private decimal hiddenStudentGPA;

        // Parameterless Constructor
        public Student()
        {
            hiddenStudentMajor = "";
            hiddenStudentGPA = 0.0m;

        } 


        // Parameterized Constructor
        public Student(string name, int id, DateTime dob, string m, decimal gpa) : base(id, name, dob)
        {
            hiddenStudentMajor = m;
            hiddenStudentGPA = gpa;
        } 


        // Accessor/mutator for job title
        public string studentMajor
        {
            get
            {
                return hiddenStudentMajor;
            } 
            set   // (string value)
            {
                hiddenStudentMajor = value;
            }  
        }  


        // Accessor/mutator for job title
        public decimal studentGPA
        {
            get
            {
                return hiddenStudentGPA;
            } 
            set   // (string value)
            {
                hiddenStudentGPA = value;
            }  
        }

        // Enable controls for object to be edited
        public override void Edit(MainForm f)
        {
            base.Edit(f);
            f.gbStudent.Enabled = true;
            f.txtStudentMajor.Enabled = true;
            f.txtStudentGPA.Enabled = true;
        }

        // Save data from form to object
        public override void Save(Views.MainForm f)
        {
            base.Save(f);
            hiddenStudentMajor = f.txtStudentMajor.Text;
            hiddenStudentGPA = Convert.ToDecimal(f.txtStudentGPA.Text);
        }


        // Display data in object on form
        public override void Display(Views.MainForm f)
        {
            base.Display(f);
            f.txtStudentMajor.Text = hiddenStudentMajor;
            f.txtStudentGPA.Text = hiddenStudentGPA.ToString();
        } 

        // This toString function overrides the Object toString
        //     function.  The base refers to Object because this class
        //     inherits Object by default.
        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "Student Info: " + hiddenStudentGPA + hiddenStudentGPA.ToString(); ;
            return s;
        }  

    }  
} 

