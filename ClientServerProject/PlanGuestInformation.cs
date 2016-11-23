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
        public PlanGuestInformation(Plan p, PlanRoomNumber pgn)
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
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string gender,fn,ln,num,addr,email,dob;
            
 
            if(radFemale.Checked == true)
            {
                gender = "F";
            }
            else
            {
                gender = "M";
            }
            fn = tbFname.Text;
            ln = tbLName.Text;
            num = tbPhoneNum.Text;
            addr = txtAddr.Text;
            email = txtEmail.Text;
            dob = tbBirthYear.Text + tbBirthMonth.Text + tbBirthDate.Text;
            guestList.Add(new GuestInfo(fn,ln,addr,num,email,gender,dob));
            lbGuest.Items.Add(guestList[count].fName + guestList[count].lName);
            
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(lbGuest);
            selectedItems = lbGuest.SelectedItems;

            if (lbGuest.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                {
                    lbGuest.Items.Remove(selectedItems[i]);
                    guestList.RemoveAt(i);
                }
            }
            else
            {
                MessageBox.Show("Select something");
            }
        }
    }
    class GuestInfo
    {
        public string fName { get; private set; }
        public string lName { get; private set; }
        public string pNum { get; private set; }
        public string Gen { get; private set; }
        public string dob { get; private set; }
        public string email { get; private set; }
        public string addr { get; private set; }


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
