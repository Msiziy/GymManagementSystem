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
    public partial class BookTrainingSessions : Form
    {
        public BookTrainingSessions()
        {
            InitializeComponent();
        }

        private void BookTrainingSessions_Load(object sender, EventArgs e)
        {
            session_DateDateTimePicker1.MinDate = DateTime.Today;
            // TODO: This line of code loads data into the 'groupWst23DataSet.Member' table.
            this.memberTableAdapter.Fill(this.groupWst23DataSet.Member);

            // TODO: This line of code loads data into the 'groupWst23DataSet.Trainer_Schedule' table.
            this.trainer_ScheduleTableAdapter.SortByAvailability(
                this.groupWst23DataSet.Trainer_Schedule,
                "Availability");

            // TODO: This line of code loads data into the 'groupWst23DataSet.Training_Session' table.
            this.training_SessionTableAdapter.Fill(this.groupWst23DataSet.Training_Session);

            // TODO: This line of code loads data into the 'groupWst23DataSet.Staff' table.
            this.staffTableAdapter1.FillByTrainer(this.groupWst23DataSet.Staff);

            // TODO: This line of code loads data into the 'groupWst23DataSet.Time_Slot' table.
            this.time_SlotTableAdapter.Fill(this.groupWst23DataSet.Time_Slot);

            guna2DateTimePicker1.Format = DateTimePickerFormat.Time;
            guna2DateTimePicker1.ShowUpDown = true;

            guna2DateTimePicker2.Format = DateTimePickerFormat.Time;
            guna2DateTimePicker2.ShowUpDown = true;

            CalculateDuration();

            member_IDTextBox1.TextChanged += ClearError;
            StaffCB1.TextChanged += ClearComboError;
            SessionTypeCB1.SelectedIndexChanged += ClearComboError;
        }
        string session_ID = "";
        string time_ID = "";
        int capacity = 0;
        int attendance= 0;
        private void GetSessionCapacity()
        {
            this.session_TableTableAdapter1.RetrieveCapacity(
                this.groupWst23DataSet.Session_Table,
                SessionTypeCB1.Text
            );



            if (groupWst23DataSet.Session_Table.Rows.Count > 0)
            {
                capacity = Convert.ToInt32(groupWst23DataSet.Session_Table.Rows[0]["Session_Capacity"]);
            }
        }
  
        private void GetSessionID()
        {
            this.session_TableTableAdapter1.RetrieveBySessionType(
                this.groupWst23DataSet.Session_Table,
                SessionTypeCB1.Text
            );

             

            if (groupWst23DataSet.Session_Table.Rows.Count > 0)
            {
                session_ID = groupWst23DataSet.Session_Table.Rows[0]["Session_ID"].ToString();
            }
        }

        private void GetTimeID()
        {
            TimeSpan selectedTime = guna2DateTimePicker1.Value.TimeOfDay;

            this.time_SlotTableAdapter1.RetrieveTimeID( this.groupWst23DataSet.Time_Slot,selectedTime.ToString(@"hh\:mm\:ss")    
);

            if (groupWst23DataSet.Time_Slot.Rows.Count > 0)
            {
                time_ID = groupWst23DataSet.Time_Slot.Rows[0]["Time_ID"].ToString();
            }
            else
            {
                MessageBox.Show("No Time ID found for selected time.");
                return;
            }
        }
        private void BookSessionBtn1_Click(object sender, EventArgs e)
        {
           
            if (!ValidateSessionDetails())
                return;

            try
            {

                GetSessionID();
                GetTimeID();
                GetSessionCapacity();
                //GetMemberAttendance();
                //attendance += 1; // Increment attendance for the new booking
                int count = Convert.ToInt32(training_Session2_0TableAdapter1.FindDoubleSession(
                 session_DateDateTimePicker1.Value.ToString("yyyy-MM-dd"),
                 StaffCB1.Text,
                 guna2DateTimePicker1.Value.ToString("HH:mm:ss"),
                 guna2DateTimePicker2.Value.ToString("HH:mm:ss")));
               
                if (count > 0)
                {
                    MessageBox.Show("Duplicate Session Found cannot add session");
                    return;
                }
                else
                {
                    //Insert into temporary table to check for duplicates before inserting into main table
                    training_Session2_0TableAdapter1.InsertTemporaryTrainingSession(session_ID,member_IDTextBox1.Text,StaffCB1.Text,
                        guna2DateTimePicker1.Value.ToString("HH:mm:ss"),
                     guna2DateTimePicker2.Value.ToString("HH:mm:ss"),
                        session_DateDateTimePicker1.Value.ToString("yyyy-MM-dd"),
                        "N/A",
                        attendance,
                        session_DurationTextBox1.Text,
                        "Pending"
                        );

                    //Add Session to main table
                    training_SessionTableAdapter2.AddSession(
                     session_ID,
                     member_IDTextBox1.Text,
                     StaffCB1.Text,
                     time_ID,
                     session_DateDateTimePicker1.Value.ToString("yyyy-MM-dd"),
                     "N/A",
                     attendance,
                     session_DurationTextBox1.Text,
                     "Pending"
                 );
                    //Count attendance for the session and update the session table
                    attendance = Convert.ToInt32(training_Session2_0TableAdapter1.CountAttendance(session_ID,session_DateDateTimePicker1.Value.ToString("yyyy-MM-dd"),guna2DateTimePicker1.Value.ToString("HH:mm:ss"),
                                                                                                     guna2DateTimePicker2.Value.ToString("HH:mm:ss")));

                    //Update attendance in session table
                    training_Session2_0TableAdapter1.UpdateAttendance(attendance,session_ID,session_DateDateTimePicker1.Value.ToString("yyyy-MM-dd"),guna2DateTimePicker1.Value.ToString("HH:mm:ss"),
                                                                        guna2DateTimePicker2.Value.ToString("HH:mm:ss"));

                    

                }
                training_SessionTableAdapter2.Fill(groupWst23DataSet.Training_Session);

                MessageBox.Show("Training Session Added Successfully.");

                ClearBtn1_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ClearBtn1_Click(object sender, EventArgs e)
        {
            member_IDTextBox1.Clear();
            StaffCB1.Clear();
            SessionTypeCB1.SelectedIndex = -1;
            session_DurationTextBox1.Clear();

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

            if (sender is Guna.UI2.WinForms.Guna2ComboBox gunaCb)
            {
                gunaCb.FillColor = Color.White;
                errorProvider1.SetError(gunaCb, "");
            }
        }

        private void ShowError(Control control, string message)
        {
            errorProvider1.SetError(control, message);

            if (control is Guna.UI2.WinForms.Guna2TextBox txt)
            {
                txt.BorderColor = Color.Red;
            }
            else if (control is Guna.UI2.WinForms.Guna2ComboBox gunaCb)
            {
                gunaCb.FillColor = Color.MistyRose;
            }
            else if (control is ComboBox cb)
            {
                cb.BackColor = Color.MistyRose;
            }
        }
        private void StaffCB1_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(StaffCB1, "");
        }

        private void SessionTypeCB1_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(SessionTypeCB1, "");
        }

        private void ClearValidationErrors()
        {
            errorProvider1.Clear();

            member_IDTextBox1.BorderColor = Color.Silver;
            session_DurationTextBox1.BorderColor = Color.Silver;

            StaffCB1.FillColor = Color.White;
            SessionTypeCB1.FillColor = Color.White;
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.CurrentRow == null)
                return;

            if (guna2DataGridView1.CurrentRow.Cells[0].Value == null)
                return;
            StaffCB1.Text=guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
            string staffid=guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
            //this.trainer_ScheduleTableAdapter.FillByStaffID(this.groupWst23DataSet.Trainer_Schedule, staffid);
            try
            {
                this.trainer_ScheduleTableAdapter.FillByStaffID(this.groupWst23DataSet.Trainer_Schedule,staffid);
            }
            catch
            {
                // Ignore
            }
        }

        private void guna2DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView2.CurrentRow == null) return;

            try
            {
                DateTime selectedDate = Convert.ToDateTime(guna2DataGridView2.CurrentRow.Cells[1].Value);

                if (selectedDate.Date < DateTime.Today)
                {
                    MessageBox.Show(
                        "The selected session date (" + selectedDate.ToString("yyyy/MM/dd") + ") is in the past. Cannot book a past session.",
                        "Invalid Date",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                session_DateDateTimePicker1.Value = selectedDate;
                guna2DateTimePicker1.Value = DateTime.Today.Add((TimeSpan)guna2DataGridView2.CurrentRow.Cells[2].Value);
                guna2DateTimePicker2.Value = DateTime.Today.Add((TimeSpan)guna2DataGridView2.CurrentRow.Cells[3].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error selecting row: " + ex.Message);
            }
        }

        private void member_IDTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.memberTableAdapter.MemberSearchByNameOrID(this.groupWst23DataSet.Member, member_IDTextBox1.Text, member_IDTextBox1.Text);
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            CalculateDuration();
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            CalculateDuration();
        }
        private void CalculateDuration()
        {
            TimeSpan duration = guna2DateTimePicker2.Value - guna2DateTimePicker1.Value;

            if (duration.TotalMinutes <= 0)
            {
                session_DurationTextBox1.Text = "N/A";
                return;
            }

            session_DurationTextBox1.Text =
                $"{(int)duration.TotalHours} Hour(s) {duration.Minutes} Minute(s)";
        }
        private bool ValidateSessionDetails()
        {
            ClearValidationErrors();

            bool isValid = true;

            // Member ID
            if (string.IsNullOrWhiteSpace(member_IDTextBox1.Text))
            {
                ShowError(member_IDTextBox1, "Member ID is required.");
                isValid = false;
            }
            else if (!int.TryParse(member_IDTextBox1.Text, out _))
            {
                ShowError(member_IDTextBox1, "Member ID must contain numbers only.");
                isValid = false;
            }

            // Trainer
            if (string.IsNullOrWhiteSpace(StaffCB1.Text))
            {
                ShowError(StaffCB1, "Please select a trainer.");
                isValid = false;
            }

            // Session Type
            if (SessionTypeCB1.SelectedIndex == -1)
            {
                ShowError(SessionTypeCB1, "Please select a session type.");
                isValid = false;
            }

            // Date
            if (session_DateDateTimePicker1.Value.Date < DateTime.Today)
            {
                MessageBox.Show(
                    "Session date cannot be in the past.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                isValid = false;
            }

            // Duration
            if (session_DurationTextBox1.Text == "N/A" ||
                string.IsNullOrWhiteSpace(session_DurationTextBox1.Text))
            {
                ShowError(session_DurationTextBox1,
                    "Invalid session duration.");

                isValid = false;
            }

            // End Time
            if (guna2DateTimePicker2.Value <= guna2DateTimePicker1.Value)
            {
                MessageBox.Show(
                    "End time must be later than start time.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                isValid = false;
            }

            return isValid;
        }



        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            this.staffTableAdapter1.SearchByTrainerRole(this.groupWst23DataSet.Staff, StaffCB1.Text);
        }

        private void guna2DataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView3.CurrentRow == null)
                return;

            if (guna2DataGridView3.CurrentRow.Cells[0].Value == null)
                return;
            member_IDTextBox1.Text = guna2DataGridView3.CurrentRow.Cells[0].Value.ToString();
        }

        private void trainerRoleToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.staffTableAdapter.TrainerRole(this.groupWst23DataSet.Staff);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void session_DateDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.trainer_ScheduleTableAdapter.FillByDate(this.groupWst23DataSet.Trainer_Schedule, session_DateDateTimePicker1.Value.ToString());
        }
    }
}
