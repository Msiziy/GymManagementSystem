namespace Gym_Management_System
{
    partial class PaidPlanGymRegister
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.RegisterListGroupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.SearchByDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.RegisterDataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.paidPlanRegisterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupWst23DataSet = new Gym_Management_System.GroupWst23DataSet();
            this.paidPlanRegisterTableAdapter1 = new Gym_Management_System.GroupWst23DataSetTableAdapters.PaidPlanRegisterTableAdapter();
            this.registerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1.SuspendLayout();
            this.RegisterListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paidPlanRegisterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst23DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.guna2Panel1.Controls.Add(this.RegisterListGroupBox);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1561, 870);
            this.guna2Panel1.TabIndex = 0;
            // 
            // RegisterListGroupBox
            // 
            this.RegisterListGroupBox.Controls.Add(this.SearchByDateTimePicker);
            this.RegisterListGroupBox.Controls.Add(this.label1);
            this.RegisterListGroupBox.Controls.Add(this.RegisterDataGridView1);
            this.RegisterListGroupBox.CustomBorderColor = System.Drawing.Color.Gray;
            this.RegisterListGroupBox.FillColor = System.Drawing.Color.Silver;
            this.RegisterListGroupBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterListGroupBox.ForeColor = System.Drawing.Color.Black;
            this.RegisterListGroupBox.Location = new System.Drawing.Point(224, 125);
            this.RegisterListGroupBox.Name = "RegisterListGroupBox";
            this.RegisterListGroupBox.Size = new System.Drawing.Size(1250, 627);
            this.RegisterListGroupBox.TabIndex = 3;
            this.RegisterListGroupBox.Text = "Register List";
            this.RegisterListGroupBox.Click += new System.EventHandler(this.RegisterListGroupBox_Click);
            // 
            // SearchByDateTimePicker
            // 
            this.SearchByDateTimePicker.Location = new System.Drawing.Point(353, 69);
            this.SearchByDateTimePicker.Name = "SearchByDateTimePicker";
            this.SearchByDateTimePicker.Size = new System.Drawing.Size(350, 30);
            this.SearchByDateTimePicker.TabIndex = 3;
            this.SearchByDateTimePicker.ValueChanged += new System.EventHandler(this.SearchByDateTimePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(177, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search By Date";
            // 
            // RegisterDataGridView1
            // 
            this.RegisterDataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.RegisterDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.RegisterDataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(121)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(121)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RegisterDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.RegisterDataGridView1.ColumnHeadersHeight = 25;
            this.RegisterDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.RegisterDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.registerIDDataGridViewTextBoxColumn,
            this.memberIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.timeInDataGridViewTextBoxColumn,
            this.timeOutDataGridViewTextBoxColumn});
            this.RegisterDataGridView1.DataSource = this.paidPlanRegisterBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RegisterDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.RegisterDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RegisterDataGridView1.Location = new System.Drawing.Point(122, 120);
            this.RegisterDataGridView1.Name = "RegisterDataGridView1";
            this.RegisterDataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RegisterDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.RegisterDataGridView1.RowHeadersVisible = false;
            this.RegisterDataGridView1.RowHeadersWidth = 51;
            this.RegisterDataGridView1.RowTemplate.Height = 24;
            this.RegisterDataGridView1.Size = new System.Drawing.Size(930, 430);
            this.RegisterDataGridView1.TabIndex = 0;
            this.RegisterDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.RegisterDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.RegisterDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.RegisterDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.RegisterDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.RegisterDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.RegisterDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RegisterDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.RegisterDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.RegisterDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.RegisterDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.RegisterDataGridView1.ThemeStyle.HeaderStyle.Height = 25;
            this.RegisterDataGridView1.ThemeStyle.ReadOnly = false;
            this.RegisterDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.RegisterDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.RegisterDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.RegisterDataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.RegisterDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RegisterDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // paidPlanRegisterBindingSource
            // 
            this.paidPlanRegisterBindingSource.DataMember = "PaidPlanRegister";
            this.paidPlanRegisterBindingSource.DataSource = this.groupWst23DataSet;
            // 
            // groupWst23DataSet
            // 
            this.groupWst23DataSet.DataSetName = "GroupWst23DataSet";
            this.groupWst23DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paidPlanRegisterTableAdapter1
            // 
            this.paidPlanRegisterTableAdapter1.ClearBeforeFill = true;
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
            this.memberIDDataGridViewTextBoxColumn.HeaderText = "Member ID";
            this.memberIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.memberIDDataGridViewTextBoxColumn.Name = "memberIDDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // timeInDataGridViewTextBoxColumn
            // 
            this.timeInDataGridViewTextBoxColumn.DataPropertyName = "Time_In";
            this.timeInDataGridViewTextBoxColumn.HeaderText = "Time In";
            this.timeInDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeInDataGridViewTextBoxColumn.Name = "timeInDataGridViewTextBoxColumn";
            // 
            // timeOutDataGridViewTextBoxColumn
            // 
            this.timeOutDataGridViewTextBoxColumn.DataPropertyName = "Time_Out";
            this.timeOutDataGridViewTextBoxColumn.HeaderText = "Time Out";
            this.timeOutDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeOutDataGridViewTextBoxColumn.Name = "timeOutDataGridViewTextBoxColumn";
            // 
            // PaidPlanGymRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1561, 870);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "PaidPlanGymRegister";
            this.Text = "PaidPlanGymRegister";
            this.Load += new System.EventHandler(this.PaidPlanGymRegister_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.RegisterListGroupBox.ResumeLayout(false);
            this.RegisterListGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paidPlanRegisterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst23DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2GroupBox RegisterListGroupBox;
        private Guna.UI2.WinForms.Guna2DataGridView RegisterDataGridView1;
        private System.Windows.Forms.BindingSource paidPlanRegisterBindingSource;
        private GroupWst23DataSet groupWst23DataSet;
        private GroupWst23DataSetTableAdapters.PaidPlanRegisterTableAdapter paidPlanRegisterTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker SearchByDateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn registerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeOutDataGridViewTextBoxColumn;
    }
}