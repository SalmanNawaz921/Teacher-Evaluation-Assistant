using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBMIDProject_2022_CS_138.UI.Dashboard
{
    public partial class frm_Dashboard : Form
    {
        public frm_Dashboard()
        {
            InitializeComponent();
            populateLabels();
        }

        public void populateLabels()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd_activeCount = new SqlCommand("SELECT COUNT (*) FROM Student Where Status='5'", con);
            int activeStudentsCount = (Int32)cmd_activeCount.ExecuteScalar();
            lbl_ActiveStudentsCount.Text = activeStudentsCount.ToString(); SqlCommand cmd_inactiveCount = new SqlCommand("SELECT COUNT (*) FROM Student Where Status='6'", con);
            int inactiveStudentsCount = (Int32)cmd_inactiveCount.ExecuteScalar();
            lbl_InactiveStudentsCount.Text = inactiveStudentsCount.ToString(); SqlCommand cmd_rubricCount = new SqlCommand("SELECT COUNT (*) FROM Rubric", con);
            int rubricsCount = (Int32)cmd_rubricCount.ExecuteScalar();
            lbl_RubricsCount.Text = rubricsCount.ToString();
            SqlCommand cmd_closCount = new SqlCommand("SELECT COUNT (*) FROM Clo", con);
            int closCount = (Int32)cmd_closCount.ExecuteScalar();
            lbl_ClosCount.Text = closCount.ToString();
            SqlCommand cmd_rubricLevelCount = new SqlCommand("SELECT COUNT (*) FROM RubricLevel", con);
            int rubricLevelCount = (Int32)cmd_rubricLevelCount.ExecuteScalar();
            lbl_RubricLevelsCount.Text = rubricLevelCount.ToString(); SqlCommand cmd_assessmentsCount = new SqlCommand("SELECT COUNT (*) FROM Assessment", con);
            int assessments = (Int32)cmd_assessmentsCount.ExecuteScalar();
            lbl_AssessmentsCount.Text = assessments.ToString();
        }
    }
}
