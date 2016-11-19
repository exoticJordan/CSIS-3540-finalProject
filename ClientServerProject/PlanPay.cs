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
    public partial class PlanPay : UserControl
    {
        Plan plan;
        PlanTotal plantotal;
        public PlanPay(Plan p,PlanTotal pt)
        {
            InitializeComponent();
            plan = p;
            plantotal = pt;
        }
    }
}
