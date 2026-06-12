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
    public partial class PaidPlanGymRegister : Form
    {
        public PaidPlanGymRegister()
        {
            InitializeComponent();
        }

        private void RegisterListGroupBox_Click(object sender, EventArgs e)
        {

        }

        private void PaidPlanGymRegister_Load(object sender, EventArgs e)
        {
            // Prevent future dates
            SearchByDateTimePicker.MaxDate = DateTime.Today;
            SearchByDateTimePicker.Value = DateTime.Today;
            paidPlanRegisterTableAdapter1.Fill(this.groupWst23DataSet.PaidPlanRegister);
        }

        private void SearchByDateTimePicker_ValueChanged(object sender, EventArgs e)
        {   
            DateTime selectedDate = SearchByDateTimePicker.Value.Date;
            string dateString = selectedDate.ToString("yyyy-MM-dd");
            paidPlanRegisterTableAdapter1.SearchByDate(groupWst23DataSet.PaidPlanRegister, dateString);
        }
    }
}
