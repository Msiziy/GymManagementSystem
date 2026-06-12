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
    public partial class MembershipPlan : Form
    {
        public MembershipPlan()
        {
            InitializeComponent();
        }

        private void MembershipPlan_Load(object sender, EventArgs e)
        {
            this.membershipTableAdapter1.Fill(this.groupWst23DataSet1.Membership);
        }

        private void UpdateMembershipPlanBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int membershipID = Convert.ToInt32(MembershipPlanUpdateTextBox.Text);
                decimal planPrice = Convert.ToDecimal(PlanPriceTxt1.Text);

                membershipTableAdapter1.UpdateMembershipPlan(MembershipPlanUpdateTextBox.Text, planPrice, ManagerMembershipDesriptionTextBox.Text, membershipID.ToString());

                membershipTableAdapter1.Fill(groupWst23DataSet1.Membership);

                MessageBox.Show("Membership plan updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ManageMembershipAddNewMembershipBtn_Click(object sender, EventArgs e)
        {
            try
            {
                decimal planPrice = Convert.ToDecimal(PlanPriceTxt1.Text);
                string membershipPlanType = MembershipPlanTypeTextBox1.Text;
                string membershipPlanID = MembershipPlanUpdateTextBox.Text;


                membershipTableAdapter1.AddNewMembershipPlan(membershipPlanID, membershipPlanType, planPrice, ManagerMembershipDesriptionTextBox.Text);


                membershipTableAdapter1.Fill(groupWst23DataSet1.Membership);

                MessageBox.Show("New membership plan added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void membershipDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = membershipDataGridView.Rows[e.RowIndex];

            //    MembershipPlanTextBox.Text = row.Cells[0].Value.ToString();
            //    MembershipPlanTypeTextBox.Text = row.Cells[1].Value.ToString();
            //    PlanPriceTxt.Text = row.Cells[2].Value.ToString();
            //    ManagerMembershipDesriptionTextBox.Text = row.Cells[3].Value.ToString();
            //}
        }

        private void MembershipPlanTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void membershipDataGridView_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void UpdateMembershipPlanBtn1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateMembershipInputs())
                {
                    return;
                }

                int idCount = Convert.ToInt32(
                    membershipTableAdapter1.CheckMembershipIDExists(
                        MembershipPlanUpdateTextBox.Text
                    )
                );

                if (idCount == 0)
                {
                    MessageBox.Show("Membership ID does not exist.");
                    return;
                }

                decimal planPrice = Convert.ToDecimal(PlanPriceTxt1.Text);

                membershipTableAdapter1.UpdateMembershipPlan(
                    MembershipPlanTypeTextBox1.Text,
                    planPrice,
                    ManagerMembershipDesriptionTextBox.Text,
                    MembershipPlanUpdateTextBox.Text
                );

                membershipTableAdapter1.Fill(groupWst23DataSet1.Membership);

                MessageBox.Show("Membership plan updated successfully.");

                ClearMembershipFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ManageMembershipAddNewMembershipBtn1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateMembershipInputs())
                {
                    return;
                }

                int idCount = Convert.ToInt32(
                    membershipTableAdapter1.CheckMembershipIDExists(
                        MembershipPlanUpdateTextBox.Text
                    )
                );

                if (idCount > 0)
                {
                    MessageBox.Show("Membership ID already exists.");
                    return;
                }

                decimal planPrice = Convert.ToDecimal(PlanPriceTxt1.Text);

                membershipTableAdapter1.AddNewMembershipPlan(
                    MembershipPlanUpdateTextBox.Text,
                    MembershipPlanTypeTextBox1.Text,
                    planPrice,
                    ManagerMembershipDesriptionTextBox.Text
                );

                membershipTableAdapter1.Fill(groupWst23DataSet1.Membership);

                MessageBox.Show("New membership plan added successfully.");

                ClearMembershipFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void guna2DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = guna2DataGridView1.Rows[e.RowIndex];

                MembershipPlanUpdateTextBox.Text = row.Cells[0].Value.ToString();
                MembershipPlanTypeTextBox1.Text = row.Cells[1].Value.ToString();
                PlanPriceTxt1.Text = row.Cells[2].Value.ToString();
                ManagerMembershipDesriptionTextBox.Text = row.Cells[3].Value.ToString();
            }
        }


        private bool IsDecimalValue(string value)
        {
            decimal number;
            return decimal.TryParse(value, out number);
        }

        private bool IsAlphabetOnly(string value)
        {
            return value.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));
        }

        private bool IsAlphaNumeric(string value)
        {
            return value.All(char.IsLetterOrDigit);
        }

        private bool ValidateMembershipInputs()
        {
            // Check for empty fields
            if (string.IsNullOrWhiteSpace(MembershipPlanUpdateTextBox.Text) ||
                string.IsNullOrWhiteSpace(MembershipPlanTypeTextBox1.Text) ||
                string.IsNullOrWhiteSpace(PlanPriceTxt1.Text) ||
                string.IsNullOrWhiteSpace(ManagerMembershipDesriptionTextBox.Text))
            {
                MessageBox.Show("Please fill in all membership plan details.");
                return false;
            }

            // Membership ID Validation
            if (MembershipPlanUpdateTextBox.Text.Contains(" "))
            {
                MessageBox.Show("Membership ID must not contain spaces.");
                return false;
            }

            if (!IsAlphaNumeric(MembershipPlanUpdateTextBox.Text))
            {
                MessageBox.Show("Membership ID must contain letters and numbers only.");
                return false;
            }

            if (MembershipPlanUpdateTextBox.Text.Length < 3)
            {
                MessageBox.Show("Membership ID must be at least 3 characters long.");
                return false;
            }

            if (MembershipPlanUpdateTextBox.Text.Length > 20)
            {
                MessageBox.Show("Membership ID must not exceed 20 characters.");
                return false;
            }

            // Membership Plan Type Validation
            if (!IsAlphabetOnly(MembershipPlanTypeTextBox1.Text))
            {
                MessageBox.Show("Plan type must contain alphabets only.");
                return false;
            }

            if (MembershipPlanTypeTextBox1.Text.Trim().Length < 3)
            {
                MessageBox.Show("Plan type must be at least 3 characters long.");
                return false;
            }

            // Plan Price Validation
            if (!IsDecimalValue(PlanPriceTxt1.Text))
            {
                MessageBox.Show("Plan price must be a valid number.");
                return false;
            }

            decimal price = Convert.ToDecimal(PlanPriceTxt1.Text);

            if (price <= 0)
            {
                MessageBox.Show("Plan price must be greater than zero.");
                return false;
            }

            if (price > 100000)
            {
                MessageBox.Show("Plan price exceeds the allowed limit.");
                return false;
            }

            // Description Validation
            string description = ManagerMembershipDesriptionTextBox.Text.Trim();

            if (description.Length < 10)
            {
                MessageBox.Show("Plan description must be at least 10 characters long.");
                return false;
            }

            if (description.Length > 255)
            {
                MessageBox.Show("Plan description must not exceed 255 characters.");
                return false;
            }

            return true;
        }

        private void ClearMembershipFields()
        {
            MembershipPlanUpdateTextBox.Clear();
            MembershipPlanTypeTextBox1.Clear();
            PlanPriceTxt1.Clear();
            ManagerMembershipDesriptionTextBox.Clear();

            MembershipPlanUpdateTextBox.Focus();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MembershipPlanUpdateTextBox.Text = guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
            MembershipPlanTypeTextBox1.Text = guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
            PlanPriceTxt1.Text = guna2DataGridView1.CurrentRow.Cells[2].Value.ToString();
            ManagerMembershipDesriptionTextBox.Text = guna2DataGridView1.CurrentRow.Cells[3].Value.ToString();

        }
    }
}
