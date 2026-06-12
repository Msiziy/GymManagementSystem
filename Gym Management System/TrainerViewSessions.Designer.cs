namespace Gym_Management_System
{
    partial class TrainerViewSessions
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.TrainerStatus_comboBox = new Guna.UI2.WinForms.Guna2ComboBox();
			this.TrainerEnd_DateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.TrainerStart_DateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
			this.ListOfSessionsDataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
			this.sessionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.memberIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.trainingSessionViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.groupWst23DataSet = new Gym_Management_System.GroupWst23DataSet();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.tableAdapterManager = new Gym_Management_System.GroupWst23DataSetTableAdapters.TableAdapterManager();
			this.trainingSessionView = new Gym_Management_System.GroupWst23DataSetTableAdapters.TrainingSessionView();
			this.trainingSessionView1 = new Gym_Management_System.GroupWst23DataSetTableAdapters.TrainingSessionView();
			this.training_SessionTableAdapter1 = new Gym_Management_System.GroupWst23DataSetTableAdapters.Training_SessionTableAdapter();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.guna2GroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ListOfSessionsDataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trainingSessionViewBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupWst23DataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.guna2GroupBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1819, 922);
			this.panel1.TabIndex = 0;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Silver;
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.TrainerStatus_comboBox);
			this.panel3.Controls.Add(this.TrainerEnd_DateTimePicker);
			this.panel3.Controls.Add(this.TrainerStart_DateTimePicker);
			this.panel3.Location = new System.Drawing.Point(84, 121);
			this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1714, 104);
			this.panel3.TabIndex = 10;
			// 
			// TrainerStatus_comboBox
			// 
			this.TrainerStatus_comboBox.AutoRoundedCorners = true;
			this.TrainerStatus_comboBox.BackColor = System.Drawing.Color.Transparent;
			this.TrainerStatus_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.TrainerStatus_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.TrainerStatus_comboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.TrainerStatus_comboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.TrainerStatus_comboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.TrainerStatus_comboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.TrainerStatus_comboBox.ItemHeight = 30;
			this.TrainerStatus_comboBox.Items.AddRange(new object[] {
            "Completed",
            "Pending"});
			this.TrainerStatus_comboBox.Location = new System.Drawing.Point(1355, 30);
			this.TrainerStatus_comboBox.Margin = new System.Windows.Forms.Padding(4);
			this.TrainerStatus_comboBox.Name = "TrainerStatus_comboBox";
			this.TrainerStatus_comboBox.Size = new System.Drawing.Size(153, 36);
			this.TrainerStatus_comboBox.TabIndex = 15;
			this.TrainerStatus_comboBox.SelectedIndexChanged += new System.EventHandler(this.TrainerStatus_comboBox_SelectedIndexChanged_1);
			// 
			// TrainerEnd_DateTimePicker
			// 
			this.TrainerEnd_DateTimePicker.AutoRoundedCorners = true;
			this.TrainerEnd_DateTimePicker.Checked = true;
			this.TrainerEnd_DateTimePicker.FillColor = System.Drawing.Color.LightGray;
			this.TrainerEnd_DateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.TrainerEnd_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this.TrainerEnd_DateTimePicker.Location = new System.Drawing.Point(706, 49);
			this.TrainerEnd_DateTimePicker.Margin = new System.Windows.Forms.Padding(4);
			this.TrainerEnd_DateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.TrainerEnd_DateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.TrainerEnd_DateTimePicker.Name = "TrainerEnd_DateTimePicker";
			this.TrainerEnd_DateTimePicker.Size = new System.Drawing.Size(260, 33);
			this.TrainerEnd_DateTimePicker.TabIndex = 8;
			this.TrainerEnd_DateTimePicker.Value = new System.DateTime(2026, 5, 27, 12, 11, 48, 535);
			this.TrainerEnd_DateTimePicker.ValueChanged += new System.EventHandler(this.TrainerEnd_DateTimePicker_ValueChanged_1);
			// 
			// TrainerStart_DateTimePicker
			// 
			this.TrainerStart_DateTimePicker.AutoRoundedCorners = true;
			this.TrainerStart_DateTimePicker.Checked = true;
			this.TrainerStart_DateTimePicker.FillColor = System.Drawing.Color.LightGray;
			this.TrainerStart_DateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.TrainerStart_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this.TrainerStart_DateTimePicker.Location = new System.Drawing.Point(59, 49);
			this.TrainerStart_DateTimePicker.Margin = new System.Windows.Forms.Padding(4);
			this.TrainerStart_DateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.TrainerStart_DateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.TrainerStart_DateTimePicker.Name = "TrainerStart_DateTimePicker";
			this.TrainerStart_DateTimePicker.Size = new System.Drawing.Size(263, 33);
			this.TrainerStart_DateTimePicker.TabIndex = 7;
			this.TrainerStart_DateTimePicker.Value = new System.DateTime(2026, 5, 27, 12, 11, 48, 535);
			this.TrainerStart_DateTimePicker.ValueChanged += new System.EventHandler(this.TrainerStart_DateTimePicker_ValueChanged);
			// 
			// guna2GroupBox1
			// 
			this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
			this.guna2GroupBox1.Controls.Add(this.ListOfSessionsDataGridView1);
			this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Gray;
			this.guna2GroupBox1.FillColor = System.Drawing.Color.Silver;
			this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
			this.guna2GroupBox1.Location = new System.Drawing.Point(84, 282);
			this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.guna2GroupBox1.Name = "guna2GroupBox1";
			this.guna2GroupBox1.Size = new System.Drawing.Size(1722, 611);
			this.guna2GroupBox1.TabIndex = 7;
			this.guna2GroupBox1.Text = "List of Sessions:";
			// 
			// ListOfSessionsDataGridView1
			// 
			this.ListOfSessionsDataGridView1.AllowUserToResizeRows = false;
			dataGridViewCellStyle17.BackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(203)))));
			dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.ListOfSessionsDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
			this.ListOfSessionsDataGridView1.AutoGenerateColumns = false;
			dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(121)))), ((int)(((byte)(130)))));
			dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(121)))), ((int)(((byte)(130)))));
			dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.ListOfSessionsDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
			this.ListOfSessionsDataGridView1.ColumnHeadersHeight = 22;
			this.ListOfSessionsDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.ListOfSessionsDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sessionIDDataGridViewTextBoxColumn,
            this.memberIDDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn5,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn});
			this.ListOfSessionsDataGridView1.DataSource = this.trainingSessionViewBindingSource;
			dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Gray;
			dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(203)))));
			dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.ListOfSessionsDataGridView1.DefaultCellStyle = dataGridViewCellStyle19;
			this.ListOfSessionsDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.ListOfSessionsDataGridView1.Location = new System.Drawing.Point(22, 76);
			this.ListOfSessionsDataGridView1.Name = "ListOfSessionsDataGridView1";
			this.ListOfSessionsDataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.ListOfSessionsDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
			this.ListOfSessionsDataGridView1.RowHeadersVisible = false;
			this.ListOfSessionsDataGridView1.RowHeadersWidth = 51;
			this.ListOfSessionsDataGridView1.RowTemplate.Height = 24;
			this.ListOfSessionsDataGridView1.Size = new System.Drawing.Size(1576, 150);
			this.ListOfSessionsDataGridView1.TabIndex = 0;
			this.ListOfSessionsDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.ListOfSessionsDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.ListOfSessionsDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.ListOfSessionsDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.ListOfSessionsDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.ListOfSessionsDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.ListOfSessionsDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.ListOfSessionsDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.ListOfSessionsDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.ListOfSessionsDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.ListOfSessionsDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.ListOfSessionsDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.ListOfSessionsDataGridView1.ThemeStyle.HeaderStyle.Height = 22;
			this.ListOfSessionsDataGridView1.ThemeStyle.ReadOnly = false;
			this.ListOfSessionsDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.ListOfSessionsDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.ListOfSessionsDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.ListOfSessionsDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gray;
			this.ListOfSessionsDataGridView1.ThemeStyle.RowsStyle.Height = 24;
			this.ListOfSessionsDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.ListOfSessionsDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// sessionIDDataGridViewTextBoxColumn
			// 
			this.sessionIDDataGridViewTextBoxColumn.DataPropertyName = "Session_ID";
			this.sessionIDDataGridViewTextBoxColumn.HeaderText = "Session ID";
			this.sessionIDDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.sessionIDDataGridViewTextBoxColumn.Name = "sessionIDDataGridViewTextBoxColumn";
			// 
			// memberIDDataGridViewTextBoxColumn
			// 
			this.memberIDDataGridViewTextBoxColumn.DataPropertyName = "Member_ID";
			this.memberIDDataGridViewTextBoxColumn.HeaderText = "Member ID";
			this.memberIDDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.memberIDDataGridViewTextBoxColumn.Name = "memberIDDataGridViewTextBoxColumn";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Session_Date";
			this.dataGridViewTextBoxColumn2.HeaderText = "Session Date";
			this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "Session_Status";
			this.dataGridViewTextBoxColumn6.HeaderText = "Session Status";
			this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "Session_Duration";
			this.dataGridViewTextBoxColumn5.HeaderText = "Session Duration";
			this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// startTimeDataGridViewTextBoxColumn
			// 
			this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "Start_Time";
			this.startTimeDataGridViewTextBoxColumn.HeaderText = "Session Start Time";
			this.startTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
			// 
			// endTimeDataGridViewTextBoxColumn
			// 
			this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "End_Time";
			this.endTimeDataGridViewTextBoxColumn.HeaderText = "Session End Time";
			this.endTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
			// 
			// trainingSessionViewBindingSource
			// 
			this.trainingSessionViewBindingSource.DataMember = "TrainingSessionView";
			this.trainingSessionViewBindingSource.DataSource = this.groupWst23DataSet;
			// 
			// groupWst23DataSet
			// 
			this.groupWst23DataSet.DataSetName = "GroupWst23DataSet";
			this.groupWst23DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(68, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(154, 25);
			this.label1.TabIndex = 3;
			this.label1.Text = "View Sessions";
			// 
			// panel2
			// 
			this.panel2.BackgroundImage = global::Gym_Management_System.Properties.Resources.IMG_0885;
			this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel2.Location = new System.Drawing.Point(15, 14);
			this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(48, 47);
			this.panel2.TabIndex = 2;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.ArchiveMemberTableAdapter = null;
			this.tableAdapterManager.ArchiveStaffTableAdapter = null;
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.Connection = null;
			this.tableAdapterManager.FreePlanRegisterTableTableAdapter = null;
			this.tableAdapterManager.LoginTableAdapter = null;
			this.tableAdapterManager.MembershipTableAdapter = null;
			this.tableAdapterManager.MemberTableAdapter = null;
			this.tableAdapterManager.PaidPlanRegisterTableAdapter = null;
			this.tableAdapterManager.PaymentTableAdapter = null;
			this.tableAdapterManager.Session_TableTableAdapter = null;
			this.tableAdapterManager.StaffTableAdapter = null;
			this.tableAdapterManager.Time_SlotTableAdapter = null;
			this.tableAdapterManager.Trainer_ScheduleTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = Gym_Management_System.GroupWst23DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// trainingSessionView
			// 
			this.trainingSessionView.ClearBeforeFill = true;
			// 
			// trainingSessionView1
			// 
			this.trainingSessionView1.ClearBeforeFill = true;
			// 
			// training_SessionTableAdapter1
			// 
			this.training_SessionTableAdapter1.ClearBeforeFill = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(56, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 20);
			this.label2.TabIndex = 19;
			this.label2.Text = "Date From:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(703, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 20);
			this.label3.TabIndex = 20;
			this.label3.Text = "Date To:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(1181, 46);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(142, 20);
			this.label4.TabIndex = 21;
			this.label4.Text = "Session Status:";
			// 
			// TrainerViewSessions
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1819, 922);
			this.Controls.Add(this.panel1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "TrainerViewSessions";
			this.Text = "ViewSessions";
			this.Load += new System.EventHandler(this.TrainerViewSessions_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.guna2GroupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ListOfSessionsDataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trainingSessionViewBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupWst23DataSet)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private GroupWst23DataSet groupWst23DataSet;
        private GroupWst23DataSetTableAdapters.TableAdapterManager tableAdapterManager;
       // private System.Windows.Forms.DataGridViewTextBoxColumn sessionDateDataGridViewTextBoxColumn;
       // private System.Windows.Forms.DataGridViewTextBoxColumn staffAttendanceDataGridViewTextBoxColumn;
       // private System.Windows.Forms.DataGridViewTextBoxColumn memberAttendanceDataGridViewTextBoxColumn;
      //  private System.Windows.Forms.DataGridViewTextBoxColumn sessionDurationDataGridViewTextBoxColumn;
       // private System.Windows.Forms.DataGridViewTextBoxColumn sessionCapacityDataGridViewTextBoxColumn;
      //  private System.Windows.Forms.DataGridViewTextBoxColumn sessionStatusDataGridViewTextBoxColumn;
      //  private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2DataGridView ListOfSessionsDataGridView1;
        private System.Windows.Forms.BindingSource trainingSessionViewBindingSource;
        private GroupWst23DataSetTableAdapters.TrainingSessionView trainingSessionView;
        private GroupWst23DataSetTableAdapters.TrainingSessionView trainingSessionView1;
        private GroupWst23DataSetTableAdapters.Training_SessionTableAdapter training_SessionTableAdapter1;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2ComboBox TrainerStatus_comboBox;
        private Guna.UI2.WinForms.Guna2DateTimePicker TrainerEnd_DateTimePicker;
        private Guna.UI2.WinForms.Guna2DateTimePicker TrainerStart_DateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
	}
}