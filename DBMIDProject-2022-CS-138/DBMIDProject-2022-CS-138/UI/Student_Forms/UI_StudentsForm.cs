using DBMIDProject_2022_CS_138.DL.Student_Forms;
using DBMIDProject_2022_CS_138.UI.Student_Forms;
using DBMIDProject_2022_CS_138s;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBMIDProject_2022_CS_138.UI
{
    public partial class frm_StudentsUI : Form
    {
        public int status;
        public int student_id;
        public string first_name;
        public string last_name;
        public string contact;
        public string email;
        public string reg_no;
        public frm_StudentsUI()
        {
            InitializeComponent();
            showGrid();
            populateComboBox();
        }

        private void showGrid()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Id,FirstName,LastName,Contact,Email,RegistrationNumber  from Student Where Status=5", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid_Students.DataSource = dt;
        }
        private void populateComboBox()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Student'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Add an empty item for flexibility

            foreach (DataRow row in dt.Rows)
            {
                box_Sort.Items.Add(row["COLUMN_NAME"].ToString());
            }
            box_Sort.Text = box_Sort.Items[0].ToString();
        }

        private void refreshGrid()
        {
            grid_Students.DataSource = null;
            showGrid();
            grid_Students.Refresh();
        }

        private void box_Sort_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            UtilisImplementation.sortStudent(box_Sort.Text, grid_Students);
            btn_Search.PlaceholderText = "Search By " + box_Sort.Text;
        }

        private void btn_Search_TextChanged(object sender, System.EventArgs e)
        {
            if (btn_Search.Text != "")
            {

                string query = $"Select Id, FirstName, LastName, Contact, Email, RegistrationNumber from Student Where {box_Sort.Text}";
                UtilisImplementation.search(query, btn_Search.Text, grid_Students);
            }
            else
            {
                refreshGrid();
            }
        }
        private void btn_Add_Click_1(object sender, System.EventArgs e)
        {
            frm_StudentsAdd addStudent = new frm_StudentsAdd(student_id, ref status);
            addStudent.ShowDialog();
            refreshGrid();
        }

        private void btn_Edit_Click_1(object sender, System.EventArgs e)
        {
            student_id = int.Parse(grid_Students.CurrentRow.Cells[0].Value.ToString());
            first_name = grid_Students.CurrentRow.Cells[1].Value.ToString();
            last_name = grid_Students.CurrentRow.Cells[2].Value.ToString();
            contact = grid_Students.CurrentRow.Cells[3].Value.ToString();
            email = grid_Students.CurrentRow.Cells[4].Value.ToString();
            reg_no = grid_Students.CurrentRow.Cells[5].Value.ToString();
            frm_StudentsFormEdit editStudent = new frm_StudentsFormEdit(student_id, first_name, last_name, contact, email, reg_no, ref status);
            editStudent.ShowDialog();
            refreshGrid();
        }

        private void btn_Delete_Click_1(object sender, System.EventArgs e)
        {
            student_id = int.Parse(grid_Students.CurrentRow.Cells[0].Value.ToString());
            string fName = grid_Students.CurrentRow.Cells[1].Value.ToString();
            string email = grid_Students.CurrentRow.Cells[4].Value.ToString();
            string regNo = grid_Students.CurrentRow.Cells[5].Value.ToString();
            DL_Student.deleteStudent(fName, email, regNo, student_id, ref status);
            refreshGrid();
        }
    }
}
