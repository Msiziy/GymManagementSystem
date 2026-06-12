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
	public partial class MemberCrystalReportViewer : Form
	{
		public MemberCrystalReport rpt;
		public DataTable reportTable;
		public string MemberStatus { get; set; }
		public string MemberType { get; set; }
		public string MemberGender { get; set; }
		public string RecordCount { get; set; }
		public int NumberOfTotalMembers { get; set; }
		public int ReportTotalFreeUsers { get; set; }
		public int ReportTotalActiveUsers { get; set; }
		public int ReportTotalPaidMembers { get; set; }
		public string PrintedDate { get; set; }
		public string PrintedTime { get; set; }
		public string PrintedBy { get; set; }

		public MemberCrystalReportViewer()
		{
			InitializeComponent();
		}

		private void crystalReportViewer1_Load(object sender, EventArgs e)
		{
			try
			{
				if (reportTable != null)
				{
					
				    rpt = new MemberCrystalReport();
					rpt.SetDataSource(reportTable);
					rpt.SetParameterValue("MemberStatus", MemberStatus);
					rpt.SetParameterValue("MemberType", MemberType);
					rpt.SetParameterValue("MemberGender", MemberGender);
					rpt.SetParameterValue("RecordCount", RecordCount);
					rpt.SetParameterValue("NumberOfTotalMembers", NumberOfTotalMembers);
					rpt.SetParameterValue("ReportTotalFreeUsers", ReportTotalFreeUsers);
					rpt.SetParameterValue("ReportTotalActiveUsers", ReportTotalActiveUsers);
					rpt.SetParameterValue("ReportTotalPaidMembers", ReportTotalPaidMembers);
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

		private void MemberCrystalReportViewer_Load(object sender, EventArgs e)
		{

		}
	}
}
