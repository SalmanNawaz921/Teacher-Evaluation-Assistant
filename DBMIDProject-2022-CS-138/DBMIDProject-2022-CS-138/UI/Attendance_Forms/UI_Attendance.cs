using DBMIDProject_2022_CS_138.DL.Attendance;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBMIDProject_2022_CS_138.UI.Attendance_Forms
{
    public partial class frm_Attendance : Form
    {
        int count;
        public frm_Attendance()
        {
            InitializeComponent();
            count = 0;
            showGrid();
            //box_Date.Value = DateTime.Now;
        }

        public void showGrid()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Id,RegistrationNumber,FirstName+' '+LastName as Name from Student where Status='5'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataGridViewCheckBoxColumn checkBoxColumn1 = new DataGridViewCheckBoxColumn();
            checkBoxColumn1.HeaderText = "Present";
            checkBoxColumn1.Width = 50;
            checkBoxColumn1.Name = "checkBoxColumn1";
            checkBoxColumn1.TrueValue = "Yes";
            checkBoxColumn1.FalseValue = "No";

            // Create second checkbox column
            DataGridViewCheckBoxColumn checkBoxColumn2 = new DataGridViewCheckBoxColumn();
            checkBoxColumn2.HeaderText = "Absent";
            checkBoxColumn2.Width = 50;
            checkBoxColumn2.Name = "checkBoxColumn2";
            checkBoxColumn2.TrueValue = "On";
            checkBoxColumn2.FalseValue = "Off";

            // Add columns to DataGridView control
            DataGridViewCheckBoxColumn checkBoxColumn3 = new DataGridViewCheckBoxColumn();
            checkBoxColumn3.HeaderText = "Leave";
            checkBoxColumn3.Width = 50;
            checkBoxColumn3.Name = "checkBoxColumn3";
            checkBoxColumn3.TrueValue = "On";
            checkBoxColumn3.FalseValue = "Off";

            DataGridViewCheckBoxColumn checkBoxColumn4 = new DataGridViewCheckBoxColumn();
            checkBoxColumn4.HeaderText = "Late";
            checkBoxColumn4.Width = 50;
            checkBoxColumn4.Name = "checkBoxColumn4";
            checkBoxColumn4.TrueValue = "On";
            checkBoxColumn4.FalseValue = "Off";
            if (count == 0)
            {
                grid_StudentAttendence.DataSource = dt;
                grid_StudentAttendence.Columns.Add(checkBoxColumn1);
                grid_StudentAttendence.Columns.Add(checkBoxColumn2);
                grid_StudentAttendence.Columns.Add(checkBoxColumn3);
                grid_StudentAttendence.Columns.Add(checkBoxColumn4);
                count++;
            }
        }

        public void refreshGrid()
        {
            grid_StudentAttendence.DataSource = null;
            showGrid();
            grid_StudentAttendence.Refresh();
        }
        private void btn_View_Click(object sender, EventArgs e)
        {
            frm_AttendenceView viewAttendence = new frm_AttendenceView(box_Date.Text);
            viewAttendence.refreshGrid();
            viewAttendence.ShowDialog();

        }



        private void box_Date_ValueChanged(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            var date = DateTime.Now.ToString("yyyy-MM-dd");
            DateTime dates = Convert.ToDateTime(box_Date.Text);
            if (dates <= DateTime.Now)
            {
                SqlCommand cmd1 = new SqlCommand("Select Id from ClassAttendance where AttendanceDate=@Date", con);
                cmd1.Parameters.AddWithValue("@Date", dates);
                int id = Convert.ToInt32(cmd1.ExecuteScalar());
                if (id == 0)
                {
                    SqlCommand cmd = new SqlCommand("INSERT Into ClassAttendance Values(@AttendanceDate)", con);
                    cmd.Parameters.AddWithValue("@AttendanceDate", dates);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Date has been Added", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Date has Already Added", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Date Can't be greater than " + date, "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                box_Date.Value = DateTime.Now.Date;
            }
            box_Date.Refresh();
            grid_StudentAttendence.Refresh();

        }

        private void grid_StudentAttendence_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var date = Convert.ToDateTime(box_Date.Text);
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            int attendanceId = DL_Attendance.GetAttendenceId(date);

            if (attendanceId == 0)
            {
                MessageBox.Show("Date has not been added");
                return;
            }

            string studentId = grid_StudentAttendence.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            int studentAttendanceStatus = DL_Attendance.GetAttendanceStatus(int.Parse(studentId), attendanceId);
            DL_Attendance.UpdateStudentAttendanceInGrid(e.RowIndex, studentId, e.ColumnIndex, studentAttendanceStatus, grid_StudentAttendence, attendanceId);
        }

        private void btn_Search_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

