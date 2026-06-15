using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management_System
{
	public partial class TrainerReport : Form
	{
		private string TrainerStatus = "All";
		private string TrainerGender = "All";
		private int NumberOfTotalRows = 0;
		private const int extraRow = 1;
		public TrainerReport()
		{
			InitializeComponent();
		}

		private void TrainerReport_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'groupWst23DataSet1.Staff' table. You can move, or remove it, as needed.
			//this.staffTableAdapter.Fill(this.groupWst23DataSet1.Staff);
			// TODO: This line of code loads data into the 'groupWst23DataSet.Staff' table. You can move, or remove it, as needed.
			//this.staffTableAdapter.Fill(this.groupWst23DataSet.Staff);
			this.staffTableAdapter.FillByTrainer_Role(this.groupWst23DataSet1.Staff);
			NumberOfTotalRows = TrainerReportDataGridView.RowCount - extraRow;
			MemberReportTotals(); // Call the method to calculate and display the totals
		}

		//Filters the report based on the selected status
		private void TrainerReportStatusComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			if (TrainerReportStatusComboBox.Text == "All")
			{
				this.staffTableAdapter.TrainerReportFilterByAll(this.groupWst23DataSet1.Staff);
			}
			else
			{
				this.staffTableAdapter.TrainerReportFilterByStatus(this.groupWst23DataSet1.Staff, TrainerReportStatusComboBox.SelectedItem.ToString());
			}
			TrainerStatus = TrainerReportStatusComboBox.SelectedItem.ToString();
			MemberReportTotals();
		}

		//Filters the report based on the selected gender
		private void TrainerReportTypeComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			if (TrainerReportTypeComboBox.Text == "All")
			{
				this.staffTableAdapter.TrainerReportFilterByAll(this.groupWst23DataSet1.Staff);
			}
			else
			{
				this.staffTableAdapter.TrainerReportFilterByGender(this.groupWst23DataSet1.Staff, TrainerReportTypeComboBox.SelectedItem.ToString());
			}
			TrainerGender = TrainerReportTypeComboBox.SelectedItem.ToString();
			MemberReportTotals();
		}

		////Filters the report based on the selected date range
		//private void ReportFromDateTimePicker_ValueChanged_1(object sender, EventArgs e)
		//{
		//	string startDate = ReportFromDateTimePicker.Value.ToShortDateString();
		//	string endDate = ReportToDateTimePicker.Value.ToShortDateString();

		//	this.staffTableAdapter.TrainerReportFilterByDate(this.groupWst23DataSet.Staff, startDate, endDate);
		//	MemberReportTotals();
		//}

		//////Filters the report based on the selected date range
		//private void ReportToDateTimePicker_ValueChanged_1(object sender, EventArgs e)
		//{
		//	string startDate = ReportFromDateTimePicker.Value.ToShortDateString();
		//	string endDate = ReportToDateTimePicker.Value.ToShortDateString();

		//	this.staffTableAdapter.TrainerReportFilterByDate(this.groupWst23DataSet.Staff, startDate, endDate);
		//	MemberReportTotals();
		//}

		//Calculates the total number of trainers and updates the corresponding label
		private int TotalNumberOfTrainer()
		{
			int additionalRow = 1;
			int totalUsers = TrainerReportDataGridView.RowCount - additionalRow;
			NumberOfTotalTrainerLabel.Text = totalUsers.ToString();
			return NumberOfTotalTrainerLabel.Text != null ? Convert.ToInt32(NumberOfTotalTrainerLabel.Text) : 0;
		}

		//Calculates the total number of active trainers and updates the corresponding label
		private int TotalNumberOfActiveTrainer()
		{
			int activeCount = 0;

			for (int i = 0; i < TrainerReportDataGridView.Rows.Count - 1; i++)
			{
				if (TrainerReportDataGridView.Rows[i].Cells[9].Value.ToString() == "Active")
				{
					activeCount++;
				}
			}

			TotalNumberOfActiveTrainerLabel.Text = activeCount.ToString();
			return TotalNumberOfActiveTrainerLabel.Text != null ? Convert.ToInt32(TotalNumberOfActiveTrainerLabel.Text) : 0;
		}

		//Calculates the total number of inactive trainers and updates the corresponding label
		private int TotalNumberOfInactiveTrainer()
		{
			int activeCount = 0;

			for (int i = 0; i < TrainerReportDataGridView.Rows.Count - 1; i++)
			{
				if (TrainerReportDataGridView.Rows[i].Cells[9].Value.ToString() == "Inactive")
				{
					activeCount++;
				}
			}

			TotalNumberOfInactiveTrainers.Text = activeCount.ToString();
			return TotalNumberOfInactiveTrainers.Text != null ? Convert.ToInt32(TotalNumberOfInactiveTrainers.Text) : 0;
		}


		// Calls the methods to calculate and display the totals for the report
		private void MemberReportTotals()
		{
			TotalNumberOfTrainer();
			TotalNumberOfActiveTrainer();
			TotalNumberOfInactiveTrainer();
		}

		public DataTable reportTable;
		// Prepares the data from the DataGridView and opens the TrainerCrystalReportViewer to display the report
		private void PrintReportButton_Click(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();

			foreach (DataGridViewColumn col in TrainerReportDataGridView.Columns)
				dt.Columns.Add(col.HeaderText);

			foreach (DataGridViewRow row in TrainerReportDataGridView.Rows)
			{
				if (!row.IsNewRow)
				{
					DataRow dr = dt.NewRow();

					for (int i = 0; i < TrainerReportDataGridView.Columns.Count; i++)
					{
						dr[i] = row.Cells[i].Value;
					}

					dt.Rows.Add(dr);
				}
			}
			TrainerCrystalReportViewer frm = new TrainerCrystalReportViewer();
			frm.reportTable = dt;
			frm.TrainerStatus = TrainerStatus;
			frm.TrainerGender = TrainerGender;
			//frm.TrainerDateFrom = ReportFromDateTimePicker.Value.ToShortDateString();
			//frm.TrainerDateTo = ReportToDateTimePicker.Value.ToShortDateString();
			frm.NumberOfTotalTrainers = TotalNumberOfTrainer().ToString();
			frm.NumberOfActiveTrainers = TotalNumberOfActiveTrainer().ToString();
			frm.NumberOfInactiveTrainers = TotalNumberOfInactiveTrainer().ToString();
			frm.RecordCount = (TrainerReportDataGridView.RowCount - 1) + " of " + NumberOfTotalRows;
			frm.PrintedDate = DateTime.Now.ToString("yyyy-MM-dd");
			frm.PrintedTime = DateTime.Now.ToString("HH:mm:ss");
			frm.PrintedBy = UserSession.FirstName;
			TrainerReportViewerConnector.CurrentViewer = frm;
			frm.Show();
		}

		// Navigates back to the ManagerForm when the Home button is clicked
		private void ReportHomeButton_Click(object sender, EventArgs e)
		{
			ManagerForm managerForm = new ManagerForm();
			managerForm.Show();
			this.Hide();
		}

		// Saves the current state of the report when the Save button is clicked
		private void SaveReportButton1_Click(object sender, EventArgs e)
		{
			TrainerReportViewerConnector.saveForm();
		}

        private void guna2GroupBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
