using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientServerProject
{
    public partial class OnBoard : UserControl
    {
	    private Plan _plan;
        public OnBoard(Plan p)
        {
            InitializeComponent();
            _plan = p;
        }

        private void btnEmLog_Click(object sender, EventArgs e)
        {
            var emlog= new EmployeeLogin(_plan);
            _plan.Controls.Add(emlog);
            _plan.Controls.Remove(this);
        }

        private void btnOBBack_Click(object sender, EventArgs e)
        {
            var ps = new PlanSearch(_plan);
            _plan.Controls.Remove(this);
            _plan.Controls.Add(ps);
          
        }

        private void Onboard_Load(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString(CultureInfo.CurrentCulture);
        }

		private void btnPayment_Click(object sender, EventArgs e)
		{
			var paymentLogin = new PaymentLogin(_plan);
			_plan.Controls.Add(paymentLogin);
			_plan.Controls.Remove(this);
		}
	}
}
