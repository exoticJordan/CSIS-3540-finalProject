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
    public partial class PlanSearch : UserControl
    {
        DBConnect dbc = new DBConnect();
        Plan plan;
        MySqlConnection connection;
        MySqlCommand cmd;
        string criteria, order;
        List<int> tempId;
        List<Cruise> cruises;

        public PlanSearch(Plan p)
        {
            InitializeComponent();
            plan = p;
        }

        private void PlanSearch_Load(object sender, EventArgs e)
        {
            cmd = new MySqlCommand();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //set the search order by
            if (radioButton1.Checked)
                order = " order by Cruise_Price";
            else order = " order by Ship_Name";
            if (criteria != null)
            {
                executeSearch(criteria, order);
            }
            else
            {
                executeSearch("none", order);
            }
            openResult();
        }

        public void executeSearch(string criteria, string order)
        {
            string query = "select Cruise_id,Cruise_Name,Ship_Name,Route_Duration,Cruise_Price from Cruises c inner join Ships s on c.Ship_id=s.Ship_id inner join Routes r on c.Route_id=r.Route_Number";
            if (criteria != "none")
            {
                query += criteria + order;
                System.Console.WriteLine(query);
            }
            else
            {
                query += order;
                System.Console.WriteLine(query);
            }
            connection = dbc.connect(connection);
            fillCMD(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            cruises = new List<Cruise>();
            while (reader.Read())
            {
                cruises.Add(
                    new Cruise
                    {
                        ID = int.Parse(reader.GetString(0)),
                        Name = reader.GetString(1),
                        Ship = reader.GetString(2),
                        Duration = int.Parse(reader.GetString(3)),
                        Price = Double.Parse(reader.GetString(4))
                    }
                );
            }
            reader.Close();
            tempId = new List<int>();
            for(int x =0;x< cruises.Count(); x++)
            {
                tempId.Add(cruises[x].ID);
            }
            MessageBox.Show(string.Join(",",tempId));
        }

        public void executeQuery(string query)
        {
            MySqlDataAdapter mcmd = new MySqlDataAdapter();
            connection = dbc.connect(connection);
            fillCMD(query, connection);

            mcmd.SelectCommand = cmd;

            displayGV(mcmd);
            mcmd.Dispose();
        }

        private void displayGV(MySqlDataAdapter mcmd)
        {
            if (connection != null)
            {
                /* mcmd contains the data
                   mcmd.Fill "transfer" data to DataSet ds */
                DataSet ds = new DataSet();
                mcmd.Fill(ds);
                dGV1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Try to connect");
            }
        }

        public void fillCMD(string s, MySqlConnection c)
        {
            cmd.CommandText = s;
            cmd.Connection = c;
        }

        private void btnDept_Click(object sender, EventArgs e)
        {
            string query = "select distinct Port_Name as 'Departure' from Port p inner join Stops s on p.Port_id=s.Port_id where Stop_SequenceNumber = '1'";
            //clear gridview
            dGV1.DataSource = null;
            executeQuery(query);
        }

        private void btnDest_Click(object sender, EventArgs e)
        {
            string query = "select distinct Port_Name as 'Destination' from Port p inner join (select Route_Number,Port_id,Max(Stop_SequenceNumber) from Stops group by Route_Number) as e on p.Port_id=e.Port_id";
            //clear gridview
            dGV1.DataSource = null;
            executeQuery(query);
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            string query = "select distinct Cruise_Start_Date as 'Start' from Cruises";
            //clear gridview
            dGV1.DataSource = null;
            executeQuery(query);
        }

        private void btnDuration_Click(object sender, EventArgs e)
        {
            string query = "select distinct Route_Duration as 'Duration' from Routes";
            //clear gridview
            dGV1.DataSource = null;
            executeQuery(query); 
            
        }

        private void dGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //set the search criteria
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                int colIndex = dGV1.CurrentCell.ColumnIndex;
                string longfilter = dGV1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                string colName = dGV1.Columns[colIndex].Name;
                string filter = longfilter.Split(' ').First();
                if (colName == "Start")
                {
                    criteria = " where Cruise_Start_Date >= '" + filter + "'";
                }else if(colName == "Duration")
                {
                    criteria = " where Route_Duration = '" + filter + "'";
                }
                else if(colName == "Departure")
                {
                    criteria = " where Port_Name = '" + filter + "'";
                }else if(colName == "Destination")
                {
                    criteria = " where Port_Name = '" + filter + "'";
                }
            }
        }
        //pass a list of cruises
        public void openResult()
        {
            if (cruises.Count() > 0)
            {
                PlanSearchResult psr = new PlanSearchResult(plan, this, cruises);
                plan.Controls.Add(psr);
                this.Visible = false;
            }else
            {
                MessageBox.Show("no cruises that match your selection");
            }
        }

        private void btnOnBoard_Click(object sender, EventArgs e)
        {
            OnBoard onboard = new OnBoard(plan);
            plan.Controls.Add(onboard);
            this.Visible = false;
        }
    }
}
