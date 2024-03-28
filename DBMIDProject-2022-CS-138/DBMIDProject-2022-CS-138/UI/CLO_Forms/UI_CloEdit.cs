using DBMIDProject_2022_CS_138.DL.CLO_Forms;
using System;
using System.Windows.Forms;

namespace DBMIDProject_2022_CS_138.UI.CLO_Forms
{
    public partial class frm_CloEdit : Form
    {
        private int clo_id;
        public frm_CloEdit(int clo_id)
        {
            InitializeComponent();
            this.clo_id = clo_id;
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            DL_Clos.updateClo(txt_Name.Text, clo_id, this);

        }
    }
}
