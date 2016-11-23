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
    public partial class Schedule : UserControl
    {
        Plan plan;
        public Schedule(Plan p)
        {
            InitializeComponent();
            plan = p;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Chef chef = new Chef(plan);
            Bartender bar = new Bartender(plan);
            plan.Controls.Remove(this);
            if (lbS.Text == "Gift Cashier Schedule")
            {
               ((Button)bar.Controls["btnOrder"]).Text = "Gift Order";
               ((Button)bar.Controls["btnS"]).Text = lbS.Text;
               ((Label)bar.Controls["lbTitle"]).Text = "Gift Cashier";
                plan.Controls.Add(bar);
            }
            if (lbS.Text == "Bartender Schedule")
            {
                ((Button)bar.Controls["btnOrder"]).Text = "Bar Order";
                ((Button)bar.Controls["btnS"]).Text = lbS.Text;
                ((Label)bar.Controls["lbTitle"]).Text = "Bartender";
                plan.Controls.Add(bar);
            }
            if (lbS.Text == "Chef Schedule")
            {
                ((Button)chef.Controls["btnS"]).Text = lbS.Text;
                ((Label)chef.Controls["lbTitle"]).Text = "Chef";
                plan.Controls.Add(chef);
            }
            if (lbS.Text == "Server Schedule")
            {
                ((Button)chef.Controls["btnS"]).Text = lbS.Text;
                ((Label)chef.Controls["lbTitle"]).Text = "Server";
                plan.Controls.Add(chef);
            }
            if (lbS.Text == "Cleaner Schedule")
            {
                ((Button)chef.Controls["btnS"]).Text = lbS.Text;
                ((Label)chef.Controls["lbTitle"]).Text = "Cleaner";
                plan.Controls.Add(chef);
            }     
            ((Label)bar.Controls["lbName"]).Text = lbName.Text;
            ((Label)chef.Controls["lbName"]).Text = lbName.Text;
            ((Label)bar.Controls["lbID"]).Text = lbID.Text;
            ((Label)chef.Controls["lbID"]).Text = lbID.Text;
        }
    }
}
