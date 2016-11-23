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
    public partial class PlanPayment : UserControl
    {
        public PlanPayment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment successful, thank you for cruising with us");
            /*
            //---1--INSERT TVL_FName, TVL_LName, TVL_Phone_Number, TVL_DOB, TVL_Gender 
            //------into TRAVELLERS table

            //---2--INSERT Cruise_ID,Room_Number,TVL_ID
            //------into CRUISES table

            //---3--do math, determine whether to
            //------UPDATE Room_Availability to No
             */
        }
    }
}
