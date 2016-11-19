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
    public partial class PlanRoomInformation : UserControl
    {
        Plan plan;
        PlanGuestInformation planguestinformation;
        public PlanRoomInformation(Plan p,PlanGuestInformation pgi)
        {
            InitializeComponent();
            plan = p;
            planguestinformation = pgi;
        }

        private void btnInside_Click(object sender, EventArgs e)
        {
            openRoomPosition();
        }

        private void btnOcean_Click(object sender, EventArgs e)
        {
            openRoomPosition();
        }

        private void btnBalcony_Click(object sender, EventArgs e)
        {
            openRoomPosition();
        }

        public void openRoomPosition()
        {
            PlanRoomPosition prp = new PlanRoomPosition(plan,this);
            plan.Controls.Add(prp);
            this.Visible = false;
        }
    }
}
