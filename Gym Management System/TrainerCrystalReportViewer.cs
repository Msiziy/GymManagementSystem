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
	public partial class TrainerCrystalReportViewer : Form
	{
		public TrainerCrystalReport rpt;
		public DataTable reportTable;

		public int NumberOfTotalTrainers { get; set; }
		public int NumberOfActiveTrainers { get; set; }
		public int NumberOfInactiveTrainers { get; set; }
		public string TrainerStatus { get; set; }
		public string TrainerGender { get; set; }
		//public string TrainerDateFrom { get; set; }
		//public string TrainerDateTo { get; set; }
		public string RecordCount { get; set; }
		public string PrintedDate { get; set; }
		public string PrintedTime { get; set; }
		public string PrintedBy { get; set; }
		public TrainerCrystalReportViewer()
		{
			InitializeComponent();
		}

		private void TrainerCrystalReportViewer_Load(object sender, EventArgs e)
		{	
			try
			{
				if (reportTable != null)
				{

					rpt = new TrainerCrystalReport();
					rpt.SetDataSource(reportTable);
					rpt.SetParameterValue("NumberOfTotalTrainers", NumberOfTotalTrainers);
					rpt.SetParameterValue("NumberOfActiveTrainers", NumberOfActiveTrainers);
					rpt.SetParameterValue("NumberOfInactiveTrainers", NumberOfInactiveTrainers);
					rpt.SetParameterValue("TrainerStatus", TrainerStatus);
					rpt.SetParameterValue("TrainerGender", TrainerGender);
					//rpt.SetParameterValue("TrainerDateFrom", TrainerDateFrom);
					//rpt.SetParameterValue("TrainerDateTo", TrainerDateTo);
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
	}
}
