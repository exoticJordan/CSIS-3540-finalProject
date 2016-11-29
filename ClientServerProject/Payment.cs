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
	    private MySqlDataAdapter _dgvData;

	    public Payment(MySqlConnection conn, MySqlCommand cmd, Plan p, int[] dataCollection)
	    {
			InitializeComponent();
			
		    _connection = conn;
		    _command = cmd;
			_plan = p;
		    _creds = dataCollection;
		    labRoom.Text = _creds[0].ToString();
			DisplayRecords();
		}

		public Payment()
        {
            InitializeComponent();
        }

	    private void DisplayRecords()
	    {
			var query2 =
				"SELECT DISTINCT P.Room_Num AS Room, P.Purchase_Date AS `Date`, " +
				"P.Purchase_Time AS `TIME`, P.TotalCost AS `COST(USD)`, " +
				"F.Facility_Name AS Location, S.Ship_Name AS Ship, C.Cruise_Name AS Cruise " +
				"FROM Purchases AS P " +
				"INNER JOIN Rooms AS R ON R.Room_Number = P.Room_Num " +
				"INNER JOIN Facility AS F ON F.Facility_ID = P.Facility_ID " +
				"INNER JOIN Cruises AS C ON C.Cruise_id = P.Cruise_ID " +
				"INNER JOIN Ships AS S ON S.Ship_id = P.Ship_ID " +
				"WHERE P.Room_Num = " + _creds[0] + " AND P.Ship_ID = " + _creds[1] + " AND P.Cruise_ID = " + _creds[2];
		    if (_connection.State == ConnectionState.Open)
		    {
			    _dgvData = new MySqlDataAdapter(query2, _connection);
				var ds = new DataSet();
			    _dgvData.Fill(ds);
			    dgvPurchasedGoods.DataSource = ds.Tables[0];
			    var totalCosts = 0.0;
			    _command.Connection = _connection;
			    _command.CommandText = query2;
			    var reader = _command.ExecuteReader();
			    while (reader.Read())
			    {
				    totalCosts += double.Parse(reader["COST(USD)"].ToString());
				    labShipName.Text = @"Ship Name: " + reader["Ship"];
				    labCruiseName.Text = @"Cruise Name: " + reader["Cruise"];
			    }
				reader.Close();
				
			    labTotalDue.Text = @"Total: $" + Math.Round(totalCosts,2);
		    }

		}

		private void btnPaymentB_Click(object sender, EventArgs e)
		{
			var payLogin = new PaymentLogin(_plan);
			_plan.Controls.Add(payLogin);
			_plan.Controls.Remove(this);
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			var payInfo = new PaymentInfo(_connection, _command, _plan, _creds);
			_plan.Controls.Add(payInfo);
			_plan.Controls.Remove(this);
		}
	}
}
