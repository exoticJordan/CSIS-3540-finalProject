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
    public partial class PlanRoomChoice : UserControl
    {
        Plan plan;
        PlanRoomDeck planroomdeck;
        public PlanRoomChoice(Plan p,PlanRoomDeck prd)
        {
            InitializeComponent();
            plan = p;
            planroomdeck = prd;
        }

        private void btnChoiceCont_Click(object sender, EventArgs e)
        {
            openTotal();
        }

        public void openTotal()
        {
            PlanTotal pt = new PlanTotal(plan,this);
            plan.Controls.Add(pt);
            this.Visible = false;
        }
    }
}
