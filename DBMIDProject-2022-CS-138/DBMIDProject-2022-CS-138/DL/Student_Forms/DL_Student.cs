using DBMIDProject_2022_CS_138s;
using MaterialSkin.Controls;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBMIDProject_2022_CS_138.DL.Student_Forms
{
    public class DL_Student
    {
        public static void addStudent(string fName, string lName, string contact, string email, string regNo, ref int status, Form addForm)
        {
            var con1 = Configuration.getInstance().getConnection();
            SqlCommand cmd1 = new SqlCommand("Select LookupId from Lookup where Name='Active'", con1);
            status = (Int32)cmd1.ExecuteScalar();
            cmd1.ExecuteNonQuery();


            if (fName != "" && lName != "" && contact != "" && email != "" && regNo != "")
            {
                try
                {
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand check = new SqlCommand("select count(*) from student where RegistrationNumber='" + regNo + "'", con);
                    SqlCommand check1 = new SqlCommand("select count(*) from student where Email='" + email + "'", con);
                    int count = Convert.ToInt32(check.ExecuteScalar());
                    int count1 = Convert.ToInt32(check1.ExecuteScalar());
                    if (count == 0 && count1 == 0)
                    {
                        SqlCommand cmd = new SqlCommand("Insert into Student values (@FirstName,@LastName,@Contact,@Email,@RegistrationNumber,@Status)", con);
                        if (UtilisImplementation.ValidateFirstName(fName) == true)
                        {
                            cmd.Parameters.AddWithValue("@FirstName", fName.Trim());
                        }
                        if (UtilisImplementation.ValidateLastName(lName) == true)
                        {
                            cmd.Parameters.AddWithValue("@LastName", lName);
                        }
                        if (UtilisImplementation.ValidatePhoneNumber(contact) == true)
                        {
                            cmd.Parameters.AddWithValue("@Contact", contact);
                        }
                        if (UtilisImplementation.ValidateEmail(email) == true)
                        {
                            cmd.Parameters.AddWithValue("@Email", email);
                        }
                        if (UtilisImplementation.ValidateRegistrationNumber(regNo) == true)
                        {
                            cmd.Parameters.AddWithValue("@RegistrationNumber", regNo);
                        }
                        cmd.Parameters.AddWithValue("@Status", status);
                        cmd.ExecuteNonQuery();
                        MaterialMessageBox.Show("Successfully saved", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        addForm.Close();
                    }
                    else
                    {
                        MaterialMessageBox.Show("Registration Number or Email Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {

                }
            }
            else
            {
                MaterialMessageBox.Show("Input All Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public static void updateStudent(int sid, string fName, string lName, string contact, string email, string regNo, ref int status, Form editForm)
        {
            var con1 = Configuration.getInstance().getConnection();
            SqlCommand cmd1 = new SqlCommand("Select LookupId from Lookup where Name='Active'", con1);
            status = (Int32)cmd1.ExecuteScalar();
            cmd1.ExecuteNonQuery();
            if (fName != "" && lName != "" && regNo != "")
            {
                try
                {
                    var con = Configuration.getInstance().getConnection();

                    SqlCommand check1 = new SqlCommand("select count(*) from student where  Id<>@Id and Email='" + lName + "'", con);
                    check1.Parameters.AddWithValue("@Id", sid);
                    //int count = Convert.ToInt32(check.ExecuteScalar());
                    int count1 = Convert.ToInt32(check1.ExecuteScalar());

                    if (count1 == 0)
                    {
                        SqlCommand cmd = new SqlCommand("Update Student set FirstName=@FirstName,LastName=@LastName,Contact=@Contact,Email=@Email,RegistrationNumber=@RegistrationNumber,status=5 where Id=@Id", con);
                        if (UtilisImplementation.ValidateFirstName(fName) == true)
                        {
                            cmd.Parameters.AddWithValue("@FirstName", fName.Trim());
                            if (UtilisImplementation.ValidateLastName(lName) == true && lName != "")
                            {
                                cmd.Parameters.AddWithValue("@LastName", lName);
                                if (UtilisImplementation.ValidatePhoneNumber(contact) == true && contact != "")
                                {
                                    cmd.Parameters.AddWithValue("@Contact", contact);
                                    if (UtilisImplementation.ValidateEmail(email) == true && email != "")
                                    {
                                        cmd.Parameters.AddWithValue("@Email", email);
                                        if (UtilisImplementation.ValidateRegistrationNumber(regNo) == true && regNo != "")
                                        {
                                            cmd.Parameters.AddWithValue("@RegistrationNumber", regNo);
                                        }
                                    }
                                }
                            }
                        }
                        cmd.Parameters.AddWithValue("@Status", status);
                        cmd.Parameters.AddWithValue("@Id", sid);
                        cmd.ExecuteNonQuery();
                        MaterialMessageBox.Show("Successfully updated", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        editForm.Close();
                    }
                    else
                    {
                        MaterialMessageBox.Show("Registration Number or Email Already Exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception)
                {
                }
            }
            else
            {
                MaterialMessageBox.Show("Enter All Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void deleteStudent(string fName, string email, string regNo, int sid, ref int status)
        {
            var con1 = Configuration.getInstance().getConnection();
            SqlCommand cmd1 = new SqlCommand("Select LookupId from Lookup where Name='InActive'", con1);
            status = (Int32)cmd1.ExecuteScalar();
            cmd1.ExecuteNonQuery();
            if (fName != "" && email != "" && regNo != "")
            {

                try
                {
                    var con = Configuration.getInstance().getConnection();
                    //string Id=Convert.ToString(ProcessCmdKey)
                    SqlCommand cmd = new SqlCommand("update Student set Status=@Status where Id=@Id", con);
                    //MaterialMessageBox.Show(sid.ToString());
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@Id", sid);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Changed Status to Inactive", "inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                }
            }
            else
            {
                MessageBox.Show("Enter a Unique Credential to Delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
