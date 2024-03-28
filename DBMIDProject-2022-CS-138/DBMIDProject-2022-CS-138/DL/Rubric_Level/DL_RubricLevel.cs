using DBMIDProject_2022_CS_138.UI.Rubric_Level_Forms;
using Guna.UI2.WinForms;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBMIDProject_2022_CS_138.DL.Rubric_Level
{
    public class DL_RubricLevel
    {

        public static void addRubricLevel(string rubric_id, string details, string measurement_id, frm_RubricLevelAdd form)
        {
            if (rubric_id != "" && details != "" && measurement_id != "")
            {
                try
                {
                    var con = Configuration.getInstance().getConnection();

                    // Check if a RubricLevel with the same RubricId and Details already exists
                    SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM RubricLevel WHERE RubricId = @RubricId AND Details = @Details", con);
                    checkCmd.Parameters.AddWithValue("@RubricId", int.Parse(rubric_id));
                    checkCmd.Parameters.AddWithValue("@Details", details);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count == 0)
                    {
                        // If the RubricLevel does not already exist, insert it into the database
                        SqlCommand cmd = new SqlCommand("Insert into RubricLevel values(@RubricId,@Details,@MeasurementLevel)", con);
                        cmd.Parameters.AddWithValue("@RubricId", int.Parse(rubric_id));
                        cmd.Parameters.AddWithValue("@Details", details);
                        cmd.Parameters.AddWithValue("@MeasurementLevel", int.Parse(measurement_id));
                        cmd.ExecuteNonQuery();
                        Guna.UI2.WinForms.MessageDialog.Show(form, "Successfully Saved", "Inform", MessageDialogButtons.OK, MessageDialogIcon.Information);
                        form.Close();
                        //clearrubricleveltexts();
                    }
                    else
                    {
                        // If the RubricLevel already exists, show an error message
                        Guna.UI2.WinForms.MessageDialog.Show("A RubricLevel with the same RubricId and Details already exists", "warning", MessageDialogButtons.OK, MessageDialogIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that occur during the database operation
                    Guna.UI2.WinForms.MessageDialog.Show(form, "Error: " + ex.Message, "Error", MessageDialogButtons.OK, MessageDialogIcon.Error);
                }
            }
            else
            {
                Guna.UI2.WinForms.MessageDialog.Show(form, "Enter All Credentials", "warning", MessageDialogButtons.OK, MessageDialogIcon.Warning);
            }

        }
        public static void updateRubricLevel(int rubricLevelId, string rubric_id, string details, string measurement_id, Form form)
        {
            if (rubric_id != "" && details != "" && measurement_id != "")
            {

                var con = Configuration.getInstance().getConnection();

                // Check if a RubricLevel with the same RubricId and Details already exists
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM RubricLevel WHERE RubricId = @RubricId AND Details = @Details and Id<>@Id", con);
                checkCmd.Parameters.AddWithValue("@RubricId", int.Parse(rubric_id));
                checkCmd.Parameters.AddWithValue("@Details", details);
                checkCmd.Parameters.AddWithValue("@Id", rubricLevelId);
                int count = (int)checkCmd.ExecuteScalar();

                if (count == 0)
                {
                    SqlCommand cmd = new SqlCommand("Update  RubricLevel set RubricId=@RubricId,Details=@Details,MeasurementLevel=@MeasurementLevel where Id=@Id", con);
                    cmd.Parameters.AddWithValue("@RubricId", int.Parse(rubric_id));
                    cmd.Parameters.AddWithValue("@Details", details);
                    cmd.Parameters.AddWithValue("@MeasurementLevel", int.Parse(measurement_id));
                    cmd.Parameters.AddWithValue("@Id", rubricLevelId);
                    cmd.ExecuteNonQuery();
                    Guna.UI2.WinForms.MessageDialog.Show(form, "Successfully Updated", "Inform", MessageDialogButtons.OK, MessageDialogIcon.Information);
                    form.Close();
                    //clearrubricleveltexts();
                }
                else
                {
                    // If the RubricLevel already exists, show an error message
                    Guna.UI2.WinForms.MessageDialog.Show(form, "A RubricLevel with the same RubricId and Details already exists", "warning", MessageDialogButtons.OK, MessageDialogIcon.Warning);
                }

            }
            else
            {
                Guna.UI2.WinForms.MessageDialog.Show(form, "Enter All Credentials", "warning", MessageDialogButtons.OK, MessageDialogIcon.Warning);
            }

        }
        public static void deleteRubricLevel(int rubricLevelId)
        {

            try
            {

                var con = Configuration.getInstance().getConnection();

                SqlCommand cmd1 = new SqlCommand("DELETE FROM StudentResult WHERE AssessmentComponentId IN (SELECT Id FROM AssessmentComponent WHERE RubricId IN (SELECT RubricId FROM RubricLevel WHERE Id = @Id))", con);
                cmd1.Parameters.AddWithValue("@Id", rubricLevelId);
                cmd1.ExecuteNonQuery();

                //SqlCommand cmd2 = new SqlCommand("DELETE FROM AssessmentComponent WHERE RubricId IN (SELECT RubricId FROM RubricLevel WHERE Id = @Id)", con);
                //cmd2.Parameters.AddWithValue("@Id", rubricLevelId);
                //cmd2.ExecuteNonQuery();


                SqlCommand cmd3 = new SqlCommand("DELETE FROM RubricLevel WHERE Id = @Id", con);
                cmd3.Parameters.AddWithValue("@Id", rubricLevelId);
                cmd3.ExecuteNonQuery();

                Guna.UI2.WinForms.MessageDialog.Show("Successfully Deleted", "Inform", MessageDialogButtons.OK, MessageDialogIcon.Information);
                //clearrubricleveltexts();

            }
            catch (Exception)
            {
            }

        }
    }
}
