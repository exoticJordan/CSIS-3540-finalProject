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
        List<Cruise> cruises;
        int index;
        public PlanSearchResult(Plan p,PlanSearch ps,List<Cruise> c,int i=0)
        {
            InitializeComponent();
            plan = p;
            plansearch = ps;
            cruises = c;
            index = i;
            if (index == 0)
                btnPrevResult.Enabled = false;
            else if (index == cruises.Count() - 1)
                btnNextResult.Enabled = false;
        }

        private void PlanSearchResult_Load(object sender, EventArgs e)
        {
            lblName.Text = cruises[index].Name;
            lblShip.Text = cruises[index].Ship;
            lblPrice.Text = (cruises[index].Price).ToString();

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
            PlanRoomNumber prn = new PlanRoomNumber(plan,this, cruises[index].ID,cruises[index].Price);
            plan.Controls.Add(prn);
            this.Visible = false;
        }

        private void btnBook_Click_1(object sender, EventArgs e)
        {
            openBook();
        }

        private void btnNextResult_Click(object sender, EventArgs e)
        {
            if (index < cruises.Count() - 1)
            {
                PlanSearchResult psr = new PlanSearchResult(plan, plansearch, cruises, index + 1);
                plan.Controls.Add(psr);
                plan.Controls.Remove(this);
            }
            else btnNextResult.Enabled = false;
        }

        private void btnPrevResult_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                PlanSearchResult psr = new PlanSearchResult(plan, plansearch, cruises, index - 1);
                plan.Controls.Add(psr);
                plan.Controls.Remove(this);
            }
            else btnPrevResult.Enabled = false;
        }
    }
}
