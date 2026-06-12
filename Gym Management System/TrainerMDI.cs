using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management_System
{
    public partial class TrainerMDI : Form
    {
        public TrainerMDI()
        {
            InitializeComponent();
        }
        public void SetMenuAccess()
        {
            manageMemberToolStripMenuItem.Enabled = false;
            managePaymentToolStripMenuItem.Enabled = false;
            bookTrainingSessionToolStripMenuItem.Enabled = false;
            logInToolStripMenuItem.Enabled = false;
            generateReportToolStripMenuItem.Enabled = false;
            manageMembershipToolStripMenuItem.Enabled = false;
            manageStaffToolStripMenuItem.Enabled = false;
            chooseAvailabilityToolStripMenuItem.Enabled = true;
            registerToolStripMenuItem.Enabled = false;
            viewTrainingSessionsToolStripMenuItem.Enabled = false;
            


        }


        public void formSetUp(Form form)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();

        }
        private void TrainerMDI_Load(object sender, EventArgs e)
        {
            SetMenuAccess();
            TrainerDashboard trainerForm2 = new TrainerDashboard();
            formSetUp(trainerForm2);
            toolStripTextBox1.Text = "Logged in as: " + UserSession.FirstName + " (Trainer)";
            toolStripTextBox1.ForeColor = Color.Green;
            toolStripTextBox1.ReadOnly = false;
        }



        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrainerDashboard trainerForm2 = new TrainerDashboard();
            formSetUp(trainerForm2);
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // TrainerProfile profile = new TrainerProfile();
           // formSetUp(profile);
        }

        

        private void chooseAvailabilityToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TrainerChooseAvailability chooseAvailability = new TrainerChooseAvailability();
            formSetUp(chooseAvailability);
        }

        //private void viewTrainerSessionsToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    TrainerViewSessions trainerViewSessions = new TrainerViewSessions();
        //    formSetUp(trainerViewSessions);
        //}

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewTrainerSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrainerViewSessions trainerViewSessions = new TrainerViewSessions();
            formSetUp(trainerViewSessions);
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
