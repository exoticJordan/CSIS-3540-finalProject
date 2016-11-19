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
    public partial class EmployeeLogin : UserControl
    {
        Plan plan;
        public EmployeeLogin(Plan p)
        {
            InitializeComponent();
            plan = p;
        }

        private void btnEmBack_Click(object sender, EventArgs e)
        {
            OnBoard onboard = new OnBoard(plan);
            plan.Controls.Add(onboard);
            plan.Controls.Remove(this);
        }
    }
}
