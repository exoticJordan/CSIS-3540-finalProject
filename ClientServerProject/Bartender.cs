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
    public partial class Bartender : UserControl
    {
        Plan plan;
        public Bartender(Plan p)
        {
            InitializeComponent();
            plan = p;
        }

        private void btnBSBack_Click(object sender, EventArgs e)
        {
            OnBoard board = new OnBoard(plan);
            plan.Controls.Remove(this);
            plan.Controls.Add(board);
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            Schedule s = new Schedule(plan);
            ((Label)s.Controls["lbS"]).Text = btnS.Text;
            plan.Controls.Remove(this);
            plan.Controls.Add(s);          
        }
    }
}
