using DBMIDProject_2022_CS_138.DL.Rubric_Forms;
using System.Windows.Forms;

namespace DBMIDProject_2022_CS_138.UI.Rubric_Forms
{
    public partial class frm_RubricsAdd : Form
    {
        private int rubricID;
        private frm_RubricsUI rubricUI;
        public frm_RubricsAdd(ref int rubricID, frm_RubricsUI rubricsUI)
        {
            InitializeComponent();
            this.rubricID = rubricID;
            this.rubricUI = rubricsUI;
            rubricsUI.populateBox(box_Clos);
        }


        public void clearrubrictexts()
        {
            box_Clos.Text = "";
            txt_Details.ResetText();
        }
        private void btn_Submit_Click(object sender, System.EventArgs e)
        {
            DL_Rubrics.addRubric(ref rubricID, box_Clos.Text, txt_Details.Text, this);
        }
    }
}
