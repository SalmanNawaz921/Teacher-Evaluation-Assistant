using DBMIDProject_2022_CS_138.DL.Student_Forms;
using System.Windows.Forms;

namespace DBMIDProject_2022_CS_138.UI.Student_Forms
{
    public partial class frm_StudentsAdd : Form
    {
        private int status;
        private int student_id;
        public frm_StudentsAdd(int student_id, ref int status)
        {
            InitializeComponent();
            this.status = status;
            this.student_id = student_id;
        }

        private void btn_Submit_Click(object sender, System.EventArgs e)
        {
            DL_Student.addStudent(txt_fName.Text, txt_lName.Text, txt_Contact.Text, txt_Email.Text, txt_RegNo.Text, ref status, this);
            cleartexts();
        }
        public void cleartexts()
        {
            txt_fName.Clear();
            txt_lName.Clear();
            txt_Email.Clear();
            txt_RegNo.Clear();
            txt_Contact.Clear();
        }

        private void txt_fName_TextChanged(object sender, System.EventArgs e)
        {

        }
    }
}
