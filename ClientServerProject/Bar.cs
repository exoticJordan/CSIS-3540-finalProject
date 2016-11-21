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

    public partial class Bar : UserControl
    {
        Plan plan;
        public Bar(Plan p)
        {
            InitializeComponent();
            plan = p;
        }

        private void btnBarB_Click(object sender, EventArgs e)
        {
            Bartender b = new Bartender(plan);
            plan.Controls.Remove(this);
            plan.Controls.Add(b);
            ((Button)b.Controls["btnOrder"]).Text = "Bar Order";
            ((Label)b.Controls["lbName"]).Text = lbName.Text;
            ((Label)b.Controls["lbTitle"]).Text = "Bartender";
            ((Button)b.Controls["btnS"]).Text = "Bartender Schedule";
        }
    }
}
