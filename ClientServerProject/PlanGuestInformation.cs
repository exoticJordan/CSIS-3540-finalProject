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
        int count = 0;
        List<GuestInfo> guestList = new List<GuestInfo>();
        List<string> temp = new List<string>();
        CommandProcessor cp;
        string roomnum;
        int guestnum;
        string by, bm, bd;
        int guestinfonumber;
        public PlanGuestInformation(Plan p, PlanRoomNumber pgn,string rn,int gn)
        {
            InitializeComponent();
            plan = p;
            planguestnumber = pgn;
            roomnum = rn;
            guestnum = gn;
        }

        private void btnGuestCont_Click(object sender, EventArgs e)
        {
            /*
             if statement to decide whether to move to next userControl or refresh same
            */
            if (guestList.Count() == guestnum)
            {
                string query = "INSERT INTO Travellers VALUES(@fname, @lname, @addr, @phone, @email, @dob, @gender)";
                for (int x = 0; x < guestList.Count; x++)
                {
                    temp.Add(guestList[x].fName);
                    temp.Add(guestList[x].lName);
                    temp.Add(guestList[x].addr);
                    temp.Add(guestList[x].pNum);
                    temp.Add(guestList[x].email);
                    temp.Add(guestList[x].dob);
                    temp.Add(guestList[x].Gen);
                    cp.insertRec(query, temp);
                }
                PlanPayment pp = new PlanPayment(plan, this);
                plan.Controls.Add(pp);
                this.Visible = false;
            }
            else if (guestList.Count() < guestnum) MessageBox.Show("Have you registered all the guests?");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string gender, fn, ln, num, addr, email,dob;
 
            if(radFemale.Checked == true)
                gender = "F";
            else gender = "M";
            fn = tbFname.Text;
            ln = tbLName.Text;
            num = tbPhoneNum.Text;
            addr = txtAddr.Text;
            email = txtEmail.Text;
            string[] s = datePicker.Value.ToString().Split('/');
            bm = s[0];
            bd = s[1];
            s = s[2].Split(' ');
            by = s[0];
            dob = by.ToString() + bm.ToString() + bd.ToString();
            if (fn != "" && ln != "" && num != "" && addr != "" && email != "" && dob != "" && gender != "")
            {
                if (guestList.Count() < guestnum)
                {
                    guestList.Add(new GuestInfo(fn, ln, addr, num, email, gender, dob));
                    lbGuest.DataSource = null;
                    lbGuest.DataSource = guestList;
                }
                else MessageBox.Show("Max number of guests added");
            }
            else MessageBox.Show("All fields must be filled");
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int selectedIndex = lbGuest.SelectedIndex;

            if (selectedIndex != -1)
            {
                guestList.RemoveAt(selectedIndex);
            }
            else
            {
                MessageBox.Show("Select something");
            }
            lbGuest.DataSource = null;
            lbGuest.DataSource = guestList;
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lbGuest.SelectedIndex == -1)
                return;
            int selectedIndex = lbGuest.SelectedIndex;
                
            tbFname.Text = guestList[selectedIndex].fName;
            tbLName.Text = guestList[selectedIndex].lName;
            int y, m, d;
            y = int.Parse(guestList[selectedIndex].dob.Substring(0, 4));
            m = int.Parse(guestList[selectedIndex].dob.Substring(4, 2));
            d = int.Parse(guestList[selectedIndex].dob.Substring(6, 2));
            datePicker.Value = new DateTime(y,m,d);
            tbPhoneNum.Text = guestList[selectedIndex].pNum;
            txtAddr.Text = guestList[selectedIndex].addr;
            txtEmail.Text = guestList[selectedIndex].email;
            if (guestList[selectedIndex].Gen == "M")
                radMale.Checked = true;
            else radFemale.Checked = true;
            guestinfonumber = selectedIndex;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string gender, fn, ln, num, addr, email, dob;
            if (radFemale.Checked == true)
                gender = "F";
            else gender = "M";
            fn = tbFname.Text;
            ln = tbLName.Text;
            num = tbPhoneNum.Text;
            addr = txtAddr.Text;
            email = txtEmail.Text;
            string[] s = datePicker.Value.ToString().Split('/');
            bm = s[0];
            bd = s[1];
            s = s[2].Split(' ');
            by = s[0];
            dob = by.ToString() + bm.ToString() + bd.ToString();
            if (fn != "" && ln != "" && num != "" && addr != "" && email != "" && dob != "" && gender != "")
            {
                if (guestList.Count() < guestnum)
                {
                    //fn, ln, addr, num, email, gender, dob));
                    guestList[guestinfonumber].fName = fn;
                    guestList[guestinfonumber].lName = ln;
                    guestList[guestinfonumber].addr = addr;
                    guestList[guestinfonumber].pNum = num;
                    guestList[guestinfonumber].email = email;
                    guestList[guestinfonumber].Gen = gender;
                    guestList[guestinfonumber].dob = dob;
                    lbGuest.Refresh();
                    lbGuest.Update();
                }
                else MessageBox.Show("Max number of guests added");
            }
            else MessageBox.Show("All fields must be filled");
        }

        private void tbBirthYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
    class GuestInfo
    {
        public string fName { get; set; }
        public string lName { get; set; }
        public string pNum { get; set; }
        public string Gen { get; set; }
        public string dob { get; set; }
        public string email { get; set; }
        public string addr { get; set; }


        public GuestInfo(string FirstName,string LastName, string address,string phoneNum,string em,string Gender, string dateob)
        {
            fName = FirstName;
            lName = LastName;
            addr = address;
            pNum = phoneNum;
            email = em;
            Gen = Gender;
            dob = dateob;

        }


    }


}
