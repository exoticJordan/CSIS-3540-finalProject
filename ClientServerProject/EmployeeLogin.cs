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
    public partial class EmployeeLogin : UserControl
    {
       // private List<Employee> employees;
	    private MySqlConnection _connection;
	    private MySqlCommand _cmd;
	    private Plan _plan;

        public EmployeeLogin(Plan p)
        {
            _plan = p;
         //   employees = new List<Employee>();
            InitializeComponent();
            _cmd = new MySqlCommand();
	        var connectionString = "SERVER=ec2-54-226-9-216.compute-1.amazonaws.com;"
	                                  + " DATABASE=f2016_s1_user20; UID=f2016_s1_user20; PASSWORD=f2016_s1_user20;";
            _connection = new MySqlConnection(connectionString);
        }
        private void btnEmBack_Click(object sender, EventArgs e)
        {
            var onboard = new OnBoard(_plan);
            _plan.Controls.Add(onboard);
            _plan.Controls.Remove(this);
        }
        private void SetupSqlCommand(string query)
        {
            _cmd.Connection = _connection;
            _cmd.CommandText = query;
        }

        private void btnEmLog_Click(object sender, EventArgs e)
        {
            var uid = txtEmId.Text;
            var password = txtEmPW.Text;
            var query = "SELECT Staff_ID,Password,Position_Name,First_Name,Last_Name FROM Staff,Positions WHERE Staff_ID = '" + uid
                + "' AND Password = '" + password + "' AND Positions.Position_ID = Staff.Position_ID";

	        var chef = new Chef(_plan);
            var bar = new Bartender(_plan);
            if (_connection != null) 
            {
                _connection.Open();
                SetupSqlCommand(query);
                var dataReader = _cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    var em = new Employee();
                    while (dataReader.Read())
                    {
                        em.EmID = dataReader["Staff_ID"].ToString();
                        em.Password = dataReader["Password"].ToString();
                        em.PositionName = dataReader["Position_Name"].ToString();
                        em.FName = dataReader["First_Name"].ToString();
                        em.LName = dataReader["Last_Name"].ToString();
                        //     employees.Add(em);                        
                    }

                    //   Chef chef = new Chef(plan);
                    if ((em.PositionName == "Server") || (em.PositionName == "Chef") || (em.PositionName == "Cleaner"))
                    {
                        if (em.PositionName == "Cleaner")
                        {
                            ((Button)chef.Controls["btnS"]).Text = @"Cleaner Schedule";
                        }
                        if (em.PositionName == "Server")
                        {
                            ((Button)chef.Controls["btnS"]).Text = @"Server Schedule";
                        }
                        if (em.PositionName == "Chef")
                        {
                            ((Button)chef.Controls["btnS"]).Text = @"Chef Schedule";
                        }
                        ((Label)chef.Controls["lbTitle"]).Text = em.PositionName;
                        ((Label)chef.Controls["lbName"]).Text = em.FName + @" " + em.LName;
                        ((Label)chef.Controls["lbID"]).Text = em.EmID;
                        _plan.Controls.Add(chef);
                        _plan.Controls.Remove(this);
                    }
                    else
                    {
                        if (em.PositionName == "Cashier")
                        {
                            ((Button)bar.Controls["btnOrder"]).Text = @"Gift Order";
                            ((Button)bar.Controls["btnS"]).Text = @"Gift Cashier Schedule";
                            ((Label)bar.Controls["lbTitle"]).Text = @"Gift " + em.PositionName;
                        }
                        if (em.PositionName == "Bartender")
                        {
                            ((Button)bar.Controls["btnOrder"]).Text = @"Bar Order";
                            ((Button)bar.Controls["btnS"]).Text = @"Bartender Schedule";
                            ((Label)bar.Controls["lbTitle"]).Text = em.PositionName;
                        }
                        ((Label)bar.Controls["lbName"]).Text = em.FName + @" " + em.LName;
                        ((Label)bar.Controls["lbID"]).Text = em.EmID;
                        _plan.Controls.Add(bar);
                        _plan.Controls.Remove(this);
                    }

                    dataReader.Close(); 
                }

                else
                {
                    MessageBox.Show(@"Invalid username/password, please try again");
                }

                _connection.Close();
            }

            else
            {
	            _connection?.Close();
	            MessageBox.Show(@"Try to reconnect database server");
            }
        }
    }
}
