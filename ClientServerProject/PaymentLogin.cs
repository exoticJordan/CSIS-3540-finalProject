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

        public PaymentLogin()
        {
            InitializeComponent();
			DbConnect();
			_command = new MySqlCommand();
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
			    int temp;
			    if (!int.TryParse(txtRoomNum.Text, out temp))
			    {
				    erpPayLog.SetError(txtRoomNum, @"Entered Text is not A Number");
				    if (temp < 101 || temp > 630)
				    {
					    erpPayLog.SetError(txtRoomNum, @"Room Number does not Exist! \n Please Check your Records and Try Again.");
				    }
				    if (temp > 130 && temp < 201)
				    {
					    erpPayLog.SetError(txtRoomNum, @"Room Number does not Exist! \n Please Check your Records and Try Again.");
				    }
				    if (temp > 230 && temp < 301)
				    {
					    erpPayLog.SetError(txtRoomNum, @"Room Number does not Exist! \n Please Check your Records and Try Again.");
				    }
				    if (temp > 330 && temp < 401)
				    {
					    erpPayLog.SetError(txtRoomNum, @"Room Number does not Exist! \n Please Check your Records and Try Again.");
				    }
				    if (temp > 430 && temp < 501)
				    {
					    erpPayLog.SetError(txtRoomNum, @"Room Number does not Exist! \n Please Check your Records and Try Again.");
				    }
				    if (temp > 530 && temp < 601)
				    {
					    erpPayLog.SetError(txtRoomNum, @"Room Number does not Exist! \n Please Check your Records and Try Again.");
				    }
				    if (temp == 110 || temp == 220 || temp == 330 || temp == 410)
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
                            
						    var temp2 = DbValidate(validRoomNum, validPass);
						    var pairValid = bool.Parse(temp2[0]);
						    if (!pairValid)
						    {
							    erpPayLog.SetError(btnUserLog, @"Login Information is incorrect! Please try again.");
						    }
						    else
						    {
							    erpPayLog.SetError(btnUserLog, @"");
							    GotoPayment(int.Parse(temp2[1]), temp2[2]);
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

	    private string[] DbValidate(int roomNum, string roomPass)
	    {
		    string[] retVal = {bool.FalseString, "", ""};

            var fname = roomPass.Substring(3, roomPass.Length);

		    var query1 =
				"SELECT DISTINCT B.Room_Number AS RNUM " +
				"FROM Rooms AS R " +
				"INNER JOIN Booking AS B ON R.Room_Number = B.Room_Number " +
				"INNER JOIN Travellers AS T ON B.Traveller_ID = T.TVL_ID " +
				"WHERE B.Room_Number = "+ roomNum +" AND T.TVL_FName = '"+ fname +"'";
		    var query2 =
			    "";
            string verifiedRoomNum;
		    _command.Connection = _connection;
		    _command.CommandText = query1;
		    var reader = _command.ExecuteReader();
		    while (reader.Read())
		    {
                verifiedRoomNum = reader["RNUM"].ToString();
		    }
			return retVal;
	    }

	    private void GotoPayment(int roomNum, string guestName)
	    {
		    
	    }
	}
}
