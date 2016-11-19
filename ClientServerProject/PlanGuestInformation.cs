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
    public partial class PlanGuestInformation : UserControl
    {
        Plan plan;
        PlanRoomNumber planguestnumber;
        public PlanGuestInformation(Plan p,PlanRoomNumber pgn)
        {
            InitializeComponent();
            plan = p;
            planguestnumber = pgn;
            
        }

        private void btnGuestCont_Click(object sender, EventArgs e)
        {
            /*
             if statement to decide whether to move to next userControl or refresh same
            */
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int count = 0;
            GuestInfo[] gInfo = new GuestInfo[4];
            for (int i = 0; i < 4; i++)
            {
                gInfo[i] = new GuestInfo();
            }

            gInfo[0].FirstName = "See";
            gInfo[0].LastName = "The Sharp Band";
            gInfo[0].Rating = 10;
        }
    }
    class GuestInfo
    {
        private string fName;
        private string lName;
        private int rating;

        public string FirstName
        {
            get { return fName; }
            set { fName = value; }
        }
        public string LastName
        {
            get { return lName; }
            set { lName = value; }
        }
        public int Rating
        {
            get { return rating; }
            set { rating = value; }
        }
    }


}
