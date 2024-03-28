using DBMIDProject_2022_CS_138.DL.Assessment_Component;
using DBMIDProject_2022_CS_138s;
using Guna.UI2.WinForms;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBMIDProject_2022_CS_138.UI.Assessment_Component_Forms
{
    public partial class frm_AssessmentComponent : Form
    {
        public frm_AssessmentComponent()
        {
            InitializeComponent();
            showGrid();
        }
        private void showGrid()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from AssessmentComponent", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid_AssessmentComponent.DataSource = dt;
        }
        private void refreshGrid()
        {
            grid_AssessmentComponent.DataSource = null;
            showGrid();
            grid_AssessmentComponent.Refresh();
        }

        public void populateBox(Guna2ComboBox box, string tableName)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand($"Select Id from {tableName}", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            box.ValueMember = "Id";
            box.DataSource = dt;
        }

        private void btn_Add_Click(object sender, System.EventArgs e)
        {
            frm_AssessmentComponentAdd addAssessmentComponent = new frm_AssessmentComponentAdd(this);
            addAssessmentComponent.ShowDialog();
            refreshGrid();

        }

        private void btn_Edit_Click(object sender, System.EventArgs e)
        {

            int assessmentComponentId = int.Parse(grid_AssessmentComponent.CurrentRow.Cells[0].Value.ToString());
            frm_AssessmentComponentEdit editComponent = new frm_AssessmentComponentEdit(assessmentComponentId, this);
            editComponent.ShowDialog();
            refreshGrid();
        }

        private void btn_Delete_Click(object sender, System.EventArgs e)
        {
            int assessmentComponentId = int.Parse(grid_AssessmentComponent.CurrentRow.Cells[0].Value.ToString());
            DL_AssessmentComponent.deleteAssessementComponent(assessmentComponentId);
            refreshGrid();
        }

        private void btn_Search_TextChanged(object sender, System.EventArgs e)
        {
            if (btn_Search.Text != "")
            {

                string query = "Select * from AssessmentComponent Where Name";
                UtilisImplementation.search(query, btn_Search.Text, grid_AssessmentComponent);
            }
            else
            {
                refreshGrid();
            }
        }
    }
}
