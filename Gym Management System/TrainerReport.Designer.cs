namespace Gym_Management_System
{
	partial class TrainerReport
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainerReport));
			this.SaveReportButton1 = new Guna.UI2.WinForms.Guna2Button();
			this.PrintReportButton = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
			this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
			this.TotalNumberOfActiveTrainerLabel = new System.Windows.Forms.Label();
			this.TotalFreeUsersLabel = new System.Windows.Forms.Label();
			this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
			this.TotalNumberOfInactiveTrainers = new System.Windows.Forms.Label();
			this.TotalActiveUsersLabel = new System.Windows.Forms.Label();
			this.TodaysMemberCheckInPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
			this.NumberOfTotalTrainerLabel = new System.Windows.Forms.Label();
			this.TotalMembersLabel = new System.Windows.Forms.Label();
			this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
			this.TrainerReportDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
			this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
			this.TrainerReportTypeComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
			this.TrainerReportStatusComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.staffRoleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.staffFNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.staffLNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.staffTelephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.staffPhoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.staffEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.staffDOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.staffGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.staffStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.staffBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.groupWst23DataSet1 = new Gym_Management_System.GroupWst23DataSet();
			this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.groupWst23DataSet = new Gym_Management_System.GroupWst23DataSet();
			this.staffTableAdapter = new Gym_Management_System.GroupWst23DataSetTableAdapters.StaffTableAdapter();
			this.guna2Panel2.SuspendLayout();
			this.guna2ShadowPanel1.SuspendLayout();
			this.guna2ShadowPanel2.SuspendLayout();
			this.TodaysMemberCheckInPanel.SuspendLayout();
			this.guna2GroupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.TrainerReportDataGridView)).BeginInit();
			this.guna2GroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.staffBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupWst23DataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupWst23DataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// SaveReportButton1
			// 
			this.SaveReportButton1.AutoRoundedCorners = true;
			this.SaveReportButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.SaveReportButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.SaveReportButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.SaveReportButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.SaveReportButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.SaveReportButton1.FillColor = System.Drawing.Color.Gray;
			this.SaveReportButton1.Font = new System.Drawing.Font("Segoe UI", 10.8F);
			this.SaveReportButton1.ForeColor = System.Drawing.Color.White;
			this.SaveReportButton1.Location = new System.Drawing.Point(1224, 855);
			this.SaveReportButton1.Name = "SaveReportButton1";
			this.SaveReportButton1.Size = new System.Drawing.Size(253, 66);
			this.SaveReportButton1.TabIndex = 43;
			this.SaveReportButton1.Text = "Export as PDF";
			this.SaveReportButton1.Click += new System.EventHandler(this.SaveReportButton1_Click);
			// 
			// PrintReportButton
			// 
			this.PrintReportButton.AutoRoundedCorners = true;
			this.PrintReportButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.PrintReportButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.PrintReportButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.PrintReportButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.PrintReportButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.PrintReportButton.FillColor = System.Drawing.Color.Gray;
			this.PrintReportButton.Font = new System.Drawing.Font("Segoe UI", 10.8F);
			this.PrintReportButton.ForeColor = System.Drawing.Color.White;
			this.PrintReportButton.Location = new System.Drawing.Point(489, 855);
			this.PrintReportButton.Name = "PrintReportButton";
			this.PrintReportButton.Size = new System.Drawing.Size(253, 66);
			this.PrintReportButton.TabIndex = 42;
			this.PrintReportButton.Text = "Print Report";
			this.PrintReportButton.Click += new System.EventHandler(this.PrintReportButton_Click);
			// 
			// guna2Panel2
			// 
			this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
			this.guna2Panel2.Controls.Add(this.guna2ShadowPanel1);
			this.guna2Panel2.Controls.Add(this.guna2ShadowPanel2);
			this.guna2Panel2.Controls.Add(this.TodaysMemberCheckInPanel);
			this.guna2Panel2.CustomBorderColor = System.Drawing.Color.Gray;
			this.guna2Panel2.FillColor = System.Drawing.Color.Silver;
			this.guna2Panel2.Location = new System.Drawing.Point(153, 703);
			this.guna2Panel2.Name = "guna2Panel2";
			this.guna2Panel2.Size = new System.Drawing.Size(1632, 133);
			this.guna2Panel2.TabIndex = 47;
			// 
			// guna2ShadowPanel1
			// 
			this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
			this.guna2ShadowPanel1.Controls.Add(this.TotalNumberOfActiveTrainerLabel);
			this.guna2ShadowPanel1.Controls.Add(this.TotalFreeUsersLabel);
			this.guna2ShadowPanel1.FillColor = System.Drawing.Color.Gray;
			this.guna2ShadowPanel1.Location = new System.Drawing.Point(721, 11);
			this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
			this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.WhiteSmoke;
			this.guna2ShadowPanel1.ShadowDepth = 180;
			this.guna2ShadowPanel1.Size = new System.Drawing.Size(190, 101);
			this.guna2ShadowPanel1.TabIndex = 37;
			// 
			// TotalNumberOfActiveTrainerLabel
			// 
			this.TotalNumberOfActiveTrainerLabel.AutoSize = true;
			this.TotalNumberOfActiveTrainerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TotalNumberOfActiveTrainerLabel.Location = new System.Drawing.Point(27, 40);
			this.TotalNumberOfActiveTrainerLabel.Name = "TotalNumberOfActiveTrainerLabel";
			this.TotalNumberOfActiveTrainerLabel.Size = new System.Drawing.Size(133, 38);
			this.TotalNumberOfActiveTrainerLabel.TabIndex = 2;
			this.TotalNumberOfActiveTrainerLabel.Text = "Number";
			// 
			// TotalFreeUsersLabel
			// 
			this.TotalFreeUsersLabel.AutoSize = true;
			this.TotalFreeUsersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TotalFreeUsersLabel.Location = new System.Drawing.Point(17, 9);
			this.TotalFreeUsersLabel.Name = "TotalFreeUsersLabel";
			this.TotalFreeUsersLabel.Size = new System.Drawing.Size(143, 25);
			this.TotalFreeUsersLabel.TabIndex = 3;
			this.TotalFreeUsersLabel.Text = "Active Trainers";
			// 
			// guna2ShadowPanel2
			// 
			this.guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
			this.guna2ShadowPanel2.Controls.Add(this.TotalNumberOfInactiveTrainers);
			this.guna2ShadowPanel2.Controls.Add(this.TotalActiveUsersLabel);
			this.guna2ShadowPanel2.FillColor = System.Drawing.Color.Gray;
			this.guna2ShadowPanel2.Location = new System.Drawing.Point(1404, 11);
			this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
			this.guna2ShadowPanel2.ShadowColor = System.Drawing.Color.WhiteSmoke;
			this.guna2ShadowPanel2.ShadowDepth = 180;
			this.guna2ShadowPanel2.Size = new System.Drawing.Size(190, 101);
			this.guna2ShadowPanel2.TabIndex = 36;
			// 
			// TotalNumberOfInactiveTrainers
			// 
			this.TotalNumberOfInactiveTrainers.AutoSize = true;
			this.TotalNumberOfInactiveTrainers.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TotalNumberOfInactiveTrainers.Location = new System.Drawing.Point(41, 40);
			this.TotalNumberOfInactiveTrainers.Name = "TotalNumberOfInactiveTrainers";
			this.TotalNumberOfInactiveTrainers.Size = new System.Drawing.Size(133, 38);
			this.TotalNumberOfInactiveTrainers.TabIndex = 2;
			this.TotalNumberOfInactiveTrainers.Text = "Number";
			// 
			// TotalActiveUsersLabel
			// 
			this.TotalActiveUsersLabel.AutoSize = true;
			this.TotalActiveUsersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TotalActiveUsersLabel.Location = new System.Drawing.Point(18, 9);
			this.TotalActiveUsersLabel.Name = "TotalActiveUsersLabel";
			this.TotalActiveUsersLabel.Size = new System.Drawing.Size(156, 25);
			this.TotalActiveUsersLabel.TabIndex = 3;
			this.TotalActiveUsersLabel.Text = "Inactive Trainers";
			// 
			// TodaysMemberCheckInPanel
			// 
			this.TodaysMemberCheckInPanel.BackColor = System.Drawing.Color.Transparent;
			this.TodaysMemberCheckInPanel.Controls.Add(this.NumberOfTotalTrainerLabel);
			this.TodaysMemberCheckInPanel.Controls.Add(this.TotalMembersLabel);
			this.TodaysMemberCheckInPanel.FillColor = System.Drawing.Color.Gray;
			this.TodaysMemberCheckInPanel.Location = new System.Drawing.Point(31, 11);
			this.TodaysMemberCheckInPanel.Name = "TodaysMemberCheckInPanel";
			this.TodaysMemberCheckInPanel.ShadowColor = System.Drawing.Color.WhiteSmoke;
			this.TodaysMemberCheckInPanel.ShadowDepth = 180;
			this.TodaysMemberCheckInPanel.Size = new System.Drawing.Size(190, 101);
			this.TodaysMemberCheckInPanel.TabIndex = 35;
			// 
			// NumberOfTotalTrainerLabel
			// 
			this.NumberOfTotalTrainerLabel.AutoSize = true;
			this.NumberOfTotalTrainerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NumberOfTotalTrainerLabel.Location = new System.Drawing.Point(27, 40);
			this.NumberOfTotalTrainerLabel.Name = "NumberOfTotalTrainerLabel";
			this.NumberOfTotalTrainerLabel.Size = new System.Drawing.Size(133, 38);
			this.NumberOfTotalTrainerLabel.TabIndex = 2;
			this.NumberOfTotalTrainerLabel.Text = "Number";
			// 
			// TotalMembersLabel
			// 
			this.TotalMembersLabel.AutoSize = true;
			this.TotalMembersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TotalMembersLabel.Location = new System.Drawing.Point(14, 9);
			this.TotalMembersLabel.Name = "TotalMembersLabel";
			this.TotalMembersLabel.Size = new System.Drawing.Size(133, 25);
			this.TotalMembersLabel.TabIndex = 1;
			this.TotalMembersLabel.Text = "Total Trainers";
			// 
			// guna2GroupBox2
			// 
			this.guna2GroupBox2.Controls.Add(this.TrainerReportDataGridView);
			this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.Gray;
			this.guna2GroupBox2.FillColor = System.Drawing.Color.Silver;
			this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
			this.guna2GroupBox2.Location = new System.Drawing.Point(153, 191);
			this.guna2GroupBox2.Name = "guna2GroupBox2";
			this.guna2GroupBox2.Size = new System.Drawing.Size(1632, 486);
			this.guna2GroupBox2.TabIndex = 46;
			this.guna2GroupBox2.Text = "Trainer Report";
			this.guna2GroupBox2.Click += new System.EventHandler(this.guna2GroupBox2_Click);
			// 
			// TrainerReportDataGridView
			// 
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			this.TrainerReportDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
			this.TrainerReportDataGridView.AutoGenerateColumns = false;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(121)))), ((int)(((byte)(130)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(121)))), ((int)(((byte)(130)))));
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.TrainerReportDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.TrainerReportDataGridView.ColumnHeadersHeight = 50;
			this.TrainerReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.TrainerReportDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffIDDataGridViewTextBoxColumn,
            this.staffRoleDataGridViewTextBoxColumn,
            this.staffFNameDataGridViewTextBoxColumn,
            this.staffLNameDataGridViewTextBoxColumn,
            this.staffTelephoneDataGridViewTextBoxColumn,
            this.staffPhoneNumberDataGridViewTextBoxColumn,
            this.staffEmailDataGridViewTextBoxColumn,
            this.staffDOBDataGridViewTextBoxColumn,
            this.staffGenderDataGridViewTextBoxColumn,
            this.staffStatusDataGridViewTextBoxColumn});
			this.TrainerReportDataGridView.DataSource = this.staffBindingSource1;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.TrainerReportDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
			this.TrainerReportDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.TrainerReportDataGridView.Location = new System.Drawing.Point(18, 54);
			this.TrainerReportDataGridView.Name = "TrainerReportDataGridView";
			this.TrainerReportDataGridView.RowHeadersVisible = false;
			this.TrainerReportDataGridView.RowHeadersWidth = 51;
			this.TrainerReportDataGridView.RowTemplate.Height = 24;
			this.TrainerReportDataGridView.Size = new System.Drawing.Size(1576, 412);
			this.TrainerReportDataGridView.TabIndex = 0;
			this.TrainerReportDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.TrainerReportDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.TrainerReportDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.TrainerReportDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.TrainerReportDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.TrainerReportDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.TrainerReportDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.TrainerReportDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.TrainerReportDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.TrainerReportDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TrainerReportDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.TrainerReportDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.TrainerReportDataGridView.ThemeStyle.HeaderStyle.Height = 50;
			this.TrainerReportDataGridView.ThemeStyle.ReadOnly = false;
			this.TrainerReportDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.TrainerReportDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.TrainerReportDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TrainerReportDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
			this.TrainerReportDataGridView.ThemeStyle.RowsStyle.Height = 24;
			this.TrainerReportDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.TrainerReportDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// guna2GroupBox1
			// 
			this.guna2GroupBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.guna2GroupBox1.Controls.Add(this.TrainerReportTypeComboBox);
			this.guna2GroupBox1.Controls.Add(this.TrainerReportStatusComboBox);
			this.guna2GroupBox1.Controls.Add(this.pictureBox2);
			this.guna2GroupBox1.Controls.Add(this.label2);
			this.guna2GroupBox1.Controls.Add(this.label3);
			this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Gray;
			this.guna2GroupBox1.FillColor = System.Drawing.Color.Silver;
			this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
			this.guna2GroupBox1.Location = new System.Drawing.Point(153, 12);
			this.guna2GroupBox1.Name = "guna2GroupBox1";
			this.guna2GroupBox1.Size = new System.Drawing.Size(1632, 173);
			this.guna2GroupBox1.TabIndex = 45;
			this.guna2GroupBox1.Text = "Trainer Report - filter";
			// 
			// TrainerReportTypeComboBox
			// 
			this.TrainerReportTypeComboBox.AutoRoundedCorners = true;
			this.TrainerReportTypeComboBox.BackColor = System.Drawing.Color.Transparent;
			this.TrainerReportTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.TrainerReportTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.TrainerReportTypeComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.TrainerReportTypeComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.TrainerReportTypeComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.TrainerReportTypeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.TrainerReportTypeComboBox.ItemHeight = 30;
			this.TrainerReportTypeComboBox.Items.AddRange(new object[] {
            "All",
            "Male",
            "Female",
            "Other"});
			this.TrainerReportTypeComboBox.Location = new System.Drawing.Point(755, 91);
			this.TrainerReportTypeComboBox.Name = "TrainerReportTypeComboBox";
			this.TrainerReportTypeComboBox.Size = new System.Drawing.Size(214, 36);
			this.TrainerReportTypeComboBox.TabIndex = 33;
			this.TrainerReportTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.TrainerReportTypeComboBox_SelectedIndexChanged_1);
			// 
			// TrainerReportStatusComboBox
			// 
			this.TrainerReportStatusComboBox.AutoRoundedCorners = true;
			this.TrainerReportStatusComboBox.BackColor = System.Drawing.Color.Transparent;
			this.TrainerReportStatusComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.TrainerReportStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.TrainerReportStatusComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.TrainerReportStatusComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.TrainerReportStatusComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.TrainerReportStatusComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.TrainerReportStatusComboBox.ItemHeight = 30;
			this.TrainerReportStatusComboBox.Items.AddRange(new object[] {
            "All",
            "Active",
            "Inactive"});
			this.TrainerReportStatusComboBox.Location = new System.Drawing.Point(95, 92);
			this.TrainerReportStatusComboBox.Name = "TrainerReportStatusComboBox";
			this.TrainerReportStatusComboBox.Size = new System.Drawing.Size(203, 36);
			this.TrainerReportStatusComboBox.TabIndex = 32;
			this.TrainerReportStatusComboBox.SelectedIndexChanged += new System.EventHandler(this.TrainerReportStatusComboBox_SelectedIndexChanged_1);
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(1371, 51);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(181, 106);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 17;
			this.pictureBox2.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(751, 65);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(144, 24);
			this.label2.TabIndex = 24;
			this.label2.Text = "Trainer Gender:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(91, 65);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(130, 24);
			this.label3.TabIndex = 22;
			this.label3.Text = "Trainer Status:";
			// 
			// staffIDDataGridViewTextBoxColumn
			// 
			this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "Staff_ID";
			this.staffIDDataGridViewTextBoxColumn.HeaderText = "Staff_ID";
			this.staffIDDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
			// 
			// staffRoleDataGridViewTextBoxColumn
			// 
			this.staffRoleDataGridViewTextBoxColumn.DataPropertyName = "Staff_Role";
			this.staffRoleDataGridViewTextBoxColumn.HeaderText = "Staff_Role";
			this.staffRoleDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.staffRoleDataGridViewTextBoxColumn.Name = "staffRoleDataGridViewTextBoxColumn";
			// 
			// staffFNameDataGridViewTextBoxColumn
			// 
			this.staffFNameDataGridViewTextBoxColumn.DataPropertyName = "Staff_FName";
			this.staffFNameDataGridViewTextBoxColumn.HeaderText = "Staff_FName";
			this.staffFNameDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.staffFNameDataGridViewTextBoxColumn.Name = "staffFNameDataGridViewTextBoxColumn";
			// 
			// staffLNameDataGridViewTextBoxColumn
			// 
			this.staffLNameDataGridViewTextBoxColumn.DataPropertyName = "Staff_LName";
			this.staffLNameDataGridViewTextBoxColumn.HeaderText = "Staff_LName";
			this.staffLNameDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.staffLNameDataGridViewTextBoxColumn.Name = "staffLNameDataGridViewTextBoxColumn";
			// 
			// staffTelephoneDataGridViewTextBoxColumn
			// 
			this.staffTelephoneDataGridViewTextBoxColumn.DataPropertyName = "Staff_Telephone";
			this.staffTelephoneDataGridViewTextBoxColumn.HeaderText = "Staff_Telephone";
			this.staffTelephoneDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.staffTelephoneDataGridViewTextBoxColumn.Name = "staffTelephoneDataGridViewTextBoxColumn";
			// 
			// staffPhoneNumberDataGridViewTextBoxColumn
			// 
			this.staffPhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Staff_Phone_Number";
			this.staffPhoneNumberDataGridViewTextBoxColumn.HeaderText = "Staff_Phone_Number";
			this.staffPhoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.staffPhoneNumberDataGridViewTextBoxColumn.Name = "staffPhoneNumberDataGridViewTextBoxColumn";
			// 
			// staffEmailDataGridViewTextBoxColumn
			// 
			this.staffEmailDataGridViewTextBoxColumn.DataPropertyName = "Staff_Email";
			this.staffEmailDataGridViewTextBoxColumn.HeaderText = "Staff_Email";
			this.staffEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.staffEmailDataGridViewTextBoxColumn.Name = "staffEmailDataGridViewTextBoxColumn";
			// 
			// staffDOBDataGridViewTextBoxColumn
			// 
			this.staffDOBDataGridViewTextBoxColumn.DataPropertyName = "Staff_DOB";
			this.staffDOBDataGridViewTextBoxColumn.HeaderText = "Staff_DOB";
			this.staffDOBDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.staffDOBDataGridViewTextBoxColumn.Name = "staffDOBDataGridViewTextBoxColumn";
			// 
			// staffGenderDataGridViewTextBoxColumn
			// 
			this.staffGenderDataGridViewTextBoxColumn.DataPropertyName = "Staff_Gender";
			this.staffGenderDataGridViewTextBoxColumn.HeaderText = "Staff_Gender";
			this.staffGenderDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.staffGenderDataGridViewTextBoxColumn.Name = "staffGenderDataGridViewTextBoxColumn";
			// 
			// staffStatusDataGridViewTextBoxColumn
			// 
			this.staffStatusDataGridViewTextBoxColumn.DataPropertyName = "Staff_Status";
			this.staffStatusDataGridViewTextBoxColumn.HeaderText = "Staff_Status";
			this.staffStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.staffStatusDataGridViewTextBoxColumn.Name = "staffStatusDataGridViewTextBoxColumn";
			// 
			// staffBindingSource1
			// 
			this.staffBindingSource1.DataMember = "Staff";
			this.staffBindingSource1.DataSource = this.groupWst23DataSet1;
			// 
			// groupWst23DataSet1
			// 
			this.groupWst23DataSet1.DataSetName = "GroupWst23DataSet";
			this.groupWst23DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// staffBindingSource
			// 
			this.staffBindingSource.DataMember = "Staff";
			this.staffBindingSource.DataSource = this.groupWst23DataSet;
			// 
			// groupWst23DataSet
			// 
			this.groupWst23DataSet.DataSetName = "GroupWst23DataSet";
			this.groupWst23DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// staffTableAdapter
			// 
			this.staffTableAdapter.ClearBeforeFill = true;
			// 
			// TrainerReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(1924, 998);
			this.Controls.Add(this.PrintReportButton);
			this.Controls.Add(this.SaveReportButton1);
			this.Controls.Add(this.guna2Panel2);
			this.Controls.Add(this.guna2GroupBox2);
			this.Controls.Add(this.guna2GroupBox1);
			this.Name = "TrainerReport";
			this.Text = "TrainerReport";
			this.Load += new System.EventHandler(this.TrainerReport_Load);
			this.guna2Panel2.ResumeLayout(false);
			this.guna2ShadowPanel1.ResumeLayout(false);
			this.guna2ShadowPanel1.PerformLayout();
			this.guna2ShadowPanel2.ResumeLayout(false);
			this.guna2ShadowPanel2.PerformLayout();
			this.TodaysMemberCheckInPanel.ResumeLayout(false);
			this.TodaysMemberCheckInPanel.PerformLayout();
			this.guna2GroupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.TrainerReportDataGridView)).EndInit();
			this.guna2GroupBox1.ResumeLayout(false);
			this.guna2GroupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.staffBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupWst23DataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupWst23DataSet)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private Guna.UI2.WinForms.Guna2Button SaveReportButton1;
		private Guna.UI2.WinForms.Guna2Button PrintReportButton;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
		private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
		private System.Windows.Forms.Label TotalNumberOfActiveTrainerLabel;
		private System.Windows.Forms.Label TotalFreeUsersLabel;
		private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
		private System.Windows.Forms.Label TotalNumberOfInactiveTrainers;
		private System.Windows.Forms.Label TotalActiveUsersLabel;
		private Guna.UI2.WinForms.Guna2ShadowPanel TodaysMemberCheckInPanel;
		private System.Windows.Forms.Label NumberOfTotalTrainerLabel;
		private System.Windows.Forms.Label TotalMembersLabel;
		private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
		private Guna.UI2.WinForms.Guna2DataGridView TrainerReportDataGridView;
		private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private GroupWst23DataSet groupWst23DataSet;
		private System.Windows.Forms.BindingSource staffBindingSource;
		private GroupWst23DataSetTableAdapters.StaffTableAdapter staffTableAdapter;
		private Guna.UI2.WinForms.Guna2ComboBox TrainerReportTypeComboBox;
		private Guna.UI2.WinForms.Guna2ComboBox TrainerReportStatusComboBox;
		private GroupWst23DataSet groupWst23DataSet1;
		private System.Windows.Forms.BindingSource staffBindingSource1;
		private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn staffRoleDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn staffFNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn staffLNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn staffTelephoneDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn staffPhoneNumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn staffEmailDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn staffDOBDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn staffGenderDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn staffStatusDataGridViewTextBoxColumn;
	}
}