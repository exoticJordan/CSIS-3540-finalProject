using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientServerProject
{
    class Guest
    {
        public string fName { get; set; }
        public string lName { get; set; }
        public string addr { get; set; }
        public string pNum { get; set; }
        public string email { get; set; }
        public int bYear { get; set; }
        public int bMonth { get; set; }
        public int bDate { get; set; }
        public char gender { get; set; }
        public string toDOB()
        {
            string y, m, d, dob;
            y = this.bYear.ToString();
            if (this.bMonth < 10)
            {
                m = "0" + (this.bMonth.ToString());
            }
            else m = this.bMonth.ToString();
            if (this.bDate < 10)
            {
                d = "0" + (this.bDate.ToString());
            }
            else d = this.bDate.ToString();
            dob = y + m + d;
            return dob;
        }
        public override string ToString()
        {
            return fName + " " + lName;
        }
        public Guest(string fn, string ln, string ad, string pn, string em, int by,int bm,int bd,char gd)
        {
            fName = fn;
            lName = ln;
            addr = ad;
            pNum = pn;
            email = em;
            bYear = by;
            bMonth = bm;
            bDate = bd;
            gender = gd;
        }
    }
}
