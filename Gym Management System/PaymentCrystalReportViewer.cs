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
	public partial class PaymentCrystalReportViewer : Form
	{
		public PaymentCrystalReport rpt;
		public DataTable reportTable;

		public int PaymentNumberOfTotalMembers { get; set; }
		public int NumberOfTotalPaidMembers { get; set; }
		public int NumberOfTotalPayments { get; set; }
		public string DateFrom { get; set; }
		public string DateTo { get; set; }
		public string RecordCount { get; set; }
		public string PrintedDate { get; set; }
		public string PrintedTime { get; set; }
		public string PrintedBy { get; set; }
		public PaymentCrystalReportViewer()
		{
			InitializeComponent();
		}

		private void crystalReportViewer1_Load(object sender, EventArgs e)
		{
			try
			{
				if (reportTable != null)
				{

				    rpt = new PaymentCrystalReport();
					rpt.SetDataSource(reportTable);
					rpt.SetParameterValue("PaymentNumberOfTotalMembers", PaymentNumberOfTotalMembers);
					rpt.SetParameterValue("NumberOfTotalPaidMembers", NumberOfTotalPaidMembers);
					rpt.SetParameterValue("NumberOfTotalPayments", NumberOfTotalPayments);
					rpt.SetParameterValue("DateFrom", DateFrom);
					rpt.SetParameterValue("DateTo", DateTo);
					rpt.SetParameterValue("RecordCount", RecordCount);
					rpt.SetParameterValue("PrintedDate", PrintedDate);
					rpt.SetParameterValue("PrintedTime", PrintedTime);
					rpt.SetParameterValue("PrintedBy", PrintedBy);
					crystalReportViewer1.ReportSource = rpt;
				}
				else
				{
					MessageBox.Show("Can not access Customer details");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Encountered some issues with Crystal repport");
			}
		}

		private void PaymentCrystalReportViewer_Load(object sender, EventArgs e)
		{

		}
	}
	
}
