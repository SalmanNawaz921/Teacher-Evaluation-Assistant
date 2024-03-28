using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBMIDProject_2022_CS_138.DL.Attendance
{
    class DL_Attendance
    {
        public static int GetAttendenceId(DateTime date)
        {
            var con = Configuration.getInstance().getConnection();
            int attendanceId;
            try
            {
                SqlCommand cmd = new SqlCommand("Select Id from ClassAttendance Where AttendanceDate=@Date", con);
                cmd.Parameters.AddWithValue("@Date", date);
                attendanceId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch
            {
                attendanceId = 0;
            }
            return attendanceId;
        }

        public static int GetAttendanceStatus(int student_id, int attendance_id)
        {

            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd3 = new SqlCommand("Select StudentId from StudentAttendance where AttendanceId=@CA and StudentId=@Id", con);
            cmd3.Parameters.AddWithValue("@CA", attendance_id);
            cmd3.Parameters.AddWithValue("@Id", student_id);
            int scheck = Convert.ToInt32(cmd3.ExecuteScalar());
            return scheck;
        }

        public static void InsertStudentAttendance(int attendanceId, string studentId, int status)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("INSERT into StudentAttendance values(@AttendanceId,@StudentId,@AttendanceStatus)", con);
            cmd.Parameters.AddWithValue("@AttendanceId", attendanceId);
            cmd.Parameters.AddWithValue("@StudentId", studentId);
            cmd.Parameters.AddWithValue("@AttendanceStatus", status);
            cmd.ExecuteNonQuery();

        }

        public static void UpdateStudentAttendance(int attendanceId, string studentId, int status)
        {
            var con = Configuration.getInstance().getConnection();

            SqlCommand cmd = new SqlCommand("UPDATE StudentAttendance SET AttendanceStatus=@AttendanceStatus where AttendanceId=@AttendanceId and StudentId=@StudentId", con);
            cmd.Parameters.AddWithValue("@AttendanceId", attendanceId);
            cmd.Parameters.AddWithValue("@StudentId", studentId);
            cmd.Parameters.AddWithValue("@AttendanceStatus", status);
            cmd.ExecuteNonQuery();

        }
        public static void UpdateStudentAttendanceInGrid(int rowIndex, string studentId, int columnIndex, int currentStatus, DataGridView grid_StudentAttendence, int attendanceId)
        {

            grid_StudentAttendence.Rows[rowIndex].Cells[0].Value = false;
            grid_StudentAttendence.Rows[rowIndex].Cells[1].Value = false;
            grid_StudentAttendence.Rows[rowIndex].Cells[2].Value = false;
            grid_StudentAttendence.Rows[rowIndex].Cells[3].Value = false;

            int newStatus;
            switch (columnIndex)
            {
                case 0:
                    newStatus = 1;
                    break;
                case 1:
                    newStatus = 2;
                    break;
                case 2:
                    newStatus = 3;
                    break;
                case 3:

                    newStatus = 4;
                    break;
                default:
                    return;
            }

            if (currentStatus == 0)
            {
                InsertStudentAttendance(attendanceId, studentId, newStatus);
            }
            else
            {
                UpdateStudentAttendance(attendanceId, studentId, newStatus);
            }

            grid_StudentAttendence.Rows[rowIndex].Cells[columnIndex].Value = true;
        }
    }
}
