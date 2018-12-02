using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwlCommunity.Classes
{
    public class OwlMemberDB
    {

        public OleDbDataReader SelectOwlMemberFromFaculty(int OwlMemberID, out bool OKFlag)
        {
            string strSelectOwlMember = "SELECT OWLMEMBER.fldID, OWLMEMBER.fldName, OWLMEMBER.fldBirthdate, "
                    + "FACULTY.fldDepartment, FACULTY.fldRank FROM OWLMEMBER "
                    + "INNER JOIN FACULTY ON FACULTY.fldID = OWLMEMBER.fldID "
                    + "WHERE FACULTY.fldID = " + OwlMemberID + ";";

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strSelectOwlMember, myConnection);
            OleDbDataReader myDataReader;

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                OKFlag = true; // returns true if Select was successful
            }
            catch (OleDbException ex)
            {
                Console.Write("There was a Select Faculty member error: " + ex.Message);
                myDataReader = null;
                myConnection.Close();
                OKFlag = false; // returns false if Select was unsuccessful
            }

            return myDataReader;
        }  // end SelectOwlMemberFromFaculty


        public OleDbDataReader SelectOwlMemberFromGraduateStudent(int OwlMemberID, out bool OKFlag)
        {
            string strSelectOwlMember = "SELECT OWLMEMBER.fldID, OWLMEMBER.fldName, OWLMEMBER.fldBirthdate, " + "STUDENT.fldMajor, STUDENT.fldGPA, "
                + "GRADUATESTUDENT.fldStipend, GRADUATESTUDENT.fldDegreeProgram FROM (OWLMEMBER "
                + "INNER JOIN STUDENT ON STUDENT.fldID = OWLMEMBER.fldID) "
                + "INNER JOIN GRADUATESTUDENT ON GRADUATESTUDENT.fldID = OWLMEMBER.fldID "
                + "WHERE OWLMEMBER.fldID = " + OwlMemberID + ";";

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strSelectOwlMember, myConnection);
            OleDbDataReader myDataReader;

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                OKFlag = true;
            }
            catch (OleDbException ex)
            {
                Console.Write("There was a Select Graduate Student error: " + ex.Message);
                myConnection.Close();
                myDataReader = null;
                OKFlag = false; // returns false if Select was unsuccessful
            }

            return myDataReader;
        } // end SelectOwlMemberFromGraduateStudent

    }
}
