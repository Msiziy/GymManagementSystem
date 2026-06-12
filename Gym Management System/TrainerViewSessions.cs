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
    public partial class TrainerViewSessions : Form
    {
        public TrainerViewSessions()
        {
            InitializeComponent();
        }

       // string username = UserSession.Email;
       // string staffID;

        private void TrainerSessionBackBtn_Click(object sender, EventArgs e)
        {
            TrainerDashboard trainerForm2 = new TrainerDashboard();
            trainerForm2.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        string trainerID = UserSession.StaffID;

        private void TrainerViewSessions_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupWst23DataSet.TrainingSessionView' table. You can move, or remove it, as needed.
            this.trainingSessionView.Fill(this.groupWst23DataSet.TrainingSessionView);
            // TODO: This line of code loads data into the 'groupWst23DataSet.Training_Session' table. You can move, or remove it, as needed.
            this.trainingSessionView.TrainingSessionDetails(this.groupWst23DataSet.TrainingSessionView, UserSession.Email);
            //this.training_SessionTableAdapter1.Fill(this.groupWst23DataSet.Training_Session);
            //this.trainer_Session_viewTableAdapter1.TrainerFillBySessionVeiw(this.groupWst23DataSet.Trainer_Session_view, "162727");

            TrainerStatus_comboBox.SelectedItem = "Pending";


        }

        private void TrainerStatus_comboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            String SelectedStatus = TrainerStatus_comboBox.SelectedItem.ToString();
            trainingSessionView.TrainerFillBySessionStatus(this.groupWst23DataSet.TrainingSessionView, SelectedStatus, UserSession.Email);
        }

        private void TrainerStart_DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            String Start_date = TrainerStart_DateTimePicker.Value.ToShortDateString();
            string end_date = TrainerEnd_DateTimePicker.Value.ToShortDateString();
            trainingSessionView.TrainerSortByDate(this.groupWst23DataSet.TrainingSessionView, Start_date, end_date, UserSession.Email);
        }

        private void TrainerEnd_DateTimePicker_ValueChanged_1(object sender, EventArgs e)
        {
            String Start_date = TrainerStart_DateTimePicker.Value.ToShortDateString();
            string end_date = TrainerEnd_DateTimePicker.Value.ToShortDateString();
            trainingSessionView.TrainerSortByDate(this.groupWst23DataSet.TrainingSessionView, Start_date, end_date, UserSession.Email);
        }

    }
}
