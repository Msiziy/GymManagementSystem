using Guna.UI2.WinForms;
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
    public partial class UpdateMemberDetails : Form
    {
        public UpdateMemberDetails()
        {
            InitializeComponent();
        }


        //string status;
        private void UpdateMemberDetails_Load(object sender, EventArgs e)
        {
            this.memberTableAdapter1.Fill(this.groupWst23DataSet.Member);

            member_IDTextBox2.TextChanged += ClearError;
            member_FNameTextBox2.TextChanged += ClearError;
            member_LNameTextBox2.TextChanged += ClearError;
            member_EmailTextBox2.TextChanged += ClearError;
            member_Phone_NumberTextBox2.TextChanged += ClearError;
            member_TelephoneTextBox2.TextChanged += ClearError;
            member_Street_NameTextBox2.TextChanged += ClearError;
            member_Street_NumberTextBox2.TextChanged += ClearError;
            member_CityTextBox2.TextChanged += ClearError;
            member_Postal_CodeTextBox2.TextChanged += ClearError;
            emergency_Contact_NameTextBox2.TextChanged += ClearError;
            emergency_Contact_NumberTextBox2.TextChanged += ClearError;

            GenderComboBox2.SelectedIndexChanged += ClearComboError;
            Provincecombobox2.SelectedIndexChanged += ClearComboError;
            RelationshipCB.SelectedIndexChanged += ClearComboError;
            MemberStatusCB.SelectedIndexChanged += ClearComboError;

            member_DOBDateTimePicker2.ValueChanged += ClearDateError;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string memberID = MemberSearchTxt.Text.ToString();
            string memberName = MemberSearchTxt.Text.ToString();
            this.memberTableAdapter1.UpdatedMemberDetails(this.groupWst23DataSet.Member, memberID, memberName);
            if (guna2DataGridView1.CurrentRow == null)
            {
                return;
            }

            if (guna2DataGridView1.CurrentRow.Cells[0].Value == null)
            {
                return;
            }
            joinDate = guna2DataGridView1.CurrentRow.Cells[13].Value.ToString();
            member_IDTextBox2.Text = guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
            member_FNameTextBox2.Text = guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
            member_LNameTextBox2.Text = guna2DataGridView1.CurrentRow.Cells[2].Value.ToString();
            member_TelephoneTextBox2.Text = guna2DataGridView1.CurrentRow.Cells[3].Value.ToString();
            member_Phone_NumberTextBox2.Text = guna2DataGridView1.CurrentRow.Cells[4].Value.ToString();
            member_EmailTextBox2.Text = guna2DataGridView1.CurrentRow.Cells[5].Value.ToString();
            member_Street_NameTextBox2.Text = guna2DataGridView1.CurrentRow.Cells[6].Value.ToString();
            member_Street_NumberTextBox2.Text = guna2DataGridView1.CurrentRow.Cells[7].Value.ToString();
            member_CityTextBox2.Text = guna2DataGridView1.CurrentRow.Cells[8].Value.ToString();
            Provincecombobox2.Text = guna2DataGridView1.CurrentRow.Cells[9].Value.ToString();
            member_Postal_CodeTextBox2.Text = guna2DataGridView1.CurrentRow.Cells[10].Value.ToString();
            GenderComboBox2.Text = guna2DataGridView1.CurrentRow.Cells[11].Value.ToString();
            member_DOBDateTimePicker2.Value = Convert.ToDateTime(guna2DataGridView1.CurrentRow.Cells[12].Value);
            emergency_Contact_NameTextBox2.Text = guna2DataGridView1.CurrentRow.Cells[15].Value.ToString();
            emergency_Contact_NumberTextBox2.Text = guna2DataGridView1.CurrentRow.Cells[16].Value.ToString();
            RelationshipCB.Text = guna2DataGridView1.CurrentRow.Cells[17].Value.ToString();

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RegisterBtn1_Click(object sender, EventArgs e)
        {
            if (!MemberIDExists(member_IDTextBox2.Text))
            {
                MessageBox.Show("Member ID does not exist.",
                    "Update Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            // Validate details
            if (!ValidateMemberDetails())
            {
                return;
            }

            try
            {
                memberTableAdapter1.UpdateMember(
                    member_FNameTextBox2.Text,
                    member_LNameTextBox2.Text,
                    member_TelephoneTextBox2.Text,
                    member_Phone_NumberTextBox2.Text,
                    member_EmailTextBox2.Text,
                    member_Street_NameTextBox2.Text,
                    member_Street_NumberTextBox2.Text,
                    member_CityTextBox2.Text,
                    Provincecombobox2.SelectedItem.ToString(),
                    member_Postal_CodeTextBox2.Text,
                    MemberStatusCB.Text,
                    emergency_Contact_NameTextBox2.Text,
                    emergency_Contact_NumberTextBox2.Text,
                    RelationshipCB.Text,
                    member_IDTextBox2.Text
                );

                // Refresh DataGridView
                this.memberTableAdapter1.Fill(this.groupWst23DataSet.Member);

                MessageBox.Show("Member updated successfully.",
                    "Update Successful",
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
                // Skip empty row
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

            if (string.IsNullOrWhiteSpace(member_IDTextBox2.Text))
            {
                ShowError(member_IDTextBox2, "Member ID is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(member_FNameTextBox2.Text))
            {
                ShowError(member_FNameTextBox2, "First Name is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(member_LNameTextBox2.Text))
            {
                ShowError(member_LNameTextBox2, "Last Name is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(member_Phone_NumberTextBox2.Text))
            {
                ShowError(member_Phone_NumberTextBox2, "Phone Number is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(member_EmailTextBox2.Text))
            {
                ShowError(member_EmailTextBox2, "Email Address is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(member_Street_NameTextBox2.Text))
            {
                ShowError(member_Street_NameTextBox2, "Street Name is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(member_Street_NumberTextBox2.Text))
            {
                ShowError(member_Street_NumberTextBox2, "Street Number is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(member_CityTextBox2.Text))
            {
                ShowError(member_CityTextBox2, "City is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(member_Postal_CodeTextBox2.Text))
            {
                ShowError(member_Postal_CodeTextBox2, "Postal Code is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(emergency_Contact_NameTextBox2.Text))
            {
                ShowError(emergency_Contact_NameTextBox2, "Emergency Contact Name is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(emergency_Contact_NumberTextBox2.Text))
            {
                ShowError(emergency_Contact_NumberTextBox2, "Emergency Contact Number is required.");
                isValid = false;
            }

            if (GenderComboBox2.SelectedIndex == -1)
            {
                ShowError(GenderComboBox2, "Please select a Gender.");
                isValid = false;
            }

            if (Provincecombobox2.SelectedIndex == -1)
            {
                ShowError(Provincecombobox2, "Please select a Province.");
                isValid = false;
            }

            if (RelationshipCB.SelectedIndex == -1)
            {
                ShowError(RelationshipCB, "Please select a Relationship.");
                isValid = false;
            }

            if (MemberStatusCB.SelectedIndex == -1)
            {
                ShowError(MemberStatusCB, "Please select a Status.");
                isValid = false;
            }

            if (!ValidationHelper.ContainsNoSpaces(member_IDTextBox2.Text))
            {
                ShowError(member_IDTextBox2, "Member ID cannot contain spaces.");
                isValid = false;
            }

            if (!ValidationHelper.IsValidMemberID(member_IDTextBox2.Text))
            {
                ShowError(member_IDTextBox2, "Member ID must be exactly 9 digits.");
                isValid = false;
            }

            if (!ValidationHelper.IsAlphabetOnly(member_FNameTextBox2.Text))
            {
                ShowError(member_FNameTextBox2, "First Name must contain letters only.");
                isValid = false;
            }

            if (!ValidationHelper.IsAlphabetOnly(member_LNameTextBox2.Text))
            {
                ShowError(member_LNameTextBox2, "Last Name must contain letters only.");
                isValid = false;
            }

            if (!ValidationHelper.IsAlphabetOnly(member_Street_NameTextBox2.Text))
            {
                ShowError(member_Street_NameTextBox2, "Street Name must contain letters only.");
                isValid = false;
            }

            if (!ValidationHelper.IsAlphabetOnly(member_CityTextBox2.Text))
            {
                ShowError(member_CityTextBox2, "City must contain letters only.");
                isValid = false;
            }

            if (!ValidationHelper.IsAlphabetOnly(emergency_Contact_NameTextBox2.Text))
            {
                ShowError(emergency_Contact_NameTextBox2,
                    "Emergency Contact Name must contain letters only.");
                isValid = false;
            }

            if (!ValidationHelper.IsValidEmail(member_EmailTextBox2.Text))
            {
                ShowError(member_EmailTextBox2, "Invalid Email Address.");
                isValid = false;
            }

            if (!ValidationHelper.IsValidPhone(member_Phone_NumberTextBox2.Text))
            {
                ShowError(member_Phone_NumberTextBox2,
                    "Phone Number must be 10 digits and start with 0.");
                isValid = false;
            }

            if (!string.IsNullOrWhiteSpace(member_TelephoneTextBox2.Text) &&
                !ValidationHelper.IsValidTelephone(member_TelephoneTextBox2.Text))
            {
                ShowError(member_TelephoneTextBox2,
                    "Telephone Number must be 10 digits and start with 0.");
                isValid = false;
            }

            if (!ValidationHelper.IsValidPhone(emergency_Contact_NumberTextBox2.Text))
            {
                ShowError(emergency_Contact_NumberTextBox2,
                    "Emergency Contact Number must be 10 digits and start with 0.");
                isValid = false;
            }

            if (!ValidationHelper.IsValidPostalCode(member_Postal_CodeTextBox2.Text))
            {
                ShowError(member_Postal_CodeTextBox2,
                    "Postal Code must be exactly 4 digits.");
                isValid = false;
            }

            if (!ValidationHelper.IsValidStreetNumber(member_Street_NumberTextBox2.Text))
            {
                ShowError(member_Street_NumberTextBox2,
                    "Street Number must contain numbers only.");
                isValid = false;
            }

            if (ValidationHelper.IsFutureDate(member_DOBDateTimePicker2.Value))
            {
                ShowError(member_DOBDateTimePicker2,
                    "Date of Birth cannot be today or a future date.");
                isValid = false;
            }

            if (!ValidationHelper.IsValidAge(member_DOBDateTimePicker2.Value, 16))
            {
                ShowError(member_DOBDateTimePicker2,
                    "Member must be at least 16 years old.");
                isValid = false;
            }

            return isValid;
        }
        private void ShowError(Control control, string message)
        {
            errorProvider1.SetError(control, message);

            if (control is Guna2TextBox txt)
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
            if (sender is Guna2TextBox txt)
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
            errorProvider1.SetError(member_DOBDateTimePicker2, "");
        }

        private void ClearValidationErrors()
        {
            errorProvider1.Clear();

            member_IDTextBox2.BorderColor = Color.Silver;
            member_FNameTextBox2.BorderColor = Color.Silver;
            member_LNameTextBox2.BorderColor = Color.Silver;
            member_TelephoneTextBox2.BorderColor = Color.Silver;
            member_Phone_NumberTextBox2.BorderColor = Color.Silver;
            member_EmailTextBox2.BorderColor = Color.Silver;
            member_Street_NameTextBox2.BorderColor = Color.Silver;
            member_Street_NumberTextBox2.BorderColor = Color.Silver;
            member_CityTextBox2.BorderColor = Color.Silver;
            member_Postal_CodeTextBox2.BorderColor = Color.Silver;
            emergency_Contact_NameTextBox2.BorderColor = Color.Silver;
            emergency_Contact_NumberTextBox2.BorderColor = Color.Silver;

            GenderComboBox2.BackColor = Color.White;
            Provincecombobox2.BackColor = Color.White;
            RelationshipCB.BackColor = Color.White;
            MemberStatusCB.BackColor = Color.White;
        }
        String joinDate = "";
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Prevent errors when clicking column headers
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = guna2DataGridView1.Rows[e.RowIndex];

            joinDate = row.Cells[13].Value?.ToString() ?? "";

            member_IDTextBox2.Text = row.Cells[0].Value?.ToString() ?? "";
            member_FNameTextBox2.Text = row.Cells[1].Value?.ToString() ?? "";
            member_LNameTextBox2.Text = row.Cells[2].Value?.ToString() ?? "";
            member_TelephoneTextBox2.Text = row.Cells[3].Value?.ToString() ?? "";
            member_Phone_NumberTextBox2.Text = row.Cells[4].Value?.ToString() ?? "";
            member_EmailTextBox2.Text = row.Cells[5].Value?.ToString() ?? "";
            member_Street_NameTextBox2.Text = row.Cells[6].Value?.ToString() ?? "";
            member_Street_NumberTextBox2.Text = row.Cells[7].Value?.ToString() ?? "";
            member_CityTextBox2.Text = row.Cells[8].Value?.ToString() ?? "";
            Provincecombobox2.Text = row.Cells[9].Value?.ToString() ?? "";
            member_Postal_CodeTextBox2.Text = row.Cells[10].Value?.ToString() ?? "";
            GenderComboBox2.Text = row.Cells[11].Value?.ToString() ?? "";

            if (row.Cells[12].Value != null)
            {
                member_DOBDateTimePicker2.Value =
                    Convert.ToDateTime(row.Cells[12].Value);
            }

            MemberStatusCB.Text = row.Cells[14].Value?.ToString() ?? "";
            emergency_Contact_NameTextBox2.Text = row.Cells[15].Value?.ToString() ?? "";
            emergency_Contact_NumberTextBox2.Text = row.Cells[16].Value?.ToString() ?? "";
            RelationshipCB.Text = row.Cells[17].Value?.ToString() ?? "";
        }

        private void clearbtn2_Click(object sender, EventArgs e)
        {
            ClearMemberFields();
        }
   
        private void ClearMemberFields()
        {
            member_IDTextBox2.Clear();
            member_FNameTextBox2.Clear();
            member_LNameTextBox2.Clear();
            member_TelephoneTextBox2.Clear();
            member_Phone_NumberTextBox2.Clear();
            member_EmailTextBox2.Clear();
            member_Street_NameTextBox2.Clear();
            member_Street_NumberTextBox2.Clear();
            member_CityTextBox2.Clear();
            Provincecombobox2.SelectedIndex = -1;
            member_Postal_CodeTextBox2.Clear();
            GenderComboBox2.SelectedIndex = -1;
            emergency_Contact_NameTextBox2.Clear();
            emergency_Contact_NumberTextBox2.Clear();
            RelationshipCB.SelectedIndex = -1;
           
          
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string memberID = member_IDTextBox2.Text.Trim();

                // Check if a member has been selected
                if (string.IsNullOrWhiteSpace(memberID))
                {
                    MessageBox.Show(
                        "Please select a member to delete.",
                        "No Member Selected",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // Check if member exists
                int count = Convert.ToInt32(
                    memberTableAdapter1.CheckMemberIDExists(memberID)
                );

                if (count == 0)
                {
                    MessageBox.Show(
                        "Member ID does not exist.",
                        "Delete Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                // Confirm delete
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to permanently delete Member {memberID}?\n\n" +
                    "This action cannot be undone.",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result != DialogResult.Yes)
                {
                    MessageBox.Show(
                        "Delete cancelled.",
                        "Cancelled",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }

                // Archive member before deleting
                archiveMemberTableAdapter1.InsertMemberArchive(
                    memberID,
                    member_FNameTextBox2.Text,
                    member_LNameTextBox2.Text,
                    member_TelephoneTextBox2.Text,
                    member_Phone_NumberTextBox2.Text,
                    member_EmailTextBox2.Text,
                    member_Street_NameTextBox2.Text,
                    member_Street_NumberTextBox2.Text,
                    member_CityTextBox2.Text,
                    Provincecombobox2.Text,
                    member_Postal_CodeTextBox2.Text,
                    GenderComboBox2.Text,
                    member_DOBDateTimePicker2.Value.ToString("yyyy-MM-dd"),
                    joinDate,
                    MemberStatusCB.Text,
                    emergency_Contact_NameTextBox2.Text,
                    emergency_Contact_NumberTextBox2.Text,
                    RelationshipCB.Text
                );

                // Delete related records first
                paymentTableAdapter1.DeletePaymentDetails(memberID);
                training_SessionTableAdapter1.DeleteTrainingSession(memberID);
                // Delete member
                memberTableAdapter1.DeleteMember(memberID);

                // Refresh DataGridView
                memberTableAdapter1.Fill(groupWst23DataSet.Member);

                // Clear controls
                ClearMemberFields();

                MessageBox.Show(
                    "Member deleted successfully.",
                    "Delete Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"An error occurred while deleting the member.\n\n{ex.Message}",
                    "Delete Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void guna2GroupBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
