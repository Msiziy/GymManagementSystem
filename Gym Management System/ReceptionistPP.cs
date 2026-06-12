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
    public partial class ReceptionistPP : Form
    {
        public ReceptionistPP()
        {
            InitializeComponent();
        }
        public void PrepareForm(Form form)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
            
        }
        private void registerMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageMember managemember = new ManageMember();
            PrepareForm(managemember);
        }

        private void updateMemberDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateMemberDetails updatemember = new UpdateMemberDetails();
            PrepareForm(updatemember);
        }

        private void makePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentForm paymentform = new PaymentForm();
            PrepareForm(paymentform);
        }
        private void viewMembersToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MemberDetailsForm memberdetails = new MemberDetailsForm();
            PrepareForm(memberdetails);
        }
        private void bookTrainingSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookTrainingSessions book = new BookTrainingSessions();
            PrepareForm(book);
        }

        private void viewTrainingSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewTrainingSession view = new ViewTrainingSession();
            PrepareForm(view);
        }

        private void dashBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaidPlanManagerDashboardForm dashboard = new PaidPlanManagerDashboardForm();
            PrepareForm(dashboard);
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            PrepareForm(login);
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripTextBox1.Text = "Logged out ";
            toolStripTextBox1.ForeColor = Color.Red;
            memberDetailsToolStripMenuItem.Enabled = false;
            paymentDetailsToolStripMenuItem.Enabled = false;
            trainingSessionDetailsToolStripMenuItem.Enabled = false;
            logInToolStripMenuItem.Enabled = true;
            HomeToolStripMenuItem.Enabled = false;
            LoginForm login = new LoginForm();
            PrepareForm(login);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void paymentBindingNavigatorSaveItem_Click1(object sender, EventArgs e)
        {
            this.Validate();
            this.paymentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.groupWst23DataSet);

        }

        private void RegisterMemberLabel_Click1(object sender, EventArgs e)
        {

        }

        
        public void SetMenuAccess()
        {
            memberDetailsToolStripMenuItem.Enabled = true;
            paymentDetailsToolStripMenuItem.Enabled = true;
            trainingSessionDetailsToolStripMenuItem.Enabled = true;  
            logInToolStripMenuItem.Enabled = false;
            reportToolStripMenuItem.Enabled = false;
            manageMembershipToolStripMenuItem.Enabled= false;
            manageStaffToolStripMenuItem.Enabled= false;
            chooseAvailabilityToolStripMenuItem.Enabled= false;
            toolStripTextBox1.ReadOnly = true;
        }

        private void ReceptionistPP_Load(object sender, EventArgs e)
        {
            toolStripTextBox1.Text = "Logged in as: " + UserSession.FirstName + " (Receptionist)";
            toolStripTextBox1.ForeColor = Color.Green;
            PaidPlanManagerDashboardForm dashboard = new PaidPlanManagerDashboardForm();
            PrepareForm(dashboard);
            SetMenuAccess();
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PaidPlanRegisterForm register = new PaidPlanRegisterForm();
            //PrepareForm(register);
        }

        private void signInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PaidPlanRegisterForm register=new PaidPlanRegisterForm();
            //PrepareForm(register);
        }

        private void signRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaidPlanRegisterForm register = new PaidPlanRegisterForm();
            PrepareForm(register);
        }

        private void viewRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaidPlanGymRegister paidPlanGymRegister = new PaidPlanGymRegister();
            PrepareForm(paidPlanGymRegister);
        }
    }
}
