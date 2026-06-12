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
	public partial class SessionCrystalReportViewer : Form
	{
		public SessionCrystalReport rpt;
		public DataTable reportTable;

		public int totalTrainingSessions { get; set; }
		public int incompleteTrainingSessions { get; set; }
		public int cancelledTrainingSessions { get; set; }
		public int CompleteTrainingSessions { get; set; }
		public string DateFrom { get; set; }
		public string DateTo { get; set; }
		public string RecordCount { get; set; }
		public string PrintedDate { get; set; }
		public string PrintedTime { get; set; }
		public string PrintedBy { get; set; }
		public string SessionStatus { get; set; }

		public SessionCrystalReportViewer()
		{
			InitializeComponent();
		}

		private void crystalReportViewer1_Load(object sender, EventArgs e)
		{
			try
			{
				if (reportTable != null)
				{

				    rpt = new SessionCrystalReport();
					rpt.SetDataSource(reportTable);
					rpt.SetParameterValue("totalTrainingSessions", totalTrainingSessions);
					rpt.SetParameterValue("incompleteTrainingSessions", incompleteTrainingSessions);
					rpt.SetParameterValue("cancelledTrainingSessions", cancelledTrainingSessions);
					rpt.SetParameterValue("CompleteTrainingSessions", CompleteTrainingSessions);
					rpt.SetParameterValue("SessionStatus", SessionStatus);
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

		private void SessionCrystalReportViewer_Load(object sender, EventArgs e)
		{

		}
	}
}
