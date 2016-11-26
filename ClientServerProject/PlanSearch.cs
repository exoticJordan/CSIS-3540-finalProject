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
        string criteria;
        List<Cruise> cruises;

        public PlanSearch(Plan p)
        {
            InitializeComponent();
            plan = p;
        }

        private void PlanSearch_Load(object sender, EventArgs e)
        {
            cmd = new MySqlCommand();
            cmd.Parameters.Add("@start", MySqlDbType.Date);
            cmd.Parameters.Add("@duration", MySqlDbType.Int32);
            cmd.Parameters.Add("@departure", MySqlDbType.String);
            cmd.Parameters.Add("@destination", MySqlDbType.String);
            cmd.Parameters.Add("@p", MySqlDbType.Int32);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cruises = new List<Cruise>();
            //if no criteria
            if (criteria == null)
                criteria = "select Cruise_id from Cruises";
            storeID(criteria);
            storeNamePrice();
            storeShip();
            storeDuration();
            storeItinary();
            openResult();
        }

        public void storeItinary()
        {
            string query = "select Port_Name from Port p join (select * from Stops s join Cruises c on s.Route_Number=c.Route_id where c.Cruise_id=@p order by Stop_SequenceNumber) as e on p.Port_id=e.Port_id";
            connection = dbc.connect(connection);
            fillCMD(query, connection);
            for (int x = 0; x < cruises.Count(); x++)
            {
                cmd.Parameters["@p"].Value = cruises[x].ID;
                MySqlDataReader reader = cmd.ExecuteReader();
                cruises[x].Itinary = new List<string>();
                while (reader.Read())
                {
                    cruises[x].Itinary.Add(reader.GetString(0));
                }
                reader.Close();
            }
            connection.Close();
        }

        public void storeDuration()
        {
            string query = "select Route_Duration from Routes r join Cruises c on r.Route_Number=c.Route_id where Cruise_id=@p";
            connection = dbc.connect(connection);
            fillCMD(query, connection);
            for (int x = 0; x < cruises.Count(); x++)
            {
                cmd.Parameters["@p"].Value = cruises[x].ID;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cruises[x].Duration = int.Parse(reader.GetString(0));
                }
                reader.Close();
            }
            connection.Close();
        }

        public void storeShip()
        {
            string query = "select Ship_Name from Ships s join Cruises c on s.Ship_id=c.Ship_id where c.Cruise_id=@p";
            connection = dbc.connect(connection);
            fillCMD(query, connection);
            for (int x = 0; x < cruises.Count(); x++)
            {
                cmd.Parameters["@p"].Value = cruises[x].ID;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cruises[x].Ship = reader.GetString(0);
                }
                reader.Close();
            }
            connection.Close();
        }

        public void storeNamePrice()
        {
            //MessageBox.Show("In storeNamePrice");
            string query = "select Cruise_Name,Cruise_Price from Cruises where Cruise_id=@p";
            connection = dbc.connect(connection);
            fillCMD(query, connection);
            for (int x = 0; x < cruises.Count(); x++)
            {
                cmd.Parameters["@p"].Value = cruises[x].ID;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cruises[x].Name = reader.GetString(0);
                    cruises[x].Price = double.Parse(reader.GetString(1));
                }
                reader.Close();
            }
            /*foreach (var c in cruises)
            {
                MessageBox.Show("ID:"+c.ID.ToString()+"Name"+c.Name+"Price"+c.Price.ToString());
            }*/
            connection.Close();
        }

        public void storeID(string query)
        {
            connection = dbc.connect(connection);
            fillCMD(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cruises.Add(
                    new Cruise
                    {
                        ID = int.Parse(reader.GetString(0))
                    }
                );
            }
            reader.Close();
            connection.Close();
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
            string query = "select Port_Name as 'Departure' from Port p join Stops s on p.Port_id=s.Port_id where Stop_SequenceNumber = '1'";
            //clear gridview
            dGV1.DataSource = null;
            executeQuery(query);
        }

        private void btnDest_Click(object sender, EventArgs e)
        {
            string query = "select Port_Name from Port p join (select * from Stops s join (select Route_Number as rn,Max(Stop_SequenceNumber) as ss from Stops group by rn) as eo where s.Route_Number=eo.rn and s.Stop_SequenceNumber=eo.ss) as et on p.Port_id=et.Port_id";
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
                string longfilter = dGV1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Trim();
                string colName = dGV1.Columns[colIndex].Name;
                string filter = longfilter.Split(' ').First().Trim();
                if (colName == "Start")
                {
                    criteria = "select Cruise_id from Cruises where Cruise_Start_Date>=@start";
                    cmd.Parameters["@start"].Value=filter;
                }else if(colName == "Duration")
                {
                    criteria = "select Cruise_id from Cruises c join Routes r on c.Route_id=r.Route_Number where r.Route_Duration=@duration";
                    cmd.Parameters["@duration"].Value = longfilter;
                }
                else if(colName == "Departure")
                {
                    criteria = "select Cruise_id from Cruises c join Stops s on c.Route_id=s.Route_number where s.Port_id=(select Port_id from Port where Port_Name=@departure) and s.Stop_SequenceNumber='1'";
                    cmd.Parameters["@departure"].Value = longfilter;
                } else if(colName == "Destination")
                {
                    criteria = "select Cruise_id from Cruises c join (select * from Stops s join (select Route_Number as rn,Max(Stop_SequenceNumber) as ss from Stops group by rn) as eo where s.Route_Number=eo.rn and s.Stop_SequenceNumber=eo.ss) as et where c.Route_id=et.rn and et.Port_id=(select Port_id from Port where Port_Name=@destination)";
                    cmd.Parameters["@destination"].Value = longfilter;
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
