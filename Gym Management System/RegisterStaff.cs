using Gym_Management_System.GroupWst23DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management_System
{
    public partial class RegisterStaff : Form
    {
        public RegisterStaff()
        {
            InitializeComponent();
        }

        private void RegisterStaff_Load(object sender, EventArgs e)
        {
            this.staffTableAdapter.FillByStaffRole(this.groupWst23DataSet.Staff);

            StaffIdText.TextChanged += ClearError;
            StaffFirstNameTextBox.TextChanged += ClearError;
            StaffLastNameTextBox.TextChanged += ClearError;
            StaffTelephoneTextbox.TextChanged += ClearError;
            StaffPhoneNoTextBox.TextChanged += ClearError;
            StaffEmailTextBox.TextChanged += ClearError;

            StaffGenderComboBox.SelectedIndexChanged += ClearComboError;
            StaffRoleComboBox.SelectedIndexChanged += ClearComboError;
            StaffStatusComboBox.SelectedIndexChanged += ClearComboError;

            StaffDateOfBirthPicker.ValueChanged += ClearDateError;
        }

        private void staffBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.staffBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.groupWst23DataSet);

        }

        private void ManangerStaffSearchTxt_TextChanged(object sender, EventArgs e)
        {

        }
        string staffID = "";
        private void ManagerAddStaffBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateStaffInputs())
                {
                    return;
                }

                int idCount = Convert.ToInt32(staffTableAdapter.CheckStaffIDExists(StaffIdText.Text));

                if (idCount > 0)
                {
                    MessageBox.Show("Staff ID already exists. Please use a different Staff ID.");
                    return;
                }

                string email = StaffEmailTextBox.Text.Trim();
                int emailCount = Convert.ToInt32(staffTableAdapter.CheckStaffEmailExist(email));

                if (emailCount > 0)
                {
                    MessageBox.Show("Email already exists. Please use a different email.");
                    return;
                }

                string phone = StaffPhoneNoTextBox.Text.Trim();
                int phoneCount = Convert.ToInt32(staffTableAdapter.CheckStaffPhoneExists(phone));

                if (phoneCount > 0)
                {
                    MessageBox.Show("Phone number already exists. Please use a different phone number.");
                    return;
                }

                staffTableAdapter.AddNewStaffMember(
                    StaffIdText.Text,
                    StaffRoleComboBox.Text,
                    StaffFirstNameTextBox.Text,
                    StaffLastNameTextBox.Text,
                    StaffTelephoneTextbox.Text == "" ? null : StaffTelephoneTextbox.Text,
                    StaffPhoneNoTextBox.Text,
                    StaffEmailTextBox.Text,
                    StaffDateOfBirthPicker.Value.ToString(),
                    StaffGenderComboBox.Text,
                    StaffStatusComboBox.Text
                );

                loginTableAdapter1.CreateStaffLogin(StaffEmailTextBox.Text, "Gym@123", StaffRoleComboBox.Text);

                staffTableAdapter.FillByStaffRole(groupWst23DataSet.Staff);

                MessageBox.Show("Staff member added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void UpdateBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (StaffIdText.Text == "")
                {
                    MessageBox.Show("Please enter Staff ID.");
                    return;
                }

                int count = Convert.ToInt32(staffTableAdapter.CheckStaffIDExists(StaffIdText.Text));

                if (count == 0)
                {
                    MessageBox.Show("Staff ID does not exist. Update cancelled.");
                    return;
                }

                if (!ValidateStaffInputs())
                {
                    return;
                }

                int emailCount = Convert.ToInt32(
                    staffTableAdapter.CheckEmailUsedByAnotherStaff(
                        StaffEmailTextBox.Text,
                        StaffIdText.Text
                    )
                );

                if (emailCount > 0)
                {
                    MessageBox.Show("This email is already used by another staff member.");
                    return;
                }

                int phoneCount = Convert.ToInt32(
                    staffTableAdapter.CheckPhoneUsedByAnotherStaff(
                        StaffPhoneNoTextBox.Text,
                        StaffIdText.Text
                    )
                );

                if (phoneCount > 0)
                {
                    MessageBox.Show("This phone number is already used by another staff member.");
                    return;
                }

                staffTableAdapter.UpdateStaffDetails(
                    StaffRoleComboBox.Text,
                    StaffFirstNameTextBox.Text,
                    StaffLastNameTextBox.Text,
                    StaffTelephoneTextbox.Text == "" ? null : StaffTelephoneTextbox.Text,
                    StaffPhoneNoTextBox.Text,
                    StaffEmailTextBox.Text,
                    StaffDateOfBirthPicker.Value.ToString(),
                    StaffGenderComboBox.Text,
                    StaffStatusComboBox.Text,
                    StaffIdText.Text
                );

                //loginTableAdapter1.UpdateLoginRole(StaffRoleComboBox.Text,"Gym@123", StaffEmailTextBox.Text);

                staffTableAdapter.FillByStaffRole(groupWst23DataSet.Staff);

                MessageBox.Show("Staff details updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Handling Delete Staff Member Button 
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (StaffIdText.Text == "")
                {
                    MessageBox.Show("Please select a staff member to delete.");
                    return;
                }

                int count = Convert.ToInt32(staffTableAdapter.CheckStaffIDExists(StaffIdText.Text));

                if (count == 0)
                {
                    MessageBox.Show("Staff ID does not exist.");
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this staff member?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    archiveStaffTableAdapter1.InsertArchieveStaff(
                        StaffIdText.Text,
                        StaffRoleComboBox.Text,
                        StaffFirstNameTextBox.Text,
                        StaffLastNameTextBox.Text,
                        StaffTelephoneTextbox.Text,
                        StaffPhoneNoTextBox.Text,
                        StaffEmailTextBox.Text,
                        StaffDateOfBirthPicker.Value.ToString(),
                        StaffGenderComboBox.Text,
                        StaffStatusComboBox.Text
                      );
                    //login_ArchiveTableAdapter1.InsertLoginArchivedDetails(StaffEmailTextBox.Text,UserSession.Password,UserSession.Role);

                    loginTableAdapter1.DeleteLoginDetails(StaffEmailTextBox.Text);
                    training_SessionTableAdapter1.DeleteStaffDetails(StaffIdText.Text);
                    staffTableAdapter.DeleteStaffDetails(StaffIdText.Text);
                    staffTableAdapter.FillByStaffRole(groupWst23DataSet.Staff);
                    MessageBox.Show("Staff member deleted successfully.");
                    ClearStaffFields();
                }
                else
                {
                    MessageBox.Show("Delete cancelled.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        private void ClearBtn_Click_1(object sender, EventArgs e)
        {
            ClearStaffFields();
        }

        private void ManangerStaffSearchTxt_TextChanged_1(object sender, EventArgs e)
        {
            this.staffTableAdapter.StaffSearchByNameOrID(this.groupWst23DataSet.Staff,ManangerStaffSearchTxt.Text, ManangerStaffSearchTxt.Text,ManangerStaffSearchTxt.Text);

            if (StaffDataGridView.CurrentRow == null)
            {
                return;
            }

            if (StaffDataGridView.CurrentRow.Cells[0].Value == null)
            {
                return;
            }

            StaffIdText.Text = StaffDataGridView.CurrentRow.Cells[0].Value.ToString();
            staffID = StaffDataGridView.CurrentRow.Cells[0].Value.ToString();
            StaffRoleComboBox.Text = Convert.ToString(StaffDataGridView.CurrentRow.Cells[1].Value);
            StaffFirstNameTextBox.Text = Convert.ToString(StaffDataGridView.CurrentRow.Cells[2].Value);
            StaffLastNameTextBox.Text = Convert.ToString(StaffDataGridView.CurrentRow.Cells[3].Value);
            StaffTelephoneTextbox.Text = Convert.ToString(StaffDataGridView.CurrentRow.Cells[4].Value);
            StaffPhoneNoTextBox.Text = Convert.ToString(StaffDataGridView.CurrentRow.Cells[5].Value);
            StaffEmailTextBox.Text = Convert.ToString(StaffDataGridView.CurrentRow.Cells[6].Value);
            StaffDateOfBirthPicker.Text = Convert.ToString(StaffDataGridView.CurrentRow.Cells[7].Value);
            StaffGenderComboBox.Text = Convert.ToString(StaffDataGridView.CurrentRow.Cells[8].Value);
            StaffStatusComboBox.Text = Convert.ToString(StaffDataGridView.CurrentRow.Cells[9].Value);
        }

        private bool ValidateStaffInputs()
        {
            ClearValidationErrors();

            bool isValid = true;

            StaffIdText.Text = ValidationHelper.Trim(StaffIdText.Text);
            StaffFirstNameTextBox.Text = ValidationHelper.Trim(StaffFirstNameTextBox.Text);
            StaffLastNameTextBox.Text = ValidationHelper.Trim(StaffLastNameTextBox.Text);
            StaffEmailTextBox.Text = ValidationHelper.Trim(StaffEmailTextBox.Text);
            StaffPhoneNoTextBox.Text = ValidationHelper.Trim(StaffPhoneNoTextBox.Text);
            StaffTelephoneTextbox.Text = ValidationHelper.Trim(StaffTelephoneTextbox.Text);

            // Required Fields

            if (string.IsNullOrWhiteSpace(StaffIdText.Text))
            {
                ShowError(StaffIdText, "Staff ID is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(StaffFirstNameTextBox.Text))
            {
                ShowError(StaffFirstNameTextBox, "First Name is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(StaffLastNameTextBox.Text))
            {
                ShowError(StaffLastNameTextBox, "Last Name is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(StaffPhoneNoTextBox.Text))
            {
                ShowError(StaffPhoneNoTextBox, "Phone Number is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(StaffEmailTextBox.Text))
            {
                ShowError(StaffEmailTextBox, "Email Address is required.");
                isValid = false;
            }

            if (StaffRoleComboBox.SelectedIndex == -1)
            {
                ShowError(StaffRoleComboBox, "Please select a Role.");
                isValid = false;
            }

            if (StaffGenderComboBox.SelectedIndex == -1)
            {
                ShowError(StaffGenderComboBox, "Please select a Gender.");
                isValid = false;
            }

            if (StaffStatusComboBox.SelectedIndex == -1)
            {
                ShowError(StaffStatusComboBox, "Please select a Status.");
                isValid = false;
            }

            // Staff ID

            if (!string.IsNullOrWhiteSpace(StaffIdText.Text) &&
                !ValidationHelper.IsValidStaffID(StaffIdText.Text))
            {
                ShowError(StaffIdText, "Staff ID must be exactly 6 digits.");
                isValid = false;
            }

            // Names

            if (!string.IsNullOrWhiteSpace(StaffFirstNameTextBox.Text) &&
                !ValidationHelper.IsValidName(StaffFirstNameTextBox.Text))
            {
                ShowError(StaffFirstNameTextBox,
                    "First Name contains invalid characters.");
                isValid = false;
            }

            if (!string.IsNullOrWhiteSpace(StaffLastNameTextBox.Text) &&
                !ValidationHelper.IsValidName(StaffLastNameTextBox.Text))
            {
                ShowError(StaffLastNameTextBox,
                    "Last Name contains invalid characters.");
                isValid = false;
            }

            // Email

            if (!string.IsNullOrWhiteSpace(StaffEmailTextBox.Text) &&
                !ValidationHelper.IsValidEmail(StaffEmailTextBox.Text))
            {
                ShowError(StaffEmailTextBox,
                    "Please enter a valid email address.");
                isValid = false;
            }

            // Phone

            if (!string.IsNullOrWhiteSpace(StaffPhoneNoTextBox.Text) &&
                !ValidationHelper.IsValidPhone(StaffPhoneNoTextBox.Text))
            {
                ShowError(StaffPhoneNoTextBox,
                    "Phone number must be 10 digits starting with 0.");
                isValid = false;
            }

            // Optional Telephone

            if (!string.IsNullOrWhiteSpace(StaffTelephoneTextbox.Text) &&
                !ValidationHelper.IsValidPhone(StaffTelephoneTextbox.Text))
            {
                ShowError(StaffTelephoneTextbox,
                    "Telephone number must be valid.");
                isValid = false;
            }

            // DOB

            if (ValidationHelper.IsFutureDate(StaffDateOfBirthPicker.Value))
            {
                ShowError(StaffDateOfBirthPicker,
                    "Date of birth cannot be today or in the future.");
                isValid = false;
            }

            if (!ValidationHelper.IsValidAge(StaffDateOfBirthPicker.Value, 18))
            {
                ShowError(StaffDateOfBirthPicker,
                    "Staff must be at least 18 years old.");
                isValid = false;
            }

            return isValid;
        }

        private void ClearStaffFields()
        {
            StaffIdText.Text = "";
            StaffFirstNameTextBox.Text = "";
            StaffLastNameTextBox.Text = "";
            StaffTelephoneTextbox.Text = "";
            StaffPhoneNoTextBox.Text = "";
            StaffEmailTextBox.Text = "";

            StaffGenderComboBox.SelectedIndex = -1;
            StaffRoleComboBox.SelectedIndex = -1;
            StaffStatusComboBox.SelectedIndex = -1;

            StaffDateOfBirthPicker.Value = DateTime.Now;
        }
        private void ShowError(Control control, string message)
        {
            errorProvider1.SetError(control, message);

            if (control is Guna.UI2.WinForms.Guna2TextBox txt)
            {
                txt.BorderColor = Color.Red;
            }
            else if (control is System.Windows.Forms.ComboBox cb)
            {
                cb.BackColor = Color.MistyRose;
            }
        }

        private void ClearError(object sender, EventArgs e)
        {
            if (sender is Guna.UI2.WinForms.Guna2TextBox txt)
            {
                txt.BorderColor = Color.Silver;
                errorProvider1.SetError(txt, "");
            }
        }

        private void ClearComboError(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.ComboBox cb)
            {
                cb.BackColor = Color.White;
                errorProvider1.SetError(cb, "");
            }
        }

        private void ClearDateError(object sender, EventArgs e)
        {
            errorProvider1.SetError(StaffDateOfBirthPicker, "");
        }

        private void ClearValidationErrors()
        {
            errorProvider1.Clear();

            StaffIdText.BorderColor = Color.Silver;
            StaffFirstNameTextBox.BorderColor = Color.Silver;
            StaffLastNameTextBox.BorderColor = Color.Silver;
            StaffTelephoneTextbox.BorderColor = Color.Silver;
            StaffPhoneNoTextBox.BorderColor = Color.Silver;
            StaffEmailTextBox.BorderColor = Color.Silver;

            StaffGenderComboBox.BackColor = Color.White;
            StaffRoleComboBox.BackColor = Color.White;
            StaffStatusComboBox.BackColor = Color.White;
        }

        private void StaffDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            StaffIdText.Text = StaffDataGridView.CurrentRow.Cells[0].Value.ToString();
            staffID = StaffDataGridView.CurrentRow.Cells[0].Value.ToString();
            StaffRoleComboBox.Text = StaffDataGridView.CurrentRow.Cells[1].Value.ToString();
            StaffFirstNameTextBox.Text = StaffDataGridView.CurrentRow.Cells[2].Value.ToString();
            StaffLastNameTextBox.Text = StaffDataGridView.CurrentRow.Cells[3].Value.ToString();
            StaffTelephoneTextbox.Text = StaffDataGridView.CurrentRow.Cells[4].Value.ToString();
            StaffPhoneNoTextBox.Text = StaffDataGridView.CurrentRow.Cells[5].Value.ToString();
            StaffEmailTextBox.Text = StaffDataGridView.CurrentRow.Cells[6].Value.ToString();
            StaffDateOfBirthPicker.Text = StaffDataGridView.CurrentRow.Cells[7].Value.ToString();
            StaffGenderComboBox.Text = StaffDataGridView.CurrentRow.Cells[8].Value.ToString();
            StaffStatusComboBox.Text = StaffDataGridView.CurrentRow.Cells[9].Value.ToString();

        }

        private void UpdatePassButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Check Staff ID
                if (string.IsNullOrWhiteSpace(StaffIdText.Text))
                {
                    MessageBox.Show("Please enter Staff ID.");
                    return;
                }

                // Check if Staff exists
                int count = Convert.ToInt32(
                    staffTableAdapter.CheckStaffIDExists(StaffIdText.Text)
                );

                if (count == 0)
                {
                    MessageBox.Show("Staff ID does not exist.");
                    return;
                }

                // Check Email
                if (string.IsNullOrWhiteSpace(StaffEmailTextBox.Text))
                {
                    MessageBox.Show("Email address is required.");
                    return;
                }

                // Confirmation Message
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to reset this staff member's password to 'Gym@123'?",
                    "Confirm Password Reset",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.No)
                    return;

                // Reset Password
                int rowsAffected = loginTableAdapter1.UpdateLoginRole(
                    StaffRoleComboBox.Text,
                    "Gym@123",
                    StaffEmailTextBox.Text
                );

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Password has been reset successfully.");
                }
                else
                {
                    MessageBox.Show("No matching login account was found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An error occurred while resetting the password.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void StaffIdText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void StaffFirstNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void StaffPhoneNoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}