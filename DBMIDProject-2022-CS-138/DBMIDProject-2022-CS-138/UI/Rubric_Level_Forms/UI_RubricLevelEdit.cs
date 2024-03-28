using DBMIDProject_2022_CS_138.DL.Rubric_Level;
using System;
using System.Windows.Forms;

namespace DBMIDProject_2022_CS_138.UI.Rubric_Level_Forms
{
    public partial class frm_RubricLevelEdit : Form
    {
        private int rubricLevelId;
        private frm_RubricLevel rubricLevel;
        public frm_RubricLevelEdit(int rubricLevelId, frm_RubricLevel rubricLevel)
        {
            InitializeComponent();
            this.rubricLevelId = rubricLevelId;
            this.rubricLevel = rubricLevel;
            rubricLevel.populateBox(box_RubricId);
        }

        private void btn_Confrim_Click(object sender, EventArgs e)
        {
            DL_RubricLevel.updateRubricLevel(rubricLevelId, box_RubricId.Text, txt_Details.Text, box_MeasurementLevel.Text, this);
        }
    }
}
