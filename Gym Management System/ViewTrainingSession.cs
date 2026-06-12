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
    public partial class ViewTrainingSession : Form
    {
        public ViewTrainingSession()
        {
            InitializeComponent();
        }

        private void ViewTrainingSession_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupWst23DataSet.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.groupWst23DataSet.Member);
            // TODO: This line of code loads data into the 'groupWst23DataSet.Training_Session' table. You can move, or remove it, as needed.
            this.training_SessionTableAdapter.Fill(this.groupWst23DataSet.Training_Session);
            
            SessionIDtxt.TextChanged += ClearError;
            AttendanceCb.SelectedIndexChanged += ClearComboError;
            SessionStatusCb.SelectedIndexChanged += ClearComboError;
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore header row clicks
            if (e.RowIndex < 0) return;

            if (guna2DataGridView1.CurrentRow == null) return;

            try
            {
                var row = guna2DataGridView1.CurrentRow;

                // Safely get Session ID
                if (row.Cells[0].Value == null || string.IsNullOrWhiteSpace(row.Cells[0].Value.ToString()))
                {
                    MessageBox.Show(
                        "Selected row has no Session ID.",
                        "Invalid Selection",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                SessionIDtxt.Text = row.Cells[0].Value.ToString();

                // Safely get Attendance
                AttendanceCb.Text = row.Cells[6].Value != null
                    ? row.Cells[6].Value.ToString()
                    : string.Empty;

                // Safely get Session Status
                SessionStatusCb.Text = row.Cells[10].Value != null
                    ? row.Cells[10].Value.ToString()
                    : string.Empty;

                // Safely get Session Date
                if (row.Cells[5].Value != null &&
                    DateTime.TryParse(row.Cells[5].Value.ToString(), out DateTime sessionDate))
                {
                    SessionDateTxt.Value = sessionDate;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error selecting row: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            ClearValidationErrors();

            bool isValid = true;

            int sessionID;

            if (!int.TryParse(SessionIDtxt.Text, out sessionID))
            {
                ShowError(SessionIDtxt, "Please select a valid Session ID.");
                isValid = false;
            }

            if (AttendanceCb.SelectedIndex == -1)
            {
                ShowError(AttendanceCb, "Please select Attendance.");
                isValid = false;
            }

            if (SessionStatusCb.SelectedIndex == -1)
            {
                ShowError(SessionStatusCb, "Please select Session Status.");
                isValid = false;
            }

            if (!isValid)
            {
                return;
            }

            try
            {
                this.training_SessionTableAdapter.UpdateTrainingSession(
                    SessionDateTxt.Value.ToString("yyyy-MM-dd"),
                    AttendanceCb.Text,
                    SessionStatusCb.Text,
                    sessionID
                );

                this.training_SessionTableAdapter.Fill(this.groupWst23DataSet.Training_Session);

                MessageBox.Show(
                    "Training session updated successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ClearValidationErrors();
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
        private void ClearValidationErrors()
        {
            errorProvider1.Clear();

            SessionIDtxt.BorderColor = Color.Silver;
            AttendanceCb.BackColor = Color.White;
            SessionStatusCb.BackColor = Color.White;
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

        private void clearSessionBtn_Click(object sender, EventArgs e)
        {
            SessionIDtxt.Clear();
            AttendanceCb.SelectedIndex = -1;
            SessionStatusCb.SelectedIndex = -1;

            ClearValidationErrors();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            this.memberTableAdapter.MemberSearchByNameOrID(this.groupWst23DataSet.Member, guna2TextBox1.Text, guna2TextBox1.Text);
            this.training_SessionTableAdapter.FillByMemberID(this.groupWst23DataSet.Training_Session,guna2TextBox1.Text);
        }

        //private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        //{
        //    this.training_SessionTableAdapter.SearchByID(this.groupWst23DataSet.Training_Session,Convert.ToInt32(guna2TextBox1.Text));
        //}
    }
}
