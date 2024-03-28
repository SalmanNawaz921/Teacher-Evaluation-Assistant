using Guna.UI2.WinForms;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBMIDProject_2022_CS_138.UI.Student_Result_Forms
{
    public partial class frm_StudentResultList : Form
    {
        public frm_StudentResultList()
        {
            InitializeComponent();
            showGrid();
        }

        public void showGrid()
        {
            var con = Configuration.getInstance().getConnection();
            //SqlCommand cmd = new SqlCommand("SELECT Name, RegistrationNumber, ObtainedMarks, TotalMarks, AssessmentComponentName, RubricMeasurementId, AssessmentComponent, Title FROM(SELECT FirstName + ' ' + LastName AS Name, RegistrationNumber, (CONVERT(FLOAT, RubricLevel.MeasurementLevel) / MAX(RubricLevel.MeasurementLevel) OVER() * AssessmentComponent.TotalMarks) AS ObtainedMarks, AssessmentComponent.TotalMarks,(SELECT AssessmentComponent.Name FROM AssessmentComponent JOIN StudentResult ON StudentResult.AssessmentComponentId= AssessmentComponent.Id WHERE StudentResult.AssessmentComponentId= AssessmentComponent.Id) AS AssessmentComponentName , RubricMeasurementId,AssessmentComponent.Name AS AssessmentComponent, Assessment.Title FROM Student JOIN StudentResult ON Student.Id = StudentResult.StudentId JOIN RubricLevel ON StudentResult.RubricMeasurementId = RubricLevel.Id JOIN Rubric ON RubricLevel.RubricId = Rubric.Id JOIN AssessmentComponent ON Rubric.Id = AssessmentComponent.RubricId JOIN Assessment ON AssessmentComponent.AssessmentId = Assessment.Id WHERE StudentResult.StudentId = StudentId AND AssessmentComponent.Id = AssessmentComponentId) AS subquery", con);
            SqlCommand cmd = new SqlCommand("SELECT FirstName + ' ' + LastName AS Name, RegistrationNumber, (CONVERT(FLOAT, RubricLevel.MeasurementLevel) / MAX(RubricLevel.MeasurementLevel) OVER()) * AssessmentComponent.TotalMarks AS ObtainedMarks,    AssessmentComponent.TotalMarks AS TotalMarks,   AssessmentComponent.Name AS AssessmentComponentName,     Assessment.Title FROM Student JOIN StudentResult ON Student.Id = StudentResult.StudentId JOIN RubricLevel ON StudentResult.RubricMeasurementId = RubricLevel.Id JOIN Rubric ON RubricLevel.RubricId = Rubric.Id JOIN AssessmentComponent ON Rubric.Id = AssessmentComponent.RubricId JOIN Assessment ON AssessmentComponent.AssessmentId = Assessment.Id WHERE StudentResult.StudentId = StudentId AND AssessmentComponent.Id = AssessmentComponentId;", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid_StudentsResult.DataSource = dt;
        }
        public void refreshGrid()
        {
            grid_StudentsResult.DataSource = null;
            grid_StudentsResult.Refresh();
            showGrid();
        }

        private void grid_StudentsResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Download_Click(object sender, System.EventArgs e)
        {
            downloadResultReport();
        }
        private void downloadResultReport()
        {
            string reportTitle = "Overall Result";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.Title = "Save Result";
            saveFileDialog.FileName = "Overall Assessment Report.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                DataGridView dataGridView = grid_StudentsResult;
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
