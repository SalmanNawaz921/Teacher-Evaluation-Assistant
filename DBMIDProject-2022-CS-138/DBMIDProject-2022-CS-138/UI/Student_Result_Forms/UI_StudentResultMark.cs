using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBMIDProject_2022_CS_138.UI.Student_Result_Forms
{
    public partial class frm_StudentResultMark : Form
    {
        public frm_StudentResultMark()
        {
            InitializeComponent();
            showGrid();
            populateBox(box_ComponentId);
            populateBox(box_MeasurementId);
        }
        private void showGrid()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Id,FirstName+' '+LastName As Name,RegistrationNumber,Email from Student", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid_StudentDetails.DataSource = dt;
        }
        private void refreshGrid()
        {
            grid_StudentDetails.DataSource = null;
            showGrid();
            grid_StudentDetails.Refresh();
        }



        public void populateBox(Guna2ComboBox box)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = null;
            if (box == box_ComponentId)
            {
                cmd = new SqlCommand("Select Id from AssessmentComponent", con);
            }
            else
            {
                int componentId;
                if (int.TryParse(box_ComponentId.Text, out componentId))
                {
                    cmd = new SqlCommand("SELECT DISTINCT RL.Id FROM RubricLevel RL JOIN Rubric R ON R.Id = RL.RubricId JOIN AssessmentComponent AC ON R.Id = AC.RubricId WHERE AC.Id = @ComponentId", con);
                    cmd.Parameters.AddWithValue("@ComponentId", componentId);
                    // Execute the command and handle the result
                }
                else
                {
                    // Handle the case when box_ComponentId.Text is not a valid integer
                    MessageBox.Show("Input is not in the correct format. Please enter a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            if (cmd != null)
            {

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                box.ValueMember = "Id";
                box.DataSource = dt;
            }
        }

        private void box_ComponentId_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            populateBox(box_MeasurementId);
        }

        private void btn_Mark_Click(object sender, System.EventArgs e)
        {
            int id = int.Parse(grid_StudentDetails.CurrentRow.Cells[0].Value.ToString());
            if (!string.IsNullOrEmpty(box_MeasurementId.Text) && !string.IsNullOrEmpty(box_ComponentId.Text) && id >= 0)

            {
                int component_id = int.Parse(box_ComponentId.Text);
                int measurement_id = int.Parse(box_MeasurementId.Text);
                try
                {
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("Insert into StudentResult values (@StudentId,@AssessmentComponentId,@RubricMeasurementId,@EvaluationDate)", con);
                    cmd.Parameters.AddWithValue("@StudentId", id);
                    cmd.Parameters.AddWithValue("@AssessmentComponentId", component_id);
                    cmd.Parameters.AddWithValue("@RubricMeasurementId", measurement_id);
                    cmd.Parameters.AddWithValue("@EvaluationDate", DateTime.Now);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully saved");
                    //Guna.UI2.WinForms.MessageDialog.Show(this, "Successfully Marked", "inform", MessageDialogButtons.OK, MessageDialogIcon.Information);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                    //Guna.UI2.WinForms.MessageDialog.Show(err.Message, "warning", MessageDialogButtons.OK, MessageDialogIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Enter All Details");
                // Guna.UI2.WinForms.MessageDialog.Show(this, "Enter All Credentials", "warning", MessageDialogButtons.OK, MessageDialogIcon.Warning);
            }
        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            frm_StudentResultList studentsResult = new frm_StudentResultList();
            studentsResult.ShowDialog();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(grid_StudentDetails.CurrentRow.Cells[0].Value.ToString());
            if (!string.IsNullOrEmpty(box_MeasurementId.Text) && !string.IsNullOrEmpty(box_ComponentId.Text) && id >= 0)

            {
                int component_id = int.Parse(box_ComponentId.Text);
                int measurement_id = int.Parse(box_MeasurementId.Text);
                try
                {
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("UPDATE StudentResult SET  RubricMeasurementId = @RubricMeasurementId,EvaluationDate = @EvaluationDate WHERE StudentId = @StudentId AND AssessmentComponentId = @AssessmentComponentId ", con);

                    cmd.Parameters.AddWithValue("@StudentId", id);
                    cmd.Parameters.AddWithValue("@AssessmentComponentId", component_id);
                    cmd.Parameters.AddWithValue("@RubricMeasurementId", measurement_id);
                    cmd.Parameters.AddWithValue("@EvaluationDate", DateTime.Now);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully saved");
                    //Guna.UI2.WinForms.MessageDialog.Show(this, "Successfully Marked", "inform", MessageDialogButtons.OK, MessageDialogIcon.Information);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                    //Guna.UI2.WinForms.MessageDialog.Show(err.Message, "warning", MessageDialogButtons.OK, MessageDialogIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Enter All Details");
                // Guna.UI2.WinForms.MessageDialog.Show(this, "Enter All Credentials", "warning", MessageDialogButtons.OK, MessageDialogIcon.Warning);
            }
        }
    }
}
