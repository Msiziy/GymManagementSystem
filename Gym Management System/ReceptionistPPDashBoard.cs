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
    public partial class ReceptionistPPDashBoard : Form
    {
        public ReceptionistPPDashBoard()
        {
            InitializeComponent();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ReceptionistPPDashBoard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupWst23DataSet.Member' table. You can move, or remove it, as needed.
            //this.memberTableAdapter.Fill(this.groupWst23DataSet.Member);
            RefreshDashboard();

        }
        private void RefreshDashboard()
        {
            try
            {
                //Displaying Today's Date
                TodayDateLabel.Text = DateTime.Now.ToLongDateString();

                //Welcome Message
                welcomeLbl.Text = "Welcome, " + UserSession.FirstName + "!";

                //Extracting The Date From the DateTimePicker Value (yyy-MM-dd) And Converting It To A String
                string selectedDate = CheckPrevDaysDateTimePicker.Value.Date.ToString("yyyy-MM-dd");

                //Total Members
                int totalMembers = Convert.ToInt32(this.memberTableAdapter.TotalMembersCount());
                TotalGymMembersLabel.Text = totalMembers.ToString();

                //Total Trainers
                int totalTrainers = Convert.ToInt32(this.staffTableAdapter1.TotalGymTrainers());
                TotalGymTrainersLabel.Text = totalTrainers.ToString();

                //Today's Check-in
             //   int todayMembersCheckIn = Convert.ToInt32(this.paidPlanRegisterTableTableAdapter1.TodaysCheckedInMembers(selectedDate));
             //   TodaysCheckInLabel.Text = todayMembersCheckIn.ToString();

                //Present Trainers
                int todayTrainersPresent = Convert.ToInt32(this.training_SessionTableAdapter1.PresentTrainersInGym(selectedDate, "Present"));
                PresentTrainersLabel.Text = todayTrainersPresent.ToString();

                //Total Sessions On That Day
                int totalTodaySessions = Convert.ToInt32(this.training_SessionTableAdapter1.TotalSessionOnThatDay(selectedDate));
                TodaysSessionsLabel.Text = totalTodaySessions.ToString();

                //Total Completed Sessions On That Day
                int totalCompletedSessions = Convert.ToInt32(this.training_SessionTableAdapter1.TotalCompletedOrIncompleteSessions("Completed", selectedDate));
                CompletedSessionsLabel.Text = totalCompletedSessions.ToString();

                //Total Incomplte Sessions On That Day
                int totalIncompleteSessions = Convert.ToInt32(this.training_SessionTableAdapter1.TotalCompletedOrIncompleteSessions("Incomplete", selectedDate));
                IncompleteSessionsLabel.Text = totalIncompleteSessions.ToString();

                //Member Joined On That Day
                ///int membersJoinedOnThatDay = Convert.ToInt32(this.memberTableAdapter.TotalMemberJoinedThatDay(selectedDate));
               // NewMembersLabel.Text = membersJoinedOnThatDay.ToString();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.MdiParent.Close();
        }

        private void CheckPrevDaysDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            RefreshDashboard();
        }
    }
}
