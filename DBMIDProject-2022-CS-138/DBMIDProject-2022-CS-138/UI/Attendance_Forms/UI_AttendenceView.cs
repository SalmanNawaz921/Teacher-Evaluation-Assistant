using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBMIDProject_2022_CS_138.UI.Attendance_Forms
{
    public partial class frm_AttendenceView : Form
    {
        string dateTime;
        Int32 Ids = 0;
        public frm_AttendenceView(string dateTime)
        {
            InitializeComponent();
            this.dateTime = dateTime;
            refreshGrid();
        }

        public void showGrid()
        {
            DateTime date = DateTime.Now;
            date = Convert.ToDateTime(dateTime);
            var con1 = Configuration.getInstance().getConnection();
            SqlCommand cmd1 = new SqlCommand("Select max(Id) from ClassAttendance", con1);

            object result = cmd1.ExecuteScalar();
            Ids = result != DBNull.Value ? Convert.ToInt32(result) : 0;
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select distinct RegistrationNumber , FirstName + ' ' + LastName As Name,(select Name from Lookup where LookupId=StudentAttendance.AttendanceStatus) As Status From Student JOIN StudentAttendance on Student.Id=StudentAttendance.StudentId JOIN ClassAttendance on ClassAttendance.Id=StudentAttendance.AttendanceId  Where Status = 5 and AttendanceDate=@AttendanceDate", con);
            cmd.Parameters.AddWithValue("@Id", Ids);
            cmd.Parameters.AddWithValue("@AttendanceDate", date);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid_ClassAttendence.DataSource = dt;
        }
        public void refreshGrid()
        {
            grid_ClassAttendence.DataSource = null;
            grid_ClassAttendence.Refresh();
            showGrid();
            grid_ClassAttendence.Refresh();
        }
    }
}
