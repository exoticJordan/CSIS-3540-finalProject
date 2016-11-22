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

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int gender;
            string fn;
            string ln;
            string num;
            int bd;
            int bm;
            int by;
            
 
                if(radFemale.Checked == true)
                {
                    gender = 0;
                }
                else
                {
                    gender = 1;
                }
                fn = tbFname.Text;
                ln = tbLName.Text;
                num = tbPhoneNum.Text;
                bd = Int32.Parse(tbBirthDate.Text);
                bm = Int32.Parse(tbBirthMonth.Text);
                by = Int32.Parse(tbBirthYear.Text);
                guestList.Add(new GuestInfo(fn,ln,num,gender,bd,bm,by));
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
        public int Gen { get; private set; }
        public int bDate { get; private set; }
        public int bMonth { get; private set; }
        public int bYear { get; private set; }
         
   

        public GuestInfo(string FirstName,string LastName, string phoneNum,int Gender, int birthDate,int birthMonth,int birthYear)
        {
            fName = FirstName;
            lName = LastName;
            pNum = phoneNum;
            Gen = Gender;
            bDate = birthDate;
            bMonth = birthDate;
            bYear = birthYear;

        }


    }


}
