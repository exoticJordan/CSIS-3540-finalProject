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
    public partial class PlanSearch : UserControl
    {
        Plan plan;
        public PlanSearch(Plan p)
        {
            InitializeComponent();
            plan = p;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            openResult();
        }

        public void openResult()
        {
            PlanSearchResult psr = new PlanSearchResult(plan,this);
            plan.Controls.Add(psr);
            this.Visible = false;
        }

        private void btnOnBoard_Click(object sender, EventArgs e)
        {
            OnBoard onboard = new OnBoard(plan);
            plan.Controls.Add(onboard);
            plan.Controls.Remove(this);
        }
    }
}
