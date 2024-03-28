using DBMIDProject_2022_CS_138.DL.Assessment_Forms;
using System;
using System.Windows.Forms;

namespace DBMIDProject_2022_CS_138.UI.Assessment_Forms
{
    public partial class frm_AssessmentAdd : Form
    {
        public frm_AssessmentAdd()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            DL_Assessment.addAssessment(txt_Title.Text, txt_TMarks.Text, txt_TWeightage.Text, this);
        }
    }
}
