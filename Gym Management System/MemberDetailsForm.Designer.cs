namespace Gym_Management_System
{
    partial class MemberDetailsForm
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
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupWst23DataSet1 = new Gym_Management_System.GroupWst23DataSet();
            this.memberTableAdapter1 = new Gym_Management_System.GroupWst23DataSetTableAdapters.MemberTableAdapter();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchMemberByIDTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.memberIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Member_FName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberLNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberTelephoneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberPhoneNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberEmailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberStreetNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberStreetNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberCityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberProvinceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberPostalCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberGenderDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberDOBDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberJoinDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberStatusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emergencyContactNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emergencyContactNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emergencyContactRelationshipDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst23DataSet1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "Member";
            this.memberBindingSource.DataSource = this.groupWst23DataSet1;
            // 
            // groupWst23DataSet1
            // 
            this.groupWst23DataSet1.DataSetName = "GroupWst23DataSet";
            this.groupWst23DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memberTableAdapter1
            // 
            this.memberTableAdapter1.ClearBeforeFill = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.guna2Panel1.Controls.Add(this.guna2GroupBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1924, 1055);
            this.guna2Panel1.TabIndex = 19;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Controls.Add(this.SearchMemberByIDTextBox);
            this.guna2GroupBox1.Controls.Add(this.guna2DataGridView1);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Gray;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.Silver;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(42, 127);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1857, 809);
            this.guna2GroupBox1.TabIndex = 1;
            this.guna2GroupBox1.Text = " Members List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(453, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search By Name/ID";
            // 
            // SearchMemberByIDTextBox
            // 
            this.SearchMemberByIDTextBox.Animated = true;
            this.SearchMemberByIDTextBox.AutoRoundedCorners = true;
            this.SearchMemberByIDTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchMemberByIDTextBox.DefaultText = "";
            this.SearchMemberByIDTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchMemberByIDTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchMemberByIDTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchMemberByIDTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchMemberByIDTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchMemberByIDTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchMemberByIDTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchMemberByIDTextBox.IconRight = global::Gym_Management_System.Properties.Resources.search_icon;
            this.SearchMemberByIDTextBox.Location = new System.Drawing.Point(691, 108);
            this.SearchMemberByIDTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchMemberByIDTextBox.Name = "SearchMemberByIDTextBox";
            this.SearchMemberByIDTextBox.PlaceholderText = "Search Member by ID / first name";
            this.SearchMemberByIDTextBox.SelectedText = "";
            this.SearchMemberByIDTextBox.Size = new System.Drawing.Size(312, 34);
            this.SearchMemberByIDTextBox.TabIndex = 1;
            this.SearchMemberByIDTextBox.TextChanged += new System.EventHandler(this.SearchMemberByIDTextBox_TextChanged);
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            this.guna2DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(121)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(121)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 62;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.memberIDDataGridViewTextBoxColumn1,
            this.Member_FName,
            this.memberLNameDataGridViewTextBoxColumn1,
            this.memberTelephoneDataGridViewTextBoxColumn1,
            this.memberPhoneNumberDataGridViewTextBoxColumn1,
            this.memberEmailDataGridViewTextBoxColumn1,
            this.memberStreetNameDataGridViewTextBoxColumn1,
            this.memberStreetNumberDataGridViewTextBoxColumn1,
            this.memberCityDataGridViewTextBoxColumn1,
            this.memberProvinceDataGridViewTextBoxColumn1,
            this.memberPostalCodeDataGridViewTextBoxColumn1,
            this.memberGenderDataGridViewTextBoxColumn1,
            this.memberDOBDataGridViewTextBoxColumn1,
            this.memberJoinDateDataGridViewTextBoxColumn1,
            this.memberStatusDataGridViewTextBoxColumn1,
            this.emergencyContactNameDataGridViewTextBoxColumn1,
            this.emergencyContactNumberDataGridViewTextBoxColumn1,
            this.emergencyContactRelationshipDataGridViewTextBoxColumn1});
            this.guna2DataGridView1.DataSource = this.memberBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(34, 164);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowTemplate.Height = 24;
            this.guna2DataGridView1.Size = new System.Drawing.Size(1754, 509);
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
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 62;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // memberIDDataGridViewTextBoxColumn1
            // 
            this.memberIDDataGridViewTextBoxColumn1.DataPropertyName = "Member_ID";
            this.memberIDDataGridViewTextBoxColumn1.HeaderText = "Member_ID";
            this.memberIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.memberIDDataGridViewTextBoxColumn1.Name = "memberIDDataGridViewTextBoxColumn1";
            this.memberIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Member_FName
            // 
            this.Member_FName.DataPropertyName = "Member_FName";
            this.Member_FName.HeaderText = "First Name";
            this.Member_FName.MinimumWidth = 6;
            this.Member_FName.Name = "Member_FName";
            this.Member_FName.ReadOnly = true;
            // 
            // memberLNameDataGridViewTextBoxColumn1
            // 
            this.memberLNameDataGridViewTextBoxColumn1.DataPropertyName = "Member_LName";
            this.memberLNameDataGridViewTextBoxColumn1.HeaderText = "Surname";
            this.memberLNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.memberLNameDataGridViewTextBoxColumn1.Name = "memberLNameDataGridViewTextBoxColumn1";
            this.memberLNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // memberTelephoneDataGridViewTextBoxColumn1
            // 
            this.memberTelephoneDataGridViewTextBoxColumn1.DataPropertyName = "Member_Telephone";
            this.memberTelephoneDataGridViewTextBoxColumn1.HeaderText = "Member_Telephone";
            this.memberTelephoneDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.memberTelephoneDataGridViewTextBoxColumn1.Name = "memberTelephoneDataGridViewTextBoxColumn1";
            this.memberTelephoneDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // memberPhoneNumberDataGridViewTextBoxColumn1
            // 
            this.memberPhoneNumberDataGridViewTextBoxColumn1.DataPropertyName = "Member_Phone_Number";
            this.memberPhoneNumberDataGridViewTextBoxColumn1.HeaderText = "Mobile Number";
            this.memberPhoneNumberDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.memberPhoneNumberDataGridViewTextBoxColumn1.Name = "memberPhoneNumberDataGridViewTextBoxColumn1";
            this.memberPhoneNumberDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // memberEmailDataGridViewTextBoxColumn1
            // 
            this.memberEmailDataGridViewTextBoxColumn1.DataPropertyName = "Member_Email";
            this.memberEmailDataGridViewTextBoxColumn1.HeaderText = "Email";
            this.memberEmailDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.memberEmailDataGridViewTextBoxColumn1.Name = "memberEmailDataGridViewTextBoxColumn1";
            this.memberEmailDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // memberStreetNameDataGridViewTextBoxColumn1
            // 
            this.memberStreetNameDataGridViewTextBoxColumn1.DataPropertyName = "Member_Street_Name";
            this.memberStreetNameDataGridViewTextBoxColumn1.HeaderText = "Street Name";
            this.memberStreetNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.memberStreetNameDataGridViewTextBoxColumn1.Name = "memberStreetNameDataGridViewTextBoxColumn1";
            this.memberStreetNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // memberStreetNumberDataGridViewTextBoxColumn1
            // 
            this.memberStreetNumberDataGridViewTextBoxColumn1.DataPropertyName = "Member_Street_Number";
            this.memberStreetNumberDataGridViewTextBoxColumn1.HeaderText = "Street Number";
            this.memberStreetNumberDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.memberStreetNumberDataGridViewTextBoxColumn1.Name = "memberStreetNumberDataGridViewTextBoxColumn1";
            this.memberStreetNumberDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // memberCityDataGridViewTextBoxColumn1
            // 
            this.memberCityDataGridViewTextBoxColumn1.DataPropertyName = "Member_City";
            this.memberCityDataGridViewTextBoxColumn1.HeaderText = "City";
            this.memberCityDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.memberCityDataGridViewTextBoxColumn1.Name = "memberCityDataGridViewTextBoxColumn1";
            this.memberCityDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // memberProvinceDataGridViewTextBoxColumn1
            // 
            this.memberProvinceDataGridViewTextBoxColumn1.DataPropertyName = "Member_Province";
            this.memberProvinceDataGridViewTextBoxColumn1.HeaderText = "Province";
            this.memberProvinceDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.memberProvinceDataGridViewTextBoxColumn1.Name = "memberProvinceDataGridViewTextBoxColumn1";
            this.memberProvinceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // memberPostalCodeDataGridViewTextBoxColumn1
            // 
            this.memberPostalCodeDataGridViewTextBoxColumn1.DataPropertyName = "Member_Postal_Code";
            this.memberPostalCodeDataGridViewTextBoxColumn1.HeaderText = "Postal Code";
            this.memberPostalCodeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.memberPostalCodeDataGridViewTextBoxColumn1.Name = "memberPostalCodeDataGridViewTextBoxColumn1";
            this.memberPostalCodeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // memberGenderDataGridViewTextBoxColumn1
            // 
            this.memberGenderDataGridViewTextBoxColumn1.DataPropertyName = "Member_Gender";
            this.memberGenderDataGridViewTextBoxColumn1.HeaderText = "Gender";
            this.memberGenderDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.memberGenderDataGridViewTextBoxColumn1.Name = "memberGenderDataGridViewTextBoxColumn1";
            this.memberGenderDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // memberDOBDataGridViewTextBoxColumn1
            // 
            this.memberDOBDataGridViewTextBoxColumn1.DataPropertyName = "Member_DOB";
            this.memberDOBDataGridViewTextBoxColumn1.HeaderText = "Date of Birth";
            this.memberDOBDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.memberDOBDataGridViewTextBoxColumn1.Name = "memberDOBDataGridViewTextBoxColumn1";
            this.memberDOBDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // memberJoinDateDataGridViewTextBoxColumn1
            // 
            this.memberJoinDateDataGridViewTextBoxColumn1.DataPropertyName = "Member_Join_Date";
            this.memberJoinDateDataGridViewTextBoxColumn1.HeaderText = "Join Date";
            this.memberJoinDateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.memberJoinDateDataGridViewTextBoxColumn1.Name = "memberJoinDateDataGridViewTextBoxColumn1";
            this.memberJoinDateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // memberStatusDataGridViewTextBoxColumn1
            // 
            this.memberStatusDataGridViewTextBoxColumn1.DataPropertyName = "Member_Status";
            this.memberStatusDataGridViewTextBoxColumn1.HeaderText = "Status";
            this.memberStatusDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.memberStatusDataGridViewTextBoxColumn1.Name = "memberStatusDataGridViewTextBoxColumn1";
            this.memberStatusDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // emergencyContactNameDataGridViewTextBoxColumn1
            // 
            this.emergencyContactNameDataGridViewTextBoxColumn1.DataPropertyName = "Emergency_Contact_Name";
            this.emergencyContactNameDataGridViewTextBoxColumn1.HeaderText = "Emergency Contact Name";
            this.emergencyContactNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.emergencyContactNameDataGridViewTextBoxColumn1.Name = "emergencyContactNameDataGridViewTextBoxColumn1";
            this.emergencyContactNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // emergencyContactNumberDataGridViewTextBoxColumn1
            // 
            this.emergencyContactNumberDataGridViewTextBoxColumn1.DataPropertyName = "Emergency_Contact_Number";
            this.emergencyContactNumberDataGridViewTextBoxColumn1.HeaderText = "Emergency Mobile Number";
            this.emergencyContactNumberDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.emergencyContactNumberDataGridViewTextBoxColumn1.Name = "emergencyContactNumberDataGridViewTextBoxColumn1";
            this.emergencyContactNumberDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // emergencyContactRelationshipDataGridViewTextBoxColumn1
            // 
            this.emergencyContactRelationshipDataGridViewTextBoxColumn1.DataPropertyName = "Emergency_Contact_Relationship";
            this.emergencyContactRelationshipDataGridViewTextBoxColumn1.HeaderText = "Emergency Contact Relationship";
            this.emergencyContactRelationshipDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.emergencyContactRelationshipDataGridViewTextBoxColumn1.Name = "emergencyContactRelationshipDataGridViewTextBoxColumn1";
            this.emergencyContactRelationshipDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // memberBindingSource1
            // 
            this.memberBindingSource1.DataMember = "Member";
            this.memberBindingSource1.DataSource = this.groupWst23DataSet1;
            // 
            // MemberDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "MemberDetailsForm";
            this.Text = "MemberDetailsForm";
            this.Load += new System.EventHandler(this.MemberDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst23DataSet1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupWst23DataSet groupWst23DataSet1;
        private GroupWst23DataSetTableAdapters.MemberTableAdapter memberTableAdapter1;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.BindingSource memberBindingSource1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2TextBox SearchMemberByIDTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Member_FName;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberLNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberTelephoneDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberPhoneNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberEmailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberStreetNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberStreetNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberCityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberProvinceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberPostalCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberGenderDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberDOBDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberJoinDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberStatusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emergencyContactNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emergencyContactNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emergencyContactRelationshipDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label1;
    }
}