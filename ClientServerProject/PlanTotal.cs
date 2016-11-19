using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientServerProject
{
    public partial class PlanTotal : UserControl
    {
        Plan plan;
        PlanRoomNumber planroomchoice;
        public PlanTotal(Plan p,PlanRoomNumber prc)
        {
            InitializeComponent();
            plan = p;
            planroomchoice = prc;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {

        }
    }
}
