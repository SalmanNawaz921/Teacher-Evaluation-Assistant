using System;
using System.Windows.Forms;

namespace DBMIDProject_2022_CS_138
{
    public partial class Start_Form : Form
    {
        private Main_Form mainForm; // Declare a variable to hold the instance of Main_Form

        public Start_Form()
        {
            InitializeComponent();
        }

        private void Start_Form_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void loading()
        {
            guna2CircleProgressBar1.Value += 20;
            if (guna2CircleProgressBar1.Value == 100 && mainForm == null) // Check if Main_Form instance has not been created yet
            {
                mainForm = new Main_Form(); // Create Main_Form instance
                mainForm.FormClosed += MainForm_FormClosed; // Subscribe to the FormClosed event
                mainForm.Show();
                timer1.Stop();
                this.Hide();
            }
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // This method will be called when the Main_Form is closed
            this.Close(); // Close the Start_Form
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            loading();
        }
    }
}
