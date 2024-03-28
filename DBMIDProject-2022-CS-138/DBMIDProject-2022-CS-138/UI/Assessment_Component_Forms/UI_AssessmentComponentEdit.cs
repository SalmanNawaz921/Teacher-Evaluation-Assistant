using DBMIDProject_2022_CS_138.DL.Assessment_Component;
using System;
using System.Windows.Forms;

namespace DBMIDProject_2022_CS_138.UI.Assessment_Component_Forms
{
    public partial class frm_AssessmentComponentEdit : Form
    {
        private int assessmentComponentId;
        private frm_AssessmentComponent assessmentComponent;
        public frm_AssessmentComponentEdit(int assessmentComponentId, frm_AssessmentComponent assessmentComponent)
        {
            InitializeComponent();
            this.assessmentComponentId = assessmentComponentId;
            this.assessmentComponent = assessmentComponent;
            assessmentComponent.populateBox(box_RubricId, "Rubric");
            assessmentComponent.populateBox(box_Assessmentid, "Assessment");
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            DL_AssessmentComponent.updateAssessmentComponent(assessmentComponentId, txt_Name.Text, box_RubricId.Text, txt_TMarks.Text, box_Assessmentid.Text, this);

        }
    }
}
