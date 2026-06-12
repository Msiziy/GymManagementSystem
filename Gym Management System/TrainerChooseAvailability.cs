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
    public partial class TrainerChooseAvailability : Form
    {
        public TrainerChooseAvailability()
        {
            InitializeComponent();
        }
       
        string username = UserSession.Email;
        string staffID;
        private void TrainerShiftBackBtn_Click(object sender, EventArgs e)
        {
            TrainerDashboard trainerForm1 = new TrainerDashboard();
            trainerForm1.Show();
            this.Hide();
        }

        private void TrainerShifts_Load(object sender, EventArgs e)
        {
            this.time_SlotTableAdapter.Fill(this.groupWst23DataSet.Time_Slot);
            getSfaffID();

            // Prevent past dates
            AvalabiltyDateTimePicker1.MinDate = DateTime.Today;

            for (int i = 0; i < TrainerTimeSlotDataGridView.RowCount - 1; i++)
            {
                TrainerTimeSlotDataGridView.Rows[i].Cells[3].Value = "Unavailable";
            }
        }


        private void getSfaffID()
        {
            object result = staffTableAdapter1.GetStaffIDByEmail(username);
            if (result != null)
            {
                staffID = result.ToString();
            }
            else
            {
                MessageBox.Show("No staff member found for email: " + username);
            }
        }

        private void TrainerSave_AbilityBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to save the trainer's availability?",
                    "Confirm Save",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.No)
                {
                    return;
                }

                string date = AvalabiltyDateTimePicker1.Value.ToString("yyyy-MM-dd");
                int savedCount = 0;

                for (int i = 0; i < TrainerTimeSlotDataGridView.RowCount - 1; i++)
                {
                    if (TrainerTimeSlotDataGridView.Rows[i].Cells[3].Value.ToString() == "Available")
                    {
                        trainer_ScheduleTableAdapter1.SaveAvailability(
                            staffID,
                            date,
                            TrainerTimeSlotDataGridView.Rows[i].Cells[1].Value.ToString(),
                            TrainerTimeSlotDataGridView.Rows[i].Cells[2].Value.ToString(),
                            TrainerTimeSlotDataGridView.Rows[i].Cells[3].Value.ToString()
                        );

                        savedCount++;
                    }
                }

                if (savedCount > 0)
                {
                    MessageBox.Show(
                        $"{savedCount} availability slot(s) saved successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    MessageBox.Show(
                        "No available time slots were selected to save.",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void TrainerAvailabityClearBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to clear all selected availability slots?",
                "Confirm Clear",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
            {
                return;
            }

            for (int i = 0; i < TrainerTimeSlotDataGridView.RowCount - 1; i++)
            {
                TrainerTimeSlotDataGridView.Rows[i].Cells[3].Value = "Unavailable";
            }

           
            AvalabiltyDateTimePicker1.Value = DateTime.Today;

            MessageBox.Show(
                "Availability has been cleared successfully.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
