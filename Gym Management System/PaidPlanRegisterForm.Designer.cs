namespace Gym_Management_System
{
    partial class PaidPlanRegisterForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.MemberList = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2DataGridView2 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.memberIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberFNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberLNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupWst23DataSet = new Gym_Management_System.GroupWst23DataSet();
            this.SignoutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SignInBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.registerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidPlanRegisterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2DateTimePicker2 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.RegisterDatetxt = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.MemberRegisterIDtxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.paidPlanRegisterTableAdapter = new Gym_Management_System.GroupWst23DataSetTableAdapters.PaidPlanRegisterTableAdapter();
            this.memberTableAdapter1 = new Gym_Management_System.GroupWst23DataSetTableAdapters.MemberTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2Panel1.SuspendLayout();
            this.MemberList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst23DataSet)).BeginInit();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paidPlanRegisterBindingSource)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.MemberList);
            this.guna2Panel1.Controls.Add(this.SignoutBtn);
            this.guna2Panel1.Controls.Add(this.SignInBtn);
            this.guna2Panel1.Controls.Add(this.guna2GroupBox2);
            this.guna2Panel1.Controls.Add(this.guna2GroupBox1);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.FillColor = System.Drawing.Color.Silver;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1873, 866);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // MemberList
            // 
            this.MemberList.Controls.Add(this.guna2DataGridView2);
            this.MemberList.CustomBorderColor = System.Drawing.Color.Gray;
            this.MemberList.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MemberList.ForeColor = System.Drawing.Color.Black;
            this.MemberList.Location = new System.Drawing.Point(518, 149);
            this.MemberList.Name = "MemberList";
            this.MemberList.Size = new System.Drawing.Size(455, 356);
            this.MemberList.TabIndex = 4;
            this.MemberList.Text = "Member List";
            // 
            // guna2DataGridView2
            // 
            this.guna2DataGridView2.AllowUserToAddRows = false;
            this.guna2DataGridView2.AllowUserToDeleteRows = false;
            this.guna2DataGridView2.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView2.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(121)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(121)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView2.ColumnHeadersHeight = 22;
            this.guna2DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.memberIDDataGridViewTextBoxColumn1,
            this.memberFNameDataGridViewTextBoxColumn,
            this.memberLNameDataGridViewTextBoxColumn});
            this.guna2DataGridView2.DataSource = this.memberBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2DataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView2.Location = new System.Drawing.Point(0, 40);
            this.guna2DataGridView2.Name = "guna2DataGridView2";
            this.guna2DataGridView2.ReadOnly = true;
            this.guna2DataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DataGridView2.RowHeadersVisible = false;
            this.guna2DataGridView2.RowHeadersWidth = 51;
            this.guna2DataGridView2.RowTemplate.Height = 24;
            this.guna2DataGridView2.Size = new System.Drawing.Size(455, 316);
            this.guna2DataGridView2.TabIndex = 0;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Silver;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(203)))));
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView2.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView2.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(121)))), ((int)(((byte)(130)))));
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.Height = 22;
            this.guna2DataGridView2.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DataGridView2.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.Height = 24;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(203)))));
            this.guna2DataGridView2.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView2_CellClick);
            // 
            // memberIDDataGridViewTextBoxColumn1
            // 
            this.memberIDDataGridViewTextBoxColumn1.DataPropertyName = "Member_ID";
            this.memberIDDataGridViewTextBoxColumn1.HeaderText = "Member ID";
            this.memberIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.memberIDDataGridViewTextBoxColumn1.Name = "memberIDDataGridViewTextBoxColumn1";
            this.memberIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // memberFNameDataGridViewTextBoxColumn
            // 
            this.memberFNameDataGridViewTextBoxColumn.DataPropertyName = "Member_FName";
            this.memberFNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.memberFNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.memberFNameDataGridViewTextBoxColumn.Name = "memberFNameDataGridViewTextBoxColumn";
            this.memberFNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // memberLNameDataGridViewTextBoxColumn
            // 
            this.memberLNameDataGridViewTextBoxColumn.DataPropertyName = "Member_LName";
            this.memberLNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.memberLNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.memberLNameDataGridViewTextBoxColumn.Name = "memberLNameDataGridViewTextBoxColumn";
            this.memberLNameDataGridViewTextBoxColumn.ReadOnly = true;
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
            // SignoutBtn
            // 
            this.SignoutBtn.Animated = true;
            this.SignoutBtn.AutoRoundedCorners = true;
            this.SignoutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SignoutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SignoutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SignoutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SignoutBtn.FillColor = System.Drawing.Color.Teal;
            this.SignoutBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SignoutBtn.ForeColor = System.Drawing.Color.White;
            this.SignoutBtn.IndicateFocus = true;
            this.SignoutBtn.Location = new System.Drawing.Point(1355, 471);
            this.SignoutBtn.Name = "SignoutBtn";
            this.SignoutBtn.Size = new System.Drawing.Size(180, 45);
            this.SignoutBtn.TabIndex = 3;
            this.SignoutBtn.Text = "Sign out";
            this.SignoutBtn.UseTransparentBackground = true;
            this.SignoutBtn.Click += new System.EventHandler(this.SignoutBtn_Click);
            // 
            // SignInBtn
            // 
            this.SignInBtn.Animated = true;
            this.SignInBtn.AutoRoundedCorners = true;
            this.SignInBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SignInBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SignInBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SignInBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SignInBtn.FillColor = System.Drawing.Color.Teal;
            this.SignInBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SignInBtn.ForeColor = System.Drawing.Color.White;
            this.SignInBtn.IndicateFocus = true;
            this.SignInBtn.Location = new System.Drawing.Point(1075, 471);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Size = new System.Drawing.Size(180, 45);
            this.SignInBtn.TabIndex = 2;
            this.SignInBtn.Text = "Sign in";
            this.SignInBtn.UseTransparentBackground = true;
            this.SignInBtn.Click += new System.EventHandler(this.SignInBtn_Click);
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Controls.Add(this.guna2DataGridView1);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.Gray;
            this.guna2GroupBox2.FillColor = System.Drawing.Color.Silver;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(518, 532);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(1017, 304);
            this.guna2GroupBox2.TabIndex = 1;
            this.guna2GroupBox2.Text = "Register";
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            this.guna2DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.guna2DataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(121)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(121)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.guna2DataGridView1.ColumnHeadersHeight = 22;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.registerIDDataGridViewTextBoxColumn,
            this.memberIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.timeInDataGridViewTextBoxColumn,
            this.timeOutDataGridViewTextBoxColumn});
            this.guna2DataGridView1.DataSource = this.paidPlanRegisterBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(49, 61);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowTemplate.Height = 24;
            this.guna2DataGridView1.Size = new System.Drawing.Size(920, 221);
            this.guna2DataGridView1.TabIndex = 0;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Gray;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(200)))), ((int)(((byte)(72)))));
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(200)))), ((int)(((byte)(72)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellClick);
            // 
            // registerIDDataGridViewTextBoxColumn
            // 
            this.registerIDDataGridViewTextBoxColumn.DataPropertyName = "Register_ID";
            this.registerIDDataGridViewTextBoxColumn.HeaderText = "Register_ID";
            this.registerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.registerIDDataGridViewTextBoxColumn.Name = "registerIDDataGridViewTextBoxColumn";
            this.registerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // memberIDDataGridViewTextBoxColumn
            // 
            this.memberIDDataGridViewTextBoxColumn.DataPropertyName = "Member_ID";
            this.memberIDDataGridViewTextBoxColumn.HeaderText = "Member_ID";
            this.memberIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.memberIDDataGridViewTextBoxColumn.Name = "memberIDDataGridViewTextBoxColumn";
            this.memberIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeInDataGridViewTextBoxColumn
            // 
            this.timeInDataGridViewTextBoxColumn.DataPropertyName = "Time_In";
            this.timeInDataGridViewTextBoxColumn.HeaderText = "Time_In";
            this.timeInDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeInDataGridViewTextBoxColumn.Name = "timeInDataGridViewTextBoxColumn";
            this.timeInDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeOutDataGridViewTextBoxColumn
            // 
            this.timeOutDataGridViewTextBoxColumn.DataPropertyName = "Time_Out";
            this.timeOutDataGridViewTextBoxColumn.HeaderText = "Time_Out";
            this.timeOutDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeOutDataGridViewTextBoxColumn.Name = "timeOutDataGridViewTextBoxColumn";
            this.timeOutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paidPlanRegisterBindingSource
            // 
            this.paidPlanRegisterBindingSource.DataMember = "PaidPlanRegister";
            this.paidPlanRegisterBindingSource.DataSource = this.groupWst23DataSet;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.Controls.Add(this.guna2DateTimePicker2);
            this.guna2GroupBox1.Controls.Add(this.guna2DateTimePicker1);
            this.guna2GroupBox1.Controls.Add(this.RegisterDatetxt);
            this.guna2GroupBox1.Controls.Add(this.MemberRegisterIDtxt);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Gray;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.Silver;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(1062, 149);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(473, 296);
            this.guna2GroupBox1.TabIndex = 0;
            this.guna2GroupBox1.Text = "Mark Register";
            // 
            // guna2DateTimePicker2
            // 
            this.guna2DateTimePicker2.Animated = true;
            this.guna2DateTimePicker2.AutoRoundedCorners = true;
            this.guna2DateTimePicker2.Checked = true;
            this.guna2DateTimePicker2.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2DateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker2.IndicateFocus = true;
            this.guna2DateTimePicker2.Location = new System.Drawing.Point(168, 203);
            this.guna2DateTimePicker2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker2.Name = "guna2DateTimePicker2";
            this.guna2DateTimePicker2.Size = new System.Drawing.Size(229, 36);
            this.guna2DateTimePicker2.TabIndex = 10;
            this.guna2DateTimePicker2.UseTransparentBackground = true;
            this.guna2DateTimePicker2.Value = new System.DateTime(2026, 5, 28, 16, 49, 38, 553);
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.Animated = true;
            this.guna2DateTimePicker1.AutoRoundedCorners = true;
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.IndicateFocus = true;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(168, 150);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(229, 36);
            this.guna2DateTimePicker1.TabIndex = 10;
            this.guna2DateTimePicker1.UseTransparentBackground = true;
            this.guna2DateTimePicker1.Value = new System.DateTime(2026, 5, 28, 16, 49, 38, 553);
            // 
            // RegisterDatetxt
            // 
            this.RegisterDatetxt.Animated = true;
            this.RegisterDatetxt.AutoRoundedCorners = true;
            this.RegisterDatetxt.Checked = true;
            this.RegisterDatetxt.FillColor = System.Drawing.Color.WhiteSmoke;
            this.RegisterDatetxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RegisterDatetxt.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.RegisterDatetxt.IndicateFocus = true;
            this.RegisterDatetxt.Location = new System.Drawing.Point(168, 102);
            this.RegisterDatetxt.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.RegisterDatetxt.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.RegisterDatetxt.Name = "RegisterDatetxt";
            this.RegisterDatetxt.Size = new System.Drawing.Size(273, 36);
            this.RegisterDatetxt.TabIndex = 9;
            this.RegisterDatetxt.UseTransparentBackground = true;
            this.RegisterDatetxt.Value = new System.DateTime(2026, 5, 28, 16, 49, 38, 553);
            // 
            // MemberRegisterIDtxt
            // 
            this.MemberRegisterIDtxt.Animated = true;
            this.MemberRegisterIDtxt.AutoRoundedCorners = true;
            this.MemberRegisterIDtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MemberRegisterIDtxt.DefaultText = "";
            this.MemberRegisterIDtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MemberRegisterIDtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MemberRegisterIDtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MemberRegisterIDtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MemberRegisterIDtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MemberRegisterIDtxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MemberRegisterIDtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MemberRegisterIDtxt.Location = new System.Drawing.Point(168, 61);
            this.MemberRegisterIDtxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MemberRegisterIDtxt.Name = "MemberRegisterIDtxt";
            this.MemberRegisterIDtxt.PlaceholderText = "";
            this.MemberRegisterIDtxt.SelectedText = "";
            this.MemberRegisterIDtxt.Size = new System.Drawing.Size(229, 32);
            this.MemberRegisterIDtxt.TabIndex = 8;
            this.MemberRegisterIDtxt.TextChanged += new System.EventHandler(this.MemberRegisterIDtxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Time in:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time out";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member ID";
            // 
            // paidPlanRegisterTableAdapter
            // 
            this.paidPlanRegisterTableAdapter.ClearBeforeFill = true;
            // 
            // memberTableAdapter1
            // 
            this.memberTableAdapter1.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // PaidPlanRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1873, 866);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "PaidPlanRegisterForm";
            this.Text = "PaidPlanRegisterForm";
            this.Load += new System.EventHandler(this.PaidPlanRegisterForm_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.MemberList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst23DataSet)).EndInit();
            this.guna2GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paidPlanRegisterBindingSource)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2DateTimePicker RegisterDatetxt;
        private Guna.UI2.WinForms.Guna2TextBox MemberRegisterIDtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private GroupWst23DataSet groupWst23DataSet;
      //  private GroupWst23DataSetTableAdapters.PaidPlanRegisterTableTableAdapter paidPlanRegisterTableTableAdapter;
        private Guna.UI2.WinForms.Guna2Button SignoutBtn;
        private Guna.UI2.WinForms.Guna2Button SignInBtn;
        private System.Windows.Forms.BindingSource paidPlanRegisterBindingSource;
        private GroupWst23DataSetTableAdapters.PaidPlanRegisterTableAdapter paidPlanRegisterTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn registerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeOutDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker2;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private GroupWst23DataSetTableAdapters.MemberTableAdapter memberTableAdapter1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private Guna.UI2.WinForms.Guna2GroupBox MemberList;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberFNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberLNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler1;
        //  private GroupWst23DataSetTableAdapters.PaidPlanRegisterTableTableAdapter paidPlanRegisterTableTableAdapter1;
    }
}