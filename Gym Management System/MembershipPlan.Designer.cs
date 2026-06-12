namespace Gym_Management_System
{
    partial class MembershipPlan
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
            this.membershipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupWst23DataSet1 = new Gym_Management_System.GroupWst23DataSet();
            this.membershipTableAdapter1 = new Gym_Management_System.GroupWst23DataSetTableAdapters.MembershipTableAdapter();
            this.membershipBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.membershipIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planTypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planDescriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.ManageMembershipAddNewMembershipBtn1 = new Guna.UI2.WinForms.Guna2Button();
            this.UpdateMembershipPlanBtn1 = new Guna.UI2.WinForms.Guna2Button();
            this.PlanPriceTxt1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.MembershipPlanTypeTextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.ManagerMembershipDesriptionTextBox = new System.Windows.Forms.TextBox();
            this.MembershipPlanUpdateTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.UpdatePlanDescription = new System.Windows.Forms.Label();
            this.UpdatePlanIDLabel = new System.Windows.Forms.Label();
            this.UpdatePlanTypeLabel = new System.Windows.Forms.Label();
            this.UpdatePlanPriceLabel = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.membershipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst23DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipBindingSource1)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.guna2GroupBox2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // membershipBindingSource
            // 
            this.membershipBindingSource.DataMember = "Membership";
            this.membershipBindingSource.DataSource = this.groupWst23DataSet1;
            // 
            // groupWst23DataSet1
            // 
            this.groupWst23DataSet1.DataSetName = "GroupWst23DataSet";
            this.groupWst23DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // membershipTableAdapter1
            // 
            this.membershipTableAdapter1.ClearBeforeFill = true;
            // 
            // membershipBindingSource1
            // 
            this.membershipBindingSource1.DataMember = "Membership";
            this.membershipBindingSource1.DataSource = this.groupWst23DataSet1;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.guna2GroupBox1.Controls.Add(this.guna2DataGridView1);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Gray;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.Silver;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(170, 70);
            this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1348, 308);
            this.guna2GroupBox1.TabIndex = 0;
            this.guna2GroupBox1.Text = "Membership Plans";
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            this.guna2DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(200)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(121)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(121)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 22;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.membershipIDDataGridViewTextBoxColumn1,
            this.planTypeDataGridViewTextBoxColumn1,
            this.planPriceDataGridViewTextBoxColumn1,
            this.planDescriptionDataGridViewTextBoxColumn1});
            this.guna2DataGridView1.DataSource = this.membershipBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(200)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(35, 77);
            this.guna2DataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowTemplate.Height = 24;
            this.guna2DataGridView1.Size = new System.Drawing.Size(1298, 167);
            this.guna2DataGridView1.TabIndex = 0;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellClick);
            this.guna2DataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.guna2DataGridView1_RowHeaderMouseClick);
            // 
            // membershipIDDataGridViewTextBoxColumn1
            // 
            this.membershipIDDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.membershipIDDataGridViewTextBoxColumn1.DataPropertyName = "Membership_ID";
            this.membershipIDDataGridViewTextBoxColumn1.HeaderText = "Membership_ID";
            this.membershipIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.membershipIDDataGridViewTextBoxColumn1.Name = "membershipIDDataGridViewTextBoxColumn1";
            this.membershipIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.membershipIDDataGridViewTextBoxColumn1.Width = 150;
            // 
            // planTypeDataGridViewTextBoxColumn1
            // 
            this.planTypeDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.planTypeDataGridViewTextBoxColumn1.DataPropertyName = "Plan_Type";
            this.planTypeDataGridViewTextBoxColumn1.FillWeight = 202.7027F;
            this.planTypeDataGridViewTextBoxColumn1.HeaderText = "Plan_Type";
            this.planTypeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.planTypeDataGridViewTextBoxColumn1.Name = "planTypeDataGridViewTextBoxColumn1";
            this.planTypeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.planTypeDataGridViewTextBoxColumn1.Width = 250;
            // 
            // planPriceDataGridViewTextBoxColumn1
            // 
            this.planPriceDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.planPriceDataGridViewTextBoxColumn1.DataPropertyName = "Plan_Price";
            this.planPriceDataGridViewTextBoxColumn1.FillWeight = 48.64865F;
            this.planPriceDataGridViewTextBoxColumn1.HeaderText = "Plan_Price";
            this.planPriceDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.planPriceDataGridViewTextBoxColumn1.Name = "planPriceDataGridViewTextBoxColumn1";
            this.planPriceDataGridViewTextBoxColumn1.ReadOnly = true;
            this.planPriceDataGridViewTextBoxColumn1.Width = 128;
            // 
            // planDescriptionDataGridViewTextBoxColumn1
            // 
            this.planDescriptionDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.planDescriptionDataGridViewTextBoxColumn1.DataPropertyName = "Plan_Description";
            this.planDescriptionDataGridViewTextBoxColumn1.FillWeight = 48.64865F;
            this.planDescriptionDataGridViewTextBoxColumn1.HeaderText = "Plan_Description";
            this.planDescriptionDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.planDescriptionDataGridViewTextBoxColumn1.Name = "planDescriptionDataGridViewTextBoxColumn1";
            this.planDescriptionDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BackColor = System.Drawing.Color.Silver;
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.LightGray;
            this.guna2GroupBox2.Controls.Add(this.ManageMembershipAddNewMembershipBtn1);
            this.guna2GroupBox2.Controls.Add(this.UpdateMembershipPlanBtn1);
            this.guna2GroupBox2.Controls.Add(this.PlanPriceTxt1);
            this.guna2GroupBox2.Controls.Add(this.MembershipPlanTypeTextBox1);
            this.guna2GroupBox2.Controls.Add(this.ManagerMembershipDesriptionTextBox);
            this.guna2GroupBox2.Controls.Add(this.MembershipPlanUpdateTextBox);
            this.guna2GroupBox2.Controls.Add(this.UpdatePlanDescription);
            this.guna2GroupBox2.Controls.Add(this.UpdatePlanIDLabel);
            this.guna2GroupBox2.Controls.Add(this.UpdatePlanTypeLabel);
            this.guna2GroupBox2.Controls.Add(this.UpdatePlanPriceLabel);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.Gray;
            this.guna2GroupBox2.FillColor = System.Drawing.Color.Silver;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(382, 407);
            this.guna2GroupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(825, 513);
            this.guna2GroupBox2.TabIndex = 1;
            this.guna2GroupBox2.Text = "Update Membership Plan";
            // 
            // ManageMembershipAddNewMembershipBtn1
            // 
            this.ManageMembershipAddNewMembershipBtn1.Animated = true;
            this.ManageMembershipAddNewMembershipBtn1.AutoRoundedCorners = true;
            this.ManageMembershipAddNewMembershipBtn1.BackColor = System.Drawing.Color.Transparent;
            this.ManageMembershipAddNewMembershipBtn1.BorderColor = System.Drawing.Color.Gray;
            this.ManageMembershipAddNewMembershipBtn1.BorderThickness = 1;
            this.ManageMembershipAddNewMembershipBtn1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ManageMembershipAddNewMembershipBtn1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ManageMembershipAddNewMembershipBtn1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ManageMembershipAddNewMembershipBtn1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ManageMembershipAddNewMembershipBtn1.FillColor = System.Drawing.Color.Teal;
            this.ManageMembershipAddNewMembershipBtn1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ManageMembershipAddNewMembershipBtn1.ForeColor = System.Drawing.Color.White;
            this.ManageMembershipAddNewMembershipBtn1.IndicateFocus = true;
            this.ManageMembershipAddNewMembershipBtn1.Location = new System.Drawing.Point(562, 454);
            this.ManageMembershipAddNewMembershipBtn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ManageMembershipAddNewMembershipBtn1.Name = "ManageMembershipAddNewMembershipBtn1";
            this.ManageMembershipAddNewMembershipBtn1.Size = new System.Drawing.Size(180, 46);
            this.ManageMembershipAddNewMembershipBtn1.TabIndex = 4;
            this.ManageMembershipAddNewMembershipBtn1.Text = "Add New Plan";
            this.ManageMembershipAddNewMembershipBtn1.UseTransparentBackground = true;
            this.ManageMembershipAddNewMembershipBtn1.Click += new System.EventHandler(this.ManageMembershipAddNewMembershipBtn1_Click);
            // 
            // UpdateMembershipPlanBtn1
            // 
            this.UpdateMembershipPlanBtn1.Animated = true;
            this.UpdateMembershipPlanBtn1.AutoRoundedCorners = true;
            this.UpdateMembershipPlanBtn1.BorderColor = System.Drawing.Color.LightGray;
            this.UpdateMembershipPlanBtn1.BorderThickness = 1;
            this.UpdateMembershipPlanBtn1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UpdateMembershipPlanBtn1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UpdateMembershipPlanBtn1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateMembershipPlanBtn1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UpdateMembershipPlanBtn1.FillColor = System.Drawing.Color.Teal;
            this.UpdateMembershipPlanBtn1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UpdateMembershipPlanBtn1.ForeColor = System.Drawing.Color.White;
            this.UpdateMembershipPlanBtn1.Location = new System.Drawing.Point(61, 454);
            this.UpdateMembershipPlanBtn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateMembershipPlanBtn1.Name = "UpdateMembershipPlanBtn1";
            this.UpdateMembershipPlanBtn1.Size = new System.Drawing.Size(180, 46);
            this.UpdateMembershipPlanBtn1.TabIndex = 3;
            this.UpdateMembershipPlanBtn1.Text = "Update Plan";
            this.UpdateMembershipPlanBtn1.Click += new System.EventHandler(this.UpdateMembershipPlanBtn1_Click);
            // 
            // PlanPriceTxt1
            // 
            this.PlanPriceTxt1.Animated = true;
            this.PlanPriceTxt1.AutoRoundedCorners = true;
            this.PlanPriceTxt1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PlanPriceTxt1.DefaultText = "";
            this.PlanPriceTxt1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PlanPriceTxt1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PlanPriceTxt1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PlanPriceTxt1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PlanPriceTxt1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PlanPriceTxt1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PlanPriceTxt1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PlanPriceTxt1.Location = new System.Drawing.Point(307, 194);
            this.PlanPriceTxt1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PlanPriceTxt1.Name = "PlanPriceTxt1";
            this.PlanPriceTxt1.PlaceholderText = "";
            this.PlanPriceTxt1.SelectedText = "";
            this.PlanPriceTxt1.Size = new System.Drawing.Size(271, 34);
            this.PlanPriceTxt1.TabIndex = 2;
            // 
            // MembershipPlanTypeTextBox1
            // 
            this.MembershipPlanTypeTextBox1.Animated = true;
            this.MembershipPlanTypeTextBox1.AutoRoundedCorners = true;
            this.MembershipPlanTypeTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MembershipPlanTypeTextBox1.DefaultText = "";
            this.MembershipPlanTypeTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MembershipPlanTypeTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MembershipPlanTypeTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MembershipPlanTypeTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MembershipPlanTypeTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MembershipPlanTypeTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MembershipPlanTypeTextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MembershipPlanTypeTextBox1.Location = new System.Drawing.Point(307, 139);
            this.MembershipPlanTypeTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MembershipPlanTypeTextBox1.Name = "MembershipPlanTypeTextBox1";
            this.MembershipPlanTypeTextBox1.PlaceholderText = "";
            this.MembershipPlanTypeTextBox1.SelectedText = "";
            this.MembershipPlanTypeTextBox1.Size = new System.Drawing.Size(271, 34);
            this.MembershipPlanTypeTextBox1.TabIndex = 1;
            // 
            // ManagerMembershipDesriptionTextBox
            // 
            this.ManagerMembershipDesriptionTextBox.Location = new System.Drawing.Point(307, 255);
            this.ManagerMembershipDesriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ManagerMembershipDesriptionTextBox.Multiline = true;
            this.ManagerMembershipDesriptionTextBox.Name = "ManagerMembershipDesriptionTextBox";
            this.ManagerMembershipDesriptionTextBox.Size = new System.Drawing.Size(328, 122);
            this.ManagerMembershipDesriptionTextBox.TabIndex = 11;
            // 
            // MembershipPlanUpdateTextBox
            // 
            this.MembershipPlanUpdateTextBox.Animated = true;
            this.MembershipPlanUpdateTextBox.AutoRoundedCorners = true;
            this.MembershipPlanUpdateTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MembershipPlanUpdateTextBox.DefaultText = "";
            this.MembershipPlanUpdateTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MembershipPlanUpdateTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MembershipPlanUpdateTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MembershipPlanUpdateTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MembershipPlanUpdateTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MembershipPlanUpdateTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MembershipPlanUpdateTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MembershipPlanUpdateTextBox.Location = new System.Drawing.Point(307, 75);
            this.MembershipPlanUpdateTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MembershipPlanUpdateTextBox.Name = "MembershipPlanUpdateTextBox";
            this.MembershipPlanUpdateTextBox.PlaceholderText = "";
            this.MembershipPlanUpdateTextBox.SelectedText = "";
            this.MembershipPlanUpdateTextBox.Size = new System.Drawing.Size(271, 34);
            this.MembershipPlanUpdateTextBox.TabIndex = 0;
            // 
            // UpdatePlanDescription
            // 
            this.UpdatePlanDescription.AutoSize = true;
            this.UpdatePlanDescription.Location = new System.Drawing.Point(37, 258);
            this.UpdatePlanDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpdatePlanDescription.Name = "UpdatePlanDescription";
            this.UpdatePlanDescription.Size = new System.Drawing.Size(177, 26);
            this.UpdatePlanDescription.TabIndex = 3;
            this.UpdatePlanDescription.Text = "Plan Description";
            // 
            // UpdatePlanIDLabel
            // 
            this.UpdatePlanIDLabel.AutoSize = true;
            this.UpdatePlanIDLabel.Location = new System.Drawing.Point(37, 75);
            this.UpdatePlanIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpdatePlanIDLabel.Name = "UpdatePlanIDLabel";
            this.UpdatePlanIDLabel.Size = new System.Drawing.Size(165, 26);
            this.UpdatePlanIDLabel.TabIndex = 0;
            this.UpdatePlanIDLabel.Text = "Membership ID";
            // 
            // UpdatePlanTypeLabel
            // 
            this.UpdatePlanTypeLabel.AutoSize = true;
            this.UpdatePlanTypeLabel.Location = new System.Drawing.Point(37, 139);
            this.UpdatePlanTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpdatePlanTypeLabel.Name = "UpdatePlanTypeLabel";
            this.UpdatePlanTypeLabel.Size = new System.Drawing.Size(111, 26);
            this.UpdatePlanTypeLabel.TabIndex = 1;
            this.UpdatePlanTypeLabel.Text = "Plan Type";
            // 
            // UpdatePlanPriceLabel
            // 
            this.UpdatePlanPriceLabel.AutoSize = true;
            this.UpdatePlanPriceLabel.Location = new System.Drawing.Point(37, 194);
            this.UpdatePlanPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpdatePlanPriceLabel.Name = "UpdatePlanPriceLabel";
            this.UpdatePlanPriceLabel.Size = new System.Drawing.Size(115, 26);
            this.UpdatePlanPriceLabel.TabIndex = 2;
            this.UpdatePlanPriceLabel.Text = "Plan Price";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel1.Controls.Add(this.guna2GroupBox2);
            this.guna2Panel1.Controls.Add(this.guna2GroupBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1924, 1055);
            this.guna2Panel1.TabIndex = 18;
            // 
            // MembershipPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MembershipPlan";
            this.Text = "MembershipPlan";
            this.Load += new System.EventHandler(this.MembershipPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.membershipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst23DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipBindingSource1)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource membershipBindingSource;
        private GroupWst23DataSet groupWst23DataSet1;
        private GroupWst23DataSetTableAdapters.MembershipTableAdapter membershipTableAdapter1;
        private System.Windows.Forms.BindingSource membershipBindingSource1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2Button ManageMembershipAddNewMembershipBtn1;
        private Guna.UI2.WinForms.Guna2Button UpdateMembershipPlanBtn1;
        private Guna.UI2.WinForms.Guna2TextBox PlanPriceTxt1;
        private Guna.UI2.WinForms.Guna2TextBox MembershipPlanTypeTextBox1;
        private System.Windows.Forms.TextBox ManagerMembershipDesriptionTextBox;
        private Guna.UI2.WinForms.Guna2TextBox MembershipPlanUpdateTextBox;
        private System.Windows.Forms.Label UpdatePlanDescription;
        private System.Windows.Forms.Label UpdatePlanIDLabel;
        private System.Windows.Forms.Label UpdatePlanTypeLabel;
        private System.Windows.Forms.Label UpdatePlanPriceLabel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
       // private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler1;
        private System.Windows.Forms.DataGridViewTextBoxColumn membershipIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn planTypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn planPriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn planDescriptionDataGridViewTextBoxColumn1;
    }
}