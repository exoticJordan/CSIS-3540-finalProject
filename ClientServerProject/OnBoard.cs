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
    public partial class OnBoard : UserControl
    {
        Plan plan;
        public OnBoard(Plan p)
        {
            InitializeComponent();
            plan = p;
        }

        private void btnEmLog_Click(object sender, EventArgs e)
        {
            EmployeeLogin emlog= new EmployeeLogin(plan);
            plan.Controls.Add(emlog);
            plan.Controls.Remove(this);
        }

        private void btnOBBack_Click(object sender, EventArgs e)
        {
            PlanSearch ps = new PlanSearch(plan);
            plan.Controls.Remove(this);
            plan.Controls.Add(ps);
          
        }

        private void Onboard_Load(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString();
        }
    }
}
