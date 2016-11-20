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
        Plan plan;
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataAdapter mcmd = new MySqlDataAdapter();

        public PlanSearch(Plan p, MySqlConnection c)
        {
            InitializeComponent();
            plan = p;
            connection = c;
        }

        public PlanSearch(Plan p)
        {
            InitializeComponent();
            plan = p;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int col, row;
            col = dGV1.CurrentCell.ColumnIndex;
            row = dGV1.CurrentCell.RowIndex;
            //set the search criteria
            string criteria = dGV1.Rows[row].Cells[col].Value.ToString();
            //set the search order by
            string order;
            if (radioButton1.Checked)
                order = radioButton1.Text;
            else order = radioButton2.Text;
            //executeSearch(criteria,order);
            openResult();
        }

        public void openResult()
        {
            PlanSearchResult psr = new PlanSearchResult(plan,this);
            plan.Controls.Add(psr);
            this.Visible = false;
        }

        private void btnOnBoard_Click(object sender, EventArgs e)
        {
            OnBoard onboard = new OnBoard(plan);
            plan.Controls.Add(onboard);
            plan.Controls.Remove(this);
        }

        private void btnDept_Click(object sender, EventArgs e)
        {
            /*string query = "select * from Routes";
            //executeQuery method should return a list of results
            var result = executeQuery(query);

            //clear gridview
            DGv1.DataSource = null;
            
            //place results inside gridview
            DGv1.DataSource = result.ToList();
            */
        }

        private void PlanSearch_Load(object sender, EventArgs e)
        {
            cmd = new MySqlCommand();
        }

        private void btnDest_Click(object sender, EventArgs e)
        {
            /*string query = "select * from Routes";
            //executeQuery method should return a list of results
            var result = executeQuery(query);

            //clear gridview
            DGv1.DataSource = null;
            
            //place results inside gridview
            DGv1.DataSource = result.ToList();
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
            //executeQuery method should return a list of results
            var result = executeQuery(query);

            //clear gridview
            DGv1.DataSource = null;
            
            //place results inside gridview
            DGv1.DataSource = result.ToList();
            */
        }

        public void executeQuery(string s)
        {
            cmd.CommandText = s;
            cmd.Connection = connection;

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
    }
}
