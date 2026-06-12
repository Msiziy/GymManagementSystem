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
    public partial class PaidPlanManagerDashboardForm : Form
    {
        public PaidPlanManagerDashboardForm()
        {
            InitializeComponent();
        }
       

        private void PaidPlanManagerDashboardForm_Load(object sender, EventArgs e)
        {
            // Prevent future dates
            CheckPrevDaysDateTimePicker.MaxDate = DateTime.Today;

            
            CheckPrevDaysDateTimePicker.Value = DateTime.Today;

            RefreshDashboard();

        }

        private void RefreshDashboard()
        {
            try
            {
                //Displaying Today's Date
                TodayDateLabel.Text = DateTime.Now.ToLongDateString();

                //Welcome Message
                WelcomeLabel.Text = "Welcome, " + UserSession.FirstName +" "+UserSession.LastName+ "!";

                //Extracting The Date From the DateTimePicker Value (yyy-MM-dd) And Converting It To A String
                string selectedDate = CheckPrevDaysDateTimePicker.Value.Date.ToString("yyyy-MM-dd");
                DateTime pickedDate = CheckPrevDaysDateTimePicker.Value.Date;

                //Total Members
                int totalMembers = Convert.ToInt32(this.memberTableAdapter1.TotalMembersCount());
                TotalGymMembersLabel.Text = totalMembers.ToString();

                //Total Trainers
                int totalTrainers = Convert.ToInt32(this.staffTableAdapter1.TotalGymTrainers());
                TotalGymTrainersLabel.Text = totalTrainers.ToString();

                //Today's Check-in
               int todayMembersCheckIn = Convert.ToInt32(this.paidPlanRegisterTableAdapter1.TodaysCheckedInMembers(selectedDate));
               TodaysCheckInLabel.Text = todayMembersCheckIn.ToString();

                //Present Trainers
                int todayTrainersPresent = Convert.ToInt32(this.training_SessionTableAdapter1.PresentTrainersInGym(selectedDate,"Present"));
                PresentTrainersLabel.Text = todayTrainersPresent.ToString();

                //New Trainers That Month
                int newTrainersJoinedOnThatDay = Convert.ToInt32(this.staffTableAdapter1.NewTrainersThisMonth(pickedDate));
                NewTrainersLabel.Text = newTrainersJoinedOnThatDay.ToString();

                //Total Sessions On That Day
                int totalTodaySessions = Convert.ToInt32(this.training_SessionTableAdapter1.TotalSessionOnThatDay(selectedDate));
                TodaysSessionsLabel.Text = totalTodaySessions.ToString();

                //Total Completed Sessions On That Day
                int totalCompletedSessions = Convert.ToInt32(this.training_SessionTableAdapter1.TotalCompletedOrIncompleteSessions("Completed",selectedDate));
                CompletedSessionsLabel.Text = totalCompletedSessions.ToString();

                //Total Incomplte Sessions On That Day
                int totalIncompleteSessions = Convert.ToInt32(this.training_SessionTableAdapter1.TotalCompletedOrIncompleteSessions("Incomplete", selectedDate));
                IncompleteSessionsLabel.Text = totalIncompleteSessions.ToString();

                //Member Joined On That Day
                //DateTime dateTime = selectedDate.Date;

                int membersJoinedOnThatDay = Convert.ToInt32(this.memberTableAdapter1.NewMembersThisMonth(pickedDate));
                NewMembersLabel.Text = membersJoinedOnThatDay.ToString();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void CheckPrevDaysDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            RefreshDashboard();
        }




        private void ManagerViewMembersBtn_Click(object sender, EventArgs e)
        {
            MemberDetailsForm memberDetailsForm = new MemberDetailsForm();

            ManagerForm managerForm = (ManagerForm)this.MdiParent;

            managerForm.formSetUp(memberDetailsForm);
        }

        private void ManagerViewReportsBtn_Click(object sender, EventArgs e)
        {
            MemberReport reportsForm = new MemberReport();
            ManagerForm managerForm = (ManagerForm)this.MdiParent;
            managerForm.formSetUp(reportsForm);
        }

        private void ManagerViewPayBtn_Click(object sender, EventArgs e)
        {

        }

        private void ManangerManageTrainersBtn_Click(object sender, EventArgs e)
        {
            RegisterStaff registerStaffForm = new RegisterStaff();
            ManagerForm managerForm = (ManagerForm)this.MdiParent;
            managerForm.formSetUp(registerStaffForm);
        }

        private void ManagerMembershipplansBtn_Click(object sender, EventArgs e)
        {
            MembershipPlan membership = new MembershipPlan();

            ManagerForm managerForm = (ManagerForm)this.MdiParent;

            managerForm.formSetUp(membership);
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

         private void LogOutButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.MdiParent.Close();
        }

        private void WelcomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void QuickViewGroupBox_Click(object sender, EventArgs e)
        {

        }

        private void NewMembersSubLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
