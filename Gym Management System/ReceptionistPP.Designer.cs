namespace Gym_Management_System
{
    partial class ReceptionistPP
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
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMembersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMemberDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStaffDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainingSessionDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookTrainingSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTrainingSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseAvailabilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTrainerSessionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageMembershipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membershipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makePaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupWst23DataSet = new Gym_Management_System.GroupWst23DataSet();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.membershipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.time_SlotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentTableAdapter = new Gym_Management_System.GroupWst23DataSetTableAdapters.PaymentTableAdapter();
            this.tableAdapterManager = new Gym_Management_System.GroupWst23DataSetTableAdapters.TableAdapterManager();
            this.time_SlotTableAdapter = new Gym_Management_System.GroupWst23DataSetTableAdapters.Time_SlotTableAdapter();
            this.membershipTableAdapter = new Gym_Management_System.GroupWst23DataSetTableAdapters.MembershipTableAdapter();
            this.memberTableAdapter1 = new Gym_Management_System.GroupWst23DataSetTableAdapters.MemberTableAdapter();
            this.paymentTableAdapter1 = new Gym_Management_System.GroupWst23DataSetTableAdapters.PaymentTableAdapter();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst23DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_SlotBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accessControlToolStripMenuItem,
            this.HomeToolStripMenuItem,
            this.memberDetailsToolStripMenuItem,
            this.manageStaffToolStripMenuItem,
            this.trainingSessionDetailsToolStripMenuItem,
            this.manageMembershipToolStripMenuItem,
            this.paymentDetailsToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.registerToolStripMenuItem,
            this.toolStripTextBox1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1796, 31);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accessControlToolStripMenuItem
            // 
            this.accessControlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.accessControlToolStripMenuItem.Name = "accessControlToolStripMenuItem";
            this.accessControlToolStripMenuItem.Size = new System.Drawing.Size(120, 27);
            this.accessControlToolStripMenuItem.Text = "Access Control";
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.logInToolStripMenuItem.Text = "Log in";
            this.logInToolStripMenuItem.Click += new System.EventHandler(this.logInToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // HomeToolStripMenuItem
            // 
            this.HomeToolStripMenuItem.Image = global::Gym_Management_System.Properties.Resources.home_icon;
            this.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem";
            this.HomeToolStripMenuItem.Size = new System.Drawing.Size(84, 27);
            this.HomeToolStripMenuItem.Text = "Home";
            this.HomeToolStripMenuItem.Click += new System.EventHandler(this.dashBoardToolStripMenuItem_Click);
            // 
            // memberDetailsToolStripMenuItem
            // 
            this.memberDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerMemberToolStripMenuItem,
            this.viewMembersToolStripMenuItem,
            this.updateMemberDetailsToolStripMenuItem});
            this.memberDetailsToolStripMenuItem.Name = "memberDetailsToolStripMenuItem";
            this.memberDetailsToolStripMenuItem.Size = new System.Drawing.Size(137, 27);
            this.memberDetailsToolStripMenuItem.Text = "Manage Member";
            // 
            // registerMemberToolStripMenuItem
            // 
            this.registerMemberToolStripMenuItem.Image = global::Gym_Management_System.Properties.Resources.Member;
            this.registerMemberToolStripMenuItem.Name = "registerMemberToolStripMenuItem";
            this.registerMemberToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.registerMemberToolStripMenuItem.Text = "Register Member";
            this.registerMemberToolStripMenuItem.Click += new System.EventHandler(this.registerMemberToolStripMenuItem_Click);
            // 
            // viewMembersToolStripMenuItem
            // 
            this.viewMembersToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.viewMembersToolStripMenuItem.Image = global::Gym_Management_System.Properties.Resources.Members_Icon;
            this.viewMembersToolStripMenuItem.Name = "viewMembersToolStripMenuItem";
            this.viewMembersToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.viewMembersToolStripMenuItem.Text = "View Members";
            this.viewMembersToolStripMenuItem.Click += new System.EventHandler(this.viewMembersToolStripMenuItem_Click_1);
            // 
            // updateMemberDetailsToolStripMenuItem
            // 
            this.updateMemberDetailsToolStripMenuItem.Name = "updateMemberDetailsToolStripMenuItem";
            this.updateMemberDetailsToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.updateMemberDetailsToolStripMenuItem.Text = "Update Member Details";
            this.updateMemberDetailsToolStripMenuItem.Click += new System.EventHandler(this.updateMemberDetailsToolStripMenuItem_Click);
            // 
            // manageStaffToolStripMenuItem
            // 
            this.manageStaffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewStaffDetailsToolStripMenuItem});
            this.manageStaffToolStripMenuItem.Name = "manageStaffToolStripMenuItem";
            this.manageStaffToolStripMenuItem.Size = new System.Drawing.Size(112, 27);
            this.manageStaffToolStripMenuItem.Text = "Manage Staff";
            // 
            // viewStaffDetailsToolStripMenuItem
            // 
            this.viewStaffDetailsToolStripMenuItem.Name = "viewStaffDetailsToolStripMenuItem";
            this.viewStaffDetailsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.viewStaffDetailsToolStripMenuItem.Text = "View  Staff Details";
            // 
            // trainingSessionDetailsToolStripMenuItem
            // 
            this.trainingSessionDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookTrainingSessionToolStripMenuItem,
            this.viewTrainingSessionToolStripMenuItem,
            this.chooseAvailabilityToolStripMenuItem});
            this.trainingSessionDetailsToolStripMenuItem.Name = "trainingSessionDetailsToolStripMenuItem";
            this.trainingSessionDetailsToolStripMenuItem.Size = new System.Drawing.Size(140, 27);
            this.trainingSessionDetailsToolStripMenuItem.Text = "Manage Sessions ";
            // 
            // bookTrainingSessionToolStripMenuItem
            // 
            this.bookTrainingSessionToolStripMenuItem.Name = "bookTrainingSessionToolStripMenuItem";
            this.bookTrainingSessionToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.bookTrainingSessionToolStripMenuItem.Text = "Book Training session";
            this.bookTrainingSessionToolStripMenuItem.Click += new System.EventHandler(this.bookTrainingSessionToolStripMenuItem_Click);
            // 
            // viewTrainingSessionToolStripMenuItem
            // 
            this.viewTrainingSessionToolStripMenuItem.Name = "viewTrainingSessionToolStripMenuItem";
            this.viewTrainingSessionToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.viewTrainingSessionToolStripMenuItem.Text = "View Training Session";
            this.viewTrainingSessionToolStripMenuItem.Click += new System.EventHandler(this.viewTrainingSessionToolStripMenuItem_Click);
            // 
            // chooseAvailabilityToolStripMenuItem
            // 
            this.chooseAvailabilityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewTrainerSessionsToolStripMenuItem});
            this.chooseAvailabilityToolStripMenuItem.Name = "chooseAvailabilityToolStripMenuItem";
            this.chooseAvailabilityToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.chooseAvailabilityToolStripMenuItem.Text = "Choose Availability";
            // 
            // viewTrainerSessionsToolStripMenuItem
            // 
            this.viewTrainerSessionsToolStripMenuItem.Name = "viewTrainerSessionsToolStripMenuItem";
            this.viewTrainerSessionsToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.viewTrainerSessionsToolStripMenuItem.Text = "View Trainer Sessions";
            // 
            // manageMembershipToolStripMenuItem
            // 
            this.manageMembershipToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.membershipToolStripMenuItem});
            this.manageMembershipToolStripMenuItem.Name = "manageMembershipToolStripMenuItem";
            this.manageMembershipToolStripMenuItem.Size = new System.Drawing.Size(164, 27);
            this.manageMembershipToolStripMenuItem.Text = "Manage Membership";
            // 
            // membershipToolStripMenuItem
            // 
            this.membershipToolStripMenuItem.Name = "membershipToolStripMenuItem";
            this.membershipToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.membershipToolStripMenuItem.Text = "Update Membership plans";
            // 
            // paymentDetailsToolStripMenuItem
            // 
            this.paymentDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makePaymentToolStripMenuItem});
            this.paymentDetailsToolStripMenuItem.Name = "paymentDetailsToolStripMenuItem";
            this.paymentDetailsToolStripMenuItem.Size = new System.Drawing.Size(137, 27);
            this.paymentDetailsToolStripMenuItem.Text = "Manage Payment";
            // 
            // makePaymentToolStripMenuItem
            // 
            this.makePaymentToolStripMenuItem.Name = "makePaymentToolStripMenuItem";
            this.makePaymentToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.makePaymentToolStripMenuItem.Text = "Make Payment";
            this.makePaymentToolStripMenuItem.Click += new System.EventHandler(this.makePaymentToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(132, 27);
            this.reportToolStripMenuItem.Text = "Generate Report";
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signRegisterToolStripMenuItem,
            this.viewRegisterToolStripMenuItem});
            this.registerToolStripMenuItem.Image = global::Gym_Management_System.Properties.Resources.Member;
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(97, 27);
            this.registerToolStripMenuItem.Text = "Register";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // signRegisterToolStripMenuItem
            // 
            this.signRegisterToolStripMenuItem.Name = "signRegisterToolStripMenuItem";
            this.signRegisterToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.signRegisterToolStripMenuItem.Text = "Sign Register";
            this.signRegisterToolStripMenuItem.Click += new System.EventHandler(this.signRegisterToolStripMenuItem_Click);
            // 
            // viewRegisterToolStripMenuItem
            // 
            this.viewRegisterToolStripMenuItem.Name = "viewRegisterToolStripMenuItem";
            this.viewRegisterToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.viewRegisterToolStripMenuItem.Text = "View Register List";
            this.viewRegisterToolStripMenuItem.Click += new System.EventHandler(this.viewRegisterToolStripMenuItem_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(300, 27);
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataMember = "Payment";
            this.paymentBindingSource.DataSource = this.groupWst23DataSet;
            // 
            // groupWst23DataSet
            // 
            this.groupWst23DataSet.DataSetName = "GroupWst23DataSet";
            this.groupWst23DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "Member";
            this.memberBindingSource.DataSource = this.groupWst23DataSet;
            // 
            // membershipBindingSource
            // 
            this.membershipBindingSource.DataMember = "Membership";
            this.membershipBindingSource.DataSource = this.groupWst23DataSet;
            // 
            // time_SlotBindingSource
            // 
            this.time_SlotBindingSource.DataMember = "Time_Slot";
            this.time_SlotBindingSource.DataSource = this.groupWst23DataSet;
            // 
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArchiveMemberTableAdapter = null;
            this.tableAdapterManager.ArchiveStaffTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FreePlanRegisterTableTableAdapter = null;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.MembershipTableAdapter = null;
            this.tableAdapterManager.MemberTableAdapter = null;
            this.tableAdapterManager.PaidPlanRegisterTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = this.paymentTableAdapter;
            this.tableAdapterManager.Session_TableTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.Time_SlotTableAdapter = null;
            this.tableAdapterManager.Trainer_ScheduleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Gym_Management_System.GroupWst23DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // time_SlotTableAdapter
            // 
            this.time_SlotTableAdapter.ClearBeforeFill = true;
            // 
            // membershipTableAdapter
            // 
            this.membershipTableAdapter.ClearBeforeFill = true;
            // 
            // memberTableAdapter1
            // 
            this.memberTableAdapter1.ClearBeforeFill = true;
            // 
            // paymentTableAdapter1
            // 
            this.paymentTableAdapter1.ClearBeforeFill = true;
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
            this.guna2Button1.Location = new System.Drawing.Point(1622, 0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(119, 31);
            this.guna2Button1.TabIndex = 4;
            this.guna2Button1.Text = "Logout";
            this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // ReceptionistPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1796, 763);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "ReceptionistPP";
            this.Text = "ReceptionistPP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReceptionistPP_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst23DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_SlotBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupWst23DataSet groupWst23DataSet;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private GroupWst23DataSetTableAdapters.PaymentTableAdapter paymentTableAdapter;
        private GroupWst23DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource time_SlotBindingSource;
        private GroupWst23DataSetTableAdapters.Time_SlotTableAdapter time_SlotTableAdapter;
        private System.Windows.Forms.BindingSource membershipBindingSource;
        private GroupWst23DataSetTableAdapters.MembershipTableAdapter membershipTableAdapter;
        private GroupWst23DataSetTableAdapters.MemberTableAdapter memberTableAdapter1;
        private GroupWst23DataSetTableAdapters.PaymentTableAdapter paymentTableAdapter1;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accessControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMembersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateMemberDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makePaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainingSessionDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookTrainingSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTrainingSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem manageStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageMembershipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStaffDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membershipToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseAvailabilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTrainerSessionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signRegisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewRegisterToolStripMenuItem;
    }
}