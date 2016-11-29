﻿using System;
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
    public partial class PlanPayment : UserControl
    {

        private readonly Plan _plan;
	    private PlanSearch _ps;
	    private PlanGuestInformation _planguestinfo;
	    private int _cruiseid;
	    private string _roomnum;
	    private List<Guest> _guestinfo;
	    private List<string> _temp = new List<string>();
	    private List<string> _custId = new List<string>();
	    private CommandProcessor _cp = new CommandProcessor();
	    private int pplInRoom;
	    private string shipid;
	    private double _price;

	    public PlanPayment(Plan p, PlanGuestInformation pgi, int ci, string rn, List<Guest> gi)
	    {
		    InitializeComponent();
		    _plan = p;
		    _planguestinfo = pgi;
		    _cruiseid = ci;
		    _roomnum = rn;
		    _guestinfo = gi;

		    
	    }

	    public PlanPayment(Plan p,PlanGuestInformation pgi,int ci,string rn,List<Guest>gi,double pr)
        {
            InitializeComponent();
            _plan = p;
            _planguestinfo = pgi;
            _cruiseid = ci;
            _roomnum = rn;
            _guestinfo = gi;
            _price = pr;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //------add customers info
            var query = "INSERT INTO Travellers VALUES(null, @fname, @lname, @addr, @phone, @email, @dob, @gender)";
            for (var x = 0; x < _guestinfo.Count(); x++)
            {
                _temp.Clear();
                _temp.Add(_guestinfo[x].FName);
                _temp.Add(_guestinfo[x].LName);
                _temp.Add(_guestinfo[x].Addr);
                _temp.Add(_guestinfo[x].PNum);
                _temp.Add(_guestinfo[x].Email);
                _temp.Add(_guestinfo[x].ToDob());
                _temp.Add(_guestinfo[x].Gender.ToString());
                _cp.insertRec(query, _temp);
                //------get customer autogenerated id
                const string cid = "select TVL_ID from Travellers where TVL_FName=@fname and TVL_LName=@lname and TVL_Address=@addr and TVL_Phone_Number=@phone and TVL_Email=@email and TVL_DOB=@dob and TVL_Gender=@gender";
                _custId.Add(_cp.getCId(cid, _temp));
            }
            //------add booking info
            query = "INSERT INTO Booking VALUES(@cruise,@tvlr,@room)";
            for(var y = 0; y < _guestinfo.Count(); y++)
            {
                _temp.Clear();
                _temp.Add(_cruiseid.ToString());
                _temp.Add(_custId[y]);
                _temp.Add(_roomnum);
                _cp.insertRec(query, _temp);
            }
            //------determine how many ppl reside in roomnum
            //------determine whether to change isOccupied to '1'
            query = "select Count(Traveller_Id) from Booking where Cruise_ID=@cruise and Room_Number=@room";
            pplInRoom = _cp.getPplInRoom(query, _cruiseid.ToString(), _roomnum);
            //find ship id given cruise id
            query = "select Ship_id from Cruises where Cruise_id=@cruise";
            shipid = _cp.getSId(query, _cruiseid);
            query = "update Rooms set isOccupied='1' where Room_Number=@room and Ship_ID=@ship";
            if (pplInRoom == 4)
            {
                _cp.updateRec(query, _roomnum, shipid);
            }
            MessageBox.Show(@"Payment successful, thank you for cruising with us");
            var ps = new PlanSearch(_plan);
            _plan.Controls.Add(ps);
            _plan.Controls.Remove(this);
        }

        private void PlanPayment_Load(object sender, EventArgs e)
        {
            label1.Text = "Total: CAD$" + _price;
        }
    }
}
