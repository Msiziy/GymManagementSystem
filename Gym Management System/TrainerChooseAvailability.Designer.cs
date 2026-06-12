namespace Gym_Management_System
{
    partial class TrainerChooseAvailability
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
			this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
			this.TrainerTimeSlotDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
			this.timeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Availability = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.timeSlotBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.groupWst23DataSet = new Gym_Management_System.GroupWst23DataSet();
			this.AvalabiltyDateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.TrainerAvailabityClearBtn = new Guna.UI2.WinForms.Guna2Button();
			this.label2 = new System.Windows.Forms.Label();
			this.TrainerSave_AbilityBtn = new Guna.UI2.WinForms.Guna2Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.time_SlotTableAdapter = new Gym_Management_System.GroupWst23DataSetTableAdapters.Time_SlotTableAdapter();
			this.staffTableAdapter1 = new Gym_Management_System.GroupWst23DataSetTableAdapters.StaffTableAdapter();
			this.trainer_ScheduleTableAdapter1 = new Gym_Management_System.GroupWst23DataSetTableAdapters.Trainer_ScheduleTableAdapter();
			this.label1 = new System.Windows.Forms.Label();
			this.guna2GroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.TrainerTimeSlotDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.timeSlotBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupWst23DataSet)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// guna2GroupBox1
			// 
			this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
			this.guna2GroupBox1.Controls.Add(this.TrainerTimeSlotDataGridView);
			this.guna2GroupBox1.Controls.Add(this.AvalabiltyDateTimePicker1);
			this.guna2GroupBox1.Controls.Add(this.TrainerAvailabityClearBtn);
			this.guna2GroupBox1.Controls.Add(this.label2);
			this.guna2GroupBox1.Controls.Add(this.TrainerSave_AbilityBtn);
			this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Gray;
			this.guna2GroupBox1.FillColor = System.Drawing.Color.Silver;
			this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
			this.guna2GroupBox1.Location = new System.Drawing.Point(225, 239);
			this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.guna2GroupBox1.Name = "guna2GroupBox1";
			this.guna2GroupBox1.Size = new System.Drawing.Size(1148, 517);
			this.guna2GroupBox1.TabIndex = 3;
			this.guna2GroupBox1.Text = "Choose Your Daily Availability:";
			// 
			// TrainerTimeSlotDataGridView
			// 
			this.TrainerTimeSlotDataGridView.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(203)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.TrainerTimeSlotDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.TrainerTimeSlotDataGridView.AutoGenerateColumns = false;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(121)))), ((int)(((byte)(130)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(121)))), ((int)(((byte)(130)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.TrainerTimeSlotDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.TrainerTimeSlotDataGridView.ColumnHeadersHeight = 22;
			this.TrainerTimeSlotDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.TrainerTimeSlotDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timeIDDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn,
            this.Availability});
			this.TrainerTimeSlotDataGridView.DataSource = this.timeSlotBindingSource;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(203)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.TrainerTimeSlotDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
			this.TrainerTimeSlotDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.TrainerTimeSlotDataGridView.Location = new System.Drawing.Point(90, 146);
			this.TrainerTimeSlotDataGridView.Name = "TrainerTimeSlotDataGridView";
			this.TrainerTimeSlotDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.TrainerTimeSlotDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.TrainerTimeSlotDataGridView.RowHeadersVisible = false;
			this.TrainerTimeSlotDataGridView.RowHeadersWidth = 51;
			this.TrainerTimeSlotDataGridView.RowTemplate.Height = 24;
			this.TrainerTimeSlotDataGridView.Size = new System.Drawing.Size(999, 150);
			this.TrainerTimeSlotDataGridView.TabIndex = 2;
			this.TrainerTimeSlotDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.TrainerTimeSlotDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.TrainerTimeSlotDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.TrainerTimeSlotDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.TrainerTimeSlotDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.TrainerTimeSlotDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.TrainerTimeSlotDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.TrainerTimeSlotDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.TrainerTimeSlotDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.TrainerTimeSlotDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TrainerTimeSlotDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.TrainerTimeSlotDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.TrainerTimeSlotDataGridView.ThemeStyle.HeaderStyle.Height = 22;
			this.TrainerTimeSlotDataGridView.ThemeStyle.ReadOnly = false;
			this.TrainerTimeSlotDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.TrainerTimeSlotDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.TrainerTimeSlotDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TrainerTimeSlotDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
			this.TrainerTimeSlotDataGridView.ThemeStyle.RowsStyle.Height = 24;
			this.TrainerTimeSlotDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.TrainerTimeSlotDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// timeIDDataGridViewTextBoxColumn
			// 
			this.timeIDDataGridViewTextBoxColumn.DataPropertyName = "Time_ID";
			this.timeIDDataGridViewTextBoxColumn.HeaderText = "Time_ID";
			this.timeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.timeIDDataGridViewTextBoxColumn.Name = "timeIDDataGridViewTextBoxColumn";
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
			// Availability
			// 
			this.Availability.HeaderText = "Select Availability";
			this.Availability.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
			this.Availability.MinimumWidth = 6;
			this.Availability.Name = "Availability";
			// 
			// timeSlotBindingSource
			// 
			this.timeSlotBindingSource.DataMember = "Time_Slot";
			this.timeSlotBindingSource.DataSource = this.groupWst23DataSet;
			// 
			// groupWst23DataSet
			// 
			this.groupWst23DataSet.DataSetName = "GroupWst23DataSet";
			this.groupWst23DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// AvalabiltyDateTimePicker1
			// 
			this.AvalabiltyDateTimePicker1.AutoRoundedCorners = true;
			this.AvalabiltyDateTimePicker1.Checked = true;
			this.AvalabiltyDateTimePicker1.FillColor = System.Drawing.Color.LightGray;
			this.AvalabiltyDateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.AvalabiltyDateTimePicker1.ForeColor = System.Drawing.Color.White;
			this.AvalabiltyDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this.AvalabiltyDateTimePicker1.Location = new System.Drawing.Point(164, 81);
			this.AvalabiltyDateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
			this.AvalabiltyDateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.AvalabiltyDateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.AvalabiltyDateTimePicker1.Name = "AvalabiltyDateTimePicker1";
			this.AvalabiltyDateTimePicker1.Size = new System.Drawing.Size(267, 44);
			this.AvalabiltyDateTimePicker1.TabIndex = 1;
			this.AvalabiltyDateTimePicker1.Value = new System.DateTime(2026, 5, 27, 11, 25, 44, 290);
			// 
			// TrainerAvailabityClearBtn
			// 
			this.TrainerAvailabityClearBtn.Animated = true;
			this.TrainerAvailabityClearBtn.AutoRoundedCorners = true;
			this.TrainerAvailabityClearBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.TrainerAvailabityClearBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.TrainerAvailabityClearBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.TrainerAvailabityClearBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.TrainerAvailabityClearBtn.FillColor = System.Drawing.Color.Teal;
			this.TrainerAvailabityClearBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.TrainerAvailabityClearBtn.ForeColor = System.Drawing.Color.White;
			this.TrainerAvailabityClearBtn.IndicateFocus = true;
			this.TrainerAvailabityClearBtn.Location = new System.Drawing.Point(914, 403);
			this.TrainerAvailabityClearBtn.Margin = new System.Windows.Forms.Padding(4);
			this.TrainerAvailabityClearBtn.Name = "TrainerAvailabityClearBtn";
			this.TrainerAvailabityClearBtn.Size = new System.Drawing.Size(175, 57);
			this.TrainerAvailabityClearBtn.TabIndex = 23;
			this.TrainerAvailabityClearBtn.Text = "Clear";
			this.TrainerAvailabityClearBtn.Click += new System.EventHandler(this.TrainerAvailabityClearBtn_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(109, 81);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Date:";
			// 
			// TrainerSave_AbilityBtn
			// 
			this.TrainerSave_AbilityBtn.Animated = true;
			this.TrainerSave_AbilityBtn.AutoRoundedCorners = true;
			this.TrainerSave_AbilityBtn.BackColor = System.Drawing.Color.Transparent;
			this.TrainerSave_AbilityBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.TrainerSave_AbilityBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.TrainerSave_AbilityBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.TrainerSave_AbilityBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.TrainerSave_AbilityBtn.FillColor = System.Drawing.Color.Teal;
			this.TrainerSave_AbilityBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.TrainerSave_AbilityBtn.ForeColor = System.Drawing.Color.White;
			this.TrainerSave_AbilityBtn.IndicateFocus = true;
			this.TrainerSave_AbilityBtn.Location = new System.Drawing.Point(690, 403);
			this.TrainerSave_AbilityBtn.Margin = new System.Windows.Forms.Padding(4);
			this.TrainerSave_AbilityBtn.Name = "TrainerSave_AbilityBtn";
			this.TrainerSave_AbilityBtn.Size = new System.Drawing.Size(182, 57);
			this.TrainerSave_AbilityBtn.TabIndex = 22;
			this.TrainerSave_AbilityBtn.Text = "Save";
			this.TrainerSave_AbilityBtn.Click += new System.EventHandler(this.TrainerSave_AbilityBtn_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.guna2Panel1);
			this.panel2.Controls.Add(this.guna2GroupBox1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1859, 1020);
			this.panel2.TabIndex = 23;
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.BackgroundImage = global::Gym_Management_System.Properties.Resources.Calender;
			this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.guna2Panel1.Location = new System.Drawing.Point(16, 15);
			this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new System.Drawing.Size(79, 62);
			this.guna2Panel1.TabIndex = 2;
			// 
			// time_SlotTableAdapter
			// 
			this.time_SlotTableAdapter.ClearBeforeFill = true;
			// 
			// staffTableAdapter1
			// 
			this.staffTableAdapter1.ClearBeforeFill = true;
			// 
			// trainer_ScheduleTableAdapter1
			// 
			this.trainer_ScheduleTableAdapter1.ClearBeforeFill = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(102, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(130, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = "My Availability";
			// 
			// TrainerChooseAvailability
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1859, 1020);
			this.Controls.Add(this.panel2);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "TrainerChooseAvailability";
			this.Text = "ChooseShifts";
			this.Load += new System.EventHandler(this.TrainerShifts_Load);
			this.guna2GroupBox1.ResumeLayout(false);
			this.guna2GroupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.TrainerTimeSlotDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.timeSlotBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupWst23DataSet)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private GroupWst23DataSet groupWst23DataSet;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2DateTimePicker AvalabiltyDateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button TrainerSave_AbilityBtn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button TrainerAvailabityClearBtn;
       // private System.Windows.Forms.DataGridViewTextBoxColumn timeLabelDataGridViewTextBoxColumn1;
        private Guna.UI2.WinForms.Guna2DataGridView TrainerTimeSlotDataGridView;
        private System.Windows.Forms.BindingSource timeSlotBindingSource;
        private GroupWst23DataSetTableAdapters.Time_SlotTableAdapter time_SlotTableAdapter;
        private GroupWst23DataSetTableAdapters.StaffTableAdapter staffTableAdapter1;
        private GroupWst23DataSetTableAdapters.Trainer_ScheduleTableAdapter trainer_ScheduleTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Availability;
		private System.Windows.Forms.Label label1;
	}
}