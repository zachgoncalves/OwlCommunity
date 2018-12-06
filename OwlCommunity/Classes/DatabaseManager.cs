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
        private OwlMember member;
        private UndergraduateStudent undergrad;
        private GraduateStudent grad;
        private FacultyMember facultyMember;
        private FacultyChairperson facultyChairperson;
         

        // Insert Data into Undergraduate Student related Tables
        public void insertUGStudent(string Name, int OwlMemberID, DateTime BD, string AccType, decimal GPA, string Major, decimal Tuition, int Credits, string Year)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand insertIntoOwlMember = new SqlCommand(
                    "INSERT INTO OwlMember VALUES (@ID, @Name, @BD, @AccType);"
                ,connection);
            
                insertIntoOwlMember.Parameters.AddWithValue("@Name", Name);
                insertIntoOwlMember.Parameters.AddWithValue("@ID", OwlMemberID);
                insertIntoOwlMember.Parameters.AddWithValue("@BD", BD);
                insertIntoOwlMember.Parameters.AddWithValue("@AccType", AccType);

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

        // Insert Data into Graduate Student related Tables
        public void insertGraduateStudent(string Name, int OwlMemberID, DateTime BD, string AccType, decimal GPA, string Major, decimal Stipend, string Program)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand insertIntoOwlMember = new SqlCommand(
                    "INSERT INTO OwlMember VALUES (@ID, @Name, @BD, @AccType);"
                , connection);

                insertIntoOwlMember.Parameters.AddWithValue("@Name", Name);
                insertIntoOwlMember.Parameters.AddWithValue("@ID", OwlMemberID);
                insertIntoOwlMember.Parameters.AddWithValue("@BD", BD);
                insertIntoOwlMember.Parameters.AddWithValue("@AccType", AccType);

                SqlCommand insertIntoStudent = new SqlCommand(
                    "INSERT INTO Student VALUES (@ID, @GPA, @Major);"
                , connection);

                insertIntoStudent.Parameters.AddWithValue("@ID", OwlMemberID);
                insertIntoStudent.Parameters.AddWithValue("@GPA", GPA);
                insertIntoStudent.Parameters.AddWithValue("@Major", Major);

                SqlCommand insertIntoUndergraduateStudent = new SqlCommand(
                    "INSERT INTO Graduate_Student VALUES (@ID, @Stipend, @Program);"
                , connection);

                insertIntoUndergraduateStudent.Parameters.AddWithValue("@ID", OwlMemberID);
                insertIntoUndergraduateStudent.Parameters.AddWithValue("@Stipend", Stipend);
                insertIntoUndergraduateStudent.Parameters.AddWithValue("@Program", Program);

                try
                {
                    connection.Open();
                    insertIntoOwlMember.ExecuteNonQuery();
                    insertIntoStudent.ExecuteNonQuery();
                    insertIntoUndergraduateStudent.ExecuteNonQuery();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("It failed!" + "\n" + Ex.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        // Insert Data into Faculty related Tables
        public void insertFaculty(string Name, int OwlMemberID, DateTime BD, string AccType,  string Department, string Rank)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand insertIntoOwlMember = new SqlCommand(
                    "INSERT INTO OwlMember VALUES (@ID, @Name, @BD, @AccType);"
                , connection);

                insertIntoOwlMember.Parameters.AddWithValue("@Name", Name);
                insertIntoOwlMember.Parameters.AddWithValue("@ID", OwlMemberID);
                insertIntoOwlMember.Parameters.AddWithValue("@BD", BD);
                insertIntoOwlMember.Parameters.AddWithValue("@AccType", AccType);

                SqlCommand insertIntoFaculty = new SqlCommand(
                    "INSERT INTO Faculty VALUES (@ID, @Dept, @Rank);"
                , connection);

                insertIntoFaculty.Parameters.AddWithValue("@ID", OwlMemberID);
                insertIntoFaculty.Parameters.AddWithValue("@Dept", Department);
                insertIntoFaculty.Parameters.AddWithValue("@Rank", Rank);

                try
                {
                    connection.Open();
                    insertIntoOwlMember.ExecuteNonQuery();
                    insertIntoFaculty.ExecuteNonQuery();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("It failed!" + "\n" + Ex.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        // Insert Data into Faculty Chair related Tables
        public void insertChairperson(string Name, int OwlMemberID, DateTime BD, string AccType, string Department, string Rank, decimal Stipend)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand insertIntoOwlMember = new SqlCommand(
                    "INSERT INTO OwlMember VALUES (@ID, @Name, @BD, @AccType);"
                , connection);

                insertIntoOwlMember.Parameters.AddWithValue("@Name", Name);
                insertIntoOwlMember.Parameters.AddWithValue("@ID", OwlMemberID);
                insertIntoOwlMember.Parameters.AddWithValue("@BD", BD);
                insertIntoOwlMember.Parameters.AddWithValue("@AccType", AccType);

                SqlCommand insertIntoFaculty = new SqlCommand(
                    "INSERT INTO Faculty VALUES (@ID, @Dept, @Rank);"
                , connection);

                insertIntoFaculty.Parameters.AddWithValue("@ID", OwlMemberID);
                insertIntoFaculty.Parameters.AddWithValue("@Dept", Department);
                insertIntoFaculty.Parameters.AddWithValue("@Rank", Rank);

                SqlCommand insertIntoChair = new SqlCommand(
                    "INSERT INTO Faculty_Chairperson VALUES (@ID, @Stipend);"
                , connection);

                insertIntoChair.Parameters.AddWithValue("@ID", OwlMemberID);
                insertIntoChair.Parameters.AddWithValue("@Stipend", Stipend);

                try
                {
                    connection.Open();
                    insertIntoOwlMember.ExecuteNonQuery();
                    insertIntoFaculty.ExecuteNonQuery();
                    insertIntoChair.ExecuteNonQuery();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("It failed!" + "\n" + Ex.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public void selectItem(int OwlMemberID, ref bool isSelectable)
        {
            string owlMemberType = "";
            isSelectable = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand selectFromOwlMember = new SqlCommand(
                    "SELECT * FROM OwlMember WHERE ID = @ID"
                , connection);

                selectFromOwlMember.Parameters.AddWithValue("@ID", OwlMemberID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = selectFromOwlMember.ExecuteReader();
                    while (reader.Read())
                    {
                        owlMemberType = reader["OwlType"].ToString();
                    }
                    reader.Close();

                    // Undergraduate Student Lookup 
                    if (owlMemberType.Equals("Undergraduate Student"))
                    {
                        SqlCommand selectUndergrad = new SqlCommand(@"
                            SELECT * FROM OwlMember 
                            JOIN Student ON OwlMember.ID = Student.ID
                            JOIN Undergraduate_Student ON OwlMember.ID = Undergraduate_Student.ID
                            WHERE OwlMember.ID = @ID;"
                        , connection);

                        selectUndergrad.Parameters.AddWithValue("@ID", OwlMemberID);

                        SqlDataReader undergradReader = selectUndergrad.ExecuteReader();

                        while (undergradReader.Read())
                        {
                            if(undergradReader.HasRows)
                            {
                                int readID = Convert.ToInt32(undergradReader["ID"]);
                                DateTime readBD = Convert.ToDateTime(undergradReader["BD"]);
                                string readName = undergradReader["Name"].ToString();
                                decimal readGPA = Convert.ToDecimal(undergradReader["GPA"]);
                                string readMajor = undergradReader["Major"].ToString();
                                decimal readTuition = Convert.ToDecimal(undergradReader["Tuition"]);
                                string readYear = undergradReader["Year"].ToString();
                                int readCredits = Convert.ToInt32(undergradReader["Credits"]);

                                undergrad = new UndergraduateStudent(readName, readID, readBD, readGPA, readMajor, readTuition, readCredits, readYear);
                                setMember(undergrad);
                                isSelectable = true;
                            }

                        }
                        reader.Close();
                        connection.Close();
                    }
                    else if(owlMemberType.Equals("Graduate Student")) 
                    {
                        SqlCommand selectGrad = new SqlCommand(@"
                            SELECT * FROM OwlMember 
                            JOIN Student ON OwlMember.ID = Student.ID
                            JOIN Graduate_Student ON OwlMember.ID = Graduate_Student.ID
                            WHERE OwlMember.ID = @ID;"
                        , connection);

                        selectGrad.Parameters.AddWithValue("@ID", OwlMemberID);

                        SqlDataReader graduateReader = selectGrad.ExecuteReader();

                        while (graduateReader.Read())
                        {
                            if (graduateReader.HasRows)
                            {
                                int readID = Convert.ToInt32(graduateReader["ID"]);
                                DateTime readBD = Convert.ToDateTime(graduateReader["BD"]);
                                string readName = graduateReader["Name"].ToString();
                                decimal readGPA = Convert.ToDecimal(graduateReader["GPA"]);
                                string readMajor = graduateReader["Major"].ToString();
                                decimal readStipend = Convert.ToDecimal(graduateReader["Stipend"]);
                                string readProgram = graduateReader["Program"].ToString();

                                grad = new GraduateStudent(readName, readID, readBD, readMajor, readGPA, readStipend, readProgram);
                                setMember(grad);
                                isSelectable = true;
                            }

                        }
                        reader.Close();
                        connection.Close();
                    }
                    else if (owlMemberType.Equals("Faculty"))
                    {
                        SqlCommand selectFaculty = new SqlCommand(@"
                            SELECT * FROM OwlMember 
                            JOIN Faculty ON OwlMember.ID = Faculty.ID
                            WHERE OwlMember.ID = @ID;"
                        , connection);

                        selectFaculty.Parameters.AddWithValue("@ID", OwlMemberID);

                        SqlDataReader facultyReader = selectFaculty.ExecuteReader();

                        while (facultyReader.Read())
                        {
                            if (facultyReader.HasRows)
                            {
                                int readID = Convert.ToInt32(facultyReader["ID"]);
                                DateTime readBD = Convert.ToDateTime(facultyReader["BD"]);
                                string readName = facultyReader["Name"].ToString();
                                string readDepartment = facultyReader["Department"].ToString();
                                string readRank = facultyReader["Rank"].ToString();

                                facultyMember = new FacultyMember(readName, readID, readBD, readDepartment, readRank);
                                setMember(facultyMember);
                                isSelectable = true;
                            }
                        }
                        reader.Close();
                        connection.Close();
                    }
                    else if (owlMemberType.Equals("Faculty Chair"))
                    {
                        SqlCommand selectChair = new SqlCommand(@"
                            SELECT * FROM OwlMember 
                            JOIN Faculty ON OwlMember.ID = Faculty.ID
                            JOIN Faculty_Chairperson ON OwlMember.ID = Faculty_Chairperson.ID
                            WHERE OwlMember.ID = @ID;"
                        , connection);

                        selectChair.Parameters.AddWithValue("@ID", OwlMemberID);

                        SqlDataReader facultyReader = selectChair.ExecuteReader();

                        while (facultyReader.Read())
                        {
                            if (facultyReader.HasRows)
                            {
                                int readID = Convert.ToInt32(facultyReader["ID"]);
                                DateTime readBD = Convert.ToDateTime(facultyReader["BD"]);
                                string readName = facultyReader["Name"].ToString();
                                string readDepartment = facultyReader["Department"].ToString();
                                string readRank = facultyReader["Rank"].ToString();
                                decimal readStipend = Convert.ToDecimal(facultyReader["Stipend"]);

                                facultyChairperson = new FacultyChairperson(readName, readID, readBD, readDepartment, readRank, readStipend);
                                setMember(facultyChairperson);
                                isSelectable = true;
                            }
                        }
                        reader.Close();
                        connection.Close();
                    }

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.ToString());
                }

            }
        }

        // Sets object created by select to generic OwlMember
        public OwlMember setMember(OwlMember newMember)
        {
            return member = newMember; 
        }
        // Return object created by select
        public OwlMember getMember()
        {
            return member;
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
