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
    public partial class Payment : UserControl
    {
	    private MySqlConnection _connection;
	    private MySqlCommand _command;
	    private Plan _plan;
	    private int[] _creds; //0: Room Number, 1: Ship Number, 2: Cruise Number

	    public Payment(MySqlConnection conn, MySqlCommand cmd, Plan p, int roomNum, int shipNum, int cruiseId)
	    {
			InitializeComponent();
		    _connection = conn;
		    _command = cmd;
			_plan = p;
		    _creds = new[] {roomNum, shipNum, cruiseId};
		    labRoomNum.Text = @"Room Number: " + _creds[0];

	    }

		public Payment()
        {
            InitializeComponent();
        }

		private void btnPaymentB_Click(object sender, EventArgs e)
		{
			var payLogin = new PaymentLogin();
			_plan.Controls.Add(payLogin);
			_plan.Controls.Remove(this);
		}
	}
}
