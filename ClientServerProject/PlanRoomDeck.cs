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
    public partial class PlanRoomDeck : UserControl
    {
        Plan plan;
        PlanRoomPosition planroomposition;
        public PlanRoomDeck(Plan p,PlanRoomPosition prp)
        {
            InitializeComponent();
            plan = p;
            planroomposition = prp;
        }


        //Button to open PlanRoomChoice.cs
        private void btnDeckCont_Click(object sender, EventArgs e)
        {
            openRoomChoice();
        }

        public void openRoomChoice()
        {
            PlanRoomChoice prc = new PlanRoomChoice(plan,this);
            plan.Controls.Add(prc);
            this.Visible = false;
        }
    }
}
