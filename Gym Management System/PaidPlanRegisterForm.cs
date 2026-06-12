using Guna.UI2.WinForms;
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
    public partial class PaidPlanRegisterForm : Form
    {
        public PaidPlanRegisterForm()
        {
            InitializeComponent();
        }

        private void PaidPlanRegisterForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupWst23DataSet.PaidPlanRegister' table.
            this.paidPlanRegisterTableAdapter.Fill(this.groupWst23DataSet.PaidPlanRegister);

            SignoutBtn.Enabled = false;

            guna2DateTimePicker1.Format = DateTimePickerFormat.Time;
            guna2DateTimePicker1.ShowUpDown = true;

            guna2DateTimePicker2.Format = DateTimePickerFormat.Time;
            guna2DateTimePicker2.ShowUpDown = true;
            guna2DateTimePicker2.Enabled = false;
            MemberRegisterIDtxt.TextChanged += ClearError;
            this.memberTableAdapter1.Fill(this.groupWst23DataSet.Member);
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            guna2DateTimePicker2.Enabled = true;
            SignoutBtn.Enabled = true;
            MemberRegisterIDtxt.Text = guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
            guna2DateTimePicker1.Value =DateTime.Today.Add((TimeSpan)guna2DataGridView1.CurrentRow.Cells[2].Value);
        }

        private void TimeInTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ClearValidationErrors();

                bool isValid = true;

                if (string.IsNullOrWhiteSpace(MemberRegisterIDtxt.Text))
                {
                    ShowError(MemberRegisterIDtxt, "Please enter a Member ID.");
                    isValid = false;
                }

                if (!string.IsNullOrWhiteSpace(MemberRegisterIDtxt.Text) &&
                    !int.TryParse(MemberRegisterIDtxt.Text, out _))
                {
                    ShowError(MemberRegisterIDtxt, "Member ID must be numeric.");
                    isValid = false;
                }

                if (!isValid)
                {
                    return;
                }

                int count = (int)this.memberTableAdapter1.CheckMemberIDExists(MemberRegisterIDtxt.Text);

                if (count == 0)
                {
                    ShowError(MemberRegisterIDtxt, "Member ID does not exist.");
                    return;
                }

                DateTime registerDate = RegisterDatetxt.Value;
                DateTime timeIn = guna2DateTimePicker1.Value;

                this.paidPlanRegisterTableAdapter.SignIn(
                    MemberRegisterIDtxt.Text,
                    registerDate.ToString("yyyy-MM-dd"),
                    timeIn.ToString("HH:mm:ss")
                );

                this.paidPlanRegisterTableAdapter.Fill(this.groupWst23DataSet.PaidPlanRegister);

                MessageBox.Show(
                    "Member signed in successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void SignoutBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ClearValidationErrors();

                bool isValid = true;

                if (string.IsNullOrWhiteSpace(MemberRegisterIDtxt.Text))
                {
                    ShowError(MemberRegisterIDtxt, "Please enter a Member ID.");
                    isValid = false;
                }

                if (!string.IsNullOrWhiteSpace(MemberRegisterIDtxt.Text) &&
                    !int.TryParse(MemberRegisterIDtxt.Text, out _))
                {
                    ShowError(MemberRegisterIDtxt, "Member ID must be numeric.");
                    isValid = false;
                }

                if (guna2DateTimePicker2.Value.TimeOfDay <= guna2DateTimePicker1.Value.TimeOfDay)
                {
                    errorProvider1.SetError(guna2DateTimePicker2,
                        "Sign-out time must be after sign-in time.");
                    isValid = false;
                }

                if (!isValid)
                {
                    return;
                }

                DateTime timeOut = guna2DateTimePicker2.Value;

                this.paidPlanRegisterTableAdapter.SignOut(
                    timeOut.ToString("HH:mm:ss"),
                    MemberRegisterIDtxt.Text
                );

                this.paidPlanRegisterTableAdapter.Fill(this.groupWst23DataSet.PaidPlanRegister);

                MessageBox.Show(
                    "Member signed out successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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
        private void ClearValidationErrors()
        {
            errorProvider1.Clear();

            MemberRegisterIDtxt.BorderColor = Color.Silver;
        }
        private void ShowError(Control control, string message)
        {
            errorProvider1.SetError(control, message);

            if (control is Guna2TextBox txt)
            {
                txt.BorderColor = Color.Red;
            }
        }

        private void guna2DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MemberRegisterIDtxt.Text= guna2DataGridView2.CurrentRow.Cells[0].Value.ToString();
        }

        private void MemberRegisterIDtxt_TextChanged(object sender, EventArgs e)
        {
            this.memberTableAdapter1.MemberSearchByNameOrID(this.groupWst23DataSet.Member, MemberRegisterIDtxt.Text, MemberRegisterIDtxt.Text);
        }
    }
}
