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
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupWst23DataSet1.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.groupWst23DataSet1.Member);
            // TODO: This line of code loads data into the 'groupWst23DataSet1.Membership' table. You can move, or remove it, as needed.
            this.membershipTableAdapter.Fill(this.groupWst23DataSet1.Membership);
            paymentTableAdapter1.Fill(this.groupWst23DataSet1.Payment);
            Membermembership_IDTextBox.TextChanged += ClearError;
            membership_IDTextBox.TextChanged += ClearError;
            payment_BalanceTextBox.TextChanged += ClearError;
            planTypeTxt.TextChanged += ClearError;
            payment_DateDateTimePicker.MinDate = DateTime.Today;
            paymentCB.SelectedIndexChanged += ClearComboError;
        }
        private void PayBtnPayment_Click_1(object sender, EventArgs e)
        {
            try
            {
                ClearValidationErrors();

                bool isValid = true;

                if (string.IsNullOrWhiteSpace(Membermembership_IDTextBox.Text))
                {
                    ShowError(Membermembership_IDTextBox, "Member ID is required.");
                    isValid = false;
                }

                if (string.IsNullOrWhiteSpace(membership_IDTextBox.Text))
                {
                    ShowError(membership_IDTextBox, "Membership ID is required.");
                    isValid = false;
                }

                if (string.IsNullOrWhiteSpace(planTypeTxt.Text))
                {
                    ShowError(planTypeTxt, "Membership plan is required.");
                    isValid = false;
                }

                if (string.IsNullOrWhiteSpace(payment_BalanceTextBox.Text))
                {
                    ShowError(payment_BalanceTextBox, "Payment amount is required.");
                    isValid = false;
                }

                if (paymentCB.SelectedIndex == -1)
                {
                    ShowError(paymentCB, "Please select a payment method.");
                    isValid = false;
                }

                decimal amountPaid = 0;

                if (!string.IsNullOrWhiteSpace(payment_BalanceTextBox.Text) &&
                    !decimal.TryParse(payment_BalanceTextBox.Text, out amountPaid))
                {
                    ShowError(payment_BalanceTextBox, "Please enter a valid payment amount.");
                    isValid = false;
                }

                if (!isValid)
                {
                    return;
                }

                decimal monthlyFee = 0;

                switch (planTypeTxt.Text)
                {
                    case "sport science":
                        monthlyFee = 100;
                        break;

                    case "Normal Student":
                        monthlyFee = 250;
                        break;

                    case "Staff":
                        monthlyFee = 300;
                        break;

                    default:
                        ShowError(planTypeTxt, "Invalid membership plan.");
                        return;
                }

                int months = (int)(amountPaid / monthlyFee);

                if (months < 1)
                {
                    ShowError(payment_BalanceTextBox,
                        "Amount paid is insufficient for one month.");
                    return;
                }

                string membershipPeriod = months == 1
                    ? "1 Month"
                    : months + " Months";

                paymentTableAdapter2.AddPayment(
                    membership_IDTextBox.Text,
                    Membermembership_IDTextBox.Text,
                    DateTime.Now.ToString("yyyy-MM-dd"),
                    amountPaid,
                    membershipPeriod,
                    paymentCB.SelectedItem.ToString()
                );
                clearDetails();
                paymentTableAdapter2.Fill(this.groupWst23DataSet1.Payment);

                MessageBox.Show(
                    $"Payment Successful!\n\n" +
                    $"Amount Paid: R{amountPaid}\n" +
                    $"Months Purchased: {months}",
                    "Payment Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void clearDetails()
        {
            Membermembership_IDTextBox.Clear();
            membership_IDTextBox.Clear();
            payment_BalanceTextBox.Clear();
            planTypeTxt.Clear();
            paymentCB.SelectedIndex = -1;
            AmountDueTxt.Clear();

            ClearValidationErrors();
        }
        private void clearBtnPayment_Click_1(object sender, EventArgs e)
        {
            Membermembership_IDTextBox.Clear();
            membership_IDTextBox.Clear();
            payment_BalanceTextBox.Clear();
            planTypeTxt.Clear();
            paymentCB.SelectedIndex = -1;
            AmountDueTxt.Clear();

            ClearValidationErrors();
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
            if (sender is ComboBox cb)
            {
                cb.BackColor = Color.White;
                errorProvider1.SetError(cb, "");
            }
        }
        private void ClearValidationErrors()
        {
            errorProvider1.Clear();

            Membermembership_IDTextBox.BorderColor = Color.Silver;
            membership_IDTextBox.BorderColor = Color.Silver;
            payment_BalanceTextBox.BorderColor = Color.Silver;
            planTypeTxt.BorderColor = Color.Silver;

            paymentCB.BackColor = Color.White;
        }
        private void ShowError(Control control, string message)
        {
            errorProvider1.SetError(control, message);

            if (control is Guna.UI2.WinForms.Guna2TextBox txt)
            {
                txt.BorderColor = Color.Red;
            }
            else if (control is ComboBox cb)
            {
                cb.BackColor = Color.MistyRose;
            }
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            membership_IDTextBox.Text = guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
            AmountDueTxt.Text= guna2DataGridView1.CurrentRow.Cells[2].Value.ToString();
            planTypeTxt.Text=guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
      
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Membermembership_IDTextBox_TextChanged(object sender, EventArgs e)
        {
            this.memberTableAdapter.MemberSearchByNameOrID(this.groupWst23DataSet1.Member, Membermembership_IDTextBox.Text, Membermembership_IDTextBox.Text);
        }

        private void guna2DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Membermembership_IDTextBox.Text= guna2DataGridView2.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
