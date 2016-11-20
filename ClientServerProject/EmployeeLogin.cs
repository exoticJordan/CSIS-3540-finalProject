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
        private List<Employee> employees;
        private MySqlConnection connection;
        MySqlCommand cmd;
        Plan plan;
        public EmployeeLogin(Plan p)
        {
            plan = p;
            employees = new List<Employee>();
            InitializeComponent();
            cmd = new MySqlCommand();
            string connectionString;
            connectionString = "SERVER=ec2-54-226-9-216.compute-1.amazonaws.com;"
                + " DATABASE=f2016_s1_user20; UID=f2016_s1_user20; PASSWORD=f2016_s1_user20;";
            connection = new MySqlConnection(connectionString);
        }

        private void btnEmBack_Click(object sender, EventArgs e)
        {
            OnBoard onboard = new OnBoard(plan);
            plan.Controls.Add(onboard);
            plan.Controls.Remove(this);
        }
        private void setupSqlCommand(String query)
        {
            cmd.Connection = connection;
            cmd.CommandText = query;
        }

        private void btnEmLog_Click(object sender, EventArgs e)
        {
            string uid = txtEmId.Text;
            string password = txtEmPW.Text;
            string query = "SELECT Staff_ID,Password,Position_ID FROM Staff WHERE Staff_ID = '" + uid
                + "' AND Password = '" + password + "'";
            Employee em;

            if (connection != null)
            {
                connection.Open();
                setupSqlCommand(query);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        em = new Employee();
                        em.EmID = dataReader["Staff_ID"].ToString();
                        em.Password = dataReader["Password"].ToString();
                        em.PositionID = dataReader["Position_ID"].ToString();
                        employees.Add(em);
                    }
                    dataReader.Close();
                    Chef chef = new Chef(plan);
                    plan.Controls.Add(chef);
                    plan.Controls.Remove(this);
                }

                else
                {
                    MessageBox.Show("Invalid username/password, please try again");
                }

                connection.Close();
            }

            else
            {
                connection.Close();
                MessageBox.Show("Try to reconnect database server");
            }
        }
    }
}
