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


        // Save data from form to object
        public virtual void Save(Views.MainForm f)
        {
            hiddenName = f.txtMemberName.Text;
        //    hiddenBirthDate = DateTime.Parse(f.txtMemberBD.Text);
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

