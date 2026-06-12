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
    public partial class PaymentReport : Form
    {
        //private string paymentStatus = "All";
        private int NumberOfPayments = 0;
        private const int extraRow = 1;
		public PaymentReport()
        {
            InitializeComponent();
        }
        private void PaymentReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupWst23DataSet.Payment' table. You can move, or remove it, as needed.
            this.paymentTableAdapter.Fill(this.groupWst23DataSet.Payment);
			NumberOfPayments = ReportPaymentDaGridView.RowCount - extraRow;
			TotalPayments();

        }

		//Filtering the payment report by payment Date
		private void ReportFromDateTimePicker_ValueChanged_1(object sender, EventArgs e)
		{
			string startDate = ReportFromDateTimePicker.Value.ToShortDateString();
			//string endDate = ReportToDateTimePicker.Value.ToShortDateString();

			paymentTableAdapter.PaymentReportFilterByStartDate(groupWst23DataSet.Payment, startDate);
			TotalPayments();
		}

		//Filtering the payment report by payment Date
		private void ReportToDateTimePicker_ValueChanged_1(object sender, EventArgs e)
		{
			//string startDate = ReportFromDateTimePicker.Value.ToShortDateString();
			string endDate = ReportToDateTimePicker.Value.ToShortDateString();

			paymentTableAdapter.PaymentReportFilterByStartDate(groupWst23DataSet.Payment, endDate);
			TotalPayments();
		}

		//Totaling the number of payments
		private int TotalMemberOfPayments()
        {
            int additionalRow = 1;
            int totalUsers = ReportPaymentDaGridView.RowCount - additionalRow;
            PaymentNumberOfTotalMembersLabel.Text = totalUsers.ToString();
            return PaymentNumberOfTotalMembersLabel.Text != null ? Convert.ToInt32(PaymentNumberOfTotalMembersLabel.Text) : 0;
        }

		//Totaling the number of paid members
		private int NumberOfTotalPaidMembers()
        {
            int additionalRow = 1;
            int totalUsers = ReportPaymentDaGridView.RowCount - additionalRow;
            NumberOfTotalPaidMembersLabel.Text = totalUsers.ToString();
            return NumberOfTotalPaidMembersLabel.Text != null ? Convert.ToInt32(NumberOfTotalPaidMembersLabel.Text) : 0;
        }

		//Total amount of payments
		private int NumberOfTotalPayments()
        {
            int totalPayment = 0;

            for (int i = 0; i < ReportPaymentDaGridView.Rows.Count - 1; i++)
            {
                if (ReportPaymentDaGridView.Rows[i].Cells[4].Value != null)
                {
                    totalPayment += Convert.ToInt32(
                        ReportPaymentDaGridView.Rows[i].Cells[4].Value
                    );
                }
            }

            NumberOfTotalPaymentsLabel.Text = "R" + totalPayment.ToString();
            return NumberOfTotalPaymentsLabel.Text != null ? Convert.ToInt32(NumberOfTotalPaymentsLabel.Text.Substring(1)) : 0;
        }

		//Method to call all the total methods at once
		private void TotalPayments()
        {
			TotalMemberOfPayments();
            NumberOfTotalPaidMembers();
            NumberOfTotalPayments();
        }

        public DataTable reportTable;

		//Method to print the payment report
		private void PaymentPrintReportButton_Click(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();

			foreach (DataGridViewColumn col in ReportPaymentDaGridView.Columns)
				dt.Columns.Add(col.HeaderText);

			foreach (DataGridViewRow row in ReportPaymentDaGridView.Rows)
			{
				if (!row.IsNewRow)
				{
					DataRow dr = dt.NewRow();

					for (int i = 0; i < ReportPaymentDaGridView.Columns.Count; i++)
					{
						dr[i] = row.Cells[i].Value;
					}

					dt.Rows.Add(dr);
				}
			}

			PaymentCrystalReportViewer frm = new PaymentCrystalReportViewer();
			frm.reportTable = dt;
			frm.DateFrom = ReportFromDateTimePicker.Value.ToShortDateString();
			frm.DateTo = ReportToDateTimePicker.Value.ToShortDateString();
			frm.PaymentNumberOfTotalMembers = TotalMemberOfPayments();
			frm.NumberOfTotalPaidMembers = NumberOfTotalPaidMembers();
			frm.NumberOfTotalPayments = NumberOfTotalPayments();
			frm.RecordCount = (ReportPaymentDaGridView.RowCount - 1) + " of " + NumberOfPayments;
			frm.PrintedDate = DateTime.Now.ToString("yyyy-MM-dd");
			frm.PrintedTime = DateTime.Now.ToString("HH:mm:ss");
			frm.PrintedBy = UserSession.FirstName;
			PaymentReportViewerConnector.CurrentViewer = frm;
			frm.Show();
		}

		//Method to navigate back to the manager form
		private void guna2Button2_Click_1(object sender, EventArgs e)
		{
			ManagerForm managerForm = new ManagerForm();
			managerForm.Show();
			this.Hide();
		}

		//Method to save the payment report
		private void TrainerSaveReportButton_Click(object sender, EventArgs e)
		{
			PaymentReportViewerConnector.saveForm();
		}
	}
}
