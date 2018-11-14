using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwlCommunity.Models
{
    class UndergraduateStudent : Student
    {
        private int studentTuition;
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
        public UndergraduateStudent(int tuition, int credits, string year)
        {
            studentTuition = tuition;
            studentCredits = credits;
            studentYear = year;
        }

        // Get and Set Student Tuition
        public int StudentTuition
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
    }
}
