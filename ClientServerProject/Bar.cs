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

    public partial class Bar : UserControl
    {
        Plan plan;
        public Bar(Plan p)
        {
            InitializeComponent();
            plan = p;
        }
        public Bar()
        {
            InitializeComponent();
        }

        private void btnBarB_Click(object sender, EventArgs e)
        {

        }
    }
}
