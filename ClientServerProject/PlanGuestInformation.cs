using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ClientServerProject
{
    public partial class PlanGuestInformation : UserControl
    {
        Plan plan;
        PlanRoomNumber planguestnumber;
        Guest g;
        CommandProcessor cp = new CommandProcessor();
        int cruiseid;
        string roomnum;
        int guestnum;
        double price;
        List<Guest> guests = new List<Guest>();
        int guestinfonumber = -1;
        //int count = 0;
        //string by, bm, bd;
        public PlanGuestInformation(Plan p, PlanRoomNumber pgn,int ci,string rn,int gn,double pr)
        {
            InitializeComponent();
            plan = p;
            planguestnumber = pgn;
            cruiseid = ci;
            roomnum = rn;
            guestnum = gn;
            price = pr;
        }

        private void btnGuestCont_Click(object sender, EventArgs e)
        {
            if (guests.Count() == guestnum)
            {
                PlanPayment pp = new PlanPayment(plan, this,cruiseid,roomnum,guests,price);
                plan.Controls.Add(pp);
                this.Visible = false;
            }
            else if (guests.Count() < guestnum)
                MessageBox.Show("Have you registered all the guests?");            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fn, ln, ad, pn, em;
            int by, bm, bd;
            char gd=' ';
            //set guest gender
            if (radFemale.Checked == true)
                gd = 'F';
            else gd = 'M';
            //set guest info
            fn = txtFname.Text;
            ln = txtLname.Text;
            ad = txtAddr.Text;
            pn = txtPhone.Text;
            em = txtEmail.Text;
            //set guest dob
            MessageBox.Show(dtPicker.Value.ToString());
            string[] s = dtPicker.Value.ToString().Split('/');
            int.TryParse(s[0], out bm);
            int.TryParse(s[1], out bd);
            s = s[2].Split(' ');
            int.TryParse(s[0], out by);
            if (fn != "" && ln != "" && ad != "" && pn != "" && em != "" && by != 0 && bm != 0 && bd != 0 && gd != ' ')
            {
                if (guestinfonumber == -1)
                {
                    if (guests.Count() < guestnum)
                    {
                        guests.Add(new Guest(fn, ln, ad, pn, em, by, bm, bd, gd));
                    }
                    else MessageBox.Show("Max number of guests added");
                }
                else
                {
                    replaceTime(fn, ln, ad, pn, em, by, bm, bd, gd);
                }
            }
            else MessageBox.Show("All fields must be filled");
            lbGuest.DataSource = null;
            lbGuest.DataSource = guests;
            cleanTime();
            guestinfonumber = -1;
        }

        public void replaceTime(string f,string l,string a,string p,string e,int y,int m,int d,char g)
        {
            guests[guestinfonumber].FName = f;
            guests[guestinfonumber].LName = l;
            guests[guestinfonumber].Addr = a;
            guests[guestinfonumber].PNum = p;
            guests[guestinfonumber].Email = e;
            guests[guestinfonumber].BYear = y;
            guests[guestinfonumber].BMonth = m;
            guests[guestinfonumber].BDate = d;
            guests[guestinfonumber].Gender = g;
        }

        public void cleanTime()
        {
            txtFname.Text = "";
            txtLname.Text = "";
            txtAddr.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int yr, mt, dt;
            int selectedIndex = lbGuest.SelectedIndex;
            if (selectedIndex == -1) return;
            txtFname.Text = guests[selectedIndex].FName;
            txtLname.Text = guests[selectedIndex].LName;
            txtAddr.Text = guests[selectedIndex].Addr;
            txtPhone.Text = guests[selectedIndex].PNum;
            txtEmail.Text = guests[selectedIndex].Email;
            if (guests[selectedIndex].Gender == 'M')
                radMale.Checked = true;
            else radFemale.Checked = true;
            yr = guests[selectedIndex].BYear;
            mt = guests[selectedIndex].BMonth;
            dt = guests[selectedIndex].BDate;
            dtPicker.Value = new DateTime(yr,mt,dt);
            guestinfonumber = selectedIndex;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int selectedIndex = lbGuest.SelectedIndex;

            if (selectedIndex != -1)
            {
                guests.RemoveAt(selectedIndex);
            }
            else
            {
                MessageBox.Show("Select something");
            }
            lbGuest.DataSource = null;
            lbGuest.DataSource = guests;            
        }

        private void PlanGuestInformation_Load(object sender, EventArgs e)
        {

        }

        private void tbBirthMonth_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbBirthDate_TextChanged(object sender, EventArgs e)
        {
        }

        private void lbGuest_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtFN_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbBirthYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
