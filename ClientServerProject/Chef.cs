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
    public partial class Chef : UserControl
    {
        Plan plan;
        public Chef(Plan p)
        {

            plan = p;
            InitializeComponent(); 
        }

        private void btnCSBack_Click(object sender, EventArgs e)
        {
            OnBoard board = new OnBoard(plan);
            plan.Controls.Remove(this);
            plan.Controls.Add(board);

        }

        private void btnS_Click(object sender, EventArgs e)
        {
            Schedule s = new Schedule(plan);
            ((Label)s.Controls["lbS"]).Text = btnS.Text;
            ((Label)s.Controls["lbName"]).Text = lbName.Text;
            plan.Controls.Remove(this);
            plan.Controls.Add(s);
        }
    }
}
