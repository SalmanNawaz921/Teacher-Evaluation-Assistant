using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBMIDProject_2022_CS_138.UI.Student_Forms
{
    public partial class frm_StudentInactive : Form
    {
        Int32 status = 0;
        public frm_StudentInactive()
        {
            InitializeComponent();
            showGrid();
        }

        private void showGrid()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Id,RegistrationNumber,FirstName,LastName,Contact,Email from Student where status=6", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid_StudentsInactive.DataSource = dt;
        }
        private void refreshGrid()
        {
            grid_StudentsInactive.DataSource = null;
            showGrid();
            grid_StudentsInactive.Refresh();
        }
        private void btn_Active_Click(object sender, System.EventArgs e)
        {
            makeStudentActive();
            refreshGrid();
        }

        private void makeStudentActive()
        {
            try
            {
                int acid = int.Parse(grid_StudentsInactive.CurrentRow.Cells[0].Value.ToString());
                var con1 = Configuration.getInstance().getConnection();
                SqlCommand cmd1 = new SqlCommand("Select LookupId from Lookup where Name='Active'", con1);
                status = (Int32)cmd1.ExecuteScalar();
                cmd1.ExecuteNonQuery();
                if (acid >= 0)
                {

                    try
                    {
                        var con = Configuration.getInstance().getConnection();
                        //string Id=Convert.ToString(ProcessCmdKey)
                        SqlCommand cmd = new SqlCommand("update Student set Status=@Status where Id=@Id", con);
                        //MaterialMessageBox.Show(sid.ToString());
                        cmd.Parameters.AddWithValue("@Status", status);
                        cmd.Parameters.AddWithValue("@Id", acid);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully Changed Status to Active", "inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                    }
                }
                else
                {
                    MessageBox.Show("No Student Exists", "inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
