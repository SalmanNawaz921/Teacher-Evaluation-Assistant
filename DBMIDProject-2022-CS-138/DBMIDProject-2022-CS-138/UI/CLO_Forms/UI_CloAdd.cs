using DBMIDProject_2022_CS_138.DL.CLO_Forms;
using System.Windows.Forms;

namespace DBMIDProject_2022_CS_138.UI.CLO_Forms
{
    public partial class frm_CloAdd : Form
    {
        public frm_CloAdd()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, System.EventArgs e)
        {
            DL_Clos.addClo(txt_Name.Text, this);
        }
    }
}
