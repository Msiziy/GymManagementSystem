namespace Gym_Management_System
{
    partial class ResetPasswordForm
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
            this.ResetPasswordPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.OldPassTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.OldPassLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ResetPassButton = new Guna.UI2.WinForms.Guna2Button();
            this.ConfirmPasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.NewPasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.EmailCheckTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ResetPasswordLabel = new System.Windows.Forms.Label();
            this.loginTableAdapter1 = new Gym_Management_System.GroupWst23DataSetTableAdapters.LoginTableAdapter();
            this.ResetPasswordPanel.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResetPasswordPanel
            // 
            this.ResetPasswordPanel.Controls.Add(this.guna2ShadowPanel1);
            this.ResetPasswordPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResetPasswordPanel.FillColor = System.Drawing.SystemColors.ScrollBar;
            this.ResetPasswordPanel.Location = new System.Drawing.Point(0, 0);
            this.ResetPasswordPanel.Name = "ResetPasswordPanel";
            this.ResetPasswordPanel.Size = new System.Drawing.Size(1312, 678);
            this.ResetPasswordPanel.TabIndex = 0;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.OldPassTextBox);
            this.guna2ShadowPanel1.Controls.Add(this.OldPassLabel);
            this.guna2ShadowPanel1.Controls.Add(this.label3);
            this.guna2ShadowPanel1.Controls.Add(this.label2);
            this.guna2ShadowPanel1.Controls.Add(this.label1);
            this.guna2ShadowPanel1.Controls.Add(this.ResetPassButton);
            this.guna2ShadowPanel1.Controls.Add(this.ConfirmPasswordTextBox);
            this.guna2ShadowPanel1.Controls.Add(this.NewPasswordTextBox);
            this.guna2ShadowPanel1.Controls.Add(this.EmailCheckTextBox);
            this.guna2ShadowPanel1.Controls.Add(this.ResetPasswordLabel);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.Silver;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(320, 78);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(745, 510);
            this.guna2ShadowPanel1.TabIndex = 0;
            // 
            // OldPassTextBox
            // 
            this.OldPassTextBox.Animated = true;
            this.OldPassTextBox.AutoRoundedCorners = true;
            this.OldPassTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OldPassTextBox.DefaultText = "";
            this.OldPassTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.OldPassTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.OldPassTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OldPassTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OldPassTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OldPassTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.OldPassTextBox.ForeColor = System.Drawing.Color.Black;
            this.OldPassTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OldPassTextBox.IconRight = global::Gym_Management_System.Properties.Resources.eyes_closed;
            this.OldPassTextBox.Location = new System.Drawing.Point(53, 234);
            this.OldPassTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OldPassTextBox.Name = "OldPassTextBox";
            this.OldPassTextBox.PlaceholderForeColor = System.Drawing.Color.Black;
            this.OldPassTextBox.PlaceholderText = "Old Password";
            this.OldPassTextBox.SelectedText = "";
            this.OldPassTextBox.Size = new System.Drawing.Size(323, 48);
            this.OldPassTextBox.TabIndex = 9;
            this.OldPassTextBox.IconRightClick += new System.EventHandler(this.OldPassTextBox_IconRightClick);
            // 
            // OldPassLabel
            // 
            this.OldPassLabel.AutoSize = true;
            this.OldPassLabel.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OldPassLabel.Location = new System.Drawing.Point(60, 207);
            this.OldPassLabel.Name = "OldPassLabel";
            this.OldPassLabel.Size = new System.Drawing.Size(127, 27);
            this.OldPassLabel.TabIndex = 8;
            this.OldPassLabel.Text = "Old Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(424, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Confirm Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "New Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Email Address";
            // 
            // ResetPassButton
            // 
            this.ResetPassButton.Animated = true;
            this.ResetPassButton.AutoRoundedCorners = true;
            this.ResetPassButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ResetPassButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ResetPassButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ResetPassButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ResetPassButton.FillColor = System.Drawing.Color.Teal;
            this.ResetPassButton.Font = new System.Drawing.Font("Arial", 10.2F);
            this.ResetPassButton.ForeColor = System.Drawing.Color.White;
            this.ResetPassButton.IndicateFocus = true;
            this.ResetPassButton.Location = new System.Drawing.Point(505, 446);
            this.ResetPassButton.Name = "ResetPassButton";
            this.ResetPassButton.Size = new System.Drawing.Size(180, 45);
            this.ResetPassButton.TabIndex = 4;
            this.ResetPassButton.Text = "Reset Password";
            this.ResetPassButton.UseTransparentBackground = true;
            this.ResetPassButton.Click += new System.EventHandler(this.ResetPassButton_Click);
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.Animated = true;
            this.ConfirmPasswordTextBox.AutoRoundedCorners = true;
            this.ConfirmPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ConfirmPasswordTextBox.DefaultText = "";
            this.ConfirmPasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ConfirmPasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ConfirmPasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ConfirmPasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ConfirmPasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ConfirmPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ConfirmPasswordTextBox.ForeColor = System.Drawing.Color.Black;
            this.ConfirmPasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ConfirmPasswordTextBox.IconRight = global::Gym_Management_System.Properties.Resources.eyes_closed;
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(417, 353);
            this.ConfirmPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.PlaceholderForeColor = System.Drawing.Color.Black;
            this.ConfirmPasswordTextBox.PlaceholderText = "Confirm Password";
            this.ConfirmPasswordTextBox.SelectedText = "";
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(282, 48);
            this.ConfirmPasswordTextBox.TabIndex = 3;
            this.ConfirmPasswordTextBox.IconRightClick += new System.EventHandler(this.ConfirmPasswordTextBox_IconRightClick);
            // 
            // NewPasswordTextBox
            // 
            this.NewPasswordTextBox.Animated = true;
            this.NewPasswordTextBox.AutoRoundedCorners = true;
            this.NewPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NewPasswordTextBox.DefaultText = "";
            this.NewPasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NewPasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NewPasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NewPasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NewPasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NewPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NewPasswordTextBox.ForeColor = System.Drawing.Color.Black;
            this.NewPasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NewPasswordTextBox.IconRight = global::Gym_Management_System.Properties.Resources.eyes_closed;
            this.NewPasswordTextBox.Location = new System.Drawing.Point(53, 353);
            this.NewPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewPasswordTextBox.Name = "NewPasswordTextBox";
            this.NewPasswordTextBox.PlaceholderForeColor = System.Drawing.Color.Black;
            this.NewPasswordTextBox.PlaceholderText = "New Password";
            this.NewPasswordTextBox.SelectedText = "";
            this.NewPasswordTextBox.Size = new System.Drawing.Size(323, 48);
            this.NewPasswordTextBox.TabIndex = 2;
            this.NewPasswordTextBox.IconRightClick += new System.EventHandler(this.NewPasswordTextBox_IconRightClick);
            // 
            // EmailCheckTextBox
            // 
            this.EmailCheckTextBox.Animated = true;
            this.EmailCheckTextBox.AutoRoundedCorners = true;
            this.EmailCheckTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailCheckTextBox.DefaultText = "";
            this.EmailCheckTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmailCheckTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmailCheckTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailCheckTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailCheckTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailCheckTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EmailCheckTextBox.ForeColor = System.Drawing.Color.Black;
            this.EmailCheckTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailCheckTextBox.IconLeft = global::Gym_Management_System.Properties.Resources.email_icon;
            this.EmailCheckTextBox.Location = new System.Drawing.Point(53, 124);
            this.EmailCheckTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmailCheckTextBox.Name = "EmailCheckTextBox";
            this.EmailCheckTextBox.PlaceholderForeColor = System.Drawing.Color.Black;
            this.EmailCheckTextBox.PlaceholderText = "Email Address";
            this.EmailCheckTextBox.SelectedText = "";
            this.EmailCheckTextBox.Size = new System.Drawing.Size(323, 48);
            this.EmailCheckTextBox.TabIndex = 1;
            // 
            // ResetPasswordLabel
            // 
            this.ResetPasswordLabel.AutoSize = true;
            this.ResetPasswordLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetPasswordLabel.Location = new System.Drawing.Point(283, 12);
            this.ResetPasswordLabel.Name = "ResetPasswordLabel";
            this.ResetPasswordLabel.Size = new System.Drawing.Size(163, 24);
            this.ResetPasswordLabel.TabIndex = 0;
            this.ResetPasswordLabel.Text = "Reset Password";
            // 
            // loginTableAdapter1
            // 
            this.loginTableAdapter1.ClearBeforeFill = true;
            // 
            // ResetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 678);
            this.Controls.Add(this.ResetPasswordPanel);
            this.Name = "ResetPasswordForm";
            this.ShowIcon = false;
            this.Text = "Reset Password";
            this.Load += new System.EventHandler(this.ResetPasswordForm_Load);
            this.ResetPasswordPanel.ResumeLayout(false);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel ResetPasswordPanel;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Label ResetPasswordLabel;
        private Guna.UI2.WinForms.Guna2Button ResetPassButton;
        private Guna.UI2.WinForms.Guna2TextBox ConfirmPasswordTextBox;
        private Guna.UI2.WinForms.Guna2TextBox NewPasswordTextBox;
        private Guna.UI2.WinForms.Guna2TextBox EmailCheckTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private GroupWst23DataSetTableAdapters.LoginTableAdapter loginTableAdapter1;
        private Guna.UI2.WinForms.Guna2TextBox OldPassTextBox;
        private System.Windows.Forms.Label OldPassLabel;
    }
}