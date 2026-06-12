using Gym_Management_System.GroupWst23DataSetTableAdapters;
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
    public partial class TrainerDashboard : Form
    {
        public TrainerDashboard()
        {
            InitializeComponent();
        }
        string username = UserSession.Email;
        string staffID;


        private void TrainerDashboard_Load(object sender, EventArgs e)
        {
            TrainerWelcomeLbl.Text = "Welcome, " + UserSession.FirstName + " " + UserSession.LastName + "!";
            TrainerDate.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            TrainerTimeLbl.Text = DateTime.Now.ToString("hh:mm tt");
            getSfaffID();
            int TotalMembers = Convert.ToInt32(this.training_SessionTableAdapter1.TrainerNumOfMembers(staffID));
            TotalMembersLbl.Text = TotalMembers.ToString();

            int TotalSessions = Convert.ToInt32(this.training_SessionTableAdapter1.GetTrainerNumberOfSessions(staffID));
            NumOfSessionLbl.Text = TotalSessions.ToString();

            int TotalCompletedSessions = Convert.ToInt32(this.training_SessionTableAdapter1.GetTrainerNumOfCompletedSessions(staffID));
            NumOfCompleteSessionLbl.Text = TotalCompletedSessions.ToString();

            
            int NumOfPendingSessions = Convert.ToInt32(this.training_SessionTableAdapter1.TrainerNumOfPendingSessions(staffID));
            PendingSessionLbl.Text = NumOfPendingSessions.ToString();
        }

        private void getSfaffID()
        {
            object result = staffTableAdapter1.GetStaffIDByEmail(username);
            if (result != null)
            {
                staffID = result.ToString();
                //MessageBox.Show(staffID);
            }
            else
            {
                MessageBox.Show("No staff member found for email: " + username);
            }
        }

        private void TrainerDate_Click(object sender, EventArgs e)
        {

        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.MdiParent.Close();
        }
    }
}
