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
    public partial class PlanGuestNumber : UserControl
    {
        Plan plan;
        PlanRoomNumber planroomnumber;
        public PlanGuestNumber(Plan p,PlanRoomNumber prn)
        {
            InitializeComponent();
            plan = p;
            planroomnumber = prn;
        }

        private void btnGuestNumCont_Click(object sender, EventArgs e)
        {
            /*
             if statement to decide whether to move to next userControl or refresh same
            */
            openGuestInformation();
        }

        public void openGuestInformation()
        {
            PlanGuestInformation pgi = new PlanGuestInformation(plan,this);
            plan.Controls.Add(pgi);
            this.Visible = false;
        }
    }
}
