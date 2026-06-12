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
    public partial class ManageMember : Form
    {
        public ManageMember()
        {
            InitializeComponent();
        }

        private void RegisterMember_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupWst23DataSet.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.groupWst23DataSet.Member);
            member_IDTextBox1.TextChanged += ClearError;
            member_FNameTextBox1.TextChanged += ClearError;
            member_LNameTextBox1.TextChanged += ClearError;
            member_EmailTextBox1.TextChanged += ClearError;
            member_Phone_NumberTextBox1.TextChanged += ClearError;
            member_TelephoneTextBox1.TextChanged += ClearError;
            member_Street_NameTextBox1.TextChanged += ClearError;
            member_Street_NumberTextBox1.TextChanged += ClearError;
            member_CityTextBox1.TextChanged += ClearError;
            member_Postal_CodeTextBox1.TextChanged += ClearError;
            emergency_Contact_NameTextBox1.TextChanged += ClearError;
            emergency_Contact_NumberTextBox1.TextChanged += ClearError;
            GenderComboBox1.SelectedIndexChanged += ClearComboError;
            Provincecombobox1.SelectedIndexChanged += ClearComboError;
            RelationshipCB.SelectedIndexChanged += ClearComboError;
            member_DOBDateTimePicker1.ValueChanged += ClearDateError;
        }
        private void ClearDateError(object sender, EventArgs e)
        {
            errorProvider1.SetError(member_DOBDateTimePicker1, "");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void personaldetailsgroupbox_Enter(object sender, EventArgs e)
        {

        }

        private void memberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.memberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.groupWst23DataSet);

        }

        private void MemberInfomationGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterBtn1_Click(object sender, EventArgs e)
        {
            if (MemberIDExists(member_IDTextBox1.Text))
            {
                MessageBox.Show("Member ID already exists",
                    "Register Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }
            if (!ValidateMemberDetails())
            {
                return;
            }

            try
            {
            

                memberTableAdapter1.AddMember(
                    member_IDTextBox1.Text,
                    member_FNameTextBox1.Text,
                    member_LNameTextBox1.Text,
                    member_TelephoneTextBox1.Text,
                    member_Phone_NumberTextBox1.Text,
                    member_EmailTextBox1.Text,
                    member_Street_NameTextBox1.Text,
                    member_Street_NumberTextBox1.Text,
                    member_CityTextBox1.Text,
                    Provincecombobox1.Text,
                    member_Postal_CodeTextBox1.Text,
                    GenderComboBox1.Text,
                    member_DOBDateTimePicker1.Value.ToString("yyyy-MM-dd"),
                    DateTime.Now.ToString("yyyy-MM-dd"),
                    "Inactive",
                    emergency_Contact_NameTextBox1.Text,
                    emergency_Contact_NumberTextBox1.Text,
                    RelationshipCB.Text
                );
                memberTableAdapter1.Fill(groupWst23DataSet.Member);
                MessageBox.Show("Member Added successfully.",
                    "Register  Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Clear fields
                ClearMemberFields();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
     
      
        private bool MemberIDExists(string memberID)
        {
            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
               
                if (row.Cells[0].Value == null)
                {
                    continue;
                }

                if (row.Cells[0].Value.ToString() == memberID)
                {
                    return true;
                }
            }

            return false;
        }

        private bool ValidateMemberDetails()
        {
            ClearValidationErrors();

            bool isValid = true;

            // Required Fields
            if (string.IsNullOrWhiteSpace(member_IDTextBox1.Text))
            {
                ShowError(member_IDTextBox1, "Member ID is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(member_FNameTextBox1.Text))
            {
                ShowError(member_FNameTextBox1, "First Name is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(member_LNameTextBox1.Text))
            {
                ShowError(member_LNameTextBox1, "Last Name is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(member_Phone_NumberTextBox1.Text))
            {
                ShowError(member_Phone_NumberTextBox1, "Phone Number is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(member_EmailTextBox1.Text))
            {
                ShowError(member_EmailTextBox1, "Email Address is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(member_Street_NameTextBox1.Text))
            {
                ShowError(member_Street_NameTextBox1, "Street Name is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(member_Street_NumberTextBox1.Text))
            {
                ShowError(member_Street_NumberTextBox1, "Street Number is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(member_CityTextBox1.Text))
            {
                ShowError(member_CityTextBox1, "City is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(member_Postal_CodeTextBox1.Text))
            {
                ShowError(member_Postal_CodeTextBox1, "Postal Code is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(emergency_Contact_NameTextBox1.Text))
            {
                ShowError(emergency_Contact_NameTextBox1, "Emergency Contact Name is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(emergency_Contact_NumberTextBox1.Text))
            {
                ShowError(emergency_Contact_NumberTextBox1, "Emergency Contact Number is required.");
                isValid = false;
            }

            if (RelationshipCB.SelectedIndex == -1)
            {
                ShowError(RelationshipCB, "Please select a Relationship.");
                isValid = false;
            }

            if (GenderComboBox1.SelectedIndex == -1)
            {
                ShowError(GenderComboBox1, "Please select a Gender.");
                isValid = false;
            }

            if (Provincecombobox1.SelectedIndex == -1)
            {
                ShowError(Provincecombobox1, "Please select a Province.");
                isValid = false;
            }

            // Member ID Validation
            if (!string.IsNullOrWhiteSpace(member_IDTextBox1.Text))
            {
                if (!ValidationHelper.ContainsNoSpaces(member_IDTextBox1.Text))
                {
                    ShowError(member_IDTextBox1, "Member ID cannot contain spaces.");
                    isValid = false;
                }

                if (!ValidationHelper.IsValidMemberID(member_IDTextBox1.Text))
                {
                    ShowError(member_IDTextBox1, "Member ID must be exactly 9 digits.");
                    isValid = false;
                }
            }

            // Name Validation
            if (!string.IsNullOrWhiteSpace(member_FNameTextBox1.Text) &&
                !ValidationHelper.IsAlphabetOnly(member_FNameTextBox1.Text))
            {
                ShowError(member_FNameTextBox1, "First Name must contain letters only.");
                isValid = false;
            }

            if (!string.IsNullOrWhiteSpace(member_LNameTextBox1.Text) &&
                !ValidationHelper.IsAlphabetOnly(member_LNameTextBox1.Text))
            {
                ShowError(member_LNameTextBox1, "Last Name must contain letters only.");
                isValid = false;
            }

            if (!string.IsNullOrWhiteSpace(emergency_Contact_NameTextBox1.Text) &&
                !ValidationHelper.IsAlphabetOnly(emergency_Contact_NameTextBox1.Text))
            {
                ShowError(emergency_Contact_NameTextBox1,
                    "Emergency Contact Name must contain letters only.");
                isValid = false;
            }

            if (!string.IsNullOrWhiteSpace(member_Street_NameTextBox1.Text) &&
                !ValidationHelper.IsAlphabetOnly(member_Street_NameTextBox1.Text))
            {
                ShowError(member_Street_NameTextBox1,
                    "Street Name must contain letters only.");
                isValid = false;
            }

            if (!string.IsNullOrWhiteSpace(member_CityTextBox1.Text) &&
                !ValidationHelper.IsAlphabetOnly(member_CityTextBox1.Text))
            {
                ShowError(member_CityTextBox1, "City must contain letters only.");
                isValid = false;
            }

            // Email Validation
            if (!string.IsNullOrWhiteSpace(member_EmailTextBox1.Text) &&
                !ValidationHelper.IsValidEmail(member_EmailTextBox1.Text))
            {
                ShowError(member_EmailTextBox1, "Invalid Email Address.");
                isValid = false;
            }

            // Phone Validation
            if (!string.IsNullOrWhiteSpace(member_Phone_NumberTextBox1.Text) &&
                !ValidationHelper.IsValidPhone(member_Phone_NumberTextBox1.Text))
            {
                ShowError(member_Phone_NumberTextBox1,
                    "Phone Number must be 10 digits and start with 0.");
                isValid = false;
            }

            if (!string.IsNullOrWhiteSpace(emergency_Contact_NumberTextBox1.Text) &&
                !ValidationHelper.IsValidPhone(emergency_Contact_NumberTextBox1.Text))
            {
                ShowError(emergency_Contact_NumberTextBox1,
                    "Emergency Contact Number must be 10 digits and start with 0.");
                isValid = false;
            }

            if (!string.IsNullOrWhiteSpace(member_TelephoneTextBox1.Text) &&
                !ValidationHelper.IsValidTelephone(member_TelephoneTextBox1.Text))
            {
                ShowError(member_TelephoneTextBox1,
                    "Telephone Number must be 10 digits and start with 0.");
                isValid = false;
            }

            // Postal Code Validation
            if (!string.IsNullOrWhiteSpace(member_Postal_CodeTextBox1.Text) &&
                !ValidationHelper.IsValidPostalCode(member_Postal_CodeTextBox1.Text))
            {
                ShowError(member_Postal_CodeTextBox1,
                    "Postal Code must be exactly 4 digits.");
                isValid = false;
            }

            // Street Number Validation
            if (!string.IsNullOrWhiteSpace(member_Street_NumberTextBox1.Text) &&
                !ValidationHelper.IsValidStreetNumber(member_Street_NumberTextBox1.Text))
            {
                ShowError(member_Street_NumberTextBox1,
                    "Street Number must contain numbers only.");
                isValid = false;
            }

            // Date of Birth Validation
            if (ValidationHelper.IsFutureDate(member_DOBDateTimePicker1.Value))
            {
                ShowError(member_DOBDateTimePicker1,
                    "Date of Birth cannot be today or a future date.");
                isValid = false;
            }

            if (!ValidationHelper.IsValidAge(member_DOBDateTimePicker1.Value, 16))
            {
                ShowError(member_DOBDateTimePicker1,
                    "Member must be at least 16 years old.");
                isValid = false;
            }

            return isValid;
        }
        private void ClearError(object sender, EventArgs e)
        {
            if (sender is Guna.UI2.WinForms.Guna2TextBox txt)
            {
                txt.BorderColor = Color.Silver;
                errorProvider1.SetError(txt, "");
            }
        }
        private void ClearValidationErrors()
        {
            errorProvider1.Clear();
            errorProvider1.SetError(member_DOBDateTimePicker1, "");
            member_IDTextBox1.BorderColor = Color.Silver;
            member_FNameTextBox1.BorderColor = Color.Silver;
            member_LNameTextBox1.BorderColor = Color.Silver;
            member_Phone_NumberTextBox1.BorderColor = Color.Silver;
            member_EmailTextBox1.BorderColor = Color.Silver;
            member_TelephoneTextBox1.BorderColor = Color.Silver;
            member_Street_NameTextBox1.BorderColor = Color.Silver;
            member_Street_NumberTextBox1.BorderColor = Color.Silver;
            member_CityTextBox1.BorderColor = Color.Silver;
            member_Postal_CodeTextBox1.BorderColor = Color.Silver;
            emergency_Contact_NameTextBox1.BorderColor = Color.Silver;
            emergency_Contact_NumberTextBox1.BorderColor = Color.Silver;
            GenderComboBox1.BackColor = Color.White;
            Provincecombobox1.BackColor = Color.White;
            RelationshipCB.BackColor = Color.White;
        }
        private void ClearComboError(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.ComboBox cb)
            {
                cb.BackColor = Color.White;
                errorProvider1.SetError(cb, "");
            }
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


        private void ClearMemberFields()
        {

            member_IDTextBox1.Clear();
            member_FNameTextBox1.Clear();
            member_LNameTextBox1.Clear();
            member_TelephoneTextBox1.Clear();
            member_Phone_NumberTextBox1.Clear();
            member_EmailTextBox1.Clear();
            member_Street_NameTextBox1.Clear();
            member_Street_NumberTextBox1.Clear();
            member_CityTextBox1.Clear();
            Provincecombobox1.SelectedIndex = -1;
            member_Postal_CodeTextBox1.Clear();
            GenderComboBox1.SelectedIndex = -1;
            emergency_Contact_NameTextBox1.Clear();
            emergency_Contact_NumberTextBox1.Clear();
            RelationshipCB.SelectedIndex = -1;
            
        }

        private void clearbtn1_Click(object sender, EventArgs e)
        {
          ClearMemberFields();
          ClearValidationErrors();
        }

        private void MemberSearchTxt_TextChanged(object sender, EventArgs e)
        {
            this.memberTableAdapter1.UpdatedMemberDetails(this.groupWst23DataSet.Member, MemberSearchTxt1.Text, MemberSearchTxt1.Text);
        }

        private void member_DOBDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }


    }
}
