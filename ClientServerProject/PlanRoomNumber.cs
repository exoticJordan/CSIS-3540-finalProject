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
        DBConnect db = new DBConnect();
        MySqlConnection connection;
        MySqlCommand cmd;
        Plan plan;
        PlanSearchResult plansearchresult;
        int cruiseid;
        double roomprice;
        string roomnum;
        int guestnum;
        public PlanRoomNumber(Plan p, PlanSearchResult psr, int i, double d)
        {
            InitializeComponent();
            plan = p;
            plansearchresult = psr;
            cruiseid = i;
            roomprice = d;
        }

        private void btnRoomNumCont_Click(object sender, EventArgs e)
        {
            if (cbRoomNum.SelectedIndex != -1)
            {
                roomnum = cbRoomNum.SelectedItem.ToString();
                if (cbGuest.SelectedIndex != -1)
                {
                    guestnum = int.Parse(cbGuest.SelectedItem.ToString());
                    openGuestNumber();
                }
                else MessageBox.Show("Please choose the number of guests");
            }else MessageBox.Show("Please choose a room number");
        }

        public void openGuestNumber()
        {
            PlanGuestInformation pgn = new PlanGuestInformation(plan, this,cruiseid,roomnum,guestnum);
            plan.Controls.Add(pgn);
            this.Visible = false;
        }

        private void cbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //clear room number combobox
            cbRoomNum.Items.Clear();

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

            if (cbRoomType.SelectedIndex != -1 && cbPosition.SelectedIndex != -1 && cbDeck.SelectedIndex != -1)
            {
                loadRooms();
            }
        }

        public void loadRooms()
        {
            //-----given cruise id, room type, room pos, and room deck,
            //-----query for available room nums
            string query = "SELECT Room_Number FROM Rooms r ";
            query += "INNER JOIN Cruises c ON c.Ship_ID = r.Ship_ID ";
            query += "WHERE c.Cruise_ID =  '" + cruiseid + "' ";
            query += "AND Room_Type =  '" + cbRoomType.Text.Split(' ').First() + "' ";
            query += "AND Room_Location =  '" + cbPosition.Text + "' ";
            query += "AND Room_Deck =  '" + cbDeck.Text + "' ";
            query += "AND isOccupied =  '0'";

            connection = db.connect(connection);
            fillCMD(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbRoomNum.Items.Add(reader.GetString(0));
            }
            reader.Close();

            if (cbRoomNum.Items.Count == 0)
            {
                MessageBox.Show("No available rooms, please adjust your selections");
            }
        }

        public void fillCMD(string s, MySqlConnection c)
        {
            cmd.CommandText = s;
            cmd.Connection = c;
        }

        private void cbDeck_SelectedIndexChanged(object sender, EventArgs e)
        {
            //clear room number combobox
            cbRoomNum.Items.Clear();
            if (cbRoomType.SelectedIndex != -1 && cbPosition.SelectedIndex != -1 && cbDeck.SelectedIndex != -1)
            {
                loadRooms();
            }
        }

        private void cbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            //clear room number combobox
            cbRoomNum.Items.Clear();
            if (cbRoomType.SelectedIndex != -1 && cbPosition.SelectedIndex != -1 && cbDeck.SelectedIndex != -1)
            {
                loadRooms();
            }
        }

        private void cbRoomNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            //clear guest number combobox
            cbGuest.Items.Clear();
            loadGuests();
        }

        public void loadGuests()
        {
            string query = "SELECT COUNT(CASE WHEN Room_Number = '";
            query += cbRoomNum.Text;
            query += "' THEN 1 ELSE NULL END ) FROM(SELECT Room_Number FROM Booking WHERE Cruise_ID = '";
            query += cruiseid;
            query += "') AS a";

            fillCMD(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            int booked = 0;
            while (reader.Read())
            {
                booked = int.Parse(reader.GetString(0));
            }
            reader.Close();

            int available = 4 - booked;
            for (int x = 1; x <= available; x++)
            {
                cbGuest.Items.Add(x);
            }
        }

        private void PlanRoomNumber_Load_1(object sender, EventArgs e)
        {
            cmd = new MySqlCommand();
        }
    }
}
