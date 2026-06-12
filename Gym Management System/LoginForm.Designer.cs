namespace Gym_Management_System
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginAsPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.ForgettonPassWordLabel = new System.Windows.Forms.LinkLabel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.ClearBtn = new Guna.UI2.WinForms.Guna2Button();
            this.LoginButton = new Guna.UI2.WinForms.Guna2Button();
            this.LoginAsRecepRadioButton = new Guna.UI2.WinForms.Guna2RadioButton();
            this.LoginAsTrainerRadioButton = new Guna.UI2.WinForms.Guna2RadioButton();
            this.LoginAsManagerRadioButton = new Guna.UI2.WinForms.Guna2RadioButton();
            this.LoginPasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.LoginUsernameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ShowPasswordCheckBox = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.groupWst23DataSet = new Gym_Management_System.GroupWst23DataSet();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginTableAdapter = new Gym_Management_System.GroupWst23DataSetTableAdapters.LoginTableAdapter();
            this.tableAdapterManager = new Gym_Management_System.GroupWst23DataSetTableAdapters.TableAdapterManager();
            this.loginJoinTableAdapter1 = new Gym_Management_System.GroupWst23DataSetTableAdapters.LoginJoinTableAdapter();
            this.loginJoinTableAdapter2 = new Gym_Management_System.GroupWst23DataSetTableAdapters.LoginJoinTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2Panel1.SuspendLayout();
            this.LoginAsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst23DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.LoginAsPanel);
            this.guna2Panel1.CustomBorderThickness = new System.Windows.Forms.Padding(10);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1839, 866);
            this.guna2Panel1.TabIndex = 1;
            this.guna2Panel1.UseTransparentBackground = true;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Location = new System.Drawing.Point(349, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1224, 67);
            this.label1.TabIndex = 12;
            this.label1.Text = "UKZN SPORT GYM MANAGEMENT SYSTEM";
            // 
            // LoginAsPanel
            // 
            this.LoginAsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LoginAsPanel.BorderColor = System.Drawing.Color.Transparent;
            this.LoginAsPanel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.LoginAsPanel.BorderThickness = 6;
            this.LoginAsPanel.Controls.Add(this.label2);
            this.LoginAsPanel.Controls.Add(this.ForgettonPassWordLabel);
            this.LoginAsPanel.Controls.Add(this.guna2Separator1);
            this.LoginAsPanel.Controls.Add(this.ClearBtn);
            this.LoginAsPanel.Controls.Add(this.LoginButton);
            this.LoginAsPanel.Controls.Add(this.LoginAsRecepRadioButton);
            this.LoginAsPanel.Controls.Add(this.LoginAsTrainerRadioButton);
            this.LoginAsPanel.Controls.Add(this.LoginAsManagerRadioButton);
            this.LoginAsPanel.Controls.Add(this.LoginPasswordTextBox);
            this.LoginAsPanel.Controls.Add(this.LoginUsernameTextBox);
            this.LoginAsPanel.FillColor = System.Drawing.Color.Transparent;
            this.LoginAsPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.LoginAsPanel.Location = new System.Drawing.Point(543, 199);
            this.LoginAsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.LoginAsPanel.Name = "LoginAsPanel";
            this.LoginAsPanel.Size = new System.Drawing.Size(881, 533);
            this.LoginAsPanel.TabIndex = 0;
            this.LoginAsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginAsPanel_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Goudy Stout", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label2.Location = new System.Drawing.Point(240, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 59);
            this.label2.TabIndex = 12;
            this.label2.Text = "Log in";
            // 
            // ForgettonPassWordLabel
            // 
            this.ForgettonPassWordLabel.AutoSize = true;
            this.ForgettonPassWordLabel.Location = new System.Drawing.Point(211, 331);
            this.ForgettonPassWordLabel.Name = "ForgettonPassWordLabel";
            this.ForgettonPassWordLabel.Size = new System.Drawing.Size(109, 16);
            this.ForgettonPassWordLabel.TabIndex = 9;
            this.ForgettonPassWordLabel.TabStop = true;
            this.ForgettonPassWordLabel.Text = "Forgot Password";
            this.ForgettonPassWordLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForgettonPassWordLabel_LinkClicked);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 340);
            this.guna2Separator1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(881, 18);
            this.guna2Separator1.TabIndex = 7;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Animated = true;
            this.ClearBtn.AutoRoundedCorners = true;
            this.ClearBtn.BackColor = System.Drawing.Color.Transparent;
            this.ClearBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ClearBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ClearBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ClearBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ClearBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClearBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ClearBtn.ForeColor = System.Drawing.Color.White;
            this.ClearBtn.Location = new System.Drawing.Point(213, 438);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(192, 46);
            this.ClearBtn.TabIndex = 6;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Animated = true;
            this.LoginButton.AutoRoundedCorners = true;
            this.LoginButton.BackColor = System.Drawing.Color.Transparent;
            this.LoginButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LoginButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LoginButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoginButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LoginButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(461, 438);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(192, 46);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Login";
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoginAsRecepRadioButton
            // 
            this.LoginAsRecepRadioButton.AutoSize = true;
            this.LoginAsRecepRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.LoginAsRecepRadioButton.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LoginAsRecepRadioButton.CheckedState.BorderThickness = 0;
            this.LoginAsRecepRadioButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LoginAsRecepRadioButton.CheckedState.InnerColor = System.Drawing.Color.White;
            this.LoginAsRecepRadioButton.CheckedState.InnerOffset = -4;
            this.LoginAsRecepRadioButton.Location = new System.Drawing.Point(437, 366);
            this.LoginAsRecepRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.LoginAsRecepRadioButton.Name = "LoginAsRecepRadioButton";
            this.LoginAsRecepRadioButton.Size = new System.Drawing.Size(103, 20);
            this.LoginAsRecepRadioButton.TabIndex = 4;
            this.LoginAsRecepRadioButton.Text = "Receptionist";
            this.LoginAsRecepRadioButton.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.LoginAsRecepRadioButton.UncheckedState.BorderThickness = 2;
            this.LoginAsRecepRadioButton.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.LoginAsRecepRadioButton.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.LoginAsRecepRadioButton.UseVisualStyleBackColor = false;
            this.LoginAsRecepRadioButton.CheckedChanged += new System.EventHandler(this.LoginAsRecepRadioButton_CheckedChanged);
            // 
            // LoginAsTrainerRadioButton
            // 
            this.LoginAsTrainerRadioButton.AutoSize = true;
            this.LoginAsTrainerRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.LoginAsTrainerRadioButton.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LoginAsTrainerRadioButton.CheckedState.BorderThickness = 0;
            this.LoginAsTrainerRadioButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LoginAsTrainerRadioButton.CheckedState.InnerColor = System.Drawing.Color.White;
            this.LoginAsTrainerRadioButton.CheckedState.InnerOffset = -4;
            this.LoginAsTrainerRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.LoginAsTrainerRadioButton.Location = new System.Drawing.Point(339, 366);
            this.LoginAsTrainerRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.LoginAsTrainerRadioButton.Name = "LoginAsTrainerRadioButton";
            this.LoginAsTrainerRadioButton.Size = new System.Drawing.Size(75, 21);
            this.LoginAsTrainerRadioButton.TabIndex = 3;
            this.LoginAsTrainerRadioButton.Text = "Trainer";
            this.LoginAsTrainerRadioButton.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.LoginAsTrainerRadioButton.UncheckedState.BorderThickness = 2;
            this.LoginAsTrainerRadioButton.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.LoginAsTrainerRadioButton.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.LoginAsTrainerRadioButton.UseVisualStyleBackColor = false;
            this.LoginAsTrainerRadioButton.CheckedChanged += new System.EventHandler(this.LoginAsTrainerRadioButton_CheckedChanged);
            // 
            // LoginAsManagerRadioButton
            // 
            this.LoginAsManagerRadioButton.AutoSize = true;
            this.LoginAsManagerRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.LoginAsManagerRadioButton.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LoginAsManagerRadioButton.CheckedState.BorderThickness = 0;
            this.LoginAsManagerRadioButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LoginAsManagerRadioButton.CheckedState.InnerColor = System.Drawing.Color.White;
            this.LoginAsManagerRadioButton.CheckedState.InnerOffset = -4;
            this.LoginAsManagerRadioButton.Location = new System.Drawing.Point(243, 366);
            this.LoginAsManagerRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.LoginAsManagerRadioButton.Name = "LoginAsManagerRadioButton";
            this.LoginAsManagerRadioButton.Size = new System.Drawing.Size(82, 20);
            this.LoginAsManagerRadioButton.TabIndex = 2;
            this.LoginAsManagerRadioButton.Text = "Manager";
            this.LoginAsManagerRadioButton.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.LoginAsManagerRadioButton.UncheckedState.BorderThickness = 2;
            this.LoginAsManagerRadioButton.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.LoginAsManagerRadioButton.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.LoginAsManagerRadioButton.UseVisualStyleBackColor = false;
            this.LoginAsManagerRadioButton.CheckedChanged += new System.EventHandler(this.LoginAsManagerRadioButton_CheckedChanged);
            // 
            // LoginPasswordTextBox
            // 
            this.LoginPasswordTextBox.Animated = true;
            this.LoginPasswordTextBox.AutoRoundedCorners = true;
            this.LoginPasswordTextBox.BackColor = System.Drawing.Color.Transparent;
            this.LoginPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LoginPasswordTextBox.DefaultText = "";
            this.LoginPasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LoginPasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LoginPasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LoginPasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LoginPasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LoginPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LoginPasswordTextBox.ForeColor = System.Drawing.Color.Black;
            this.LoginPasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LoginPasswordTextBox.IconRight = global::Gym_Management_System.Properties.Resources.eyes_open;
            this.LoginPasswordTextBox.Location = new System.Drawing.Point(191, 276);
            this.LoginPasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginPasswordTextBox.Name = "LoginPasswordTextBox";
            this.LoginPasswordTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoginPasswordTextBox.PlaceholderText = "Password";
            this.LoginPasswordTextBox.SelectedText = "";
            this.LoginPasswordTextBox.Size = new System.Drawing.Size(440, 50);
            this.LoginPasswordTextBox.TabIndex = 1;
            this.LoginPasswordTextBox.IconRightClick += new System.EventHandler(this.LoginPasswordTextBox_IconRightClick);
            this.LoginPasswordTextBox.TextChanged += new System.EventHandler(this.LoginPasswordTextBox_TextChanged);
            // 
            // LoginUsernameTextBox
            // 
            this.LoginUsernameTextBox.Animated = true;
            this.LoginUsernameTextBox.AutoRoundedCorners = true;
            this.LoginUsernameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.LoginUsernameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LoginUsernameTextBox.DefaultText = "";
            this.LoginUsernameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LoginUsernameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LoginUsernameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LoginUsernameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LoginUsernameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LoginUsernameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LoginUsernameTextBox.ForeColor = System.Drawing.Color.Black;
            this.LoginUsernameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LoginUsernameTextBox.Location = new System.Drawing.Point(191, 202);
            this.LoginUsernameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginUsernameTextBox.Name = "LoginUsernameTextBox";
            this.LoginUsernameTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoginUsernameTextBox.PlaceholderText = "Email Address";
            this.LoginUsernameTextBox.SelectedText = "";
            this.LoginUsernameTextBox.Size = new System.Drawing.Size(440, 50);
            this.LoginUsernameTextBox.TabIndex = 0;
            this.LoginUsernameTextBox.TextChanged += new System.EventHandler(this.LoginUsernameTextBox_TextChanged);
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.ShowPasswordCheckBox.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.ShowPasswordCheckBox.Image = global::Gym_Management_System.Properties.Resources.Menu;
            this.ShowPasswordCheckBox.ImageOffset = new System.Drawing.Point(0, 0);
            this.ShowPasswordCheckBox.ImageRotate = 0F;
            this.ShowPasswordCheckBox.IndicateFocus = true;
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(1080, 496);
            this.ShowPasswordCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(133, 30);
            this.ShowPasswordCheckBox.TabIndex = 1;
            this.ShowPasswordCheckBox.UseTransparentBackground = true;
            this.ShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckBox_CheckedChanged);
            // 
            // groupWst23DataSet
            // 
            this.groupWst23DataSet.DataSetName = "GroupWst23DataSet";
            this.groupWst23DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataMember = "Login";
            this.loginBindingSource.DataSource = this.groupWst23DataSet;
            // 
            // loginTableAdapter
            // 
            this.loginTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArchiveMemberTableAdapter = null;
            this.tableAdapterManager.ArchiveStaffTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FreePlanRegisterTableTableAdapter = null;
            this.tableAdapterManager.LoginTableAdapter = this.loginTableAdapter;
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
            // loginJoinTableAdapter1
            // 
            this.loginJoinTableAdapter1.ClearBeforeFill = true;
            // 
            // loginJoinTableAdapter2
            // 
            this.loginJoinTableAdapter2.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1839, 866);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.ShowPasswordCheckBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.LoginAsPanel.ResumeLayout(false);
            this.LoginAsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst23DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2GradientPanel LoginAsPanel;
        private Guna.UI2.WinForms.Guna2TextBox LoginUsernameTextBox;
        private Guna.UI2.WinForms.Guna2RadioButton LoginAsManagerRadioButton;
        private Guna.UI2.WinForms.Guna2TextBox LoginPasswordTextBox;
        private Guna.UI2.WinForms.Guna2RadioButton LoginAsRecepRadioButton;
        private Guna.UI2.WinForms.Guna2RadioButton LoginAsTrainerRadioButton;
        private Guna.UI2.WinForms.Guna2Button ClearBtn;
        private Guna.UI2.WinForms.Guna2Button LoginButton;
        private GroupWst23DataSet groupWst23DataSet;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private GroupWst23DataSetTableAdapters.LoginTableAdapter loginTableAdapter;
        private GroupWst23DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Guna.UI2.WinForms.Guna2ImageCheckBox ShowPasswordCheckBox;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.LinkLabel ForgettonPassWordLabel;
        private GroupWst23DataSetTableAdapters.LoginJoinTableAdapter loginJoinTableAdapter1;
        private GroupWst23DataSetTableAdapters.LoginJoinTableAdapter loginJoinTableAdapter2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}