using DBMIDProject_2022_CS_138.UI;
using DBMIDProject_2022_CS_138.UI.Assessment_Component_Forms;
using DBMIDProject_2022_CS_138.UI.Assessment_Forms;
using DBMIDProject_2022_CS_138.UI.Attendance_Forms;
using DBMIDProject_2022_CS_138.UI.CLO_Forms;
using DBMIDProject_2022_CS_138.UI.Dashboard;
using DBMIDProject_2022_CS_138.UI.Rubric_Forms;
using DBMIDProject_2022_CS_138.UI.Rubric_Level_Forms;
using DBMIDProject_2022_CS_138.UI.Student_Forms;
using DBMIDProject_2022_CS_138.UI.Student_Result_Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DBMIDProject_2022_CS_138
{
    public partial class Main_Form : Form
    {
        bool sidebar_open = true;
        Form currentChildForm;
        int formCount = 0;
        List<Form> forms;
        bool mouseDown;
        private Point offset;
        public Main_Form()
        {
            InitializeComponent();
            customizeDesign();
            frm_Dashboard dashboard = new frm_Dashboard();
            OpenChildForm(dashboard);
            forms = new List<Form>() { new frm_Dashboard(), new frm_StudentsUI(), new frm_ClosUI(), new frm_CloWiseResult(), new frm_RubricsUI(), new frm_RubricLevel(), new frm_AssessmentUI(), new frm_AssessmentComponent(), new frm_AssessmentWiseResult(), new frm_Attendance(), new frm_AttendenceReport(), new frm_StudentInactive(), new frm_StudentResultMark() };
        }

        private void customizeDesign()
        {
            pnl_Clo.Visible = false;
            pnl_Assessments.Visible = false;
            pnl_Attendence.Visible = false;
            pnl_Rubrics.Visible = false;
        }

        private void hideSubMenus()
        {
            if (pnl_Clo.Visible == true)
                pnl_Clo.Visible = false;
            if (pnl_Assessments.Visible == true)
                pnl_Assessments.Visible = false;
            if (pnl_Attendence.Visible == true)
                pnl_Attendence.Visible = false;
            if (pnl_Rubrics.Visible == true)
                pnl_Rubrics.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenus();
                subMenu.Visible = true;

            }
            else
            {
                subMenu.Visible = false;
            }
        }



        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Nav_Click(object sender, System.EventArgs e)
        {
            sidebar_Timer.Start();
        }
        public void toggleSideBar()
        {
            if (sidebar_open)
            {
                pnl_Sidebar.Width -= 10;
                if (pnl_Sidebar.Width == pnl_Sidebar.MinimumSize.Width)
                {
                    sidebar_open = false;
                    sidebar_Timer.Stop();

                }
            }
            else
            {
                pnl_Sidebar.Width += 10;
                if (pnl_Sidebar.Width == pnl_Sidebar.MaximumSize.Width)
                {
                    sidebar_open = true;
                    sidebar_Timer.Stop();

                }

            }
        }

        private void sidebar_Timer_Tick(object sender, System.EventArgs e)
        {
            toggleSideBar();
        }


        private void iconDropDownButton1_Click(object sender, System.EventArgs e)
        {

        }

        private void iconDropDownButton1_Click_1(object sender, System.EventArgs e)
        {

        }
        private void OpenChildForm(Form childForm)
        {

            //open only form
            if (currentChildForm != null)
                currentChildForm.Hide();

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnl_Section.Controls.Add(childForm);
            pnl_Section.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbl_Header.Text = childForm.Text;
        }



        private void btn_Clo_Click(object sender, System.EventArgs e)
        {
            showSubMenu(pnl_Clo);
        }

        private void btn_Students_Click_1(object sender, System.EventArgs e)
        {
            OpenChildForm(new frm_StudentsUI());
        }

        private void btn_Home_Click(object sender, System.EventArgs e)
        {
            currentChildForm.Close();
            currentChildForm = null;
            lbl_Header.Text = "Home";
            OpenChildForm(new frm_Dashboard());
        }

        private void btn_Clo_Click_1(object sender, System.EventArgs e)
        {
            showSubMenu(pnl_Clo);

        }

        private void btn_manageClos_Click(object sender, System.EventArgs e)
        {

            OpenChildForm(new frm_ClosUI());
        }

        private void btn_Rubric_Click(object sender, System.EventArgs e)
        {
            showSubMenu(pnl_Rubrics);
        }

        private void btn_manageRubrics_Click(object sender, System.EventArgs e)
        {
            OpenChildForm(new frm_RubricsUI());

        }

        private void btn_Assessment_Click(object sender, System.EventArgs e)
        {
            showSubMenu(pnl_Assessments);
        }

        private void btn_ManageAssessments_Click(object sender, System.EventArgs e)
        {
            OpenChildForm(new frm_AssessmentUI());
        }

        private void btn_Attendance_Click(object sender, System.EventArgs e)
        {
            showSubMenu(pnl_Attendence);
        }

        private void btn_rubricLevels_Click(object sender, System.EventArgs e)
        {
            OpenChildForm(new frm_RubricLevel());
        }

        private void btn_AssessmentComponent_Click(object sender, System.EventArgs e)
        {
            OpenChildForm(new frm_AssessmentComponent());
        }

        private void btn_StudentResult_Click(object sender, System.EventArgs e)
        {
            OpenChildForm(new frm_StudentResultMark());
        }

        private void btn_CloResult_Click(object sender, System.EventArgs e)
        {
            OpenChildForm(new frm_CloWiseResult());
        }

        private void iconButton1_Click(object sender, System.EventArgs e)
        {
            OpenChildForm(new frm_AssessmentWiseResult());
        }

        private void btn_StudentAttendance_Click(object sender, System.EventArgs e)
        {
            OpenChildForm(new frm_Attendance());
        }

        private void btn_AttendenceReport_Click(object sender, System.EventArgs e)
        {
            OpenChildForm(new frm_AttendenceReport());
        }

        private void btn_ActiveStudents_Click(object sender, System.EventArgs e)
        {
            OpenChildForm(new frm_StudentInactive());
        }

        private void btn_Next_Click(object sender, System.EventArgs e)
        {
            Type curFormType = currentChildForm.GetType();
            int index = forms.FindIndex(f => f.GetType() == curFormType);
            if (index != -1 && index + 1 < forms.Count)
            {
                OpenChildForm(forms[index + 1]);
            }
            else
            {
                OpenChildForm(new frm_Dashboard());
            }
        }

        private void btn_Prev_Click(object sender, EventArgs e)
        {
            Type curFormType = currentChildForm.GetType();
            int index = forms.FindIndex(f => f.GetType() == curFormType);
            if (index != -1 && index - 1 > 0)
            {
                OpenChildForm(forms[index - 1]);
            }
            else
            {
                OpenChildForm(new frm_StudentResultMark());
            }
        }

        private void pnl_Header_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void pnl_Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void pnl_Header_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
