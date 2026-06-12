using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management_System
{
	public static class SessionReportViewerConnector
	{
		public static SessionCrystalReportViewer CurrentViewer;

		public static void saveForm()
		{
			if (CurrentViewer == null)
			{
				MessageBox.Show("No report is open");
				return;
			}

			if (CurrentViewer.rpt == null)
			{
				MessageBox.Show("Report not loaded yet");
				return;
			}

			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "PDF Files (*.pdf)|*.pdf";

			if (sfd.ShowDialog() == DialogResult.OK)
			{
				CurrentViewer.rpt.ExportToDisk(
					CrystalDecisions.Shared.ExportFormatType.PortableDocFormat,
					sfd.FileName);

				MessageBox.Show("Report saved successfully");
			}
		}
	}
}
