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
    public partial class PaymentLogin : UserControl
    {
	    private MySqlConnection _connection;
	    private MySqlCommand _command;
	    private Plan _plan;

        public PaymentLogin()
        {
            InitializeComponent();
			DbConnect();
			_command = new MySqlCommand();
			_plan = new Plan();
	        //labHint1.Visible = false;
	        labHint2.Visible = false;
        }

	    private void DbConnect()
	    {
		    const string server = "ec2-54-226-9-216.compute-1.amazonaws.com";
		    const string db = "f2016_s1_user20";
		    const string id = "f2016_s1_user20";
		    const string pass = "f2016_s1_user20";
			
			const string connectionString = "SERVER=" + server + ";DATABASE=" + db + ";UID=" + id + ";PASSWORD=" + pass + ";";
			_connection = new MySqlConnection(connectionString);

			_connection.Open();
		}

		private void btnUserLog_Click(object sender, EventArgs e)
		{
			UserLogin();
		}

	    private void UserLogin()
	    {
		    if (!string.IsNullOrWhiteSpace(txtRoomNum.Text))
		    {
			    int roomNum;
			    if (!int.TryParse(txtRoomNum.Text, out roomNum))
			    {
				    erpPayLog.SetError(txtRoomNum, @"Entered Text is not A Number");

				    if (roomNum < 101 || roomNum > 630)
				    {
					    erpPayLog.SetError(txtRoomNum, @"Room Number does not Exist! \n Please Check your Records and Try Again.");
				    }
				    if (roomNum > 130 && roomNum < 201)
				    {
					    erpPayLog.SetError(txtRoomNum, @"Room Number does not Exist! \n Please Check your Records and Try Again.");
				    }
				    if (roomNum > 230 && roomNum < 301)
				    {
					    erpPayLog.SetError(txtRoomNum, @"Room Number does not Exist! \n Please Check your Records and Try Again.");
				    }
				    if (roomNum > 330 && roomNum < 401)
				    {
					    erpPayLog.SetError(txtRoomNum, @"Room Number does not Exist! \n Please Check your Records and Try Again.");
				    }
				    if (roomNum > 430 && roomNum < 501)
				    {
					    erpPayLog.SetError(txtRoomNum, @"Room Number does not Exist! \n Please Check your Records and Try Again.");
				    }
				    if (roomNum > 530 && roomNum < 601)
				    {
					    erpPayLog.SetError(txtRoomNum, @"Room Number does not Exist! \n Please Check your Records and Try Again.");
				    }
				    if (roomNum == 110 || roomNum == 220 || roomNum == 330 || roomNum == 410)
				    {
					    erpPayLog.SetError(txtRoomNum, @"That is a facility number, are you sure you live there?");
				    }
			    }
			    else
			    {
				    erpPayLog.SetError(txtRoomNum, @"");
				    var validRoomNum = int.Parse(txtRoomNum.Text);
				    if (!string.IsNullOrWhiteSpace(txtUserPassword.Text))
				    {
					    int temp1;
					    if (!int.TryParse(txtUserPassword.Text, out temp1))
					    {
						    var validPass = txtUserPassword.Text;
                            
						    var vals = DbValidate(validRoomNum, validPass);
						    var pairValid = Convert.ToBoolean(vals[0]);
						    if (!pairValid)
						    {
							    erpPayLog.SetError(btnUserLog, @"Login Information is incorrect! Please try again.");
						    }
						    else
						    {
							    erpPayLog.SetError(btnUserLog, @"");
							    GotoPayment(vals[1],vals[2],vals[3]);
						    }
					    }
					    else
					    {
						    erpPayLog.SetError(txtUserPassword, @"Entered Text is not a Valid Password!");
					    }
				    }
				    else
				    {
					    erpPayLog.SetError(txtUserPassword, @"Please Enter the Password Provided to You in Your Rerservation.");
				    }
			    }
		    }
		    else
		    {
			    erpPayLog.SetError(txtRoomNum, @"Please Enter your Room Number.");
		    }
	    }

	    private int[] DbValidate(int roomNum, string roomPass)
	    {
			//value sets: {True/False, RoomNum, ShipId, CruiseId}
		    int[] retVal = {0,0,0,0};

            //var old = roomPass.Substring(3, roomPass.Length);
		    var sectionsStrings = roomPass.Split('-');
		    var sectionInts = sectionsStrings.Select(int.Parse).ToArray();
			//0: Room Number, 1: Ship Number, 2: Cruise Number
			
			var query1 =
				"SELECT DISTINCT P.Room_Num AS RNUM, P.Ship_ID AS SID, P.Cruise_ID AS CID " +
				"FROM Purchases AS P " +
				"INNER JOIN Rooms AS R ON R.Room_Number = P.Room_Num " +
				"INNER JOIN Ships AS S ON S.Ship_id = P.Ship_ID " +
				"INNER JOIN Cruises AS C ON C.Cruise_id = P.Cruise_ID " +
				"WHERE P.Room_Num = 514 AND P.Ship_ID = 1 AND P.Cruise_ID = 2";
		    var query2 =
				"SELECT DISTINCT P.Room_Num AS Room, P.Purchase_Date AS `Date`, " +
				"P.Purchase_Time AS `TIME`, P.TotalCost AS `COST(USD)`, " +
				"F.Facility_Name AS Location, S.Ship_Name AS Ship, C.Cruise_Name AS Cruise " +
				"FROM Purchases AS P " +
				"INNER JOIN Rooms AS R ON R.Room_Number = P.Room_Num " +
				"INNER JOIN Facility AS F ON F.Facility_ID = P.Facility_ID " +
				"INNER JOIN Cruises AS C ON C.Cruise_id = P.Cruise_ID " +
				"INNER JOIN Ships AS S ON S.Ship_id = P.Ship_ID " +
				"WHERE P.Room_Num = 514 AND P.Ship_ID = 1 AND P.Cruise_ID = 2";
		    _command.Connection = _connection;
		    _command.CommandText = query1;
		    var reader = _command.ExecuteReader();
		    while (reader.Read())
		    {
			    var verifiedRoomNum = int.Parse(reader["RNUM"].ToString());
			    var verifiedShipId = int.Parse(reader["SID"].ToString());
			    var verifiedCruiseId = int.Parse(reader["CID"].ToString());
				if (verifiedRoomNum == roomNum && verifiedShipId == sectionInts[1] && verifiedCruiseId == sectionInts[2])
			    {
				    reader.Close();
				    retVal = new[] {1,verifiedRoomNum,verifiedShipId,verifiedCruiseId};
					break;
			    }
		    }
			return retVal;
	    }

	    private void GotoPayment(int roomNum, int shipNum, int cruiseNum)
	    {
		    var payment = new Payment(_connection,_command,_plan,roomNum,shipNum,cruiseNum);
			_plan.Controls.Add(payment);
			_plan.Controls.Remove(this);
	    }

		private void btnUserBack_Click(object sender, EventArgs e)
		{
			var onboard = new OnBoard(_plan);
			_plan.Controls.Add(onboard);
			_plan.Controls.Remove(this);
		}
	}
}
