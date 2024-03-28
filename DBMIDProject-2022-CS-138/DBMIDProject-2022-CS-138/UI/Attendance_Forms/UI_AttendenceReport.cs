using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBMIDProject_2022_CS_138.UI.Attendance_Forms
{
    public partial class frm_AttendenceReport : Form
    {
        Int32 Ids = 0;
        public frm_AttendenceReport()
        {
            InitializeComponent();
            showGrid();
        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            downloadAttendenceReport();
        }

        private void showGrid()
        {
            DateTime date = DateTime.Now;
            string[] headers = { "Id", "Registration Number", "Name", "Status" };
            date = Convert.ToDateTime(box_Date.Text);
            var dates = date.ToString("yyyy-MM-dd");
            var con1 = Configuration.getInstance().getConnection();
            SqlCommand cmd1 = new SqlCommand("Select max(Id) from ClassAttendance", con1);
            object result = cmd1.ExecuteScalar();
            Ids = result != DBNull.Value ? Convert.ToInt32(result) : 0; var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT Student.RegistrationNumber ,CONCAT(Student.FirstName, ' ', Student.LastName) AS Name,(SELECT Name FROM Lookup WHERE LookupId=StudentAttendance.AttendanceStatus) AS Status FROM Student JOIN StudentAttendance ON Student.Id=StudentAttendance.StudentId JOIN ClassAttendance ON ClassAttendance.Id=StudentAttendance.AttendanceId WHERE Status = 5 AND AttendanceDate=@AttendanceDate", con);
            cmd.Parameters.AddWithValue("@Id", Ids);
            cmd.Parameters.AddWithValue("@AttendanceDate", date);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid_AttendenceReport.DataSource = dt;
        }
        private void downloadAttendenceReport()
        {
            var date = Convert.ToDateTime(box_Date.Text);
            var dates = date.ToString("yyyy-MM-dd");
            string reportTitle = $"Attendence Report - {dates}";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.Title = "Save Attendance Report";
            saveFileDialog.FileName = $"{box_Date.Text} Attendance Report.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                DataGridView dataGridView = grid_AttendenceReport;
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
        private void box_Date_ValueChanged(object sender, EventArgs e)
        {
            grid_AttendenceReport.DataSource = null;
            showGrid();
            grid_AttendenceReport.Refresh();
        }

        private void btn_CompleteReport_Click(object sender, EventArgs e)
        {

            frm_CompleteAttendenceReport completeReport = new frm_CompleteAttendenceReport();
            completeReport.ShowDialog();
        }

        private DataTable completeAttendanceReportGrid(DataGridView dataGridView1)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("DECLARE @cols AS NVARCHAR(MAX), @query AS NVARCHAR(MAX), @MinDate DATE, @MaxDate DATE, @SQL NVARCHAR(MAX); SELECT @MinDate = MIN(AttendanceDate), @MaxDate = MAX(AttendanceDate) FROM ClassAttendance; SET @cols = ''; WHILE @MinDate <= @MaxDate BEGIN SET @cols = CONCAT(@cols, ', MAX(CASE WHEN AttendanceDate = ''', CONVERT(VARCHAR(10), @MinDate, 120), ''' THEN CASE sa.AttendanceStatus WHEN 1 THEN ''Present'' WHEN 2 THEN ''Absent'' WHEN 3 THEN ''Late'' WHEN 4 THEN ''Leave'' ELSE ''Not Marked Yet'' END ELSE NULL END) AS [', CONVERT(VARCHAR(10), @MinDate, 120), ']'); SET @MinDate = DATEADD(DAY, 1, @MinDate); END; SET @SQL = 'SELECT s.FirstName + '' '' + s.LastName AS Name' + @cols + ' FROM Student s LEFT JOIN StudentAttendance sa ON s.Id = sa.StudentId LEFT JOIN ClassAttendance ca ON ca.Id = sa.AttendanceId GROUP BY s.Id, s.FirstName, s.LastName ORDER BY s.LastName, s.FirstName'; EXEC sp_executesql @SQL;", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            return dt;
        }

        private void btn_Download_Click_1(object sender, EventArgs e)
        {
            downloadAttendenceReport();
        }
    }
}
