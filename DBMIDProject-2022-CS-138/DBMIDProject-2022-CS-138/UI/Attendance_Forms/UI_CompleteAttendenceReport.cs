using Guna.UI2.WinForms;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBMIDProject_2022_CS_138.UI.Attendance_Forms
{
    public partial class frm_CompleteAttendenceReport : Form
    {
        DataTable dt;
        public frm_CompleteAttendenceReport()
        {
            InitializeComponent();
            dt = showGrid();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private DataTable showGrid()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("DECLARE @cols AS NVARCHAR(MAX), @query AS NVARCHAR(MAX), @MinDate DATE, @MaxDate DATE, @SQL NVARCHAR(MAX); SELECT @MinDate = MIN(AttendanceDate), @MaxDate = MAX(AttendanceDate) FROM ClassAttendance; SET @cols = ''; WHILE @MinDate <= @MaxDate BEGIN SET @cols = CONCAT(@cols, ', MAX(CASE WHEN AttendanceDate = ''', CONVERT(VARCHAR(10), @MinDate, 120), ''' THEN CASE sa.AttendanceStatus WHEN 1 THEN ''Present'' WHEN 2 THEN ''Absent'' WHEN 3 THEN ''Late'' WHEN 4 THEN ''Leave'' ELSE ''Not Marked Yet'' END ELSE NULL END) AS [', CONVERT(VARCHAR(10), @MinDate, 120), ']'); SET @MinDate = DATEADD(DAY, 1, @MinDate); END; SET @SQL = 'SELECT s.FirstName + '' '' + s.LastName AS Name' + @cols + ' FROM Student s LEFT JOIN StudentAttendance sa ON s.Id = sa.StudentId LEFT JOIN ClassAttendance ca ON ca.Id = sa.AttendanceId GROUP BY s.Id, s.FirstName, s.LastName ORDER BY s.LastName, s.FirstName'; EXEC sp_executesql @SQL;", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid_CompleteAttendenceReport.DataSource = dt;
            return dt;
        }
        private void refreshGrid()
        {

        }

        private void btn_CompleteReport_Click(object sender, System.EventArgs e)
        {
            downloadAttendanceReport();
        }

        private void downloadAttendanceReport()
        {
            string reportTitle = " Complete Attendance Report";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.Title = "Save Attendance Report";
            saveFileDialog.FileName = "Overall Attendance Report.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                DataGridView dataGridView = grid_CompleteAttendenceReport;
                MessageBox.Show(dataGridView.ColumnCount.ToString());
                if (dataGridView.ColumnCount > 0)
                {

                    ReportGenerator reportGenerator = new ReportGenerator(reportTitle, filePath, dt);
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
