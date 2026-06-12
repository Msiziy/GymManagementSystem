using Gym_Management_System.GroupWst23DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace Gym_Management_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
       
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            LoginPasswordTextBox.UseSystemPasswordChar = true;
        }


        string firstName = "";
        string lastName = "";

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string email = LoginUsernameTextBox.Text.Trim();
                string password = LoginPasswordTextBox.Text.Trim();

                string role = null;

                if (LoginAsManagerRadioButton.Checked)
                {
                    role = "Manager";
                }
                else if (LoginAsTrainerRadioButton.Checked)
                {
                    role = "Trainer";
                }
                else if (LoginAsRecepRadioButton.Checked)
                {
                    role = "Receptionist";
                }

                bool hasError = false;

                // clear previous errors
                errorProvider1.Clear();

                // role validation
                if (string.IsNullOrEmpty(role))
                {
                    MessageBox.Show("Please select a role.",
                                    "Role Required",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);

                    hasError = true;
                }

                // email validation
                if (string.IsNullOrWhiteSpace(email))
                {
                    errorProvider1.SetError(LoginUsernameTextBox, "Email is required");
                    hasError = true;
                }
                else if (!email.Contains("@") || !email.Contains("."))
                {
                    errorProvider1.SetError(LoginUsernameTextBox, "Invalid email format");
                    hasError = true;
                }
                else
                {
                    errorProvider1.SetError(LoginUsernameTextBox, "");
                }

                // password validation
                if (string.IsNullOrWhiteSpace(password))
                {
                    errorProvider1.SetError(LoginPasswordTextBox, "Password is required");
                    hasError = true;
                }
                else
                {
                    errorProvider1.SetError(LoginPasswordTextBox, "");
                }

                if (hasError)
                {
                    return;
                }

                groupWst23DataSet.Login.Clear();

                //check if email exists
                int emailExists = Convert.ToInt32(loginTableAdapter.CheckEmail(email));

                if (emailExists == 0)
                {
                    errorProvider1.SetError(LoginUsernameTextBox, "Email not found");
                    return;
                }
                else
                {
                    errorProvider1.SetError(LoginUsernameTextBox, "");
                }

                //check password
                int passwordCorrect = Convert.ToInt32(
                    loginTableAdapter.CheckPassword(email, password)
                );

                if (passwordCorrect == 0)
                {
                    errorProvider1.SetError(LoginPasswordTextBox, "Incorrect password");
                    LoginPasswordTextBox.Clear();
                    return;
                }
                else
                {
                    errorProvider1.SetError(LoginPasswordTextBox, "");
                }

                // check role
                int roleCorrect = Convert.ToInt32(
                    loginTableAdapter.CheckRole(email, role)
                );

                if (roleCorrect == 0)
                {
                    MessageBox.Show("Incorrect role selected.",
                                    "Login Failed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                // load user details and role
                loginTableAdapter.LoginDetails(groupWst23DataSet.Login, email, password, role);

                getUserDetails(email);

                if (groupWst23DataSet.Login.Rows.Count > 0)
                {
                    GroupWst23DataSet.LoginRow row = groupWst23DataSet.Login[0];

                    string dbRole = row.UserRole;

                    UserSession.FirstName = firstName;
                    UserSession.LastName = lastName;
                    UserSession.Email = email;
                    UserSession.Role = dbRole;

                    // successful login, clear errors and show welcome message
                    errorProvider1.Clear();

                    //MessageBox.Show("Welcome " + firstName + " " + lastName,"Login Successful",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    if (dbRole == "Manager")
                    {
                        ManagerForm manager = new ManagerForm();
                        manager.Show();
                    }
                    else if (dbRole == "Trainer")
                    {
                        TrainerMDI trainer = new TrainerMDI();
                        trainer.Show();
                    }
                    else if (dbRole == "Receptionist")
                    {
                        ReceptionistPP receptionist = new ReceptionistPP();
                        receptionist.Show();
                    }

                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void getUserDetails(string email)
        {
            try
            {
                groupWst23DataSet.LoginJoin.Clear();
                loginJoinTableAdapter2.GetUserDetails(groupWst23DataSet.LoginJoin, email);
                if (groupWst23DataSet.LoginJoin.Rows.Count > 0)
                {
                    GroupWst23DataSet.LoginJoinRow row = groupWst23DataSet.LoginJoin[0];
                    firstName = row.Staff_FName;
                    lastName = row.Staff_LName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        private void loginBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loginBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.groupWst23DataSet);

        }

       

        private void LoginAsManagerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked)
            {
                LoginPasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                LoginPasswordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginAsRecepRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            LoginUsernameTextBox.Text = "siyandakhethelo5@gmail.com";
            LoginPasswordTextBox.Text="Siyanda@2005";
        }

        private void LoginAsTrainerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            LoginUsernameTextBox.Clear();
            LoginPasswordTextBox.Clear();
        }

        private void ForgettonPassWordLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetPasswordForm resetPasswordForm = new ResetPasswordForm();
            resetPasswordForm.Show();
        }

        private void LoginAsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginPasswordTextBox_IconRightClick(object sender, EventArgs e)
        {
            LoginPasswordTextBox.UseSystemPasswordChar = !LoginPasswordTextBox.UseSystemPasswordChar;

            if (LoginPasswordTextBox.UseSystemPasswordChar)
            {
                LoginPasswordTextBox.IconRight = Properties.Resources.eyes_closed;

            }
            else
            {
                LoginPasswordTextBox.IconRight = Properties.Resources.eyes_open;
            }
        }

        private void LoginPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            //errorProvider1.SetError(LoginPasswordTextBox, "");
        }

        private void LoginUsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            //errorProvider1.SetError(LoginUsernameTextBox, "");
        }
    }
}

