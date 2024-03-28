using DBMIDProject_2022_CS_138.DL.Assessment_Component;
using System.Windows.Forms;

namespace DBMIDProject_2022_CS_138.UI.Assessment_Component_Forms
{
    public partial class frm_AssessmentComponentAdd : Form
    {
        private frm_AssessmentComponent assessmentComponent;
        public frm_AssessmentComponentAdd(frm_AssessmentComponent assessmentComponent)
        {
            InitializeComponent();
            this.assessmentComponent = assessmentComponent;
            assessmentComponent.populateBox(box_Assessmentid, "Assessment");
            assessmentComponent.populateBox(box_RubricId, "Rubric");
        }

        private void btn_Submit_Click(object sender, System.EventArgs e)
        {
            DL_AssessmentComponent.addAssessmentComponent(txt_Name.Text, box_RubricId.Text, txt_TMarks.Text, box_Assessmentid.Text, this);

        }
    }
}
