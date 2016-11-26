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
    public partial class Schedule : UserControl
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        Plan plan;

        public Schedule(Plan p)
        {
            InitializeComponent();
            plan = p;
            cmd = new MySqlCommand();
            //    string a = lbID.Text;
         //   string eid = getID();

            string connectionString;
            
            connectionString = "SERVER=ec2-54-226-9-216.compute-1.amazonaws.com;"
                + " DATABASE=f2016_s1_user20; UID=f2016_s1_user20; PASSWORD=f2016_s1_user20;";
            connection = new MySqlConnection(connectionString);
    /*        string query = "SELECT Shift_StartDate, Shift_StartTime, Shift_Duration, Room_Number "
                              + "FROM Schedule, Facility WHERE Staff_ID = '" + eid + "'"
                              + " and Schedule.Facility_ID = Facility.Facility_ID";
            showData(query); */
            

        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            Chef chef = new Chef(plan);
            Bartender bar = new Bartender(plan);
            plan.Controls.Remove(this);
            if (lbS.Text == "Gift Cashier Schedule")
            {
               ((Button)bar.Controls["btnOrder"]).Text = "Gift Order";
               ((Button)bar.Controls["btnS"]).Text = lbS.Text;
               ((Label)bar.Controls["lbTitle"]).Text = "Gift Cashier";
                plan.Controls.Add(bar);
            }
            if (lbS.Text == "Bartender Schedule")
            {
                ((Button)bar.Controls["btnOrder"]).Text = "Bar Order";
                ((Button)bar.Controls["btnS"]).Text = lbS.Text;
                ((Label)bar.Controls["lbTitle"]).Text = "Bartender";
                plan.Controls.Add(bar);
            }
            if (lbS.Text == "Chef Schedule")
            {
                ((Button)chef.Controls["btnS"]).Text = lbS.Text;
                ((Label)chef.Controls["lbTitle"]).Text = "Chef";
                plan.Controls.Add(chef);
            }
            if (lbS.Text == "Server Schedule")
            {
                ((Button)chef.Controls["btnS"]).Text = lbS.Text;
                ((Label)chef.Controls["lbTitle"]).Text = "Server";
                plan.Controls.Add(chef);
            }
            if (lbS.Text == "Cleaner Schedule")
            {
                ((Button)chef.Controls["btnS"]).Text = lbS.Text;
                ((Label)chef.Controls["lbTitle"]).Text = "Cleaner";
                plan.Controls.Add(chef);
            }     
            ((Label)bar.Controls["lbName"]).Text = lbName.Text;
            ((Label)chef.Controls["lbName"]).Text = lbName.Text;
            ((Label)bar.Controls["lbID"]).Text = lbID.Text;
            ((Label)chef.Controls["lbID"]).Text = lbID.Text;
        }

        private void setupSqlCommand(String query)
        {
            cmd.Connection = connection;
            cmd.CommandText = query;
        }

        private void showData(string query)
        {
            if (connection != null)
            {
                DataSet ds = new DataSet();

                MySqlDataAdapter mcmd = new MySqlDataAdapter(query, connection);
                mcmd.Fill(ds, "Schedule");
                dataGridView.DataSource = ds.Tables["Schedule"];
            }
            else
            {
                MessageBox.Show("Try to connect");
            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* string a = lbID.Text;
            string b = comboBox.Text;         
            string query = "SELECT Shift_StartDate, Shift_StartTime, Shift_Duration, Room_Number,Schedule.Ship_ID "
                              + "FROM Schedule, Facility WHERE Staff_ID = '" + a + "' and Schedule.Ship_ID = Facility.Ship_ID"
                              + " and Schedule.Facility_ID = Facility.Facility_ID";
            lbShip.Text = "Ship " + b;
            showData(query); */
        }

        private void btnShowSche_Click(object sender, EventArgs e)
        {
            string a = lbID.Text;
            string b = comboBox.Text;
            string query = "SELECT Shift_StartDate, Shift_StartTime, Shift_Duration, Room_Number,Schedule.Ship_ID "
                              + "FROM Schedule, Facility WHERE Staff_ID = '" + a + "' and Schedule.Ship_ID = Facility.Ship_ID"
                              + " and Schedule.Facility_ID = Facility.Facility_ID";
            lbShip.Text = "Ship " + b;
            showData(query);
        }
    }
}
