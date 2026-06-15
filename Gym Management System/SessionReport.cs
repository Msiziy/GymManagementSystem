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
    public partial class SessionReport : Form
    {
        private string SessionStatus = "All";
        private int NumberOfSessions = 0;
        private const int extraRow = 1;
		public SessionReport()
        {
            InitializeComponent();
        }

        private void SessionReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupWst23DataSet.Training_Session' table. You can move, or remove it, as needed.
            this.training_SessionTableAdapter.Fill(this.groupWst23DataSet.Training_Session);
			NumberOfSessions = TrainingSessionDataGridView.RowCount - extraRow;
			TotalSessions(); //Update the total sessions, incomplete sessions and cancelled sessions labels when the form loads

		}

		//Filters the training sessions based on the date selected
		private void SessionFromDateTimePicker_ValueChanged_1(object sender, EventArgs e)
		{
			string startDate = SessionFromDateTimePicker.Value.ToShortDateString();
			//string endDate = SessionToDateTimePicker.Value.ToShortDateString();

			training_SessionTableAdapter.SessionReportFilterByStartDate(groupWst23DataSet.Training_Session, startDate);
			TotalSessions();
		}

		////Filters the training sessions based on the date selected
		private void SessionToDateTimePicker_ValueChanged_1(object sender, EventArgs e)
		{
			//string startDate = SessionFromDateTimePicker.Value.ToShortDateString();
			string endDate = SessionToDateTimePicker.Value.ToShortDateString();

			training_SessionTableAdapter.SessionReportFilterByEndDate(groupWst23DataSet.Training_Session,endDate);
			TotalSessions();
		}

		//Filters the training sessions based on the session status selected
		private void SessionStatusComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			if (SessionStatusComboBox.Text == "All")
			{
				training_SessionTableAdapter.SessionReportFilterByAll(groupWst23DataSet.Training_Session);
			}
			else
			{
				training_SessionTableAdapter.SessionReportFilterByStatus(groupWst23DataSet.Training_Session, SessionStatusComboBox.SelectedItem.ToString());
			}
			SessionStatus = SessionStatusComboBox.SelectedItem.ToString();
			TotalSessions();
		}

		//Total training sessions in the datagridview
		private int totalTrainingSessions()
        {
            int additionalRow = 1;
            int sessions = TrainingSessionDataGridView.RowCount - additionalRow;
            NumberOfTotalTrainingSessionsLabel.Text = sessions.ToString();
            return NumberOfTotalTrainingSessionsLabel.Text != null ? Convert.ToInt32(NumberOfTotalTrainingSessionsLabel.Text) : 0;
        }

		//Total incomplete training sessions in the datagridview
		private int PendingTrainingSession()
        {
            int incompleteSessions = 0;

            for (int i = 0; i < TrainingSessionDataGridView.Rows.Count - 1; i++)
            {
                string status = TrainingSessionDataGridView.Rows[i]
                    .Cells[7].Value?.ToString().Trim();

                if (status == "Pending" || status == "pending")
                {
                    incompleteSessions++;
                }
            }
			//MessageBox.Show("Pennding = " + incompleteSessions.ToString());

			NumberOfIncompleteTrainingSessionsLabel.Text = incompleteSessions.ToString();
            return NumberOfIncompleteTrainingSessionsLabel.Text != null ? Convert.ToInt32(NumberOfIncompleteTrainingSessionsLabel.Text) : 0;
        }

		//Total cancelled training sessions in the datagridview
		private int cancelledTrainingSessions()
        {
            int cancelledSessions = 0;

            for (int i = 0; i < TrainingSessionDataGridView.Rows.Count - 1; i++)
            {
                string status = TrainingSessionDataGridView.Rows[i].Cells[10].Value?.ToString().Trim();
                if (status == "Cancelled")
                {
                    cancelledSessions++;
                }
            }

            NumberOfCancelledTrainingSessionsLabel.Text = cancelledSessions.ToString();
            return NumberOfCancelledTrainingSessionsLabel.Text != null ? Convert.ToInt32(NumberOfCancelledTrainingSessionsLabel.Text) : 0;
        }

		//Updates the total sessions, incomplete sessions and cancelled sessions labels
		private void TotalSessions()
        {
            totalTrainingSessions();
			PendingTrainingSession();
            cancelledTrainingSessions();
        }

        public DataTable reportTable;

		//Prints the training session report using the SessionCrystalReportViewer form
		private void SessionPrintReportButton_Click(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();

			foreach (DataGridViewColumn col in TrainingSessionDataGridView.Columns)
				dt.Columns.Add(col.HeaderText);

			foreach (DataGridViewRow row in TrainingSessionDataGridView.Rows)
			{
				if (!row.IsNewRow)
				{
					DataRow dr = dt.NewRow();

					for (int i = 0; i < TrainingSessionDataGridView.Columns.Count; i++)
					{
						dr[i] = row.Cells[i].Value;
					}

					dt.Rows.Add(dr);
				}
			}

			SessionCrystalReportViewer frm = new SessionCrystalReportViewer();
			frm.reportTable = dt;
			frm.totalTrainingSessions = totalTrainingSessions().ToString();
			frm.PendingTrainingSession = PendingTrainingSession().ToString();
			frm.cancelledTrainingSessions = cancelledTrainingSessions().ToString();
			frm.SessionStatus = SessionStatus;
			frm.DateFrom = SessionFromDateTimePicker.Value.ToShortDateString();
			frm.DateTo = SessionToDateTimePicker.Value.ToShortDateString();
			frm.RecordCount = (TrainingSessionDataGridView.RowCount - 1) + " of " + NumberOfSessions;
			frm.PrintedDate = DateTime.Now.ToString("yyyy-MM-dd");
			frm.PrintedTime = DateTime.Now.ToString("HH:mm:ss");
			frm.PrintedBy = UserSession.FirstName;
			SessionReportViewerConnector.CurrentViewer = frm;
			frm.Show();
		}

		//Saves the training session report using the SessionCrystalReportViewer form
		private void TrainerSaveReportButton_Click(object sender, EventArgs e)
		{
			SessionReportViewerConnector.saveForm();
		}

		//Navigates back to the ManagerForm
		private void guna2Button2_Click(object sender, EventArgs e)
		{
			ManagerForm managerForm = new ManagerForm();
			managerForm.Show();
			this.Hide();
		}
	}
}
