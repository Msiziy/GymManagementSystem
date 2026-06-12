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
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }


        public void SetMenuAccess()
        {
            viewTrainersSessionsToolStripMenuItem.Enabled = false;
            viewTrainersToolStripMenuItem.Enabled = true;
            manageSessionToolStripMenuItem.Enabled = false;
            membershipPlansToolStripMenuItem1.Enabled = true;
            registerMemberToolStripMenuItem.Enabled= false;
            registerToolStripMenuItem.Enabled= false;
            managePaymentToolStripMenuItem.Enabled = false;
            bookTrainingSessionToolStripMenuItem.Enabled= false;
            registerToolStripMenuItem1.Enabled= false;
            signRegisterToolStripMenuItem.Enabled = false;
            viewRegisterListToolStripMenuItem.Enabled = true;
            logOutToolStripMenuItem.Enabled = false;
            viewTrainerSessionToolStripMenuItem1.Enabled = false;

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
       // string firstName = "";
       // string lastName = "";

       

        private void AdminForm_Load(object sender, EventArgs e)
        {   
            LoginAsToolStripTextBox.Text = "Logged in as: "+ UserSession.FirstName + " (Manager)";
            

            LoginAsToolStripTextBox.ForeColor = Color.Green;
            PaidPlanManagerDashboardForm dashboardForm = new PaidPlanManagerDashboardForm();
            formSetUp(dashboardForm);

            SetMenuAccess();
        }
        //Dashboard button
        private void viewMembersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PaidPlanManagerDashboardForm dashboardForm = new PaidPlanManagerDashboardForm();
            formSetUp(dashboardForm);
        }
        //View members button
        private void viewMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberDetailsForm memberDetailsForm = new MemberDetailsForm();
            formSetUp(memberDetailsForm);
        }
        //View trainers button
        private void viewTrainersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterStaff registerStaffForm = new RegisterStaff();
            formSetUp(registerStaffForm);
        }
        //View reports button
        private void viewReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberReport reportsForm = new MemberReport();
            formSetUp(reportsForm);
        }
        //Membership Plans button
        private void membershipPlansToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MembershipPlan membership = new MembershipPlan();
            formSetUp(membership);
        }

        private void HomeToolStripDashboard_Click(object sender, EventArgs e)
        {
            PaidPlanManagerDashboardForm dashboard = new PaidPlanManagerDashboardForm();
            formSetUp(dashboard);

        }
        private void viewRegisterListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaidPlanGymRegister paidPlanGymRegister = new PaidPlanGymRegister();
            formSetUp(paidPlanGymRegister);
        }




        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fillByStaffRoleToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.staffTableAdapter.FillByStaffRole(this.groupWst23DataSet.Staff);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


        private void memberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void memberBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {

        }

        private void fillByStaffRoleToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.staffTableAdapter.FillByStaffRole(this.groupWst23DataSet.Staff);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            //this.Close();
        }

        private void manageMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void viewTrainingSessionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewTrainingSession training=new ViewTrainingSession();
            formSetUp(training);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private void registerToolStripMenuItem2_Click(object sender, EventArgs e)
		{

		}

        private void memberReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberReport memberReport = new MemberReport();
            formSetUp(memberReport);
        }

        private void trainerReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentReport paymentForm = new PaymentReport();
            formSetUp(paymentForm);
        }

        private void trainingReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SessionReport trainingReport = new SessionReport();
            formSetUp(trainingReport);
        }

		private void paymentReportToolStripMenuItem_Click(object sender, EventArgs e)
		{
            TrainerReport trainerReport = new TrainerReport();
            formSetUp(trainerReport);
		}
	}
}
