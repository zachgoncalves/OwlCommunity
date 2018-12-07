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

        // Update UG Student
        public void updateUGStudent(string Name, int OwlMemberID, DateTime BD, string AccType, decimal GPA, string Major, decimal Tuition, int Credits, string Year)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand updateOwlMember = new SqlCommand(
                    "UPDATE OwlMember SET ID = @ID, Name = @Name, BD = @BD, OwlType = @AccType WHERE ID = @ID;"
                , connection);

                updateOwlMember.Parameters.AddWithValue("@ID", OwlMemberID);
                updateOwlMember.Parameters.AddWithValue("@Name", Name);
                updateOwlMember.Parameters.AddWithValue("@BD", BD);
                updateOwlMember.Parameters.AddWithValue("@AccType", AccType);

                SqlCommand updateStudent = new SqlCommand(
                    "UPDATE Student SET ID = @ID, GPA = @GPA, Major = @Major WHERE ID = @ID;"
                , connection);

                updateStudent.Parameters.AddWithValue("@ID", OwlMemberID);
                updateStudent.Parameters.AddWithValue("@GPA", GPA);
                updateStudent.Parameters.AddWithValue("@Major", Major);

                SqlCommand updateUndergraduateStudent = new SqlCommand(
                    @"UPDATE Undergraduate_Student 
                      SET ID = @ID, Tuition = @Tuition, Year = @Year, Credits = @Credits
                      WHERE ID = @ID;"
                , connection);

                updateUndergraduateStudent.Parameters.AddWithValue("@ID", OwlMemberID);
                updateUndergraduateStudent.Parameters.AddWithValue("@Tuition", Tuition);
                updateUndergraduateStudent.Parameters.AddWithValue("@Credits", Credits);
                updateUndergraduateStudent.Parameters.AddWithValue("@Year", Year);

                try
                {
                    connection.Open();
                    updateOwlMember.ExecuteNonQuery();
                    updateStudent.ExecuteNonQuery();
                    updateUndergraduateStudent.ExecuteNonQuery();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Update failed!" + "\n" + Ex.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        // Update Graduate Student
        public void updateGraduateStudent(string Name, int OwlMemberID, DateTime BD, string AccType, decimal GPA, string Major, decimal Stipend, string Program)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand updateOwlMember = new SqlCommand(
                    "UPDATE OwlMember SET ID = @ID, Name = @Name, BD = @BD, OwlType = @AccType WHERE ID = @ID;"
                , connection);

                updateOwlMember.Parameters.AddWithValue("@Name", Name);
                updateOwlMember.Parameters.AddWithValue("@ID", OwlMemberID);
                updateOwlMember.Parameters.AddWithValue("@BD", BD);
                updateOwlMember.Parameters.AddWithValue("@AccType", AccType);


                SqlCommand updateStudent = new SqlCommand(
                    "UPDATE Student SET ID = @ID, GPA = @GPA, Major = @Major WHERE ID = @ID;"
                , connection);

                updateStudent.Parameters.AddWithValue("@ID", OwlMemberID);
                updateStudent.Parameters.AddWithValue("@GPA", GPA);
                updateStudent.Parameters.AddWithValue("@Major", Major);

                SqlCommand updateGraduateStudent = new SqlCommand(
                   @"UPDATE Graduate_Student 
                      SET ID = @ID, Stipend = @Stipend, Program = @Program
                      WHERE ID = @ID;"
               , connection);

                updateGraduateStudent.Parameters.AddWithValue("@ID", OwlMemberID);
                updateGraduateStudent.Parameters.AddWithValue("@Stipend", Stipend);
                updateGraduateStudent.Parameters.AddWithValue("@Program", Program);

                try
                {
                    connection.Open();
                    updateOwlMember.ExecuteNonQuery();
                    updateStudent.ExecuteNonQuery();
                    updateGraduateStudent.ExecuteNonQuery();
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

        // Update Faculty 
        public void updateFaculty(string Name, int OwlMemberID, DateTime BD, string AccType, string Department, string Rank)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand updateOwlMember = new SqlCommand(
                    "UPDATE OwlMember SET ID = @ID, Name = @Name, BD = @BD, OwlType = @AccType WHERE ID = @ID;"
                , connection);

                updateOwlMember.Parameters.AddWithValue("@Name", Name);
                updateOwlMember.Parameters.AddWithValue("@ID", OwlMemberID);
                updateOwlMember.Parameters.AddWithValue("@BD", BD);
                updateOwlMember.Parameters.AddWithValue("@AccType", AccType);


                SqlCommand updateFaculty = new SqlCommand(
                    "UPDATE Faculty SET ID = @ID, Department = @Department, Rank = @Rank WHERE ID = @ID;"
                , connection);

                updateFaculty.Parameters.AddWithValue("@ID", OwlMemberID);
                updateFaculty.Parameters.AddWithValue("@Department", Department);
                updateFaculty.Parameters.AddWithValue("@Rank", Rank);

                try
                {
                    connection.Open();
                    updateOwlMember.ExecuteNonQuery();
                    updateFaculty.ExecuteNonQuery();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Updating faculty failed!" + "\n" + Ex.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        // Update Faculty Chairperson
        public void updateFacultyChair(string Name, int OwlMemberID, DateTime BD, string AccType, string Department, string Rank, decimal Stipend)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand updateOwlMember = new SqlCommand(
                    "UPDATE OwlMember SET ID = @ID, Name = @Name, BD = @BD, OwlType = @AccType WHERE ID = @ID;"
                , connection);

                updateOwlMember.Parameters.AddWithValue("@Name", Name);
                updateOwlMember.Parameters.AddWithValue("@ID", OwlMemberID);
                updateOwlMember.Parameters.AddWithValue("@BD", BD);
                updateOwlMember.Parameters.AddWithValue("@AccType", AccType);


                SqlCommand updateFaculty = new SqlCommand(
                    "UPDATE Faculty SET ID = @ID, Department = @Department, Rank = @Rank WHERE ID = @ID;"
                , connection);

                updateFaculty.Parameters.AddWithValue("@ID", OwlMemberID);
                updateFaculty.Parameters.AddWithValue("@Department", Department);
                updateFaculty.Parameters.AddWithValue("@Rank", Rank);

                SqlCommand updateFacultyChair = new SqlCommand(
                    "UPDATE Faculty_Chairperson SET ID = @ID, Department = @Department, Rank = @Rank, Stipend = @Stipend WHERE ID = @ID;"
                , connection);

                updateFacultyChair.Parameters.AddWithValue("@ID", OwlMemberID);
                updateFacultyChair.Parameters.AddWithValue("@Stipend", Stipend);

                try
                {
                    connection.Open();
                    updateOwlMember.ExecuteNonQuery();
                    updateFaculty.ExecuteNonQuery();
                    updateFacultyChair.ExecuteNonQuery();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Updating faculty failed!" + "\n" + Ex.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        // Checks DB for entry with ID, and deletes entry depending on type
        public void deleteItem(int OwlMemberID)
        {
            string owlMemberType = "";
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


                    if (owlMemberType.Equals("Undergraduate Student"))
                    {
                        SqlCommand deleteMember = new SqlCommand(@"
                            DELETE FROM OwlMember WHERE ID = @ID;"
                        , connection);

                        deleteMember.Parameters.AddWithValue("@ID", OwlMemberID);

                        SqlCommand deleteStudent = new SqlCommand(@"
                            DELETE FROM Student WHERE ID = @ID;"
                        , connection);

                        deleteStudent.Parameters.AddWithValue("@ID", OwlMemberID);

                        SqlCommand deleteUndergrad = new SqlCommand(@"
                            DELETE FROM Undergraduate_Student WHERE ID = @ID;"
                        , connection);

                        deleteUndergrad.Parameters.AddWithValue("@ID", OwlMemberID);

                        deleteMember.ExecuteNonQuery();
                        deleteStudent.ExecuteNonQuery();
                        deleteUndergrad.ExecuteNonQuery();
                        connection.Close();
                    }
                    else if (owlMemberType.Equals("Graduate Student"))
                    {
                        SqlCommand deleteMember = new SqlCommand(@"
                            DELETE FROM OwlMember WHERE ID = @ID;"
                        , connection);

                        deleteMember.Parameters.AddWithValue("@ID", OwlMemberID);

                        SqlCommand deleteStudent = new SqlCommand(@"
                            DELETE FROM Student WHERE ID = @ID;"
                        , connection);

                        deleteStudent.Parameters.AddWithValue("@ID", OwlMemberID);

                        SqlCommand deleteGrad = new SqlCommand(@"
                            DELETE FROM Graduate_Student WHERE ID = @ID"
                        , connection);

                        deleteGrad.Parameters.AddWithValue("@ID", OwlMemberID);

                        deleteMember.ExecuteNonQuery();
                        deleteStudent.ExecuteNonQuery();
                        deleteGrad.ExecuteNonQuery();
                        connection.Close();
                    }
                    else if (owlMemberType.Equals("Faculty"))
                    {
                        SqlCommand deleteMember = new SqlCommand(@"
                            DELETE FROM OwlMember WHERE ID = @ID;"
                        , connection);

                        deleteMember.Parameters.AddWithValue("@ID", OwlMemberID);

                        SqlCommand deleteFaculty = new SqlCommand(@"
                            DELETE FROM Faculty WHERE ID = @ID;"
                        , connection);

                        deleteFaculty.Parameters.AddWithValue("@ID", OwlMemberID);

                        deleteMember.ExecuteNonQuery();
                        deleteFaculty.ExecuteNonQuery();
                        connection.Close();
                    }
                    else if (owlMemberType.Equals("Faculty Chair"))
                    {
                        SqlCommand deleteMember = new SqlCommand(@"
                            DELETE FROM OwlMember WHERE ID = @ID;"
                       , connection);

                        deleteMember.Parameters.AddWithValue("@ID", OwlMemberID);

                        SqlCommand deleteFaculty = new SqlCommand(@"
                            DELETE FROM Faculty WHERE ID = @ID;"
                        , connection);

                        deleteFaculty.Parameters.AddWithValue("@ID", OwlMemberID);

                        SqlCommand deleteChair = new SqlCommand(@"
                            DELETE FROM Faculty_Chairperson WHERE ID = @ID;"
                        , connection);

                        deleteChair.Parameters.AddWithValue("@ID", OwlMemberID);

                        deleteMember.ExecuteNonQuery();
                        deleteFaculty.ExecuteNonQuery();
                        deleteChair.ExecuteNonQuery();
                        connection.Close();
                    }

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.ToString());
                }
                finally
                {
                    connection.Close();
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
    }
}
