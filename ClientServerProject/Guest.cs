namespace ClientServerProject
{
    public class Guest
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string Addr { get; set; }
        public string PNum { get; set; }
        public string Email { get; set; }
        public int BYear { get; set; }
        public int BMonth { get; set; }
        public int BDate { get; set; }
        public char Gender { get; set; }
        public string ToDob()
        {
            string y, m, d, dob;
            y = BYear.ToString();
            if (BMonth < 10)
            {
                m = "0" + (BMonth);
            }
            else m = BMonth.ToString();
            if (BDate < 10)
            {
                d = "0" + (BDate);
            }
            else d = BDate.ToString();
            dob = y + m + d;
            return dob;
        }
        public override string ToString()
        {
            return FName + " " + LName;
        }
        public Guest(string fn, string ln, string ad, string pn, string em, int by,int bm,int bd,char gd)
        {
            FName = fn;
            LName = ln;
            Addr = ad;
            PNum = pn;
            Email = em;
            BYear = by;
            BMonth = bm;
            BDate = bd;
            Gender = gd;
        }
    }
}
