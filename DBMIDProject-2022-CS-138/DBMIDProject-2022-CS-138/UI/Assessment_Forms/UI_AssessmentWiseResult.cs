using Guna.UI2.WinForms;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBMIDProject_2022_CS_138.UI.Assessment_Forms
{
    public partial class frm_AssessmentWiseResult : Form
    {
        public frm_AssessmentWiseResult()
        {
            InitializeComponent();
            populateBox();
            showGrid();
        }
        public void populateBox()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Title from Assessment", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            box_Assessment.ValueMember = "Title";
            box_Assessment.DataSource = dt;
        }

        private void showGrid()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT SubQuery.RegistrationNumber, SubQuery.Name, SubQuery.TotalMarks, SUM(SubQuery.ObtainedMarks) AS ObtainedMarks, SubQuery.TotalWeightage, SUM(SubQuery.ObtainedWeightage) AS ObtainedWeightage FROM(SELECT DISTINCT S.RegistrationNumber, S.FirstName + '' + S.LastName AS Name, A.Title, A.TotalMarks, A.Totalweightage, (CONVERT(FLOAT, RL.MeasurementLevel) / MAX(RL.MeasurementLevel) OVER() * AC.TotalMarks) AS ObtainedMarks, ((CONVERT(FLOAT, RL.MeasurementLevel) / MAX(RL.MeasurementLevel) OVER() * AC.TotalMarks) / A.TotalMarks * A.TotalWeightage) AS ObtainedWeightage FROM Student S JOIN StudentResult SR ON S.Id = SR.StudentId JOIN RubricLevel RL ON SR.RubricMeasurementId = RL.Id JOIN Rubric R ON RL.RubricId = R.Id JOIN AssessmentComponent AC ON R.Id = AC.RubricId JOIN Assessment A ON AC.AssessmentId = A.Id WHERE SR.StudentId = [StudentId] AND AC.Id = [AssessmentComponentId] AND A.Title ='" + box_Assessment.Text + "') AS SubQuery GROUP BY SubQuery.RegistrationNumber, SubQuery.Name, SubQuery.TotalMarks, SubQuery.TotalWeightage", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid_AssessmentWiseResult.DataSource = dt;

        }
        private void refreshGrid()
        {
            grid_AssessmentWiseResult.DataSource = null;
            showGrid();
            grid_AssessmentWiseResult.Refresh();
        }

        private void box_Assessment_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            refreshGrid();
        }



        private void btn_Download_Click(object sender, System.EventArgs e)
        {
            downloadAssessmentWiseResult();
        }
        private void downloadAssessmentWiseResult()
        {
            string reportTitle = $"{box_Assessment.Text} Assessment Report";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.Title = "Save Assessment Report";
            saveFileDialog.FileName = $"{box_Assessment.Text} Assessment Report.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                DataGridView dataGridView = grid_AssessmentWiseResult;
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
    }
}
