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
    public partial class PlanRoomPosition : UserControl
    {
        Plan plan;
        PlanRoomInformation planroominformation;
        public PlanRoomPosition(Plan p,PlanRoomInformation pri)
        {
            InitializeComponent();
            plan = p;
            planroominformation = pri;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            openRoomDeck();
        }

        private void btnMiddle_Click(object sender, EventArgs e)
        {
            openRoomDeck();
        }

        private void btnFront_Click(object sender, EventArgs e)
        {
            openRoomDeck();
        }

        public void openRoomDeck()
        {
            PlanRoomDeck prd = new PlanRoomDeck(plan,this);
            plan.Controls.Add(prd);
            this.Visible = false;
        }
    }
}
