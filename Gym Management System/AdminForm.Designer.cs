namespace Gym_Management_System
{
    partial class ManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accessControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HomeToolStripDashboard = new System.Windows.Forms.ToolStripMenuItem();
            this.manageMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTrainersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTrainersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookTrainingSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTrainingSessionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTrainersSessionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTrainerSessionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MembershipPlansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membershipPlansToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.managePaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainerReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainingReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.signRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRegisterListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoginAsToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupWst23DataSet = new Gym_Management_System.GroupWst23DataSet();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.membershipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberTableAdapter = new Gym_Management_System.GroupWst23DataSetTableAdapters.MemberTableAdapter();
            this.staffTableAdapter = new Gym_Management_System.GroupWst23DataSetTableAdapters.StaffTableAdapter();
            this.membershipTableAdapter = new Gym_Management_System.GroupWst23DataSetTableAdapters.MembershipTableAdapter();
            this.loginJoinTableAdapter1 = new Gym_Management_System.GroupWst23DataSetTableAdapters.LoginJoinTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst23DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accessControlToolStripMenuItem,
            this.HomeToolStripDashboard,
            this.manageMemberToolStripMenuItem,
            this.manageTrainersToolStripMenuItem,
            this.manageSessionToolStripMenuItem,
            this.MembershipPlansToolStripMenuItem,
            this.managePaymentToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.registerToolStripMenuItem2,
            this.LoginAsToolStripTextBox});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1924, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // accessControlToolStripMenuItem
            // 
            this.accessControlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.accessControlToolStripMenuItem.Name = "accessControlToolStripMenuItem";
            this.accessControlToolStripMenuItem.Size = new System.Drawing.Size(120, 27);
            this.accessControlToolStripMenuItem.Text = "Access Control";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.logOutToolStripMenuItem.Text = "Login";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // HomeToolStripDashboard
            // 
            this.HomeToolStripDashboard.Image = global::Gym_Management_System.Properties.Resources.home_icon;
            this.HomeToolStripDashboard.Name = "HomeToolStripDashboard";
            this.HomeToolStripDashboard.Size = new System.Drawing.Size(84, 27);
            this.HomeToolStripDashboard.Text = "Home";
            this.HomeToolStripDashboard.Click += new System.EventHandler(this.HomeToolStripDashboard_Click);
            // 
            // manageMemberToolStripMenuItem
            // 
            this.manageMemberToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerMemberToolStripMenuItem,
            this.viewMemberToolStripMenuItem,
            this.registerToolStripMenuItem});
            this.manageMemberToolStripMenuItem.Name = "manageMemberToolStripMenuItem";
            this.manageMemberToolStripMenuItem.Size = new System.Drawing.Size(143, 27);
            this.manageMemberToolStripMenuItem.Text = "Manage Members";
            // 
            // registerMemberToolStripMenuItem
            // 
            this.registerMemberToolStripMenuItem.Name = "registerMemberToolStripMenuItem";
            this.registerMemberToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.registerMemberToolStripMenuItem.Text = "Register Member";
            // 
            // viewMemberToolStripMenuItem
            // 
            this.viewMemberToolStripMenuItem.Name = "viewMemberToolStripMenuItem";
            this.viewMemberToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.viewMemberToolStripMenuItem.Text = "View Member";
            this.viewMemberToolStripMenuItem.Click += new System.EventHandler(this.viewMemberToolStripMenuItem_Click);
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.registerToolStripMenuItem.Text = "Update Member Details";
            // 
            // manageTrainersToolStripMenuItem
            // 
            this.manageTrainersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewTrainersToolStripMenuItem});
            this.manageTrainersToolStripMenuItem.Name = "manageTrainersToolStripMenuItem";
            this.manageTrainersToolStripMenuItem.Size = new System.Drawing.Size(112, 27);
            this.manageTrainersToolStripMenuItem.Text = "Manage Staff";
            // 
            // viewTrainersToolStripMenuItem
            // 
            this.viewTrainersToolStripMenuItem.Image = global::Gym_Management_System.Properties.Resources.Members_Icon;
            this.viewTrainersToolStripMenuItem.Name = "viewTrainersToolStripMenuItem";
            this.viewTrainersToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.viewTrainersToolStripMenuItem.Text = "View Staff Details";
            this.viewTrainersToolStripMenuItem.Click += new System.EventHandler(this.viewTrainersToolStripMenuItem_Click);
            // 
            // manageSessionToolStripMenuItem
            // 
            this.manageSessionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookTrainingSessionToolStripMenuItem,
            this.viewTrainingSessionsToolStripMenuItem,
            this.registerToolStripMenuItem1,
            this.viewTrainersSessionsToolStripMenuItem,
            this.viewTrainerSessionToolStripMenuItem1});
            this.manageSessionToolStripMenuItem.Name = "manageSessionToolStripMenuItem";
            this.manageSessionToolStripMenuItem.Size = new System.Drawing.Size(130, 27);
            this.manageSessionToolStripMenuItem.Text = "Manage Session";
            // 
            // bookTrainingSessionToolStripMenuItem
            // 
            this.bookTrainingSessionToolStripMenuItem.Name = "bookTrainingSessionToolStripMenuItem";
            this.bookTrainingSessionToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.bookTrainingSessionToolStripMenuItem.Text = "Book Training Session";
            // 
            // viewTrainingSessionsToolStripMenuItem
            // 
            this.viewTrainingSessionsToolStripMenuItem.Name = "viewTrainingSessionsToolStripMenuItem";
            this.viewTrainingSessionsToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.viewTrainingSessionsToolStripMenuItem.Text = "View Training Sessions";
            this.viewTrainingSessionsToolStripMenuItem.Click += new System.EventHandler(this.viewTrainingSessionsToolStripMenuItem_Click);
            // 
            // registerToolStripMenuItem1
            // 
            this.registerToolStripMenuItem1.Name = "registerToolStripMenuItem1";
            this.registerToolStripMenuItem1.Size = new System.Drawing.Size(240, 26);
            this.registerToolStripMenuItem1.Text = "Register";
            // 
            // viewTrainersSessionsToolStripMenuItem
            // 
            this.viewTrainersSessionsToolStripMenuItem.Name = "viewTrainersSessionsToolStripMenuItem";
            this.viewTrainersSessionsToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.viewTrainersSessionsToolStripMenuItem.Text = "Choose Availability";
            // 
            // viewTrainerSessionToolStripMenuItem1
            // 
            this.viewTrainerSessionToolStripMenuItem1.Name = "viewTrainerSessionToolStripMenuItem1";
            this.viewTrainerSessionToolStripMenuItem1.Size = new System.Drawing.Size(240, 26);
            this.viewTrainerSessionToolStripMenuItem1.Text = "View Trainer Session";
            // 
            // MembershipPlansToolStripMenuItem
            // 
            this.MembershipPlansToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.membershipPlansToolStripMenuItem1});
            this.MembershipPlansToolStripMenuItem.Name = "MembershipPlansToolStripMenuItem";
            this.MembershipPlansToolStripMenuItem.Size = new System.Drawing.Size(164, 27);
            this.MembershipPlansToolStripMenuItem.Text = "Manage Membership";
            // 
            // membershipPlansToolStripMenuItem1
            // 
            this.membershipPlansToolStripMenuItem1.Image = global::Gym_Management_System.Properties.Resources.Membership_Icon;
            this.membershipPlansToolStripMenuItem1.Name = "membershipPlansToolStripMenuItem1";
            this.membershipPlansToolStripMenuItem1.Size = new System.Drawing.Size(213, 26);
            this.membershipPlansToolStripMenuItem1.Text = "Membership Plans";
            this.membershipPlansToolStripMenuItem1.Click += new System.EventHandler(this.membershipPlansToolStripMenuItem1_Click);
            // 
            // managePaymentToolStripMenuItem
            // 
            this.managePaymentToolStripMenuItem.Name = "managePaymentToolStripMenuItem";
            this.managePaymentToolStripMenuItem.Size = new System.Drawing.Size(137, 27);
            this.managePaymentToolStripMenuItem.Text = "Manage Payment";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memberReportsToolStripMenuItem,
            this.trainerReportsToolStripMenuItem,
            this.trainingReportsToolStripMenuItem,
            this.paymentReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(132, 27);
            this.reportsToolStripMenuItem.Text = "Generate Report";
            // 
            // memberReportsToolStripMenuItem
            // 
            this.memberReportsToolStripMenuItem.Name = "memberReportsToolStripMenuItem";
            this.memberReportsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.memberReportsToolStripMenuItem.Text = "Member Report";
            this.memberReportsToolStripMenuItem.Click += new System.EventHandler(this.memberReportsToolStripMenuItem_Click);
            // 
            // trainerReportsToolStripMenuItem
            // 
            this.trainerReportsToolStripMenuItem.Name = "trainerReportsToolStripMenuItem";
            this.trainerReportsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.trainerReportsToolStripMenuItem.Text = "Payment Report";
            this.trainerReportsToolStripMenuItem.Click += new System.EventHandler(this.trainerReportsToolStripMenuItem_Click);
            // 
            // trainingReportsToolStripMenuItem
            // 
            this.trainingReportsToolStripMenuItem.Name = "trainingReportsToolStripMenuItem";
            this.trainingReportsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.trainingReportsToolStripMenuItem.Text = "Session Report";
            this.trainingReportsToolStripMenuItem.Click += new System.EventHandler(this.trainingReportsToolStripMenuItem_Click);
            // 
            // paymentReportToolStripMenuItem
            // 
            this.paymentReportToolStripMenuItem.Name = "paymentReportToolStripMenuItem";
            this.paymentReportToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.paymentReportToolStripMenuItem.Text = "Trainer Report";
            this.paymentReportToolStripMenuItem.Click += new System.EventHandler(this.paymentReportToolStripMenuItem_Click);
            // 
            // registerToolStripMenuItem2
            // 
            this.registerToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signRegisterToolStripMenuItem,
            this.viewRegisterListToolStripMenuItem});
            this.registerToolStripMenuItem2.Name = "registerToolStripMenuItem2";
            this.registerToolStripMenuItem2.Size = new System.Drawing.Size(77, 27);
            this.registerToolStripMenuItem2.Text = "Register";
            this.registerToolStripMenuItem2.Click += new System.EventHandler(this.registerToolStripMenuItem2_Click);
            // 
            // signRegisterToolStripMenuItem
            // 
            this.signRegisterToolStripMenuItem.Name = "signRegisterToolStripMenuItem";
            this.signRegisterToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.signRegisterToolStripMenuItem.Text = "Sign Register";
            // 
            // viewRegisterListToolStripMenuItem
            // 
            this.viewRegisterListToolStripMenuItem.Name = "viewRegisterListToolStripMenuItem";
            this.viewRegisterListToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.viewRegisterListToolStripMenuItem.Text = "View Register List";
            this.viewRegisterListToolStripMenuItem.Click += new System.EventHandler(this.viewRegisterListToolStripMenuItem_Click);
            // 
            // LoginAsToolStripTextBox
            // 
            this.LoginAsToolStripTextBox.AutoSize = false;
            this.LoginAsToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LoginAsToolStripTextBox.Name = "LoginAsToolStripTextBox";
            this.LoginAsToolStripTextBox.Size = new System.Drawing.Size(280, 27);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Ivory;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Red;
            this.guna2Button1.IndicateFocus = true;
            this.guna2Button1.Location = new System.Drawing.Point(1806, 0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(106, 30);
            this.guna2Button1.TabIndex = 5;
            this.guna2Button1.Text = "Logout";
            this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "Member";
            this.memberBindingSource.DataSource = this.groupWst23DataSet;
            // 
            // groupWst23DataSet
            // 
            this.groupWst23DataSet.DataSetName = "GroupWst23DataSet";
            this.groupWst23DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.groupWst23DataSet;
            // 
            // membershipBindingSource
            // 
            this.membershipBindingSource.DataMember = "Membership";
            this.membershipBindingSource.DataSource = this.groupWst23DataSet;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // membershipTableAdapter
            // 
            this.membershipTableAdapter.ClearBeforeFill = true;
            // 
            // loginJoinTableAdapter1
            // 
            this.loginJoinTableAdapter1.ClearBeforeFill = true;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst23DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accessControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTrainersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTrainersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox LoginAsToolStripTextBox;
        private GroupWst23DataSet groupWst23DataSet;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private GroupWst23DataSetTableAdapters.MemberTableAdapter memberTableAdapter;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private GroupWst23DataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.BindingSource membershipBindingSource;
        private GroupWst23DataSetTableAdapters.MembershipTableAdapter membershipTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem HomeToolStripDashboard;
        private System.Windows.Forms.ToolStripMenuItem MembershipPlansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membershipPlansToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem managePaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookTrainingSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTrainingSessionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem1;
        private GroupWst23DataSetTableAdapters.LoginJoinTableAdapter loginJoinTableAdapter1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem viewTrainersSessionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainerReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainingReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signRegisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewRegisterListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTrainerSessionToolStripMenuItem1;
    }
}