using DBMIDProject_2022_CS_138.DL.CLO_Forms;
using DBMIDProject_2022_CS_138s;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBMIDProject_2022_CS_138.UI.CLO_Forms
{
    public partial class frm_ClosUI : Form
    {
        public frm_ClosUI()
        {
            InitializeComponent();
            grid_CLOs.BringToFront();
            showGrid();

        }
        private void showGrid()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Clo", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid_CLOs.DataSource = dt;
        }
        private void refreshGrid()
        {
            grid_CLOs.DataSource = null;
            showGrid();
            grid_CLOs.Refresh();
        }





        private void btn_Search_TextChanged(object sender, System.EventArgs e)
        {
            if (btn_Search.Text != "")
            {

                string query = "Select * from Clo Where Name";
                UtilisImplementation.search(query, btn_Search.Text, grid_CLOs);
            }
            else
            {
                refreshGrid();
            }
        }

        private void btn_Add_Click_1(object sender, System.EventArgs e)
        {
            frm_CloAdd addClo = new frm_CloAdd();
            addClo.ShowDialog();
            refreshGrid();
        }

        private void btn_Delete_Click_1(object sender, System.EventArgs e)
        {
            int clo_id = int.Parse(grid_CLOs.CurrentRow.Cells[0].Value.ToString());
            DL_Clos.deleteClo(clo_id);
            refreshGrid();
        }

        private void btn_Edit_Click(object sender, System.EventArgs e)
        {
            int clo_id = int.Parse(grid_CLOs.CurrentRow.Cells[0].Value.ToString());
            frm_CloEdit editClo = new frm_CloEdit(clo_id);
            editClo.ShowDialog();
            refreshGrid();
        }
    }
}
