using DBMIDProject_2022_CS_138.UI.Assessment_Component_Forms;
using DBMIDProject_2022_CS_138s;
using Guna.UI2.WinForms;
using System;
using System.Data.SqlClient;

namespace DBMIDProject_2022_CS_138.DL.Assessment_Component
{
    public class DL_AssessmentComponent
    {
        public static void addAssessmentComponent(string name, string rubric_id, string total_marks, string assessment_id, frm_AssessmentComponentAdd addComponent)
        {
            var con = Configuration.getInstance().getConnection();
            if (name != "" && rubric_id != "" && total_marks != "" && assessment_id != "")
            {
                try
                {
                    int InAS_Count = 0;
                    SqlCommand temp = new SqlCommand("SELECT SUM(AC.TotalMarks)\r\nFROM AssessmentComponent AC\r\nWHERE AC.AssessmentId = " + assessment_id, con);
                    try
                    {
                        InAS_Count = Convert.ToInt32(temp.ExecuteScalar());
                    }
                    catch { }
                    SqlCommand temp1 = new SqlCommand("SELECT A.TotalMarks FROM Assessment A WHERE A.Id = " + assessment_id, con);
                    int total = Convert.ToInt32(temp1.ExecuteScalar());
                    if (total - InAS_Count >= int.Parse(total_marks))
                    {
                        // Check if a record with the same name, rubric id, and assessment id already exists in the database
                        SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM AssessmentComponent WHERE name=@name AND AssessmentId=@AssessmentId", con);
                        checkCmd.Parameters.AddWithValue("@name", name);
                        checkCmd.Parameters.AddWithValue("@AssessmentId", assessment_id);
                        int recordCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                        // If a record already exists, show an error message
                        if (recordCount > 0)
                        {
                            Guna.UI2.WinForms.MessageDialog.Show("A record with the same name and assessment id already exists in the database.");
                        }
                        else
                        {
                            // Otherwise, insert the record into the database
                            SqlCommand cmd = new SqlCommand("Insert into AssessmentComponent values (@name,@RubricId,@TotalMarks,@DateCreated,@DateUpdated,@AssessmentId)", con);
                            cmd.Parameters.AddWithValue("@name", name);
                            cmd.Parameters.AddWithValue("@RubricId", rubric_id);
                            if (UtilisImplementation.ValidateInput(int.Parse(total_marks)) == true)
                            {
                                cmd.Parameters.AddWithValue("@TotalMarks", int.Parse(total_marks));
                            }
                            cmd.Parameters.AddWithValue("@DateCreated", DateTime.Now);
                            cmd.Parameters.AddWithValue("@DateUpdated", DateTime.Now);
                            cmd.Parameters.AddWithValue("@AssessmentId", assessment_id);
                            cmd.ExecuteNonQuery();
                            Guna.UI2.WinForms.MessageDialog.Show(addComponent, "Successfully Saved", "Inform", MessageDialogButtons.OK, MessageDialogIcon.Information);
                            //clearAssesscoptexts();
                        }
                    }
                    else
                    {
                        Guna.UI2.WinForms.MessageDialog.Show(addComponent, "Sum is greater than assessment marks", "Error", MessageDialogButtons.OK, MessageDialogIcon.Error);
                    }
                }

                catch (Exception)
                {
                }
            }
            else
            {
                Guna.UI2.WinForms.MessageDialog.Show("Enter All Credentials", "warning", MessageDialogButtons.OK, MessageDialogIcon.Warning);
            }

        }

        public static void updateAssessmentComponent(int assesscomponentdelid, string name, string rubric_id, string total_marks, string assessment_id, frm_AssessmentComponentEdit editComponent)
        {
            var con = Configuration.getInstance().getConnection();
            if (name != "" && rubric_id != "" && total_marks != "" && assessment_id != "")
            {
                try
                {
                    int InAS_Count = 0;
                    SqlCommand temp = new SqlCommand("SELECT SUM(AC.TotalMarks)\r\nFROM AssessmentComponent AC\r\nWHERE AC.AssessmentId = " + assessment_id, con);
                    try
                    {
                        InAS_Count = Convert.ToInt32(temp.ExecuteScalar());
                    }
                    catch { }
                    SqlCommand temp1 = new SqlCommand("SELECT A.TotalMarks FROM Assessment A WHERE A.Id = " + assessment_id, con);
                    int total = Convert.ToInt32(temp1.ExecuteScalar());
                    if (total - InAS_Count >= int.Parse(total_marks))
                    {
                        // Check if a record with the same name, rubric id, and assessment id already exists in the database
                        SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM AssessmentComponent WHERE Name=@Name AND AssessmentId=@AssessmentId AND Id<>@Id", con);
                        checkCmd.Parameters.AddWithValue("@Name", name);
                        checkCmd.Parameters.AddWithValue("@AssessmentId", assessment_id);
                        checkCmd.Parameters.AddWithValue("@Id", assesscomponentdelid);
                        int recordCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                        // If a record already exists, show an error message
                        if (recordCount > 0)
                        {
                            Guna.UI2.WinForms.MessageDialog.Show(editComponent, "A record with the same name and assessment id already exists in the database.");
                        }
                        else
                        {
                            SqlCommand cmd = new SqlCommand("Update AssessmentComponent Set Name=@Name,RubricId=@RubricId,TotalMarks=@TotalMarks,DateUpdated=@DateUpdated,AssessmentId=@AssessmentId Where Id=@Id", con);
                            cmd.Parameters.AddWithValue("@Name", name);
                            cmd.Parameters.AddWithValue("@RubricId", rubric_id);
                            cmd.Parameters.AddWithValue("@TotalMarks", int.Parse(total_marks));
                            cmd.Parameters.AddWithValue("@DateUpdated", DateTime.Now);
                            cmd.Parameters.AddWithValue("@AssessmentId", assessment_id);
                            cmd.Parameters.AddWithValue("@Id", assesscomponentdelid);
                            cmd.ExecuteNonQuery();
                            Guna.UI2.WinForms.MessageDialog.Show(editComponent, "Successfully Updated", "Inform", MessageDialogButtons.OK, MessageDialogIcon.Information);
                            editComponent.Close();
                            //clearAssesscoptexts();
                        }
                    }
                    else
                    {
                        Guna.UI2.WinForms.MessageDialog.Show(editComponent, "Sum is greater than assessment marks", "Error", MessageDialogButtons.OK, MessageDialogIcon.Error);
                    }
                }

                catch (Exception)
                {
                }
            }
            else
            {
                Guna.UI2.WinForms.MessageDialog.Show(editComponent, "Enter All Credentials", "warning", MessageDialogButtons.OK, MessageDialogIcon.Warning);
            }

        }

        public static void deleteAssessementComponent(int assessmentComponentId)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd1 = new SqlCommand("Delete from StudentResult where AssessmentComponentId=@Id", con);
                cmd1.Parameters.AddWithValue("@Id", assessmentComponentId);
                cmd1.ExecuteNonQuery();

                SqlCommand cmd = new SqlCommand("Delete from AssessmentComponent Where Id=@Id", con);
                cmd.Parameters.AddWithValue("@Id", assessmentComponentId);
                cmd.ExecuteNonQuery();
                Guna.UI2.WinForms.MessageDialog.Show("Successfully Deleted", "Inform", MessageDialogButtons.OK, MessageDialogIcon.Information);
            }
            catch (Exception)
            {
            }
        }
    }
}
