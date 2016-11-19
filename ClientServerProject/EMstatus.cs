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
    public partial class EMstatus : UserControl
    {
        Plan plan;
        public EMstatus(Plan p)
        {
            InitializeComponent();
            plan = p;
        }
    }
}
