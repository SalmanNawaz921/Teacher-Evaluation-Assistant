using DBMIDProject_2022_CS_138.DL.Assessment_Forms;
using System;
using System.Windows.Forms;

namespace DBMIDProject_2022_CS_138.UI.Assessment_Forms
{
    public partial class frm_AssessmentEdit : Form
    {
        private int assessmentID;
        public frm_AssessmentEdit(ref int assessmentID)
        {
            InitializeComponent();
            this.assessmentID = assessmentID;
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            DL_Assessment.updateAssessment(ref assessmentID, txt_Title.Text, txt_TMarks.Text, txt_TWeightage.Text, this);
        }
    }
}
