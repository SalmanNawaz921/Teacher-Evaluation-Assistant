using DBMIDProject_2022_CS_138.DL.Rubric_Forms;
using System;
using System.Windows.Forms;

namespace DBMIDProject_2022_CS_138.UI.Rubric_Forms
{
    public partial class frm_RubricUpdate : Form
    {
        private int rubricID;
        private frm_RubricsUI rubricsUI;
        public frm_RubricUpdate(ref int rubricID, frm_RubricsUI rubricsUI)
        {
            InitializeComponent();
            this.rubricID = rubricID;
            this.rubricsUI = rubricsUI;
            rubricsUI.populateBox(box_Clos);
        }

        private void btn_Confrim_Click(object sender, EventArgs e)
        {
            DL_Rubrics.updateRubric(ref rubricID, box_Clos.Text, txt_Details.Text, this);
        }
    }
}
