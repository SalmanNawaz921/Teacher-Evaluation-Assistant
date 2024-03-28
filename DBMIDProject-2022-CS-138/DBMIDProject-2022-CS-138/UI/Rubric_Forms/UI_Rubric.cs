using DBMIDProject_2022_CS_138.DL.Rubric_Forms;
using DBMIDProject_2022_CS_138s;
using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBMIDProject_2022_CS_138.UI.Rubric_Forms
{
    public partial class frm_RubricsUI : Form
    {
        public Int32 rubricID = 1;
        public frm_RubricsUI()
        {
            InitializeComponent();
            showGrid();
            var con1 = Configuration.getInstance().getConnection();
            SqlCommand cmd1 = new SqlCommand("Select max(Id)+1 from Rubric", con1);
            object result = cmd1.ExecuteScalar();
            if (result != DBNull.Value && result != null)
            {
                rubricID = Convert.ToInt32(result);
            }
            else
            {
                rubricID = 1;
            }
        }


        private void showGrid()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Rubric", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid_Rubrics.DataSource = dt;

        }
        private void refreshGrid()
        {
            grid_Rubrics.DataSource = null;
            showGrid();
            grid_Rubrics.Refresh();
        }



        public void populateBox(Guna2ComboBox box)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Id from Clo", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            box.ValueMember = "Id";
            box.DataSource = dt;
        }

        private void btn_Add_Click_1(object sender, EventArgs e)
        {

            frm_RubricsAdd addRubric = new frm_RubricsAdd(ref rubricID, this);
            addRubric.ShowDialog();
            refreshGrid();
        }

        private void btn_Delete_Click_1(object sender, EventArgs e)
        {
            int rId = int.Parse(grid_Rubrics.CurrentRow.Cells[0].Value.ToString());
            DL_Rubrics.deleteRubric(ref rId);
            refreshGrid();
        }

        private void btn_Edit_Click_1(object sender, EventArgs e)
        {
            frm_RubricUpdate updateRubric = new frm_RubricUpdate(ref rubricID, this);
            updateRubric.ShowDialog();
            refreshGrid();
        }

        private void btn_Search_TextChanged(object sender, EventArgs e)
        {
            if (btn_Search.Text != "")
            {

                string query = "Select * from Rubric Where Id";
                UtilisImplementation.search(query, btn_Search.Text, grid_Rubrics);
            }
            else
            {
                refreshGrid();
            }
        }
    }
}

