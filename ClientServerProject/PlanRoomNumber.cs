using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ClientServerProject
{
    public partial class PlanRoomNumber : UserControl
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        Plan plan;
        PlanSearchResult plansearchresult;
        int cruiseid;
        double roomprice;
        public PlanRoomNumber(Plan p,PlanSearchResult psr,int i,double d)
        {
            InitializeComponent();
            plan = p;
            plansearchresult = psr;
            cruiseid = i;
            roomprice = d;
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

        private void cbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //clear other comboboxes
            cbPosition.SelectedIndex = -1;
            cbDeck.SelectedIndex = -1;
            cbRoomNum.SelectedIndex = -1;
            cbGuest.SelectedIndex = -1;

            int Selected = cbRoomType.SelectedIndex;
            switch (Selected)
            {
                case 0:
                    labelGuestNum.Text = roomprice + " per person";
                    break;
                case 1:
                    labelGuestNum.Text = roomprice + 200 + " per person";
                    break;
                case 2:
                    labelGuestNum.Text = roomprice + 400 + " per person";
                    break;
            }
        }

        private void cbDeck_SelectedIndexChanged(object sender, EventArgs e)
        {
            //-----given cruise id, room type, room pos, and room deck,
            //-----query for available room nums
            if (cbRoomType.SelectedIndex != -1 && cbPosition.SelectedIndex != -1 && cbDeck.SelectedIndex != -1)
            {
                string query = "SELECT Room_Number FROM Rooms r ";
                query += "INNER JOIN Cruises c ON c.Ship_ID = r.Ship_ID ";
                query += "WHERE c.Cruise_ID =  '"+ cruiseid +"' ";
                query += "AND Room_Type =  '" + cbRoomType.Text.Split(' ').First() + "' ";
                query += "AND Room_Location =  '" + cbPosition.Text + "' ";
                query += "AND Room_Deck =  '" + cbDeck.Text + "' ";
                query += "AND Room_Availability =  'Yes'";


            }
            else MessageBox.Show("Please fill all selections");
             
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

        private void cbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbRoomNum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
