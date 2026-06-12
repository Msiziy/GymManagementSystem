using Gym_Management_System.GroupWst23DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management_System
{
    public partial class ResetPasswordForm : Form
    {
        public ResetPasswordForm()
        {
            InitializeComponent();
        }

        private void ResetPasswordForm_Load(object sender, EventArgs e)
        {
            NewPasswordTextBox.UseSystemPasswordChar = true;
            ConfirmPasswordTextBox.UseSystemPasswordChar = true;
            OldPassTextBox.UseSystemPasswordChar = true;
        }

        private void ResetPassButton_Click(object sender, EventArgs e)
        {
            try
            {
                string email = EmailCheckTextBox.Text.Trim();
                string oldPassword = OldPassTextBox.Text.Trim();
                string newPassword = NewPasswordTextBox.Text.Trim();
                string confirmPassword = ConfirmPasswordTextBox.Text.Trim();

                if (email == "" || oldPassword == "" || newPassword == "" || confirmPassword == "")
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                if (!IsValidEmail(email))
                {
                    MessageBox.Show("Please enter a valid email address.");
                    return;
                }

                int count = Convert.ToInt32(loginTableAdapter1.CheckEmailAndOldPassword(email, oldPassword)
                );

                if (count == 0)
                {
                    MessageBox.Show("Email or old password is incorrect.");
                    return;
                }

                if (!IsStrongPassword(newPassword))
                {
                    MessageBox.Show("Password must be at least 6 characters and contain uppercase, lowercase, and a number.");
                    return;
                }

                if (newPassword != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match.");
                    return;
                }

                if (newPassword == oldPassword)
                {
                    MessageBox.Show("New password cannot be the same as old password.");
                    return;
                }
                ValidateResetInputs();

                loginTableAdapter1.ResetPassword(newPassword, email);

                MessageBox.Show("Password reset successfully. You can now login.");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool IsValidEmail(string email)
        {
            return email.Contains("@") && email.Contains(".");
        }

        private bool IsStrongPassword(string password)
        {
            return password.Length >= 6 &&
                   password.Any(char.IsUpper) &&
                   password.Any(char.IsLower) &&
                   password.Any(char.IsDigit);
        }

        private bool ValidateResetInputs()
        {
            string email = EmailCheckTextBox.Text.Trim();
            string newPassword = NewPasswordTextBox.Text.Trim();
            string confirmPassword = ConfirmPasswordTextBox.Text.Trim();
            string oldPassword = OldPassTextBox.Text.Trim();

            if (email == "" || newPassword == "" || confirmPassword == "" || oldPassword == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return false;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.");
                return false;
            }

            if (!IsStrongPassword(newPassword))
            {
                MessageBox.Show("Password must be at least 6 characters and contain uppercase, lowercase, and a number.");
                return false;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return false;
            }

            return true;
        }

        private void ConfirmPasswordTextBox_IconRightClick(object sender, EventArgs e)
        {
            ConfirmPasswordTextBox.UseSystemPasswordChar = !ConfirmPasswordTextBox.UseSystemPasswordChar;

            if (ConfirmPasswordTextBox.UseSystemPasswordChar)
            {
                ConfirmPasswordTextBox.IconRight = Properties.Resources.eyes_closed;

            }
            else
            {
                ConfirmPasswordTextBox.IconRight = Properties.Resources.eyes_open;
            }
        }

        private void NewPasswordTextBox_IconRightClick(object sender, EventArgs e)
        {
            NewPasswordTextBox.UseSystemPasswordChar = !NewPasswordTextBox.UseSystemPasswordChar;

            if (NewPasswordTextBox.UseSystemPasswordChar)
            {
                NewPasswordTextBox.IconRight = Properties.Resources.eyes_closed;

            }
            else
            {
                NewPasswordTextBox.IconRight = Properties.Resources.eyes_open;
            }
        }

        private void OldPassTextBox_IconRightClick(object sender, EventArgs e)
        {
            OldPassTextBox.UseSystemPasswordChar = !OldPassTextBox.UseSystemPasswordChar;

            if (OldPassTextBox.UseSystemPasswordChar)
            {
                OldPassTextBox.IconRight = Properties.Resources.eyes_closed;

            }
            else
            {
                OldPassTextBox.IconRight = Properties.Resources.eyes_open;
            }
        }
    }
}
