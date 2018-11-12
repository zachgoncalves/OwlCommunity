﻿using System;
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
        public OwlMember(int id, string n, DateTime bd)
        {
            hiddenName = n;
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


        // Save data from form to object
        public virtual void Save(Views.MainForm f)
        {
            hiddenName = f.txtOwlMemberName.Text;
            hiddenBirthDate = DateTime.Parse(f.txtOwlMemberBirthDate.Text);
            hiddenID = Convert.ToInt32(f.txtOwlMemberID.Text);
        }  // end Save


        // Display data in object on form
        public virtual void Display(Views.MainForm f)
        {
            f.txtOwlMemberName.Text = hiddenName;
            f.txtOwlMemberBirthDate.Text = hiddenBirthDate.ToShortDateString();
            f.txtOwlMemberID.Text = hiddenID.ToString();
        }  // end Display


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
