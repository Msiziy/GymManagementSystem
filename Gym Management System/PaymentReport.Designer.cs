namespace Gym_Management_System
{
    partial class PaymentReport
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentReport));
			this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.groupWst23DataSet = new Gym_Management_System.GroupWst23DataSet();
			this.paymentTableAdapter = new Gym_Management_System.GroupWst23DataSetTableAdapters.PaymentTableAdapter();
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.TrainerSaveReportButton = new Guna.UI2.WinForms.Guna2Button();
			this.PaymentPrintReportButton = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
			this.guna2ShadowPanel4 = new Guna.UI2.WinForms.Guna2ShadowPanel();
			this.PaymentNumberOfTotalMembersLabel = new System.Windows.Forms.Label();
			this.PaymentTotalMembersLabel = new System.Windows.Forms.Label();
			this.guna2ShadowPanel5 = new Guna.UI2.WinForms.Guna2ShadowPanel();
			this.NumberOfTotalPaidMembersLabel = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.guna2ShadowPanel6 = new Guna.UI2.WinForms.Guna2ShadowPanel();
			this.NumberOfTotalPaymentsLabel = new System.Windows.Forms.Label();
			this.TotalPaymentLabels = new System.Windows.Forms.Label();
			this.PaymentReportGroupBox = new Guna.UI2.WinForms.Guna2GroupBox();
			this.ReportPaymentDaGridView = new Guna.UI2.WinForms.Guna2DataGridView();
			this.paymentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.membershipIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.memberIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.paymentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.paymentBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.planDurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.paymentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.paymentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
			this.ReportToDateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.ReportFromDateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupWst23DataSet)).BeginInit();
			this.guna2Panel1.SuspendLayout();
			this.guna2Panel2.SuspendLayout();
			this.guna2ShadowPanel4.SuspendLayout();
			this.guna2ShadowPanel5.SuspendLayout();
			this.guna2ShadowPanel6.SuspendLayout();
			this.PaymentReportGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ReportPaymentDaGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource1)).BeginInit();
			this.guna2GroupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			this.SuspendLayout();
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
			// paymentTableAdapter
			// 
			this.paymentTableAdapter.ClearBeforeFill = true;
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.Controls.Add(this.TrainerSaveReportButton);
			this.guna2Panel1.Controls.Add(this.PaymentPrintReportButton);
			this.guna2Panel1.Controls.Add(this.guna2Panel2);
			this.guna2Panel1.Controls.Add(this.PaymentReportGroupBox);
			this.guna2Panel1.Controls.Add(this.guna2GroupBox3);
			this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new System.Drawing.Size(1924, 1055);
			this.guna2Panel1.TabIndex = 0;
			// 
			// TrainerSaveReportButton
			// 
			this.TrainerSaveReportButton.AutoRoundedCorners = true;
			this.TrainerSaveReportButton.BackColor = System.Drawing.Color.Transparent;
			this.TrainerSaveReportButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.TrainerSaveReportButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.TrainerSaveReportButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.TrainerSaveReportButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.TrainerSaveReportButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.TrainerSaveReportButton.FillColor = System.Drawing.Color.Gray;
			this.TrainerSaveReportButton.Font = new System.Drawing.Font("Segoe UI", 10.8F);
			this.TrainerSaveReportButton.ForeColor = System.Drawing.Color.White;
			this.TrainerSaveReportButton.Location = new System.Drawing.Point(1164, 866);
			this.TrainerSaveReportButton.Name = "TrainerSaveReportButton";
			this.TrainerSaveReportButton.Size = new System.Drawing.Size(247, 62);
			this.TrainerSaveReportButton.TabIndex = 45;
			this.TrainerSaveReportButton.Text = "Export as PDF";
			this.TrainerSaveReportButton.Click += new System.EventHandler(this.TrainerSaveReportButton_Click);
			// 
			// PaymentPrintReportButton
			// 
			this.PaymentPrintReportButton.AutoRoundedCorners = true;
			this.PaymentPrintReportButton.BackColor = System.Drawing.Color.Transparent;
			this.PaymentPrintReportButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.PaymentPrintReportButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.PaymentPrintReportButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.PaymentPrintReportButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.PaymentPrintReportButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.PaymentPrintReportButton.FillColor = System.Drawing.Color.Gray;
			this.PaymentPrintReportButton.Font = new System.Drawing.Font("Segoe UI", 10.8F);
			this.PaymentPrintReportButton.ForeColor = System.Drawing.Color.White;
			this.PaymentPrintReportButton.Location = new System.Drawing.Point(476, 861);
			this.PaymentPrintReportButton.Name = "PaymentPrintReportButton";
			this.PaymentPrintReportButton.Size = new System.Drawing.Size(266, 67);
			this.PaymentPrintReportButton.TabIndex = 42;
			this.PaymentPrintReportButton.Text = "Print Report";
			this.PaymentPrintReportButton.Click += new System.EventHandler(this.PaymentPrintReportButton_Click);
			// 
			// guna2Panel2
			// 
			this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
			this.guna2Panel2.Controls.Add(this.guna2ShadowPanel4);
			this.guna2Panel2.Controls.Add(this.guna2ShadowPanel5);
			this.guna2Panel2.Controls.Add(this.guna2ShadowPanel6);
			this.guna2Panel2.CustomBorderColor = System.Drawing.Color.Gray;
			this.guna2Panel2.FillColor = System.Drawing.Color.Silver;
			this.guna2Panel2.Location = new System.Drawing.Point(188, 724);
			this.guna2Panel2.Name = "guna2Panel2";
			this.guna2Panel2.Size = new System.Drawing.Size(1523, 122);
			this.guna2Panel2.TabIndex = 48;
			// 
			// guna2ShadowPanel4
			// 
			this.guna2ShadowPanel4.BackColor = System.Drawing.Color.Transparent;
			this.guna2ShadowPanel4.Controls.Add(this.PaymentNumberOfTotalMembersLabel);
			this.guna2ShadowPanel4.Controls.Add(this.PaymentTotalMembersLabel);
			this.guna2ShadowPanel4.FillColor = System.Drawing.Color.Gray;
			this.guna2ShadowPanel4.Location = new System.Drawing.Point(39, 8);
			this.guna2ShadowPanel4.Name = "guna2ShadowPanel4";
			this.guna2ShadowPanel4.ShadowColor = System.Drawing.Color.WhiteSmoke;
			this.guna2ShadowPanel4.ShadowDepth = 180;
			this.guna2ShadowPanel4.Size = new System.Drawing.Size(170, 101);
			this.guna2ShadowPanel4.TabIndex = 33;
			// 
			// PaymentNumberOfTotalMembersLabel
			// 
			this.PaymentNumberOfTotalMembersLabel.AutoSize = true;
			this.PaymentNumberOfTotalMembersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PaymentNumberOfTotalMembersLabel.Location = new System.Drawing.Point(13, 53);
			this.PaymentNumberOfTotalMembersLabel.Name = "PaymentNumberOfTotalMembersLabel";
			this.PaymentNumberOfTotalMembersLabel.Size = new System.Drawing.Size(133, 38);
			this.PaymentNumberOfTotalMembersLabel.TabIndex = 2;
			this.PaymentNumberOfTotalMembersLabel.Text = "Number";
			// 
			// PaymentTotalMembersLabel
			// 
			this.PaymentTotalMembersLabel.AutoSize = true;
			this.PaymentTotalMembersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PaymentTotalMembersLabel.Location = new System.Drawing.Point(3, 16);
			this.PaymentTotalMembersLabel.Name = "PaymentTotalMembersLabel";
			this.PaymentTotalMembersLabel.Size = new System.Drawing.Size(143, 25);
			this.PaymentTotalMembersLabel.TabIndex = 1;
			this.PaymentTotalMembersLabel.Text = "Total Members";
			// 
			// guna2ShadowPanel5
			// 
			this.guna2ShadowPanel5.BackColor = System.Drawing.Color.Transparent;
			this.guna2ShadowPanel5.Controls.Add(this.NumberOfTotalPaidMembersLabel);
			this.guna2ShadowPanel5.Controls.Add(this.label4);
			this.guna2ShadowPanel5.FillColor = System.Drawing.Color.Gray;
			this.guna2ShadowPanel5.Location = new System.Drawing.Point(674, 8);
			this.guna2ShadowPanel5.Name = "guna2ShadowPanel5";
			this.guna2ShadowPanel5.ShadowColor = System.Drawing.Color.WhiteSmoke;
			this.guna2ShadowPanel5.ShadowDepth = 180;
			this.guna2ShadowPanel5.Size = new System.Drawing.Size(198, 101);
			this.guna2ShadowPanel5.TabIndex = 34;
			// 
			// NumberOfTotalPaidMembersLabel
			// 
			this.NumberOfTotalPaidMembersLabel.AutoSize = true;
			this.NumberOfTotalPaidMembersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NumberOfTotalPaidMembersLabel.Location = new System.Drawing.Point(33, 53);
			this.NumberOfTotalPaidMembersLabel.Name = "NumberOfTotalPaidMembersLabel";
			this.NumberOfTotalPaidMembersLabel.Size = new System.Drawing.Size(133, 38);
			this.NumberOfTotalPaidMembersLabel.TabIndex = 2;
			this.NumberOfTotalPaidMembersLabel.Text = "Number";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(3, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(187, 25);
			this.label4.TabIndex = 3;
			this.label4.Text = "Total Paid Members";
			// 
			// guna2ShadowPanel6
			// 
			this.guna2ShadowPanel6.BackColor = System.Drawing.Color.Transparent;
			this.guna2ShadowPanel6.Controls.Add(this.NumberOfTotalPaymentsLabel);
			this.guna2ShadowPanel6.Controls.Add(this.TotalPaymentLabels);
			this.guna2ShadowPanel6.FillColor = System.Drawing.Color.Gray;
			this.guna2ShadowPanel6.Location = new System.Drawing.Point(1282, 8);
			this.guna2ShadowPanel6.Name = "guna2ShadowPanel6";
			this.guna2ShadowPanel6.ShadowColor = System.Drawing.Color.WhiteSmoke;
			this.guna2ShadowPanel6.ShadowDepth = 180;
			this.guna2ShadowPanel6.Size = new System.Drawing.Size(190, 101);
			this.guna2ShadowPanel6.TabIndex = 35;
			// 
			// NumberOfTotalPaymentsLabel
			// 
			this.NumberOfTotalPaymentsLabel.AutoSize = true;
			this.NumberOfTotalPaymentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NumberOfTotalPaymentsLabel.Location = new System.Drawing.Point(38, 53);
			this.NumberOfTotalPaymentsLabel.Name = "NumberOfTotalPaymentsLabel";
			this.NumberOfTotalPaymentsLabel.Size = new System.Drawing.Size(133, 38);
			this.NumberOfTotalPaymentsLabel.TabIndex = 2;
			this.NumberOfTotalPaymentsLabel.Text = "Number";
			// 
			// TotalPaymentLabels
			// 
			this.TotalPaymentLabels.AutoSize = true;
			this.TotalPaymentLabels.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TotalPaymentLabels.Location = new System.Drawing.Point(23, 19);
			this.TotalPaymentLabels.Name = "TotalPaymentLabels";
			this.TotalPaymentLabels.Size = new System.Drawing.Size(148, 25);
			this.TotalPaymentLabels.TabIndex = 1;
			this.TotalPaymentLabels.Text = "Total Payments";
			// 
			// PaymentReportGroupBox
			// 
			this.PaymentReportGroupBox.BackColor = System.Drawing.Color.Transparent;
			this.PaymentReportGroupBox.Controls.Add(this.ReportPaymentDaGridView);
			this.PaymentReportGroupBox.CustomBorderColor = System.Drawing.Color.Gray;
			this.PaymentReportGroupBox.FillColor = System.Drawing.Color.Transparent;
			this.PaymentReportGroupBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PaymentReportGroupBox.ForeColor = System.Drawing.Color.Black;
			this.PaymentReportGroupBox.Location = new System.Drawing.Point(188, 215);
			this.PaymentReportGroupBox.Name = "PaymentReportGroupBox";
			this.PaymentReportGroupBox.Size = new System.Drawing.Size(1523, 493);
			this.PaymentReportGroupBox.TabIndex = 45;
			this.PaymentReportGroupBox.Text = "Payment Report";
			// 
			// ReportPaymentDaGridView
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.ReportPaymentDaGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.ReportPaymentDaGridView.AutoGenerateColumns = false;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(121)))), ((int)(((byte)(130)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(121)))), ((int)(((byte)(130)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.ReportPaymentDaGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.ReportPaymentDaGridView.ColumnHeadersHeight = 50;
			this.ReportPaymentDaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.ReportPaymentDaGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paymentIDDataGridViewTextBoxColumn,
            this.membershipIDDataGridViewTextBoxColumn,
            this.memberIDDataGridViewTextBoxColumn,
            this.paymentDateDataGridViewTextBoxColumn,
            this.paymentBalanceDataGridViewTextBoxColumn,
            this.planDurationDataGridViewTextBoxColumn,
            this.paymentTypeDataGridViewTextBoxColumn});
			this.ReportPaymentDaGridView.DataSource = this.paymentBindingSource1;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.ReportPaymentDaGridView.DefaultCellStyle = dataGridViewCellStyle3;
			this.ReportPaymentDaGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.ReportPaymentDaGridView.Location = new System.Drawing.Point(39, 68);
			this.ReportPaymentDaGridView.Name = "ReportPaymentDaGridView";
			this.ReportPaymentDaGridView.RowHeadersVisible = false;
			this.ReportPaymentDaGridView.RowHeadersWidth = 51;
			this.ReportPaymentDaGridView.RowTemplate.Height = 24;
			this.ReportPaymentDaGridView.Size = new System.Drawing.Size(1433, 410);
			this.ReportPaymentDaGridView.TabIndex = 0;
			this.ReportPaymentDaGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.ReportPaymentDaGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.ReportPaymentDaGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.ReportPaymentDaGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.ReportPaymentDaGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.ReportPaymentDaGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.ReportPaymentDaGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.ReportPaymentDaGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.ReportPaymentDaGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.ReportPaymentDaGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ReportPaymentDaGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.ReportPaymentDaGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.ReportPaymentDaGridView.ThemeStyle.HeaderStyle.Height = 50;
			this.ReportPaymentDaGridView.ThemeStyle.ReadOnly = false;
			this.ReportPaymentDaGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.ReportPaymentDaGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.ReportPaymentDaGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ReportPaymentDaGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
			this.ReportPaymentDaGridView.ThemeStyle.RowsStyle.Height = 24;
			this.ReportPaymentDaGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.ReportPaymentDaGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// paymentIDDataGridViewTextBoxColumn
			// 
			this.paymentIDDataGridViewTextBoxColumn.DataPropertyName = "Payment_ID";
			this.paymentIDDataGridViewTextBoxColumn.HeaderText = "Payment_ID";
			this.paymentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.paymentIDDataGridViewTextBoxColumn.Name = "paymentIDDataGridViewTextBoxColumn";
			// 
			// membershipIDDataGridViewTextBoxColumn
			// 
			this.membershipIDDataGridViewTextBoxColumn.DataPropertyName = "Membership_ID";
			this.membershipIDDataGridViewTextBoxColumn.HeaderText = "Membership_ID";
			this.membershipIDDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.membershipIDDataGridViewTextBoxColumn.Name = "membershipIDDataGridViewTextBoxColumn";
			// 
			// memberIDDataGridViewTextBoxColumn
			// 
			this.memberIDDataGridViewTextBoxColumn.DataPropertyName = "Member_ID";
			this.memberIDDataGridViewTextBoxColumn.HeaderText = "Member_ID";
			this.memberIDDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.memberIDDataGridViewTextBoxColumn.Name = "memberIDDataGridViewTextBoxColumn";
			// 
			// paymentDateDataGridViewTextBoxColumn
			// 
			this.paymentDateDataGridViewTextBoxColumn.DataPropertyName = "Payment_Date";
			this.paymentDateDataGridViewTextBoxColumn.HeaderText = "Payment_Date";
			this.paymentDateDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.paymentDateDataGridViewTextBoxColumn.Name = "paymentDateDataGridViewTextBoxColumn";
			// 
			// paymentBalanceDataGridViewTextBoxColumn
			// 
			this.paymentBalanceDataGridViewTextBoxColumn.DataPropertyName = "Payment_Balance";
			this.paymentBalanceDataGridViewTextBoxColumn.HeaderText = "Payment_Balance";
			this.paymentBalanceDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.paymentBalanceDataGridViewTextBoxColumn.Name = "paymentBalanceDataGridViewTextBoxColumn";
			// 
			// planDurationDataGridViewTextBoxColumn
			// 
			this.planDurationDataGridViewTextBoxColumn.DataPropertyName = "Plan_Duration";
			this.planDurationDataGridViewTextBoxColumn.HeaderText = "Plan_Duration";
			this.planDurationDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.planDurationDataGridViewTextBoxColumn.Name = "planDurationDataGridViewTextBoxColumn";
			// 
			// paymentTypeDataGridViewTextBoxColumn
			// 
			this.paymentTypeDataGridViewTextBoxColumn.DataPropertyName = "Payment_Type";
			this.paymentTypeDataGridViewTextBoxColumn.HeaderText = "Payment_Type";
			this.paymentTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.paymentTypeDataGridViewTextBoxColumn.Name = "paymentTypeDataGridViewTextBoxColumn";
			// 
			// paymentBindingSource1
			// 
			this.paymentBindingSource1.DataMember = "Payment";
			this.paymentBindingSource1.DataSource = this.groupWst23DataSet;
			// 
			// guna2GroupBox3
			// 
			this.guna2GroupBox3.Controls.Add(this.ReportToDateTimePicker);
			this.guna2GroupBox3.Controls.Add(this.ReportFromDateTimePicker);
			this.guna2GroupBox3.Controls.Add(this.pictureBox6);
			this.guna2GroupBox3.Controls.Add(this.label6);
			this.guna2GroupBox3.Controls.Add(this.label5);
			this.guna2GroupBox3.CustomBorderColor = System.Drawing.Color.Gray;
			this.guna2GroupBox3.FillColor = System.Drawing.Color.Silver;
			this.guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2GroupBox3.ForeColor = System.Drawing.Color.Black;
			this.guna2GroupBox3.Location = new System.Drawing.Point(188, 22);
			this.guna2GroupBox3.Name = "guna2GroupBox3";
			this.guna2GroupBox3.Size = new System.Drawing.Size(1523, 178);
			this.guna2GroupBox3.TabIndex = 46;
			this.guna2GroupBox3.Text = "Payment Report - filter";
			// 
			// ReportToDateTimePicker
			// 
			this.ReportToDateTimePicker.AutoRoundedCorners = true;
			this.ReportToDateTimePicker.BackColor = System.Drawing.Color.Transparent;
			this.ReportToDateTimePicker.Checked = true;
			this.ReportToDateTimePicker.FillColor = System.Drawing.Color.White;
			this.ReportToDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.ReportToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this.ReportToDateTimePicker.Location = new System.Drawing.Point(646, 85);
			this.ReportToDateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.ReportToDateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.ReportToDateTimePicker.Name = "ReportToDateTimePicker";
			this.ReportToDateTimePicker.Size = new System.Drawing.Size(264, 49);
			this.ReportToDateTimePicker.TabIndex = 18;
			this.ReportToDateTimePicker.Value = new System.DateTime(2026, 6, 10, 1, 42, 3, 273);
			this.ReportToDateTimePicker.ValueChanged += new System.EventHandler(this.ReportToDateTimePicker_ValueChanged_1);
			// 
			// ReportFromDateTimePicker
			// 
			this.ReportFromDateTimePicker.AutoRoundedCorners = true;
			this.ReportFromDateTimePicker.BackColor = System.Drawing.Color.Transparent;
			this.ReportFromDateTimePicker.Checked = true;
			this.ReportFromDateTimePicker.FillColor = System.Drawing.Color.White;
			this.ReportFromDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.ReportFromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this.ReportFromDateTimePicker.Location = new System.Drawing.Point(25, 85);
			this.ReportFromDateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.ReportFromDateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.ReportFromDateTimePicker.Name = "ReportFromDateTimePicker";
			this.ReportFromDateTimePicker.Size = new System.Drawing.Size(264, 49);
			this.ReportFromDateTimePicker.TabIndex = 17;
			this.ReportFromDateTimePicker.Value = new System.DateTime(2026, 6, 10, 1, 42, 3, 273);
			this.ReportFromDateTimePicker.ValueChanged += new System.EventHandler(this.ReportFromDateTimePicker_ValueChanged_1);
			// 
			// pictureBox6
			// 
			this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(1310, 58);
			this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(127, 98);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox6.TabIndex = 16;
			this.pictureBox6.TabStop = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(21, 58);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(95, 24);
			this.label6.TabIndex = 12;
			this.label6.Text = "Date from:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(652, 58);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(73, 24);
			this.label5.TabIndex = 13;
			this.label5.Text = "Date to:";
			// 
			// PaymentReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(1924, 1055);
			this.Controls.Add(this.guna2Panel1);
			this.Name = "PaymentReport";
			this.Text = "PaymentReport";
			this.Load += new System.EventHandler(this.PaymentReport_Load);
			((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupWst23DataSet)).EndInit();
			this.guna2Panel1.ResumeLayout(false);
			this.guna2Panel2.ResumeLayout(false);
			this.guna2ShadowPanel4.ResumeLayout(false);
			this.guna2ShadowPanel4.PerformLayout();
			this.guna2ShadowPanel5.ResumeLayout(false);
			this.guna2ShadowPanel5.PerformLayout();
			this.guna2ShadowPanel6.ResumeLayout(false);
			this.guna2ShadowPanel6.PerformLayout();
			this.PaymentReportGroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ReportPaymentDaGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource1)).EndInit();
			this.guna2GroupBox3.ResumeLayout(false);
			this.guna2GroupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private GroupWst23DataSet groupWst23DataSet;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private GroupWst23DataSetTableAdapters.PaymentTableAdapter paymentTableAdapter;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel4;
        private System.Windows.Forms.Label PaymentNumberOfTotalMembersLabel;
        private System.Windows.Forms.Label PaymentTotalMembersLabel;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel5;
        private System.Windows.Forms.Label NumberOfTotalPaidMembersLabel;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel6;
        private System.Windows.Forms.Label NumberOfTotalPaymentsLabel;
        private System.Windows.Forms.Label TotalPaymentLabels;
        private Guna.UI2.WinForms.Guna2Button PaymentPrintReportButton;
        private Guna.UI2.WinForms.Guna2GroupBox PaymentReportGroupBox;
        private Guna.UI2.WinForms.Guna2DataGridView ReportPaymentDaGridView;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
		private Guna.UI2.WinForms.Guna2Button TrainerSaveReportButton;
		private Guna.UI2.WinForms.Guna2DateTimePicker ReportToDateTimePicker;
		private Guna.UI2.WinForms.Guna2DateTimePicker ReportFromDateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn membershipIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentBalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planDurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource paymentBindingSource1;
    }
}