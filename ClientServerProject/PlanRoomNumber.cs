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
    public partial class PlanRoomNumber : UserControl
    {
        Plan plan;
        PlanSearchResult plansearchresult;
        public PlanRoomNumber(Plan p,PlanSearchResult psr)
        {
            InitializeComponent();
            plan = p;
            plansearchresult = psr;
            

        }

        private void btnRoomNumCont_Click(object sender, EventArgs e)
        {
            openGuestNumber();
        }

        public void openGuestNumber()
        {
            PlanGuestInformation pgn = new PlanGuestInformation(plan,this);
            plan.Controls.Add(pgn);
            this.Visible = false;
        }



        private void cbDeck_SelectedIndexChanged(object sender, EventArgs e)
        {
            //add room numbers, will not dispaly 
            cbRoomNum.Items.Clear();
            if (cbDeck.SelectedIndex == 0)
            {
                for (int i = 1; i <= 60; i++)
                {
                    cbRoomNum.Items.Add("1" + i.ToString("00"));
                }

            }
            else if (cbDeck.SelectedIndex == 1)
            {
                for (int i = 1; i <= 60; i++)
                {
                    cbRoomNum.Items.Add("2" + i.ToString("00"));
                }

            }
            else if (cbDeck.SelectedIndex == 2)
            {
                for (int i = 1; i <= 60; i++)
                {
                    cbRoomNum.Items.Add("3" + i.ToString("00"));
                }

            }
            else if (cbDeck.SelectedIndex == 3)
            {
                for (int i = 1; i <= 60; i++)
                {
                    cbRoomNum.Items.Add("4" + i.ToString("00"));
                }

            }
            else if (cbDeck.SelectedIndex == 4)
            {
                for (int i = 1; i <= 60; i++)
                {
                    cbRoomNum.Items.Add("5" + i.ToString("00"));
                }

            }
            else if (cbDeck.SelectedIndex == 5)
            {
                for (int i = 1; i <= 60; i++)
                {
                    cbRoomNum.Items.Add("6" + i.ToString("00"));
                }

            }
        }

        private void cbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Selected = cbRoomType.SelectedIndex;
            switch(Selected)
            {
                case 0:
                    cbGuest.Items.Clear();
                    labelGuestNum.Text = "The maximun number of guest allowed for room type1 is 2";
                    for (int i =1; i <=2 ;i++)
                    {
                        
                        cbGuest.Items.Add(i);
                    }
                    break;
                case 1:
                    cbGuest.Items.Clear();
                    labelGuestNum.Text = "The maximun number of guest allowed for room type2 is 3";
                    for (int i = 1; i <= 3; i++)
                    {
                        cbGuest.Items.Add(i);
                    }
                    break;
                case 2:
                    cbGuest.Items.Clear();
                    labelGuestNum.Text = "The maximun number of guest allowed for room type3 is 4";
                    for (int i = 1; i <= 4; i++)
                    {
                        cbGuest.Items.Add(i);
                    }
                    break;
            }
        }
    }
}
