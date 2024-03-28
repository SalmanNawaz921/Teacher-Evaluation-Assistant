using DBMIDProject_2022_CS_138s;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBMIDProject_2022_CS_138.DL.CLO_Forms
{
    public class DL_Clos
    {
        public static void addClo(string name, Form addForm)
        {
            if (name != "")
            {
                try
                {
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand check1 = new SqlCommand("select count(*) from Clo where Name='" + name + "'", con);
                    int count = Convert.ToInt32(check1.ExecuteScalar());
                    if (count == 0)
                    {
                        SqlCommand cmd = new SqlCommand("Insert into Clo values (@Name,@DateCreated,@DateUpdated)", con);
                        if (UtilisImplementation.ValidateCLO(name) == true)
                        {
                            cmd.Parameters.AddWithValue("@Name", name);
                        }
                        DateTime date = DateTime.Now;
                        cmd.Parameters.AddWithValue("@DateCreated", date);
                        cmd.Parameters.AddWithValue("@DateUpdated", date);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully saved", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        addForm.Close();
                    }
                    else
                    {
                        MessageBox.Show("CLO name already exists", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception)
                {
                }

            }
            else
            {
                MessageBox.Show("Enter All Credentials", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void updateClo(string name, int clo_id, Form editForm)
        {
            if (name != "")
            {
                try
                {
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("UPDATE Clo set Name=@Name,DateUpdated=@DateUpdated where Id=@Id", con);
                    if (UtilisImplementation.ValidateCLO(name))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                    }
                    DateTime date = DateTime.Now;
                    cmd.Parameters.AddWithValue("@DateUpdated", date);
                    cmd.Parameters.AddWithValue("@Id", clo_id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully saved", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    editForm.Close();
                }

                catch (Exception)
                {
                }

            }
            else
            {
                MessageBox.Show("Enter All Credentials", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void deleteClo(int clo_id)
        {
            if (clo_id >= 0)
            {
                try
                {

                    var con = Configuration.getInstance().getConnection();
                    SqlCommand temp3 = new SqlCommand("Delete FROM StudentResult WHERE AssessmentComponentId In (Select Id From AssessmentComponent WHERE RubricId In (Select Id From Rubric Where CloId = @Id) )", con);
                    temp3.Parameters.AddWithValue("@Id", clo_id);
                    temp3.ExecuteNonQuery();
                    SqlCommand temp2 = new SqlCommand("Delete FROM AssessmentComponent WHERE RubricId In (Select Id From Rubric Where CloId = @Id)", con);
                    temp2.Parameters.AddWithValue("@Id", clo_id);
                    temp2.ExecuteNonQuery();
                    SqlCommand temp1 = new SqlCommand("Delete FROM RubricLevel WHERE RubricId In  (Select Id From Rubric Where CloId = @Id)", con);
                    temp1.Parameters.AddWithValue("@Id", clo_id);
                    temp1.ExecuteNonQuery();
                    SqlCommand temp = new SqlCommand("Delete FROM Rubric WHERE CloId = @Id", con);
                    temp.Parameters.AddWithValue("@Id", clo_id);
                    temp.ExecuteNonQuery();
                    SqlCommand cmd = new SqlCommand("Delete FROM Clo WHERE Id= @Id", con);
                    cmd.Parameters.AddWithValue("@Id", clo_id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Deleted", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception)
                {
                }
            }
            else
            {
                MessageBox.Show("Empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}