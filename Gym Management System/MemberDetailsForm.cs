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
    public partial class MemberDetailsForm : Form
    {
        public MemberDetailsForm()
        {
            InitializeComponent();
      
        }

        private void MemberDetailsForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.memberTableAdapter1.Fill(this.groupWst23DataSet1.Member);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ManangerMemberSearchTxt_TextChanged(object sender, EventArgs e)
        {
            //this.memberTableAdapter1.MemberSearchByNameOrID(this.groupWst23DataSet1.Member, ManangerMemberSearchTxt.Text, ManangerMemberSearchTxt.Text);
        }

        private void ManagerSearchLabel_Click(object sender, EventArgs e)
        {

        }

        private void SearchMemberByIDTextBox_TextChanged(object sender, EventArgs e)
        {
            this.memberTableAdapter1.MemberSearchByNameOrID(this.groupWst23DataSet1.Member, SearchMemberByIDTextBox.Text, SearchMemberByIDTextBox.Text);
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
