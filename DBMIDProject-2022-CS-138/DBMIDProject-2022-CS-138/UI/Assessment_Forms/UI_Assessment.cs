using DBMIDProject_2022_CS_138.DL.Assessment_Forms;
using DBMIDProject_2022_CS_138s;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBMIDProject_2022_CS_138.UI.Assessment_Forms
{
    public partial class frm_AssessmentUI : Form
    {
        public frm_AssessmentUI()
        {
            InitializeComponent();
            showGrid();
            panel1.BringToFront();
        }
        private void showGrid()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Assessment", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid_Assessment.DataSource = dt;
        }
        private void refreshGrid()
        {
            grid_Assessment.DataSource = null;
            showGrid();
            grid_Assessment.Refresh();
        }


        private void btn_Delete_Click_1(object sender, System.EventArgs e)
        {

            int assessment_ID = int.Parse(grid_Assessment.CurrentRow.Cells[0].Value.ToString());
            DL_Assessment.deleteAssessment(ref assessment_ID, this);
            refreshGrid();
        }

        private void btn_Edit_Click_1(object sender, System.EventArgs e)
        {
            int assessment_ID = int.Parse(grid_Assessment.CurrentRow.Cells[0].Value.ToString());
            frm_AssessmentEdit editAssement = new frm_AssessmentEdit(ref assessment_ID);
            editAssement.ShowDialog();
            refreshGrid();
        }

        private void btn_Add_Click_1(object sender, System.EventArgs e)
        {
            frm_AssessmentAdd addAssessment = new frm_AssessmentAdd();
            addAssessment.ShowDialog();
            refreshGrid();
        }

        private void btn_Search_TextChanged(object sender, System.EventArgs e)
        {
            if (btn_Search.Text != "")
            {

                string query = "Select * from Assessment Where Clo";
                UtilisImplementation.search(query, btn_Search.Text, grid_Assessment);
            }
            else
            {
                refreshGrid();
            }
        }
    }
}
