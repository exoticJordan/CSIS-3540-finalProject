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
        Plan plan;
        PlanSearch ps;
        PlanGuestInformation planguestinfo;
        int cruiseid;
        string roomnum;
        List<string> guestinfo;
        CommandProcessor cp = new CommandProcessor();
        public PlanPayment(Plan p,PlanGuestInformation pgi,int ci,string rn,List<string>gi)
        {
            InitializeComponent();
            plan = p;
            planguestinfo = pgi;
            cruiseid = ci;
            roomnum = rn;
            guestinfo = gi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Booking VALUES(@cruise,@tvlr,@room)";
            /*
            //---1--INSERT TVL_FName, TVL_LName, TVL_Phone_Number, TVL_DOB, TVL_Gender 
            //------into TRAVELLERS table

            //---2--INSERT Cruise_ID,Room_Number,TVL_ID
            //------into CRUISES table

            //---3--do math, determine whether to
            //------UPDATE Room_Availability to No
             */
            MessageBox.Show("Payment successful, thank you for cruising with us");
            PlanSearch ps = new PlanSearch(plan);
            plan.Controls.Add(ps);
            plan.Controls.Remove(this);
        }
    }
}
