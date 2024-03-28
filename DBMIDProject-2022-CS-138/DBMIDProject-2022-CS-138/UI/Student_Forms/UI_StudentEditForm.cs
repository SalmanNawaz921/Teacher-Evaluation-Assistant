using DBMIDProject_2022_CS_138.DL.Student_Forms;
using System.Windows.Forms;

namespace DBMIDProject_2022_CS_138.UI.Student_Forms
{
    public partial class frm_StudentsFormEdit : Form
    {
        private int student_id;
        private string first_name;
        private string last_name;
        private string contact;
        private string email;
        private string reg_no;
        private int status;
        public frm_StudentsFormEdit(int student_id, string first_name, string last_name, string contact, string email, string reg_no, ref int status)
        {
            InitializeComponent();
            this.student_id = student_id;
            this.status = status;
            this.first_name = first_name;
            this.last_name = last_name;
            this.contact = contact;
            this.email = email;
            this.reg_no = reg_no;
            populateTxtBox();
        }

        private void btn_Confirm_Click(object sender, System.EventArgs e)
        {
            DL_Student.updateStudent(student_id, txt_fName.Text, txt_lName.Text, txt_Contact.Text, txt_Email.Text, txt_RegNo.Text, ref status, this);
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
        public void populateTxtBox()
        {

            txt_fName.Text = first_name;
            txt_lName.Text = last_name;
            txt_Email.Text = email;
            txt_RegNo.Text = reg_no;
            txt_Contact.Text = contact;
        }
    }

}
