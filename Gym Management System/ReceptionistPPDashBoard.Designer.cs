namespace Gym_Management_System
{
    partial class ReceptionistPPDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceptionistPPDashBoard));
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupWst23DataSet = new Gym_Management_System.GroupWst23DataSet();
            this.memberTableAdapter = new Gym_Management_System.GroupWst23DataSetTableAdapters.MemberTableAdapter();
            this.ManagerFormMainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.QuickViewGroupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.SummaryByDateLabel = new System.Windows.Forms.Label();
            this.CheckPrevDaysDateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2ShadowPanel8 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.NewMembersLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.NewMembersSubLabel = new System.Windows.Forms.Label();
            this.guna2ShadowPanel6 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.IncompleteSessionsLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.IncompleteSessionsSubLabel = new System.Windows.Forms.Label();
            this.guna2ShadowPanel5 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.CompletedSessionsLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CompletedSessionsSubLabel = new System.Windows.Forms.Label();
            this.TodayDateLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ShadowPanel4 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.TodaysSessionsLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TodaysSessionsSubLabel = new System.Windows.Forms.Label();
            this.guna2ShadowPanel3 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.PresentTrainersLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TrainersInGymSubLabel = new System.Windows.Forms.Label();
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.TotalGymTrainersLabel = new System.Windows.Forms.Label();
            this.TotalTrainersSubLabel = new System.Windows.Forms.Label();
            this.TodaysMemberCheckInPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.TodaysCheckInsSubLabel = new System.Windows.Forms.Label();
            this.TodaysCheckInLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.TotalMembersSubLabel = new System.Windows.Forms.Label();
            this.TotalGymMembersLabel = new System.Windows.Forms.Label();
            this.staffTableAdapter1 = new Gym_Management_System.GroupWst23DataSetTableAdapters.StaffTableAdapter();
         //   this.paidPlanRegisterTableTableAdapter1 = new Gym_Management_System.GroupWst23DataSetTableAdapters.PaidPlanRegisterTableTableAdapter();
            this.training_SessionTableAdapter1 = new Gym_Management_System.GroupWst23DataSetTableAdapters.Training_SessionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst23DataSet)).BeginInit();
            this.ManagerFormMainPanel.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            this.QuickViewGroupBox.SuspendLayout();
            this.guna2ShadowPanel8.SuspendLayout();
            this.guna2ShadowPanel6.SuspendLayout();
            this.guna2ShadowPanel5.SuspendLayout();
            this.guna2ShadowPanel4.SuspendLayout();
            this.guna2ShadowPanel3.SuspendLayout();
            this.guna2ShadowPanel2.SuspendLayout();
            this.TodaysMemberCheckInPanel.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
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
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // ManagerFormMainPanel
            // 
            this.ManagerFormMainPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ManagerFormMainPanel.Controls.Add(this.guna2Panel2);
            this.ManagerFormMainPanel.Controls.Add(this.guna2Panel4);
            this.ManagerFormMainPanel.Controls.Add(this.QuickViewGroupBox);
            this.ManagerFormMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ManagerFormMainPanel.Location = new System.Drawing.Point(0, 0);
            this.ManagerFormMainPanel.Name = "ManagerFormMainPanel";
            this.ManagerFormMainPanel.Size = new System.Drawing.Size(1924, 1043);
            this.ManagerFormMainPanel.TabIndex = 33;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.SystemColors.GrayText;
            this.guna2Panel2.Controls.Add(this.guna2Separator2);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 1033);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1924, 10);
            this.guna2Panel2.TabIndex = 32;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2Separator2.Location = new System.Drawing.Point(3, 51);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(1921, 10);
            this.guna2Separator2.TabIndex = 34;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.guna2Panel4.Controls.Add(this.welcomeLbl);
            this.guna2Panel4.Controls.Add(this.guna2Panel5);
            this.guna2Panel4.Controls.Add(this.guna2ImageButton1);
            this.guna2Panel4.Controls.Add(this.label3);
            this.guna2Panel4.Controls.Add(this.guna2CirclePictureBox2);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel4.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(1924, 168);
            this.guna2Panel4.TabIndex = 31;
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLbl.Location = new System.Drawing.Point(23, 121);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(89, 27);
            this.welcomeLbl.TabIndex = 6;
            this.welcomeLbl.Text = "Welcome";
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackgroundImage = global::Gym_Management_System.Properties.Resources.UKZN;
            this.guna2Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel5.Location = new System.Drawing.Point(746, 9);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(542, 129);
            this.guna2Panel5.TabIndex = 4;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(100, 100);
            this.guna2ImageButton1.IndicateFocus = true;
            this.guna2ImageButton1.Location = new System.Drawing.Point(1737, 32);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(136, 93);
            this.guna2ImageButton1.TabIndex = 3;
            this.guna2ImageButton1.UseTransparentBackground = true;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(779, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Logo";
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox2.FillColor = System.Drawing.Color.DimGray;
            this.guna2CirclePictureBox2.Image = global::Gym_Management_System.Properties.Resources.icon_profile;
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(0, 0);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(143, 118);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox2.TabIndex = 1;
            this.guna2CirclePictureBox2.TabStop = false;
            this.guna2CirclePictureBox2.UseTransparentBackground = true;
            // 
            // QuickViewGroupBox
            // 
            this.QuickViewGroupBox.Controls.Add(this.SummaryByDateLabel);
            this.QuickViewGroupBox.Controls.Add(this.CheckPrevDaysDateTimePicker);
            this.QuickViewGroupBox.Controls.Add(this.guna2ShadowPanel8);
            this.QuickViewGroupBox.Controls.Add(this.guna2ShadowPanel6);
            this.QuickViewGroupBox.Controls.Add(this.guna2ShadowPanel5);
            this.QuickViewGroupBox.Controls.Add(this.TodayDateLabel);
            this.QuickViewGroupBox.Controls.Add(this.guna2ShadowPanel4);
            this.QuickViewGroupBox.Controls.Add(this.guna2ShadowPanel3);
            this.QuickViewGroupBox.Controls.Add(this.guna2ShadowPanel2);
            this.QuickViewGroupBox.Controls.Add(this.TodaysMemberCheckInPanel);
            this.QuickViewGroupBox.Controls.Add(this.guna2ShadowPanel1);
            this.QuickViewGroupBox.CustomBorderColor = System.Drawing.Color.Gray;
            this.QuickViewGroupBox.FillColor = System.Drawing.Color.Silver;
            this.QuickViewGroupBox.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuickViewGroupBox.ForeColor = System.Drawing.Color.Black;
            this.QuickViewGroupBox.Location = new System.Drawing.Point(92, 207);
            this.QuickViewGroupBox.Name = "QuickViewGroupBox";
            this.QuickViewGroupBox.Size = new System.Drawing.Size(1649, 749);
            this.QuickViewGroupBox.TabIndex = 30;
            this.QuickViewGroupBox.Text = "Quick View";
            // 
            // SummaryByDateLabel
            // 
            this.SummaryByDateLabel.AutoSize = true;
            this.SummaryByDateLabel.Location = new System.Drawing.Point(36, 53);
            this.SummaryByDateLabel.Name = "SummaryByDateLabel";
            this.SummaryByDateLabel.Size = new System.Drawing.Size(209, 27);
            this.SummaryByDateLabel.TabIndex = 29;
            this.SummaryByDateLabel.Text = "View Summary By Date";
            // 
            // CheckPrevDaysDateTimePicker
            // 
            this.CheckPrevDaysDateTimePicker.Checked = true;
            this.CheckPrevDaysDateTimePicker.FillColor = System.Drawing.Color.Gray;
            this.CheckPrevDaysDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CheckPrevDaysDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.CheckPrevDaysDateTimePicker.Location = new System.Drawing.Point(22, 83);
            this.CheckPrevDaysDateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.CheckPrevDaysDateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.CheckPrevDaysDateTimePicker.Name = "CheckPrevDaysDateTimePicker";
            this.CheckPrevDaysDateTimePicker.Size = new System.Drawing.Size(293, 36);
            this.CheckPrevDaysDateTimePicker.TabIndex = 28;
            this.CheckPrevDaysDateTimePicker.Value = new System.DateTime(2026, 5, 28, 8, 32, 22, 379);
            this.CheckPrevDaysDateTimePicker.ValueChanged += new System.EventHandler(this.CheckPrevDaysDateTimePicker_ValueChanged);
            // 
            // guna2ShadowPanel8
            // 
            this.guna2ShadowPanel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel8.Controls.Add(this.NewMembersLabel);
            this.guna2ShadowPanel8.Controls.Add(this.NewMembersSubLabel);
            this.guna2ShadowPanel8.FillColor = System.Drawing.Color.Gray;
            this.guna2ShadowPanel8.Location = new System.Drawing.Point(1207, 483);
            this.guna2ShadowPanel8.Name = "guna2ShadowPanel8";
            this.guna2ShadowPanel8.ShadowColor = System.Drawing.Color.WhiteSmoke;
            this.guna2ShadowPanel8.ShadowDepth = 180;
            this.guna2ShadowPanel8.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.guna2ShadowPanel8.Size = new System.Drawing.Size(224, 201);
            this.guna2ShadowPanel8.TabIndex = 27;
            // 
            // NewMembersLabel
            // 
            this.NewMembersLabel.BackColor = System.Drawing.Color.Transparent;
            this.NewMembersLabel.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewMembersLabel.Location = new System.Drawing.Point(69, 56);
            this.NewMembersLabel.Name = "NewMembersLabel";
            this.NewMembersLabel.Size = new System.Drawing.Size(91, 57);
            this.NewMembersLabel.TabIndex = 7;
            this.NewMembersLabel.Text = "Tod";
            // 
            // NewMembersSubLabel
            // 
            this.NewMembersSubLabel.AutoSize = true;
            this.NewMembersSubLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewMembersSubLabel.Location = new System.Drawing.Point(9, 150);
            this.NewMembersSubLabel.Name = "NewMembersSubLabel";
            this.NewMembersSubLabel.Size = new System.Drawing.Size(241, 28);
            this.NewMembersSubLabel.TabIndex = 6;
            this.NewMembersSubLabel.Text = "New Members This Month";
            // 
            // guna2ShadowPanel6
            // 
            this.guna2ShadowPanel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel6.Controls.Add(this.IncompleteSessionsLabel);
            this.guna2ShadowPanel6.Controls.Add(this.IncompleteSessionsSubLabel);
            this.guna2ShadowPanel6.FillColor = System.Drawing.Color.Gray;
            this.guna2ShadowPanel6.Location = new System.Drawing.Point(835, 483);
            this.guna2ShadowPanel6.Name = "guna2ShadowPanel6";
            this.guna2ShadowPanel6.ShadowColor = System.Drawing.Color.WhiteSmoke;
            this.guna2ShadowPanel6.ShadowDepth = 180;
            this.guna2ShadowPanel6.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.guna2ShadowPanel6.Size = new System.Drawing.Size(218, 201);
            this.guna2ShadowPanel6.TabIndex = 25;
            // 
            // IncompleteSessionsLabel
            // 
            this.IncompleteSessionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.IncompleteSessionsLabel.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncompleteSessionsLabel.Location = new System.Drawing.Point(54, 56);
            this.IncompleteSessionsLabel.Name = "IncompleteSessionsLabel";
            this.IncompleteSessionsLabel.Size = new System.Drawing.Size(91, 57);
            this.IncompleteSessionsLabel.TabIndex = 8;
            this.IncompleteSessionsLabel.Text = "Tod";
            // 
            // IncompleteSessionsSubLabel
            // 
            this.IncompleteSessionsSubLabel.AutoSize = true;
            this.IncompleteSessionsSubLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncompleteSessionsSubLabel.Location = new System.Drawing.Point(3, 150);
            this.IncompleteSessionsSubLabel.Name = "IncompleteSessionsSubLabel";
            this.IncompleteSessionsSubLabel.Size = new System.Drawing.Size(188, 28);
            this.IncompleteSessionsSubLabel.TabIndex = 7;
            this.IncompleteSessionsSubLabel.Text = "Incomplete Sessions";
            // 
            // guna2ShadowPanel5
            // 
            this.guna2ShadowPanel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel5.Controls.Add(this.CompletedSessionsLabel);
            this.guna2ShadowPanel5.Controls.Add(this.CompletedSessionsSubLabel);
            this.guna2ShadowPanel5.FillColor = System.Drawing.Color.Gray;
            this.guna2ShadowPanel5.Location = new System.Drawing.Point(433, 483);
            this.guna2ShadowPanel5.Name = "guna2ShadowPanel5";
            this.guna2ShadowPanel5.ShadowColor = System.Drawing.Color.WhiteSmoke;
            this.guna2ShadowPanel5.ShadowDepth = 180;
            this.guna2ShadowPanel5.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.guna2ShadowPanel5.Size = new System.Drawing.Size(221, 201);
            this.guna2ShadowPanel5.TabIndex = 24;
            // 
            // CompletedSessionsLabel
            // 
            this.CompletedSessionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.CompletedSessionsLabel.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompletedSessionsLabel.Location = new System.Drawing.Point(57, 56);
            this.CompletedSessionsLabel.Name = "CompletedSessionsLabel";
            this.CompletedSessionsLabel.Size = new System.Drawing.Size(91, 57);
            this.CompletedSessionsLabel.TabIndex = 7;
            this.CompletedSessionsLabel.Text = "Tod";
            // 
            // CompletedSessionsSubLabel
            // 
            this.CompletedSessionsSubLabel.AutoSize = true;
            this.CompletedSessionsSubLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompletedSessionsSubLabel.Location = new System.Drawing.Point(24, 150);
            this.CompletedSessionsSubLabel.Name = "CompletedSessionsSubLabel";
            this.CompletedSessionsSubLabel.Size = new System.Drawing.Size(187, 28);
            this.CompletedSessionsSubLabel.TabIndex = 6;
            this.CompletedSessionsSubLabel.Text = "Completed Sessions";
            // 
            // TodayDateLabel
            // 
            this.TodayDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.TodayDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodayDateLabel.Location = new System.Drawing.Point(1240, 53);
            this.TodayDateLabel.Name = "TodayDateLabel";
            this.TodayDateLabel.Size = new System.Drawing.Size(143, 31);
            this.TodayDateLabel.TabIndex = 0;
            this.TodayDateLabel.Text = "Today\'s Date\r\n";
            // 
            // guna2ShadowPanel4
            // 
            this.guna2ShadowPanel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel4.Controls.Add(this.TodaysSessionsLabel);
            this.guna2ShadowPanel4.Controls.Add(this.TodaysSessionsSubLabel);
            this.guna2ShadowPanel4.FillColor = System.Drawing.Color.Gray;
            this.guna2ShadowPanel4.Location = new System.Drawing.Point(51, 483);
            this.guna2ShadowPanel4.Name = "guna2ShadowPanel4";
            this.guna2ShadowPanel4.ShadowColor = System.Drawing.Color.WhiteSmoke;
            this.guna2ShadowPanel4.ShadowDepth = 180;
            this.guna2ShadowPanel4.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.guna2ShadowPanel4.Size = new System.Drawing.Size(221, 201);
            this.guna2ShadowPanel4.TabIndex = 23;
            // 
            // TodaysSessionsLabel
            // 
            this.TodaysSessionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.TodaysSessionsLabel.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodaysSessionsLabel.Location = new System.Drawing.Point(55, 56);
            this.TodaysSessionsLabel.Name = "TodaysSessionsLabel";
            this.TodaysSessionsLabel.Size = new System.Drawing.Size(91, 57);
            this.TodaysSessionsLabel.TabIndex = 6;
            this.TodaysSessionsLabel.Text = "Tod";
            // 
            // TodaysSessionsSubLabel
            // 
            this.TodaysSessionsSubLabel.AutoSize = true;
            this.TodaysSessionsSubLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodaysSessionsSubLabel.Location = new System.Drawing.Point(38, 150);
            this.TodaysSessionsSubLabel.Name = "TodaysSessionsSubLabel";
            this.TodaysSessionsSubLabel.Size = new System.Drawing.Size(132, 28);
            this.TodaysSessionsSubLabel.TabIndex = 5;
            this.TodaysSessionsSubLabel.Text = "Total Sessions";
            // 
            // guna2ShadowPanel3
            // 
            this.guna2ShadowPanel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel3.Controls.Add(this.PresentTrainersLabel);
            this.guna2ShadowPanel3.Controls.Add(this.TrainersInGymSubLabel);
            this.guna2ShadowPanel3.FillColor = System.Drawing.Color.Gray;
            this.guna2ShadowPanel3.Location = new System.Drawing.Point(1207, 179);
            this.guna2ShadowPanel3.Name = "guna2ShadowPanel3";
            this.guna2ShadowPanel3.ShadowColor = System.Drawing.Color.WhiteSmoke;
            this.guna2ShadowPanel3.ShadowDepth = 180;
            this.guna2ShadowPanel3.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.guna2ShadowPanel3.Size = new System.Drawing.Size(221, 193);
            this.guna2ShadowPanel3.TabIndex = 22;
            // 
            // PresentTrainersLabel
            // 
            this.PresentTrainersLabel.BackColor = System.Drawing.Color.Transparent;
            this.PresentTrainersLabel.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PresentTrainersLabel.Location = new System.Drawing.Point(69, 62);
            this.PresentTrainersLabel.Name = "PresentTrainersLabel";
            this.PresentTrainersLabel.Size = new System.Drawing.Size(78, 57);
            this.PresentTrainersLabel.TabIndex = 0;
            this.PresentTrainersLabel.Text = "Pre";
            // 
            // TrainersInGymSubLabel
            // 
            this.TrainersInGymSubLabel.AutoSize = true;
            this.TrainersInGymSubLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrainersInGymSubLabel.Location = new System.Drawing.Point(49, 144);
            this.TrainersInGymSubLabel.Name = "TrainersInGymSubLabel";
            this.TrainersInGymSubLabel.Size = new System.Drawing.Size(145, 28);
            this.TrainersInGymSubLabel.TabIndex = 4;
            this.TrainersInGymSubLabel.Text = "Trainers In Gym";
            // 
            // guna2ShadowPanel2
            // 
            this.guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel2.Controls.Add(this.TotalGymTrainersLabel);
            this.guna2ShadowPanel2.Controls.Add(this.TotalTrainersSubLabel);
            this.guna2ShadowPanel2.FillColor = System.Drawing.Color.Gray;
            this.guna2ShadowPanel2.Location = new System.Drawing.Point(832, 179);
            this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            this.guna2ShadowPanel2.ShadowColor = System.Drawing.Color.WhiteSmoke;
            this.guna2ShadowPanel2.ShadowDepth = 180;
            this.guna2ShadowPanel2.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(221, 193);
            this.guna2ShadowPanel2.TabIndex = 21;
            // 
            // TotalGymTrainersLabel
            // 
            this.TotalGymTrainersLabel.AutoSize = true;
            this.TotalGymTrainersLabel.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalGymTrainersLabel.Location = new System.Drawing.Point(47, 64);
            this.TotalGymTrainersLabel.Name = "TotalGymTrainersLabel";
            this.TotalGymTrainersLabel.Size = new System.Drawing.Size(96, 55);
            this.TotalGymTrainersLabel.TabIndex = 0;
            this.TotalGymTrainersLabel.Text = "Tot";
            // 
            // TotalTrainersSubLabel
            // 
            this.TotalTrainersSubLabel.AutoSize = true;
            this.TotalTrainersSubLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTrainersSubLabel.Location = new System.Drawing.Point(52, 144);
            this.TotalTrainersSubLabel.Name = "TotalTrainersSubLabel";
            this.TotalTrainersSubLabel.Size = new System.Drawing.Size(125, 28);
            this.TotalTrainersSubLabel.TabIndex = 3;
            this.TotalTrainersSubLabel.Text = "Total Trainers";
            // 
            // TodaysMemberCheckInPanel
            // 
            this.TodaysMemberCheckInPanel.BackColor = System.Drawing.Color.Transparent;
            this.TodaysMemberCheckInPanel.Controls.Add(this.TodaysCheckInsSubLabel);
            this.TodaysMemberCheckInPanel.Controls.Add(this.TodaysCheckInLabel);
            this.TodaysMemberCheckInPanel.FillColor = System.Drawing.Color.Gray;
            this.TodaysMemberCheckInPanel.Location = new System.Drawing.Point(433, 179);
            this.TodaysMemberCheckInPanel.Name = "TodaysMemberCheckInPanel";
            this.TodaysMemberCheckInPanel.ShadowColor = System.Drawing.Color.WhiteSmoke;
            this.TodaysMemberCheckInPanel.ShadowDepth = 180;
            this.TodaysMemberCheckInPanel.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.TodaysMemberCheckInPanel.Size = new System.Drawing.Size(221, 193);
            this.TodaysMemberCheckInPanel.TabIndex = 20;
            // 
            // TodaysCheckInsSubLabel
            // 
            this.TodaysCheckInsSubLabel.AutoSize = true;
            this.TodaysCheckInsSubLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodaysCheckInsSubLabel.Location = new System.Drawing.Point(24, 144);
            this.TodaysCheckInsSubLabel.Name = "TodaysCheckInsSubLabel";
            this.TodaysCheckInsSubLabel.Size = new System.Drawing.Size(172, 28);
            this.TodaysCheckInsSubLabel.TabIndex = 2;
            this.TodaysCheckInsSubLabel.Text = "Member Check ins";
            // 
            // TodaysCheckInLabel
            // 
            this.TodaysCheckInLabel.BackColor = System.Drawing.Color.Transparent;
            this.TodaysCheckInLabel.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodaysCheckInLabel.Location = new System.Drawing.Point(57, 62);
            this.TodaysCheckInLabel.Name = "TodaysCheckInLabel";
            this.TodaysCheckInLabel.Size = new System.Drawing.Size(91, 57);
            this.TodaysCheckInLabel.TabIndex = 0;
            this.TodaysCheckInLabel.Text = "Tod";
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.TotalMembersSubLabel);
            this.guna2ShadowPanel1.Controls.Add(this.TotalGymMembersLabel);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.Gray;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(51, 179);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.WhiteSmoke;
            this.guna2ShadowPanel1.ShadowDepth = 180;
            this.guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(221, 193);
            this.guna2ShadowPanel1.TabIndex = 19;
            // 
            // TotalMembersSubLabel
            // 
            this.TotalMembersSubLabel.AutoSize = true;
            this.TotalMembersSubLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalMembersSubLabel.Location = new System.Drawing.Point(38, 144);
            this.TotalMembersSubLabel.Name = "TotalMembersSubLabel";
            this.TotalMembersSubLabel.Size = new System.Drawing.Size(141, 28);
            this.TotalMembersSubLabel.TabIndex = 1;
            this.TotalMembersSubLabel.Text = "Total Members";
            // 
            // TotalGymMembersLabel
            // 
            this.TotalGymMembersLabel.AutoSize = true;
            this.TotalGymMembersLabel.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalGymMembersLabel.Location = new System.Drawing.Point(45, 64);
            this.TotalGymMembersLabel.Name = "TotalGymMembersLabel";
            this.TotalGymMembersLabel.Size = new System.Drawing.Size(96, 55);
            this.TotalGymMembersLabel.TabIndex = 0;
            this.TotalGymMembersLabel.Text = "Tot";
            // 
            // staffTableAdapter1
            // 
            this.staffTableAdapter1.ClearBeforeFill = true;
            // 
            // paidPlanRegisterTableTableAdapter1
            // 
         //   this.paidPlanRegisterTableTableAdapter1.ClearBeforeFill = true;
            // 
            // training_SessionTableAdapter1
            // 
            this.training_SessionTableAdapter1.ClearBeforeFill = true;
            // 
            // ReceptionistPPDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1043);
            this.Controls.Add(this.ManagerFormMainPanel);
            this.Name = "ReceptionistPPDashBoard";
            this.Text = "ReceptionistPPDashBoard";
            this.Load += new System.EventHandler(this.ReceptionistPPDashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst23DataSet)).EndInit();
            this.ManagerFormMainPanel.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            this.QuickViewGroupBox.ResumeLayout(false);
            this.QuickViewGroupBox.PerformLayout();
            this.guna2ShadowPanel8.ResumeLayout(false);
            this.guna2ShadowPanel8.PerformLayout();
            this.guna2ShadowPanel6.ResumeLayout(false);
            this.guna2ShadowPanel6.PerformLayout();
            this.guna2ShadowPanel5.ResumeLayout(false);
            this.guna2ShadowPanel5.PerformLayout();
            this.guna2ShadowPanel4.ResumeLayout(false);
            this.guna2ShadowPanel4.PerformLayout();
            this.guna2ShadowPanel3.ResumeLayout(false);
            this.guna2ShadowPanel3.PerformLayout();
            this.guna2ShadowPanel2.ResumeLayout(false);
            this.guna2ShadowPanel2.PerformLayout();
            this.TodaysMemberCheckInPanel.ResumeLayout(false);
            this.TodaysMemberCheckInPanel.PerformLayout();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupWst23DataSet groupWst23DataSet;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private GroupWst23DataSetTableAdapters.MemberTableAdapter memberTableAdapter;
        private Guna.UI2.WinForms.Guna2Panel ManagerFormMainPanel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.Label welcomeLbl;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private Guna.UI2.WinForms.Guna2GroupBox QuickViewGroupBox;
        private System.Windows.Forms.Label SummaryByDateLabel;
        private Guna.UI2.WinForms.Guna2DateTimePicker CheckPrevDaysDateTimePicker;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel8;
        private Guna.UI2.WinForms.Guna2HtmlLabel NewMembersLabel;
        private System.Windows.Forms.Label NewMembersSubLabel;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel IncompleteSessionsLabel;
        private System.Windows.Forms.Label IncompleteSessionsSubLabel;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel CompletedSessionsLabel;
        private System.Windows.Forms.Label CompletedSessionsSubLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel TodayDateLabel;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel TodaysSessionsLabel;
        private System.Windows.Forms.Label TodaysSessionsSubLabel;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel PresentTrainersLabel;
        private System.Windows.Forms.Label TrainersInGymSubLabel;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private System.Windows.Forms.Label TotalGymTrainersLabel;
        private System.Windows.Forms.Label TotalTrainersSubLabel;
        private Guna.UI2.WinForms.Guna2ShadowPanel TodaysMemberCheckInPanel;
        private System.Windows.Forms.Label TodaysCheckInsSubLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel TodaysCheckInLabel;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Label TotalMembersSubLabel;
        private System.Windows.Forms.Label TotalGymMembersLabel;
        private GroupWst23DataSetTableAdapters.StaffTableAdapter staffTableAdapter1;
       // private GroupWst23DataSetTableAdapters.PaidPlanRegisterTableTableAdapter paidPlanRegisterTableTableAdapter1;
        private GroupWst23DataSetTableAdapters.Training_SessionTableAdapter training_SessionTableAdapter1;
    }
}