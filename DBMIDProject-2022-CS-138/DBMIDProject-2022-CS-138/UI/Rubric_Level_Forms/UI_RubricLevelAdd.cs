using DBMIDProject_2022_CS_138.DL.Rubric_Level;
using System.Windows.Forms;

namespace DBMIDProject_2022_CS_138.UI.Rubric_Level_Forms
{
    public partial class frm_RubricLevelAdd : Form
    {
        private frm_RubricLevel rubricLevel;
        public frm_RubricLevelAdd(frm_RubricLevel rubricLevel)
        {
            InitializeComponent();
            this.rubricLevel = rubricLevel;
            rubricLevel.populateBox(box_RubricId);
        }

        private void btn_Submit_Click(object sender, System.EventArgs e)
        {
            DL_RubricLevel.addRubricLevel(box_RubricId.Text, txt_Details.Text, box_MeasurementLevel.Text, this);
        }
    }
}
