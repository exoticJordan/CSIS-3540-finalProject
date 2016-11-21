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
        const string Title = "Reservation";
        // variables
        MySqlConnection connection = null;
        DBConnect db;
        MySqlCommand cmd;

        public Plan()
        {
            InitializeComponent();
        }
        private void Plan_Load(object sender, EventArgs e)
        {
            db = new DBConnect();
            cmd = new MySqlCommand();
            connect();
        }
        private void connect()
        {
            connection = new MySqlConnection(db.ToString());
            connection.Open();
            if (connection != null)
            {
                Text = Title + " [Connected]";
                openSearch();
            }
            else
                MessageBox.Show("Problem");
        }
        //pass this page and the established connection to the usercontrol
        public void openSearch()
        {
            PlanSearch ps = new PlanSearch(this, connection);
            this.Controls.Add(ps);
        }
    }
}
