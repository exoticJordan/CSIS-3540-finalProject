using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientServerProject
{
    public partial class Plan : Form
    {
        // variables
        MySqlConnection connection = null;
        DBConnect dbInfo;
        const string Title = "Create, Upate, Delete, Insert, Select";
        MySqlCommand cmd;

        public Plan()
        {
            InitializeComponent();
            openSearch();
        }

        public void openSearch()
        {
            PlanSearch ps = new PlanSearch(this);
            this.Controls.Add(ps);
        }

        private void Plan_Load(object sender, EventArgs e)
        {
            dbInfo = new DBConnect();
            cmd = new MySqlCommand();
            connect();
        }

        private void connect()
        {
            connection = new MySqlConnection(dbInfo.ToString());
            connection.Open();
            if (connection != null)
                Text = Title + " [Connected]";
            else
                MessageBox.Show("Problem");
        }
    }
}
