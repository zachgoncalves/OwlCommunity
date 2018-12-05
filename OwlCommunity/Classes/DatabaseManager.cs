using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using OwlCommunity.Models;
using System.Data;

namespace OwlCommunity.Classes
{
    public class DatabaseManager
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["OwlCommunity.Properties.Settings.OwlMemberConnectionString"].ConnectionString;
        private string InsertIntoOwlMember = "INSERT INTO OwlMember (ID, FULL_NAME, BIRTHDATE) VALUES ('','')";

        public void selectUGStudent(int OwlMemberID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand selectUGStudent = new SqlCommand(
                    "SELECT ID, FULL_NAME, BIRTHDATE, Major, GPA, Tuition, Year, Credits " +
                    "FROM dbo.Undergraduate_Student" +
                    "JOIN OwlMember USING (ID)" +
                    "JOIN Student USING (ID)" +
                    "WHERE ID = " + OwlMemberID +
                    ";", connection);
            }
        }

        public void insertUGStudent(string Name, int OwlMemberID, DateTime BD, decimal GPA, string Major, decimal Tuition, int Credits, string Year)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand insertIntoOwlMember = new SqlCommand(
                    "INSERT INTO OwlMember VALUES (@ID, @Name, @BD);"
                ,connection);
            
                insertIntoOwlMember.Parameters.AddWithValue("@Name", Name);
                insertIntoOwlMember.Parameters.AddWithValue("@ID", OwlMemberID);
                insertIntoOwlMember.Parameters.AddWithValue("@BD", BD);

                SqlCommand insertIntoStudent = new SqlCommand(
                    "INSERT INTO Student VALUES (@ID, @GPA, @Major);"
                ,connection);

                insertIntoStudent.Parameters.AddWithValue("@ID", OwlMemberID);
                insertIntoStudent.Parameters.AddWithValue("@GPA", GPA);
                insertIntoStudent.Parameters.AddWithValue("@Major", Major);

                SqlCommand insertIntoUndergraduateStudent = new SqlCommand(
                    "INSERT INTO Undergraduate_Student VALUES (@ID, @Tuition, @Year, @Credits);"
                ,connection);

                insertIntoUndergraduateStudent.Parameters.AddWithValue("@ID", OwlMemberID);
                insertIntoUndergraduateStudent.Parameters.AddWithValue("@Tuition", Tuition);
                insertIntoUndergraduateStudent.Parameters.AddWithValue("@Credits", Credits);
                insertIntoUndergraduateStudent.Parameters.AddWithValue("@Year", Year);

                try
                {

                    connection.Open();
                    insertIntoOwlMember.ExecuteNonQuery();
                    insertIntoStudent.ExecuteNonQuery();
                    insertIntoUndergraduateStudent.ExecuteNonQuery();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show("It failed!" + "\n" + Ex.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        /*
        public void displayDbInformation(OwlMember p)
        {
            bool successFlag;
            if (p == null)
            {
                MessageBox.Show("Owl p reference is null. System Error. Reenter ID.",
                          "displayDbInformation Reference Error", MessageBoxButtons.OK);
                txtOwlMemberID.Text = "";
                txtOwlMemberID.Focus();
            }  // end p == null if

            OleDbDataReader myDataReader;
            string dbStringOwl = " ";
            string dbStringRest = " ";

            if (p.GetType() == typeof(FacultyMember))     // Process Faculty
            {
                myDataReader = dbFunctions.SelectOwlMemberFromFaculty
                                 (Convert.ToInt32(txtOwlMemberID.Text), out successFlag);
                if (myDataReader == null)
                {
                    MessageBox.Show("On Faculty Select, null returned. No match found. DB and Serializable File not synched.  Reenter ID",
                            "Faculty SELECT Error", MessageBoxButtons.OK);
                    // this.Close();
                    txtOwlMemberID.Text = "";
                    txtOwlMemberID.Focus();
                }
                else
                {
                    myDataReader.Read();
                    if (!myDataReader.HasRows)
                    {
                        MessageBox.Show("Select Faculty produced no rows. No match found. DB and Serializable File not synched. Reenter ID.", "Faculty SELECT Error", MessageBoxButtons.OK);
                        txtOwlMemberID.Text = "";
                        txtOwlMemberID.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Faculty record found and read.  ", "Faculty Record Found", MessageBoxButtons.OK);
                        try
                        {
                            dbStringOwl = myDataReader[0].ToString() + "   " + myDataReader[1].ToString() + "   ";
                            dbStringOwl = dbStringOwl + ((DateTime)myDataReader[2]).ToString("MM/dd/yyyy") + Environment.NewLine;
                            dbStringRest = "   " + myDataReader[3].ToString() + "   " + myDataReader[4].ToString();
                        }
                        catch
                        {
                            MessageBox.Show("DataReader Faculty Data Conversion Error. Reenter ID. ", "Faculty SELECT Error", MessageBoxButtons.OK);
                            txtOwlMemberID.Text = "";
                            txtOwlMemberID.Focus();
                        }  // end try-catch
                    }  // end else on myDataReader HasRows
                }  // end else on myDataReader == null
            }  // end processing Faculty

            else if (p.GetType() == typeof(Chairperson))     // Process Chairperson
            {

          . . . code to process Chairperson goes here
     
       }  // end processing Chairperson 

            else if (p.GetType() == typeof(UndergraduateStudent))     // Process Undergrad
            {	

        . . . code to process UndergraduateStudent goes here
     
       }  // end Processing Undergrad

            else if (p.GetType() == typeof(GraduateStudent))   /// Process GradStudent
            {
   				
         . . . code to process Graduate Student goes here
     
       }  // end processing GradStudent
            else
            {
                MessageBox.Show("Type of object to Edit/Update is not valid. Contact System Admin.", "Delete Object Type Error", MessageBoxButtons.OK);
                MessageBox.Show("Number of records processed = " + recordsProcessedCount.ToString(),
                            "Exit Message", MessageBoxButtons.OK);
                this.Close();
            }  // end multiple alternative if
            MessageBox.Show(dbStringOwl + dbStringRest, "DataBase Retrieval", MessageBoxButtons.OK);
        }  // end displayDbInformation

        public OleDbDataReader SelectOwlMemberFromGraduateStudent(int OwlMemberID, out bool OKFlag)
        {
            string strSelectOwlMember = "SELECT OWLMEMBER.fldID, OWLMEMBER.fldName, 
             OWLMEMBER.fldBirthdate, " + "STUDENT.fldMajor, STUDENT.fldGPA, "
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


        */

    }
}
