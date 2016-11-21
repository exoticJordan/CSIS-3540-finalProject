﻿using System;
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
        Plan plan;
        MySqlConnection connection;
        MySqlCommand cmd;
        string criteria, order;
        List<Cruise> cruises;

        public PlanSearch(Plan p, MySqlConnection c)
        {
            InitializeComponent();
            plan = p;
            connection = c;
        }

        private void PlanSearch_Load(object sender, EventArgs e)
        {
            cmd = new MySqlCommand();
        }

        //the constructor below prevents error when running the program
        //will be deleted later
        public PlanSearch(Plan p)
        {
            InitializeComponent();
            plan = p;
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
            string query = "select Cruise_id as 'ID',";
            query += "Cruise_Name as 'Name',";
            query += "Ship_Name as 'Ship',";
            query += "Cruise_Price as 'Price'";
            query += " from Cruises c inner join Ships s on c.Ship_id=s.Ship_id";
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
                        Price = Double.Parse(reader.GetString(3))
                    }
                );
            }
            reader.Close();
        }

        public void executeQuery(string query)
        {
            MySqlDataAdapter mcmd = new MySqlDataAdapter();
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
            /*string query = "select * from Routes";
            //clear gridview
            dGV1.DataSource = null;
            executeQuery(query); 
            */
        }

        private void btnDest_Click(object sender, EventArgs e)
        {
            /*string query = "select * from Routes";
            //clear gridview
            dGV1.DataSource = null;
            executeQuery(query); 
            */
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            string query = "select Cruise_Start_Date from Cruises";
            //clear gridview
            dGV1.DataSource = null;
            executeQuery(query);
        }

        private void btnDuration_Click(object sender, EventArgs e)
        {
            /*string query = "select duration from Routes";
            //clear gridview
            dGV1.DataSource = null;
            executeQuery(query); 
            */
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
                if (colName == "Cruise_Start_Date")
                {
                    criteria = " where " + colName + " >= '" + filter + "'";
                }
                else criteria = " where " + colName + " = '" + filter + "'";
            }
        }
        //pass a list of cruises
        public void openResult()
        {
            PlanSearchResult psr = new PlanSearchResult(plan, this, cruises, connection);
            plan.Controls.Add(psr);
            this.Visible = false;
        }

        private void btnOnBoard_Click(object sender, EventArgs e)
        {
            OnBoard onboard = new OnBoard(plan);
            plan.Controls.Add(onboard);
            this.Visible = false;
        }
    }
}
