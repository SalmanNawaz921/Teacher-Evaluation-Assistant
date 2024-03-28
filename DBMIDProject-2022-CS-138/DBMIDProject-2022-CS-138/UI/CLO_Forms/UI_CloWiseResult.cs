using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBMIDProject_2022_CS_138.UI.CLO_Forms
{
    public partial class frm_CloWiseResult : Form
    {
        public frm_CloWiseResult()
        {
            InitializeComponent();
            populateBox();
            showGrid();
        }

        public void populateBox()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Name from Clo", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            box_Clo.ValueMember = "Name";
            box_Clo.DataSource = dt;
        }

        private void showGrid()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand(
                "SELECT RegistrationNumber, Name, SUM(TotalMarks) AS TotalMarks, SUM(ObtainedMarks) AS ObtainedMarks FROM( SELECT S.RegistrationNumber, S.FirstName + ' ' + S.LastName AS Name, Clo.Name AS[CLO Name], Clo.Id, A.Title, AC.Name AS[Assessment Component Name], AC.TotalMarks AS TotalMarks, A.Totalweightage, (CONVERT(FLOAT, RL.MeasurementLevel) / MAX(RL.MeasurementLevel) OVER() * AC.TotalMarks) AS ObtainedMarks, ((CONVERT(FLOAT, RL.MeasurementLevel) / MAX(RL.MeasurementLevel) OVER() * AC.TotalMarks) / A.TotalMarks * A.TotalWeightage) AS ObtainedWeightage FROM Student S INNER JOIN StudentResult SR ON S.Id = SR.StudentId INNER JOIN RubricLevel RL ON SR.RubricMeasurementId = RL.Id INNER JOIN Rubric R ON RL.RubricId = R.Id INNER JOIN Clo ON R.CloId = Clo.Id INNER JOIN AssessmentComponent AC ON R.Id = AC.RubricId INNER JOIN Assessment A ON AC.AssessmentId = A.Id WHERE SR.StudentId = [StudentId] AND AC.Id = [AssessmentComponentId]) AS NewTable WHERE [CLO Name] ='" + box_Clo.Text + "'GROUP BY RegistrationNumber, Name, Title", con);
            //SqlCommand cmd = new SqlCommand($"SELECT \r\n    S.RegistrationNumber, \r\n    S.FirstName + ' ' + S.LastName AS Name, \r\n    Clo.Name AS [CLO Name], \r\n    SUM(CONVERT(FLOAT, RL.MeasurementLevel) / MAX(RL.MeasurementLevel) OVER() * AC.TotalMarks) AS ObtainedMarks, \r\n    SUM(CONVERT(FLOAT, RL.MeasurementLevel) / MAX(RL.MeasurementLevel) OVER() * AC.TotalMarks / A.TotalMarks * A.TotalWeightage) AS ObtainedWeightage \r\nFROM \r\n    Student S \r\n    INNER JOIN StudentResult SR ON S.Id = SR.StudentId \r\n    INNER JOIN RubricLevel RL ON SR.RubricMeasurementId = RL.Id \r\n    INNER JOIN Rubric R ON RL.RubricId = R.Id \r\n    INNER JOIN Clo ON R.CloId = Clo.Id \r\n    INNER JOIN AssessmentComponent AC ON R.Id = AC.RubricId \r\n    INNER JOIN Assessment A ON AC.AssessmentId = A.Id \r\nWHERE \r\n    SR.StudentId = StudentId \r\n    AND AC.Id = AssessmentComponentId \r\n    AND        Clo.Name = @CloName \r\n \r\nGROUP BY \r\n    S.RegistrationNumber, \r\n    S.FirstName, \r\n    S.LastName, \r\n    Clo.Name;\r\n", con);
            //cmd.Parameters.AddWithValue("@CloName", box_Clo.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid_CloWiseResult.DataSource = dt;

        }
        private void refreshGrid()
        {
            grid_CloWiseResult.DataSource = null;
            showGrid();
            grid_CloWiseResult.Refresh();
        }
        private void box_Clo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void downloadCloReport()
        {
            string reportTitle = " Course Learning Outcome Attainment Report";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.Title = "Save Clo Report";
            saveFileDialog.FileName = $"{box_Clo.Text} Clo Result.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                DataGridView dataGridView = grid_CloWiseResult;
                if (dataGridView != null)
                {

                    ReportGenerator reportGenerator = new ReportGenerator(reportTitle, filePath, dataGridView);
                    reportGenerator.GenerateReport();
                }
                else
                {
                    Guna.UI2.WinForms.MessageDialog.Show("The Grid is empty", "error", MessageDialogButtons.OK, MessageDialogIcon.Error);
                }
            }
        }
        private void btn_Download_Click(object sender, EventArgs e)
        {
            downloadCloReport();

        }

        private void btn_Next_Click(object sender, EventArgs e)
        {

        }

        private void btn_Prev_Click(object sender, EventArgs e)
        {

        }

        private void box_Clo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            refreshGrid();

        }

        private void btn_Download_Click_1(object sender, EventArgs e)
        {
            downloadCloReport();
        }
    }
}
