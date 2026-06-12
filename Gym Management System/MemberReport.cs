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
    public partial class MemberReport : Form
    {
        private string memberStatus = "All";
        private string memberType = "All";
        private string memberGender = "All";
        private int NumberOfMembers = 0;
        private const int extraRow = 1;

		public MemberReport()
        {
            InitializeComponent();
        }

        private void MemberReport_Load(object sender, EventArgs e)
        {
            this.memberTableAdapter.Fill(this.groupWst23DataSet.Member);
			NumberOfMembers = MemberReportDataGridView.RowCount - extraRow;
			MemberReportTotals();  //Update form details when filtering

        }

		//Filter Member Report Data by Member Status
		private void ReportMemberStatusComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
		{
            if (ReportMemberStatusComboBox.Text == "All")
            {
				memberTableAdapter.FillByAllStatus(groupWst23DataSet.Member);
			}
            else
            {
				memberTableAdapter.MemberReportFiltByStatus(groupWst23DataSet.Member, ReportMemberStatusComboBox.SelectedItem.ToString());
			}
			MemberReportTotals();
		}

		//Filter Member Report Data by Member Type
		private void ReportMemberTypeComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			if (ReportMemberTypeComboBox.Text == "All")
			{
				memberType = "All";
				memberTableAdapter.FillByAllStatus(groupWst23DataSet.Member);
			}
			else if (ReportMemberTypeComboBox.Text == "Staff")
			{
				memberType = "Staff";
				memberTableAdapter.FillByReportStaffType(groupWst23DataSet.Member);
			}
			else if (ReportMemberTypeComboBox.Text == "Normal Students")
			{
				memberType = "Normal Students";
				memberTableAdapter.FillByReportNormalStudentsType(groupWst23DataSet.Member);
			}
			else if (ReportMemberTypeComboBox.Text == "Sport Science Students")
			{
				memberType = "Sport Science Students";
				memberTableAdapter.FillByReportSportScienceStudentsType(groupWst23DataSet.Member);
			}
			MemberReportTotals();
		}

		//Filter Member Report Data by Member Gender
		private void ReportMemberGenderComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
		{
            if(ReportMemberGenderComboBox.Text == "All")
            {
				memberTableAdapter.FillByAllStatus(groupWst23DataSet.Member);
			}
            else
            {
				memberTableAdapter.MemberReportFilterByGender(groupWst23DataSet.Member, ReportMemberGenderComboBox.SelectedItem.ToString());
			}
			MemberReportTotals();
		}

        //Total Members in the data grid
		private int NumberOfTotalMembers()
        {
            int additionalRow = 1;
            int totalUsers = MemberReportDataGridView.RowCount - additionalRow;
            NumberOfTotalMembersLabel.Text = totalUsers.ToString();
            return NumberOfTotalMembersLabel.Text != null ? Convert.ToInt32(NumberOfTotalMembersLabel.Text) : 0;
        }

		//Total Active Users in the data grid
		private int ReportTotalActiveUsers()
        {
            int activeCount = 0;

            for (int i = 0; i < MemberReportDataGridView.Rows.Count - 1; i++)
            {
                if (MemberReportDataGridView.Rows[i].Cells[14].Value.ToString() == "Active")
                {
                    activeCount++;
                }
            }

            ReportTotalActiveUsersLabel.Text = activeCount.ToString();
            return ReportTotalActiveUsersLabel.Text != null ? Convert.ToInt32(ReportTotalActiveUsersLabel.Text) : 0;
        }

		//Total Paid Members in the data grid
		private int ReportTotalPaidMembers()
        {
            bool paid = true;
            int count = 0;
            for (int i = 0; i < MemberReportDataGridView.RowCount - 1; i++)
            {
                for (int j = 0; j < groupWst23DataSet.Payment.Rows.Count; j++)
                {
                    if (MemberReportDataGridView.Rows[i].Cells[0].Value.ToString() ==
                        groupWst23DataSet.Payment.Rows[j][2].ToString())
                    {
                        paid = true;
                        break;
                    }
                    else
                    {
                        paid = false;
                    }
                }
                if (paid)
                {
                    count++;
                }
            }

            ReportTotalPaidMembersLabel.Text = count.ToString();
            return ReportTotalPaidMembersLabel.Text != null ? Convert.ToInt32(ReportTotalPaidMembersLabel.Text) : 0;
        }

		//Update form details when filtering
		private void MemberReportTotals()
        {
            NumberOfTotalMembers();
            ReportTotalActiveUsers();
            ReportTotalPaidMembers();
        }


        public DataTable reportTable;
		//Print the report using Crystal Report Viewer
		private void PrintReportButton_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            foreach (DataGridViewColumn col in MemberReportDataGridView.Columns)
                dt.Columns.Add(col.HeaderText);

            foreach (DataGridViewRow row in MemberReportDataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    DataRow dr = dt.NewRow();

                    for (int i = 0; i < MemberReportDataGridView.Columns.Count; i++)
                    {
                        dr[i] = row.Cells[i].Value;
                    }

                    dt.Rows.Add(dr);
                }
            }
            MemberCrystalReportViewer frm = new MemberCrystalReportViewer();
            frm.reportTable = dt;
            frm.MemberStatus = memberStatus;
            frm.MemberType = memberType;
            frm.MemberGender = memberGender;
            frm.RecordCount = (MemberReportDataGridView.RowCount - 1) + " of " + NumberOfMembers;
            frm.NumberOfTotalMembers = NumberOfTotalMembers();
            frm.ReportTotalActiveUsers = ReportTotalActiveUsers();
            frm.ReportTotalPaidMembers = ReportTotalPaidMembers();
            frm.PrintedDate = DateTime.Now.ToString("yyyy-MM-dd");
            frm.PrintedTime = DateTime.Now.ToString("HH:mm:ss");
            frm.PrintedBy = UserSession.FirstName;
			MemberReportViewerConnector.CurrentViewer = frm;
			frm.Show();
        }

		//Navigate back to Manager Form
		private void ReportHomeButton_Click(object sender, EventArgs e)
        {
            ManagerForm managerForm = new ManagerForm();
            managerForm.Show();
            this.Hide();
        }

		//Save the report using Crystal Report Viewer
		private void TrainerSaveReportButton_Click(object sender, EventArgs e)
		{
			MemberReportViewerConnector.saveForm();
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}
	}
}
