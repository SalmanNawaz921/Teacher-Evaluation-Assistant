using Guna.UI2.WinForms;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBMIDProject_2022_CS_138.DL.Rubric_Forms
{
    public class DL_Rubrics
    {
        public static void addRubric(ref int rubricID, string col_id, string details, Form addForm)
        {

            if (col_id != "" && details != "")
            {

                try
                {
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Rubric VALUES (@Id,@Details, @CloId)", con);
                    cmd.Parameters.AddWithValue("Id", rubricID);
                    cmd.Parameters.AddWithValue("Details", details);
                    cmd.Parameters.AddWithValue("CloId", col_id);
                    cmd.ExecuteNonQuery();
                    //MaterialMessageBox.Show("Successfully Saved", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Guna.UI2.WinForms.MessageDialog.Show(addForm, "Successfully Saved", "Inform", MessageDialogButtons.OK, MessageDialogIcon.Information, MessageDialogStyle.Light);
                    //addForm.clearrubrictexts();
                    addForm.Close();
                    rubricID++;

                }
                catch (Exception ex)
                {
                    Guna.UI2.WinForms.MessageDialog.Show(addForm, ex.Message, "Error", MessageDialogButtons.OK, MessageDialogIcon.Error, MessageDialogStyle.Default);
                }

            }
            else
            {
                Guna.UI2.WinForms.MessageDialog.Show(addForm, "Enter Details", "Error", MessageDialogButtons.OK, MessageDialogIcon.Error, MessageDialogStyle.Default);
            }
        }

        public static void updateRubric(ref int rubricID, string col_id, string details, Form updateForm)
        {
            if (col_id != "" && details != "")
            {
                try
                {
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("update Rubric set Details=@Details,CloId=@CloId where Id=@Id", con);
                    cmd.Parameters.AddWithValue("Id", rubricID);
                    cmd.Parameters.AddWithValue("Details", details);
                    cmd.Parameters.AddWithValue("CloId", col_id);
                    cmd.ExecuteNonQuery();
                    //MaterialMessageBox.Show("Successfully Saved", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Guna.UI2.WinForms.MessageDialog.Show(updateForm, "Successfully Saved", "Inform", MessageDialogButtons.OK, MessageDialogIcon.Information, MessageDialogStyle.Light);
                    //addForm.clearrubrictexts();
                    updateForm.Close();
                }
                catch (Exception ex)
                {
                    Guna.UI2.WinForms.MessageDialog.Show(updateForm, ex.Message, "Error", MessageDialogButtons.OK, MessageDialogIcon.Error, MessageDialogStyle.Default);

                }
            }
            else
            {
                Guna.UI2.WinForms.MessageDialog.Show(updateForm, "Enter Details", "Error", MessageDialogButtons.OK, MessageDialogIcon.Error, MessageDialogStyle.Default);
            }
        }

        public static void deleteRubric(ref int rubricId)
        {
            if (rubricId >= 0)
            {

                try
                {
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd1 = new SqlCommand("DELETE FROM StudentResult WHERE AssessmentComponentId IN (SELECT Id FROM AssessmentComponent WHERE RubricId = @RubricId)", con);
                    cmd1.Parameters.AddWithValue("@RubricId", rubricId);
                    cmd1.ExecuteNonQuery();

                    SqlCommand cmd2 = new SqlCommand("DELETE FROM AssessmentComponent WHERE RubricId = @RubricId", con);
                    cmd2.Parameters.AddWithValue("@RubricId", rubricId);
                    cmd2.ExecuteNonQuery();

                    SqlCommand cmd3 = new SqlCommand("DELETE FROM RubricLevel WHERE RubricId = @RubricId", con);
                    cmd3.Parameters.AddWithValue("@RubricId", rubricId);
                    cmd3.ExecuteNonQuery();

                    SqlCommand cmd4 = new SqlCommand("DELETE FROM Rubric WHERE Id = @RubricId", con);
                    cmd4.Parameters.AddWithValue("@RubricId", rubricId);
                    cmd4.ExecuteNonQuery();

                    Guna.UI2.WinForms.MessageDialog.Show("Successfully Deleted", "Inform", MessageDialogButtons.OK, MessageDialogIcon.Information, MessageDialogStyle.Light);


                }
                catch (Exception)
                {
                }
            }
            else
            {

                // Guna.UI2.WinForms.MessageDialog.Show(form, "Rubric Id doesnt exist", "Error", MessageDialogButtons.OK, MessageDialogIcon.Error, MessageDialogStyle.Default);
            }
        }
    }
}
