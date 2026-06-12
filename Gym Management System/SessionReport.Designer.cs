namespace Gym_Management_System
{
    partial class SessionReport
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			this.trainingSessionBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.groupWst23DataSet = new Gym_Management_System.GroupWst23DataSet();
			this.training_SessionTableAdapter = new Gym_Management_System.GroupWst23DataSetTableAdapters.Training_SessionTableAdapter();
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.SessionPrintReportButton = new Guna.UI2.WinForms.Guna2Button();
			this.TrainerSaveReportButton = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
			this.guna2ShadowPanel9 = new Guna.UI2.WinForms.Guna2ShadowPanel();
			this.NumberOfCancelledTrainingSessionsLabel = new System.Windows.Forms.Label();
			this.CancelledTrainingSessionLabel = new System.Windows.Forms.Label();
			this.guna2ShadowPanel8 = new Guna.UI2.WinForms.Guna2ShadowPanel();
			this.NumberOfIncompleteTrainingSessionsLabel = new System.Windows.Forms.Label();
			this.IncompleteTrainingSessionLabel = new System.Windows.Forms.Label();
			this.guna2ShadowPanel7 = new Guna.UI2.WinForms.Guna2ShadowPanel();
			this.NumberOfTotalTrainingSessionsLabel = new System.Windows.Forms.Label();
			this.TotalTrainingSessionLabel = new System.Windows.Forms.Label();
			this.guna2GroupBox4 = new Guna.UI2.WinForms.Guna2GroupBox();
			this.TrainingSessionDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
			this.memberIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.timeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sessionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.staffAttendanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.memberAttendanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sessionDurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sessionStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.trainingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sessionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sessionTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sessionCapacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.trainingSessionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.ReportSessionFilterGroupBox = new Guna.UI2.WinForms.Guna2GroupBox();
			this.SessionStatusComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
			this.SessionToDateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.SessionFromDateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.ReportDateFromLabel = new System.Windows.Forms.Label();
			this.ReportDateToLabel = new System.Windows.Forms.Label();
			this.ReportSessionStatusLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.trainingSessionBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupWst23DataSet)).BeginInit();
			this.guna2Panel1.SuspendLayout();
			this.guna2Panel2.SuspendLayout();
			this.guna2ShadowPanel9.SuspendLayout();
			this.guna2ShadowPanel8.SuspendLayout();
			this.guna2ShadowPanel7.SuspendLayout();
			this.guna2GroupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.TrainingSessionDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trainingSessionBindingSource1)).BeginInit();
			this.ReportSessionFilterGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// trainingSessionBindingSource
			// 
			this.trainingSessionBindingSource.DataMember = "Training_Session";
			this.trainingSessionBindingSource.DataSource = this.groupWst23DataSet;
			// 
			// groupWst23DataSet
			// 
			this.groupWst23DataSet.DataSetName = "GroupWst23DataSet";
			this.groupWst23DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// training_SessionTableAdapter
			// 
			this.training_SessionTableAdapter.ClearBeforeFill = true;
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.guna2Panel1.Controls.Add(this.SessionPrintReportButton);
			this.guna2Panel1.Controls.Add(this.TrainerSaveReportButton);
			this.guna2Panel1.Controls.Add(this.guna2Panel2);
			this.guna2Panel1.Controls.Add(this.guna2GroupBox4);
			this.guna2Panel1.Controls.Add(this.ReportSessionFilterGroupBox);
			this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new System.Drawing.Size(1924, 1055);
			this.guna2Panel1.TabIndex = 0;
			// 
			// SessionPrintReportButton
			// 
			this.SessionPrintReportButton.AutoRoundedCorners = true;
			this.SessionPrintReportButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.SessionPrintReportButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.SessionPrintReportButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.SessionPrintReportButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.SessionPrintReportButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.SessionPrintReportButton.FillColor = System.Drawing.Color.Gray;
			this.SessionPrintReportButton.Font = new System.Drawing.Font("Segoe UI", 10.8F);
			this.SessionPrintReportButton.ForeColor = System.Drawing.Color.White;
			this.SessionPrintReportButton.Location = new System.Drawing.Point(550, 859);
			this.SessionPrintReportButton.Name = "SessionPrintReportButton";
			this.SessionPrintReportButton.Size = new System.Drawing.Size(259, 64);
			this.SessionPrintReportButton.TabIndex = 42;
			this.SessionPrintReportButton.Text = "Print Report";
			this.SessionPrintReportButton.Click += new System.EventHandler(this.SessionPrintReportButton_Click);
			// 
			// TrainerSaveReportButton
			// 
			this.TrainerSaveReportButton.AutoRoundedCorners = true;
			this.TrainerSaveReportButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.TrainerSaveReportButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.TrainerSaveReportButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.TrainerSaveReportButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.TrainerSaveReportButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.TrainerSaveReportButton.FillColor = System.Drawing.Color.Gray;
			this.TrainerSaveReportButton.Font = new System.Drawing.Font("Segoe UI", 10.8F);
			this.TrainerSaveReportButton.ForeColor = System.Drawing.Color.White;
			this.TrainerSaveReportButton.Location = new System.Drawing.Point(1209, 859);
			this.TrainerSaveReportButton.Name = "TrainerSaveReportButton";
			this.TrainerSaveReportButton.Size = new System.Drawing.Size(231, 64);
			this.TrainerSaveReportButton.TabIndex = 46;
			this.TrainerSaveReportButton.Text = "Export as PDF";
			this.TrainerSaveReportButton.Click += new System.EventHandler(this.TrainerSaveReportButton_Click);
			// 
			// guna2Panel2
			// 
			this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
			this.guna2Panel2.Controls.Add(this.guna2ShadowPanel9);
			this.guna2Panel2.Controls.Add(this.guna2ShadowPanel8);
			this.guna2Panel2.Controls.Add(this.guna2ShadowPanel7);
			this.guna2Panel2.CustomBorderColor = System.Drawing.Color.Gray;
			this.guna2Panel2.FillColor = System.Drawing.Color.Silver;
			this.guna2Panel2.Location = new System.Drawing.Point(210, 711);
			this.guna2Panel2.Name = "guna2Panel2";
			this.guna2Panel2.Size = new System.Drawing.Size(1572, 131);
			this.guna2Panel2.TabIndex = 49;
			// 
			// guna2ShadowPanel9
			// 
			this.guna2ShadowPanel9.BackColor = System.Drawing.Color.Transparent;
			this.guna2ShadowPanel9.Controls.Add(this.NumberOfCancelledTrainingSessionsLabel);
			this.guna2ShadowPanel9.Controls.Add(this.CancelledTrainingSessionLabel);
			this.guna2ShadowPanel9.FillColor = System.Drawing.Color.Gray;
			this.guna2ShadowPanel9.Location = new System.Drawing.Point(1296, 20);
			this.guna2ShadowPanel9.Name = "guna2ShadowPanel9";
			this.guna2ShadowPanel9.ShadowColor = System.Drawing.Color.WhiteSmoke;
			this.guna2ShadowPanel9.ShadowDepth = 180;
			this.guna2ShadowPanel9.Size = new System.Drawing.Size(203, 101);
			this.guna2ShadowPanel9.TabIndex = 39;
			// 
			// NumberOfCancelledTrainingSessionsLabel
			// 
			this.NumberOfCancelledTrainingSessionsLabel.AutoSize = true;
			this.NumberOfCancelledTrainingSessionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NumberOfCancelledTrainingSessionsLabel.Location = new System.Drawing.Point(45, 46);
			this.NumberOfCancelledTrainingSessionsLabel.Name = "NumberOfCancelledTrainingSessionsLabel";
			this.NumberOfCancelledTrainingSessionsLabel.Size = new System.Drawing.Size(133, 38);
			this.NumberOfCancelledTrainingSessionsLabel.TabIndex = 2;
			this.NumberOfCancelledTrainingSessionsLabel.Text = "Number";
			// 
			// CancelledTrainingSessionLabel
			// 
			this.CancelledTrainingSessionLabel.AutoSize = true;
			this.CancelledTrainingSessionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CancelledTrainingSessionLabel.Location = new System.Drawing.Point(3, 6);
			this.CancelledTrainingSessionLabel.Name = "CancelledTrainingSessionLabel";
			this.CancelledTrainingSessionLabel.Size = new System.Drawing.Size(186, 25);
			this.CancelledTrainingSessionLabel.TabIndex = 3;
			this.CancelledTrainingSessionLabel.Text = "Cancelled Sessions";
			// 
			// guna2ShadowPanel8
			// 
			this.guna2ShadowPanel8.BackColor = System.Drawing.Color.Transparent;
			this.guna2ShadowPanel8.Controls.Add(this.NumberOfIncompleteTrainingSessionsLabel);
			this.guna2ShadowPanel8.Controls.Add(this.IncompleteTrainingSessionLabel);
			this.guna2ShadowPanel8.FillColor = System.Drawing.Color.Gray;
			this.guna2ShadowPanel8.Location = new System.Drawing.Point(682, 20);
			this.guna2ShadowPanel8.Name = "guna2ShadowPanel8";
			this.guna2ShadowPanel8.ShadowColor = System.Drawing.Color.WhiteSmoke;
			this.guna2ShadowPanel8.ShadowDepth = 180;
			this.guna2ShadowPanel8.Size = new System.Drawing.Size(234, 101);
			this.guna2ShadowPanel8.TabIndex = 38;
			// 
			// NumberOfIncompleteTrainingSessionsLabel
			// 
			this.NumberOfIncompleteTrainingSessionsLabel.AutoSize = true;
			this.NumberOfIncompleteTrainingSessionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NumberOfIncompleteTrainingSessionsLabel.Location = new System.Drawing.Point(43, 46);
			this.NumberOfIncompleteTrainingSessionsLabel.Name = "NumberOfIncompleteTrainingSessionsLabel";
			this.NumberOfIncompleteTrainingSessionsLabel.Size = new System.Drawing.Size(133, 38);
			this.NumberOfIncompleteTrainingSessionsLabel.TabIndex = 2;
			this.NumberOfIncompleteTrainingSessionsLabel.Text = "Number";
			// 
			// IncompleteTrainingSessionLabel
			// 
			this.IncompleteTrainingSessionLabel.AutoSize = true;
			this.IncompleteTrainingSessionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.IncompleteTrainingSessionLabel.Location = new System.Drawing.Point(16, 6);
			this.IncompleteTrainingSessionLabel.Name = "IncompleteTrainingSessionLabel";
			this.IncompleteTrainingSessionLabel.Size = new System.Drawing.Size(170, 25);
			this.IncompleteTrainingSessionLabel.TabIndex = 3;
			this.IncompleteTrainingSessionLabel.Text = "Pending Sessions";
			// 
			// guna2ShadowPanel7
			// 
			this.guna2ShadowPanel7.BackColor = System.Drawing.Color.Transparent;
			this.guna2ShadowPanel7.Controls.Add(this.NumberOfTotalTrainingSessionsLabel);
			this.guna2ShadowPanel7.Controls.Add(this.TotalTrainingSessionLabel);
			this.guna2ShadowPanel7.FillColor = System.Drawing.Color.Gray;
			this.guna2ShadowPanel7.Location = new System.Drawing.Point(66, 20);
			this.guna2ShadowPanel7.Name = "guna2ShadowPanel7";
			this.guna2ShadowPanel7.ShadowColor = System.Drawing.Color.WhiteSmoke;
			this.guna2ShadowPanel7.ShadowDepth = 180;
			this.guna2ShadowPanel7.Size = new System.Drawing.Size(190, 101);
			this.guna2ShadowPanel7.TabIndex = 37;
			// 
			// NumberOfTotalTrainingSessionsLabel
			// 
			this.NumberOfTotalTrainingSessionsLabel.AutoSize = true;
			this.NumberOfTotalTrainingSessionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NumberOfTotalTrainingSessionsLabel.Location = new System.Drawing.Point(21, 46);
			this.NumberOfTotalTrainingSessionsLabel.Name = "NumberOfTotalTrainingSessionsLabel";
			this.NumberOfTotalTrainingSessionsLabel.Size = new System.Drawing.Size(133, 38);
			this.NumberOfTotalTrainingSessionsLabel.TabIndex = 2;
			this.NumberOfTotalTrainingSessionsLabel.Text = "Number";
			// 
			// TotalTrainingSessionLabel
			// 
			this.TotalTrainingSessionLabel.AutoSize = true;
			this.TotalTrainingSessionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TotalTrainingSessionLabel.Location = new System.Drawing.Point(12, 6);
			this.TotalTrainingSessionLabel.Name = "TotalTrainingSessionLabel";
			this.TotalTrainingSessionLabel.Size = new System.Drawing.Size(142, 25);
			this.TotalTrainingSessionLabel.TabIndex = 1;
			this.TotalTrainingSessionLabel.Text = "Total Sessions";
			// 
			// guna2GroupBox4
			// 
			this.guna2GroupBox4.BackColor = System.Drawing.Color.Transparent;
			this.guna2GroupBox4.Controls.Add(this.TrainingSessionDataGridView);
			this.guna2GroupBox4.CustomBorderColor = System.Drawing.Color.Gray;
			this.guna2GroupBox4.FillColor = System.Drawing.Color.Transparent;
			this.guna2GroupBox4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2GroupBox4.ForeColor = System.Drawing.Color.Black;
			this.guna2GroupBox4.Location = new System.Drawing.Point(210, 152);
			this.guna2GroupBox4.Name = "guna2GroupBox4";
			this.guna2GroupBox4.Size = new System.Drawing.Size(1572, 544);
			this.guna2GroupBox4.TabIndex = 47;
			this.guna2GroupBox4.Text = "Session Report";
			// 
			// TrainingSessionDataGridView
			// 
			dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
			this.TrainingSessionDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
			this.TrainingSessionDataGridView.AutoGenerateColumns = false;
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(121)))), ((int)(((byte)(130)))));
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(121)))), ((int)(((byte)(130)))));
			dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.TrainingSessionDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
			this.TrainingSessionDataGridView.ColumnHeadersHeight = 50;
			this.TrainingSessionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.TrainingSessionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.memberIDDataGridViewTextBoxColumn,
            this.staffIDDataGridViewTextBoxColumn,
            this.timeIDDataGridViewTextBoxColumn,
            this.sessionDateDataGridViewTextBoxColumn,
            this.staffAttendanceDataGridViewTextBoxColumn,
            this.memberAttendanceDataGridViewTextBoxColumn,
            this.sessionDurationDataGridViewTextBoxColumn,
            this.sessionStatusDataGridViewTextBoxColumn,
            this.trainingIDDataGridViewTextBoxColumn,
            this.sessionIDDataGridViewTextBoxColumn,
            this.sessionTypeDataGridViewTextBoxColumn,
            this.sessionCapacityDataGridViewTextBoxColumn});
			this.TrainingSessionDataGridView.DataSource = this.trainingSessionBindingSource1;
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.TrainingSessionDataGridView.DefaultCellStyle = dataGridViewCellStyle12;
			this.TrainingSessionDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.TrainingSessionDataGridView.Location = new System.Drawing.Point(15, 53);
			this.TrainingSessionDataGridView.Name = "TrainingSessionDataGridView";
			this.TrainingSessionDataGridView.ReadOnly = true;
			this.TrainingSessionDataGridView.RowHeadersVisible = false;
			this.TrainingSessionDataGridView.RowHeadersWidth = 51;
			this.TrainingSessionDataGridView.RowTemplate.Height = 24;
			this.TrainingSessionDataGridView.Size = new System.Drawing.Size(1537, 473);
			this.TrainingSessionDataGridView.TabIndex = 0;
			this.TrainingSessionDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.TrainingSessionDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.TrainingSessionDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.TrainingSessionDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.TrainingSessionDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.TrainingSessionDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.TrainingSessionDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.TrainingSessionDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.TrainingSessionDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.TrainingSessionDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TrainingSessionDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.TrainingSessionDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.TrainingSessionDataGridView.ThemeStyle.HeaderStyle.Height = 50;
			this.TrainingSessionDataGridView.ThemeStyle.ReadOnly = true;
			this.TrainingSessionDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.TrainingSessionDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.TrainingSessionDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TrainingSessionDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
			this.TrainingSessionDataGridView.ThemeStyle.RowsStyle.Height = 24;
			this.TrainingSessionDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.TrainingSessionDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// memberIDDataGridViewTextBoxColumn
			// 
			this.memberIDDataGridViewTextBoxColumn.DataPropertyName = "Member_ID";
			this.memberIDDataGridViewTextBoxColumn.HeaderText = "Member_ID";
			this.memberIDDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.memberIDDataGridViewTextBoxColumn.Name = "memberIDDataGridViewTextBoxColumn";
			this.memberIDDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// staffIDDataGridViewTextBoxColumn
			// 
			this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "Staff_ID";
			this.staffIDDataGridViewTextBoxColumn.HeaderText = "Staff_ID";
			this.staffIDDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
			this.staffIDDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// timeIDDataGridViewTextBoxColumn
			// 
			this.timeIDDataGridViewTextBoxColumn.DataPropertyName = "Time_ID";
			this.timeIDDataGridViewTextBoxColumn.HeaderText = "Time_ID";
			this.timeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.timeIDDataGridViewTextBoxColumn.Name = "timeIDDataGridViewTextBoxColumn";
			this.timeIDDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// sessionDateDataGridViewTextBoxColumn
			// 
			this.sessionDateDataGridViewTextBoxColumn.DataPropertyName = "Session_Date";
			this.sessionDateDataGridViewTextBoxColumn.HeaderText = "Session_Date";
			this.sessionDateDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.sessionDateDataGridViewTextBoxColumn.Name = "sessionDateDataGridViewTextBoxColumn";
			this.sessionDateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// staffAttendanceDataGridViewTextBoxColumn
			// 
			this.staffAttendanceDataGridViewTextBoxColumn.DataPropertyName = "Staff_Attendance";
			this.staffAttendanceDataGridViewTextBoxColumn.HeaderText = "Staff_Attendance";
			this.staffAttendanceDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.staffAttendanceDataGridViewTextBoxColumn.Name = "staffAttendanceDataGridViewTextBoxColumn";
			this.staffAttendanceDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// memberAttendanceDataGridViewTextBoxColumn
			// 
			this.memberAttendanceDataGridViewTextBoxColumn.DataPropertyName = "Member_Attendance";
			this.memberAttendanceDataGridViewTextBoxColumn.HeaderText = "Member_Attendance";
			this.memberAttendanceDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.memberAttendanceDataGridViewTextBoxColumn.Name = "memberAttendanceDataGridViewTextBoxColumn";
			this.memberAttendanceDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// sessionDurationDataGridViewTextBoxColumn
			// 
			this.sessionDurationDataGridViewTextBoxColumn.DataPropertyName = "Session_Duration";
			this.sessionDurationDataGridViewTextBoxColumn.HeaderText = "Session_Duration";
			this.sessionDurationDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.sessionDurationDataGridViewTextBoxColumn.Name = "sessionDurationDataGridViewTextBoxColumn";
			this.sessionDurationDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// sessionStatusDataGridViewTextBoxColumn
			// 
			this.sessionStatusDataGridViewTextBoxColumn.DataPropertyName = "Session_Status";
			this.sessionStatusDataGridViewTextBoxColumn.HeaderText = "Session_Status";
			this.sessionStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.sessionStatusDataGridViewTextBoxColumn.Name = "sessionStatusDataGridViewTextBoxColumn";
			this.sessionStatusDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// trainingIDDataGridViewTextBoxColumn
			// 
			this.trainingIDDataGridViewTextBoxColumn.DataPropertyName = "Training_ID";
			this.trainingIDDataGridViewTextBoxColumn.HeaderText = "Training_ID";
			this.trainingIDDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.trainingIDDataGridViewTextBoxColumn.Name = "trainingIDDataGridViewTextBoxColumn";
			this.trainingIDDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// sessionIDDataGridViewTextBoxColumn
			// 
			this.sessionIDDataGridViewTextBoxColumn.DataPropertyName = "Session_ID";
			this.sessionIDDataGridViewTextBoxColumn.HeaderText = "Session_ID";
			this.sessionIDDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.sessionIDDataGridViewTextBoxColumn.Name = "sessionIDDataGridViewTextBoxColumn";
			this.sessionIDDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// sessionTypeDataGridViewTextBoxColumn
			// 
			this.sessionTypeDataGridViewTextBoxColumn.DataPropertyName = "Session_Type";
			this.sessionTypeDataGridViewTextBoxColumn.HeaderText = "Session_Type";
			this.sessionTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.sessionTypeDataGridViewTextBoxColumn.Name = "sessionTypeDataGridViewTextBoxColumn";
			this.sessionTypeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// sessionCapacityDataGridViewTextBoxColumn
			// 
			this.sessionCapacityDataGridViewTextBoxColumn.DataPropertyName = "Session_Capacity";
			this.sessionCapacityDataGridViewTextBoxColumn.HeaderText = "Session_Capacity";
			this.sessionCapacityDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.sessionCapacityDataGridViewTextBoxColumn.Name = "sessionCapacityDataGridViewTextBoxColumn";
			this.sessionCapacityDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// trainingSessionBindingSource1
			// 
			this.trainingSessionBindingSource1.DataMember = "Training_Session";
			this.trainingSessionBindingSource1.DataSource = this.groupWst23DataSet;
			// 
			// ReportSessionFilterGroupBox
			// 
			this.ReportSessionFilterGroupBox.Controls.Add(this.SessionStatusComboBox);
			this.ReportSessionFilterGroupBox.Controls.Add(this.SessionToDateTimePicker);
			this.ReportSessionFilterGroupBox.Controls.Add(this.SessionFromDateTimePicker);
			this.ReportSessionFilterGroupBox.Controls.Add(this.ReportDateFromLabel);
			this.ReportSessionFilterGroupBox.Controls.Add(this.ReportDateToLabel);
			this.ReportSessionFilterGroupBox.Controls.Add(this.ReportSessionStatusLabel);
			this.ReportSessionFilterGroupBox.CustomBorderColor = System.Drawing.Color.Gray;
			this.ReportSessionFilterGroupBox.FillColor = System.Drawing.Color.Silver;
			this.ReportSessionFilterGroupBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ReportSessionFilterGroupBox.ForeColor = System.Drawing.Color.Black;
			this.ReportSessionFilterGroupBox.Location = new System.Drawing.Point(210, 3);
			this.ReportSessionFilterGroupBox.Name = "ReportSessionFilterGroupBox";
			this.ReportSessionFilterGroupBox.Size = new System.Drawing.Size(1569, 143);
			this.ReportSessionFilterGroupBox.TabIndex = 48;
			this.ReportSessionFilterGroupBox.Text = "Session - filter";
			// 
			// SessionStatusComboBox
			// 
			this.SessionStatusComboBox.AutoRoundedCorners = true;
			this.SessionStatusComboBox.BackColor = System.Drawing.Color.Transparent;
			this.SessionStatusComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.SessionStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SessionStatusComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.SessionStatusComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.SessionStatusComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.SessionStatusComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.SessionStatusComboBox.ItemHeight = 30;
			this.SessionStatusComboBox.Items.AddRange(new object[] {
            "All",
            "Completed",
            "Pending",
            "Cancelled"});
			this.SessionStatusComboBox.Location = new System.Drawing.Point(1286, 95);
			this.SessionStatusComboBox.Name = "SessionStatusComboBox";
			this.SessionStatusComboBox.Size = new System.Drawing.Size(181, 36);
			this.SessionStatusComboBox.TabIndex = 8;
			this.SessionStatusComboBox.SelectedIndexChanged += new System.EventHandler(this.SessionStatusComboBox_SelectedIndexChanged_1);
			// 
			// SessionToDateTimePicker
			// 
			this.SessionToDateTimePicker.AutoRoundedCorners = true;
			this.SessionToDateTimePicker.BackColor = System.Drawing.Color.Transparent;
			this.SessionToDateTimePicker.Checked = true;
			this.SessionToDateTimePicker.FillColor = System.Drawing.Color.White;
			this.SessionToDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.SessionToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this.SessionToDateTimePicker.Location = new System.Drawing.Point(648, 95);
			this.SessionToDateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.SessionToDateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.SessionToDateTimePicker.Name = "SessionToDateTimePicker";
			this.SessionToDateTimePicker.Size = new System.Drawing.Size(268, 36);
			this.SessionToDateTimePicker.TabIndex = 7;
			this.SessionToDateTimePicker.Value = new System.DateTime(2026, 6, 10, 1, 51, 59, 531);
			this.SessionToDateTimePicker.ValueChanged += new System.EventHandler(this.SessionToDateTimePicker_ValueChanged_1);
			// 
			// SessionFromDateTimePicker
			// 
			this.SessionFromDateTimePicker.AutoRoundedCorners = true;
			this.SessionFromDateTimePicker.BackColor = System.Drawing.Color.Transparent;
			this.SessionFromDateTimePicker.Checked = true;
			this.SessionFromDateTimePicker.FillColor = System.Drawing.Color.White;
			this.SessionFromDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.SessionFromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this.SessionFromDateTimePicker.Location = new System.Drawing.Point(85, 78);
			this.SessionFromDateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.SessionFromDateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.SessionFromDateTimePicker.Name = "SessionFromDateTimePicker";
			this.SessionFromDateTimePicker.Size = new System.Drawing.Size(271, 36);
			this.SessionFromDateTimePicker.TabIndex = 6;
			this.SessionFromDateTimePicker.Value = new System.DateTime(2026, 6, 10, 1, 51, 59, 531);
			this.SessionFromDateTimePicker.ValueChanged += new System.EventHandler(this.SessionFromDateTimePicker_ValueChanged_1);
			// 
			// ReportDateFromLabel
			// 
			this.ReportDateFromLabel.AutoSize = true;
			this.ReportDateFromLabel.BackColor = System.Drawing.Color.Transparent;
			this.ReportDateFromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ReportDateFromLabel.Location = new System.Drawing.Point(81, 51);
			this.ReportDateFromLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.ReportDateFromLabel.Name = "ReportDateFromLabel";
			this.ReportDateFromLabel.Size = new System.Drawing.Size(95, 24);
			this.ReportDateFromLabel.TabIndex = 0;
			this.ReportDateFromLabel.Text = "Date from:";
			// 
			// ReportDateToLabel
			// 
			this.ReportDateToLabel.AutoSize = true;
			this.ReportDateToLabel.BackColor = System.Drawing.Color.Transparent;
			this.ReportDateToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ReportDateToLabel.Location = new System.Drawing.Point(644, 68);
			this.ReportDateToLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.ReportDateToLabel.Name = "ReportDateToLabel";
			this.ReportDateToLabel.Size = new System.Drawing.Size(73, 24);
			this.ReportDateToLabel.TabIndex = 1;
			this.ReportDateToLabel.Text = "Date to:";
			// 
			// ReportSessionStatusLabel
			// 
			this.ReportSessionStatusLabel.AutoSize = true;
			this.ReportSessionStatusLabel.BackColor = System.Drawing.Color.Transparent;
			this.ReportSessionStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ReportSessionStatusLabel.Location = new System.Drawing.Point(1292, 68);
			this.ReportSessionStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.ReportSessionStatusLabel.Name = "ReportSessionStatusLabel";
			this.ReportSessionStatusLabel.Size = new System.Drawing.Size(137, 24);
			this.ReportSessionStatusLabel.TabIndex = 2;
			this.ReportSessionStatusLabel.Text = "Session Status:";
			// 
			// SessionReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1924, 1055);
			this.Controls.Add(this.guna2Panel1);
			this.Name = "SessionReport";
			this.Text = "SessionReport";
			this.Load += new System.EventHandler(this.SessionReport_Load);
			((System.ComponentModel.ISupportInitialize)(this.trainingSessionBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupWst23DataSet)).EndInit();
			this.guna2Panel1.ResumeLayout(false);
			this.guna2Panel2.ResumeLayout(false);
			this.guna2ShadowPanel9.ResumeLayout(false);
			this.guna2ShadowPanel9.PerformLayout();
			this.guna2ShadowPanel8.ResumeLayout(false);
			this.guna2ShadowPanel8.PerformLayout();
			this.guna2ShadowPanel7.ResumeLayout(false);
			this.guna2ShadowPanel7.PerformLayout();
			this.guna2GroupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.TrainingSessionDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trainingSessionBindingSource1)).EndInit();
			this.ReportSessionFilterGroupBox.ResumeLayout(false);
			this.ReportSessionFilterGroupBox.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private GroupWst23DataSet groupWst23DataSet;
        private System.Windows.Forms.BindingSource trainingSessionBindingSource;
        private GroupWst23DataSetTableAdapters.Training_SessionTableAdapter training_SessionTableAdapter;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button SessionPrintReportButton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel9;
        private System.Windows.Forms.Label NumberOfCancelledTrainingSessionsLabel;
        private System.Windows.Forms.Label CancelledTrainingSessionLabel;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel8;
        private System.Windows.Forms.Label NumberOfIncompleteTrainingSessionsLabel;
        private System.Windows.Forms.Label IncompleteTrainingSessionLabel;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel7;
        private System.Windows.Forms.Label NumberOfTotalTrainingSessionsLabel;
        private System.Windows.Forms.Label TotalTrainingSessionLabel;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox4;
        private Guna.UI2.WinForms.Guna2DataGridView TrainingSessionDataGridView;
        private Guna.UI2.WinForms.Guna2GroupBox ReportSessionFilterGroupBox;
        private System.Windows.Forms.Label ReportDateFromLabel;
        private System.Windows.Forms.Label ReportDateToLabel;
        private System.Windows.Forms.Label ReportSessionStatusLabel;
		private Guna.UI2.WinForms.Guna2Button TrainerSaveReportButton;
		private Guna.UI2.WinForms.Guna2DateTimePicker SessionToDateTimePicker;
		private Guna.UI2.WinForms.Guna2DateTimePicker SessionFromDateTimePicker;
		private Guna.UI2.WinForms.Guna2ComboBox SessionStatusComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffAttendanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberAttendanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionDurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionCapacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource trainingSessionBindingSource1;
    }
}