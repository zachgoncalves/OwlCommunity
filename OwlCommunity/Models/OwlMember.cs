﻿/* Temple University
 * Component Based Software Design (CIS 3309) 
 * Project 4: OwlCommunity
 * Class: OwlMember
 * Written by: Zachary Goncalves, with code provided by Professor Frank Friedman
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;

namespace OwlCommunity.Models
{
    [Serializable()]
    public abstract class OwlMember
    {
        private int hiddenID;
        private string hiddenName;
        private DateTime hiddenBirthDate;


        // Parameterless Constructor
        public OwlMember()
        {
            hiddenID = 0;
            hiddenName = "";
            hiddenBirthDate = DateTime.Now;
        }

        // Parameterized Constructor
        public OwlMember(int id, string name, DateTime bd)
        {
            hiddenName = name;
            hiddenBirthDate = bd;
            hiddenID = id;
        }


        // Accessor/Mutator for id
        public int owlID
        {
            get
            {
                return hiddenID;
            }
            set   // (string value)
            {
                hiddenID = value;
            }
        }


        // Accessor/mutator for name
        public string OwlName
        {
            get
            {
                return hiddenName;
            }
            set   // (string value)
            {
                hiddenName = value;
            }
        }


        // Accessor/mutator for birth date
        public DateTime owlBirthDate
        {
            get
            {
                return hiddenBirthDate;
            }
            set   // (DateTime value)
            {
                hiddenBirthDate = value;
            }
        }

        // Enable controls for the object to be edited 
        public virtual void Edit(Views.MainForm f)
        {
            f.gbOwlMember.Enabled = true;
            f.txtMemberID.Enabled = true;
            f.txtMemberName.Enabled = true;
            f.dtBD.Enabled = true;
        }

        // Save data from form to object
        public virtual void Save(Views.MainForm f)
        {
            hiddenName = f.txtMemberName.Text;
            hiddenBirthDate = f.dtBD.Value;
            hiddenID = Convert.ToInt32(f.txtMemberID.Text);
        }  // end Save


        // Display data in object on form
        public virtual void Display(Views.MainForm f)
        {
            f.txtMemberName.Text = hiddenName;
            f.dtBD.Value = hiddenBirthDate;
            f.txtMemberID.Text = hiddenID.ToString();
        } 


        // This toString function overrides the Object toString function
        // The base refers to Object because this class inherits Object by default
        public override string ToString()
        {
            string s = "ObjectType       : " + base.ToString() + "\n";
            s += "OwlName     : " + hiddenName + "\n";
            s += "OwlBirthDate: " + hiddenBirthDate.ToShortDateString() + "\n";
            s += "OwlID       :" + hiddenID;
            return s;
        }
    }
}

