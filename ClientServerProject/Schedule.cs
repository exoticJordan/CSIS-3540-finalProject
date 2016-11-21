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
       /*    Chef chef = new Chef(plan);
            Bartender bar = new Bartender(plan);
             plan.Controls.Remove(this);
             if (lbS.Text == "Gift Cashier Schedule")
            {
              ((Button)bar.Controls["btnOrder"]).Text = "Gift Order";
              plan.Controls.Add(bar);
              }
           


    */


        }
    }
}
