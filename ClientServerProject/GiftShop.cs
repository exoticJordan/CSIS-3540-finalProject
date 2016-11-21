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
    public partial class GiftShop : UserControl
    {
        Plan plan;
        public GiftShop(Plan p)
        {
            plan = p;
            InitializeComponent();
        }

        private void btnGSBack_Click(object sender, EventArgs e)
        {
            Bartender b = new Bartender(plan);
            plan.Controls.Remove(this);
            plan.Controls.Add(b);
            ((Button)b.Controls["btnOrder"]).Text = "Gift Order";
            ((Label)b.Controls["lbName"]).Text = lbName.Text;
            ((Label)b.Controls["lbTitle"]).Text = "Gift Cashier";
            ((Button)b.Controls["btnS"]).Text = "Gift Cashier Schedule";
        }
    }
}
