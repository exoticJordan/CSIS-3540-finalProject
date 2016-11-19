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
    public partial class PlanSearchResult : UserControl
    {
        Plan plan;
        PlanSearch plansearch;
        public PlanSearchResult(Plan p,PlanSearch ps)
        {
            InitializeComponent();
            plan = p;
            plansearch = ps;
        }

        private void btnBackToSearch_Click(object sender, EventArgs e)
        {
            openSearch();
        }

        public void openSearch()
        {
            plansearch.Visible = true;
            this.Visible = false;
        }

        public void openBook()
        {
            PlanRoomNumber prn = new PlanRoomNumber(plan,this);
            plan.Controls.Add(prn);
            this.Visible = false;
        }

        private void btnBook_Click_1(object sender, EventArgs e)
        {
            openBook();
        }
    }
}
