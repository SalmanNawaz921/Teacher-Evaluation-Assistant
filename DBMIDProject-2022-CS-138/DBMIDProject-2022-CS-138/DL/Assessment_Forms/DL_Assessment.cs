using DBMIDProject_2022_CS_138.UI.Assessment_Forms;
using DBMIDProject_2022_CS_138s;
using Guna.UI2.WinForms;
using System;
using System.Data.SqlClient;

namespace DBMIDProject_2022_CS_138.DL.Assessment_Forms
{
    public class DL_Assessment
    {
        public static void addAssessment(string title, string total_marks, string total_weightage, frm_AssessmentAdd form)
        {
            if (title != "" && total_marks != "" && total_weightage != "")
            {
                try
                {
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("Insert into Assessment values (@Title,@DateCreated,@TotalMarks,@TotalWeightage)", con);
                    if (UtilisImplementation.ValidateAssessName(title) == true)
                    {
                        cmd.Parameters.AddWithValue("@Title", title);
                        cmd.Parameters.AddWithValue("@DateCreated", DateTime.Now);
                        if (UtilisImplementation.ValidateInput(int.Parse(total_marks)) == true)
                        {
                            cmd.Parameters.AddWithValue("@TotalMarks", int.Parse(total_marks));

                            if (UtilisImplementation.ValidateInput(int.Parse(total_weightage)) == true)
                            {
                                cmd.Parameters.AddWithValue("@TotalWeightage", int.Parse(total_weightage));
                            }
                        }
                    }
                    cmd.ExecuteNonQuery();
                    form.Close();
                    Guna.UI2.WinForms.MessageDialog.Show(form, "Successfully Saved", "Inform", MessageDialogButtons.OK, MessageDialogIcon.Information, MessageDialogStyle.Light);
                }
                catch (Exception)
                {
                }
            }
            else
            {
                Guna.UI2.WinForms.MessageDialog.Show(form, "Enter Details", "Error", MessageDialogButtons.OK, MessageDialogIcon.Error, MessageDialogStyle.Default);
            }
        }
        public static void updateAssessment(ref int assessmentID, string title, string total_marks, string total_weightage, frm_AssessmentEdit editForm)
        {
            if (title != "" && total_marks != "" && total_weightage != "")
            {
                try
                {
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("Update Assessment Set Title=@Title,DateCreated=@DateCreated,TotalMarks=@TotalMarks,TotalWeightage=@TotalWeightage Where Id=@Id", con);
                    if (UtilisImplementation.ValidateAssessName(title) == true)
                    {
                        cmd.Parameters.AddWithValue("@Title", title);
                        cmd.Parameters.AddWithValue("@DateCreated", DateTime.Now);
                        if (UtilisImplementation.ValidateInput(int.Parse(total_marks)) == true)
                        {
                            cmd.Parameters.AddWithValue("@TotalMarks", int.Parse(total_marks));

                            if (UtilisImplementation.ValidateInput(int.Parse(total_weightage)) == true)
                            {
                                cmd.Parameters.AddWithValue("@TotalWeightage", int.Parse(total_weightage));
                            }
                        }
                    }
                    cmd.Parameters.AddWithValue("@Id", assessmentID);
                    cmd.ExecuteNonQuery();
                    editForm.Close();
                    Guna.UI2.WinForms.MessageDialog.Show(editForm, "Successfully Saved", "Inform", MessageDialogButtons.OK, MessageDialogIcon.Information, MessageDialogStyle.Light);
                }
                catch (Exception)
                {
                }
            }
            else
            {
                Guna.UI2.WinForms.MessageDialog.Show(editForm, "Enter Details", "Error", MessageDialogButtons.OK, MessageDialogIcon.Error, MessageDialogStyle.Dark);
            }
        }
        public static void deleteAssessment(ref int assessmentID, frm_AssessmentUI form)
        {
            try
            {
                int assessamentdelid = assessmentID;
                var con = Configuration.getInstance().getConnection();


                SqlCommand cmd1 = new SqlCommand("DELETE FROM StudentResult WHERE AssessmentComponentId IN (SELECT AssessmentComponentId FROM Assessment WHERE Id = @Id)", con);
                cmd1.Parameters.AddWithValue("@Id", assessamentdelid);
                cmd1.ExecuteNonQuery();


                SqlCommand cmd2 = new SqlCommand("DELETE FROM AssessmentComponent WHERE AssessmentId = @Id", con);
                cmd2.Parameters.AddWithValue("@Id", assessamentdelid);
                cmd2.ExecuteNonQuery();

                SqlCommand cmd3 = new SqlCommand("DELETE FROM Assessment WHERE Id = @Id", con);
                cmd3.Parameters.AddWithValue("@Id", assessamentdelid);
                cmd3.ExecuteNonQuery();
                Guna.UI2.WinForms.MessageDialog.Show("Successfully Deleted", "Inform", MessageDialogButtons.OK, MessageDialogIcon.Information, MessageDialogStyle.Dark);
            }
            catch (Exception)
            {
            }
        }
    }
}
