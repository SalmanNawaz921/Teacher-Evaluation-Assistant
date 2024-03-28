using DBMIDProject_2022_CS_138.DL.Rubric_Level;
using DBMIDProject_2022_CS_138s;
using Guna.UI2.WinForms;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBMIDProject_2022_CS_138.UI.Rubric_Level_Forms
{
    public partial class frm_RubricLevel : Form
    {
        public frm_RubricLevel()
        {
            InitializeComponent();
            showGrid();
        }
        public void populateBox(Guna2ComboBox box)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Id from Rubric", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            box.ValueMember = "Id";
            box.DataSource = dt;
        }
        private void showGrid()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from RubricLevel", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid_RubricLevel.DataSource = dt;

        }
        private void refreshGrid()
        {
            grid_RubricLevel.DataSource = null;
            showGrid();
            grid_RubricLevel.Refresh();
        }

        private void btn_Add_Click(object sender, System.EventArgs e)
        {
            frm_RubricLevelAdd addRubricLevel = new frm_RubricLevelAdd(this);
            addRubricLevel.ShowDialog();
            refreshGrid();
        }

        private void btn_Edit_Click(object sender, System.EventArgs e)
        {
            int rubricLevelId = int.Parse(grid_RubricLevel.CurrentRow.Cells[0].Value.ToString());
            frm_RubricLevelEdit editRubricLevel = new frm_RubricLevelEdit(rubricLevelId, this);
            editRubricLevel.ShowDialog();
            refreshGrid();
        }

        private void btn_Delete_Click(object sender, System.EventArgs e)
        {
            int rubricLevelId = int.Parse(grid_RubricLevel.CurrentRow.Cells[0].Value.ToString());
            DL_RubricLevel.deleteRubricLevel(rubricLevelId);
            refreshGrid();
        }

        private void btn_Search_TextChanged(object sender, System.EventArgs e)
        {
            if (btn_Search.Text != "")
            {

                string query = "Select * from RubricLevel Where Id";
                UtilisImplementation.search(query, btn_Search.Text, grid_RubricLevel);
            }
            else
            {
                refreshGrid();
            }
        }
    }
}
