using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ClientServerProject
{

    public partial class Bar : UserControl
    {
	    private MySqlConnection _connection;
        private MySqlCommand _cmd;
        private List<Product> _wine;
        private List<Product> _beer;
        private List<Product> _cocktails;
        private List<Product> _juicePop;
        private double _totalSum;
	    private Plan _plan;
        public Bar(Plan p)
        {
            InitializeComponent();
            lbWarning.Text = "";
            _plan = p;
	        const string connectionString = "SERVER=ec2-54-226-9-216.compute-1.amazonaws.com;"
	                                        + " DATABASE=f2016_s1_user20; UID=f2016_s1_user20; PASSWORD=f2016_s1_user20;";
            _cmd = new MySqlCommand();
            _connection = new MySqlConnection(connectionString);
            _connection.Open();
            if (_connection != null)
            {
                ShowProduct("Wine");
                ShowProduct("Beer");
                ShowProduct("Cocktails");
                ShowProduct("JuicePop");
            }
            else { _connection.Close(); MessageBox.Show(@"Try to reconnect database server"); }
            _connection.Close();
        }



        private void SetupSqlCommand(string query)
        {
            _cmd.Connection = _connection;
            _cmd.CommandText = query;
        }

        private void GridViewCellMouseClick(DataGridView view, DataGridViewCellMouseEventArgs e, List<Product> list)
        {
            var row = e.RowIndex;
	        var name = view.Rows[row].Cells[0].Value.ToString();
            foreach (var pd in list)
            {
                if (pd.ProductName == name)
                {
                    listView1.Items.Add(pd.ProductName + "      " + pd.ProductPrice);
	                double singlePrice;
	                double.TryParse(pd.ProductPrice.Substring(1), out singlePrice);
                    _totalSum += singlePrice;
                    result.Text = @"$" + _totalSum;
                }
            }
        }

        private void ShowProduct(string tabName)
        {
            Product pr;
            if (tabName == "Wine")
            {
                _wine = new List<Product>();
                const string query = "SELECT Prod_Name,Prod_Price FROM Products WHERE Prod_Type='Wine' ORDER BY Prod_Price*1 DESC";
                SetupSqlCommand(query);
                var dataReader = _cmd.ExecuteReader();
                while (dataReader.Read())
                {
	                pr = new Product
	                {
		                ProductName = dataReader["Prod_Name"].ToString(),
		                ProductPrice = "$" + dataReader["Prod_Price"]
	                };
	                _wine.Add(pr);
                }
                GVWine.DataSource = _wine;
                dataReader.Close();
            }

            if (tabName == "Beer")
            {
                _beer = new List<Product>();
                const string query = "SELECT Prod_Name,Prod_Price FROM Products WHERE Prod_Type='Beer' ORDER BY Prod_Price*1 DESC";
                SetupSqlCommand(query);
                var dataReader = _cmd.ExecuteReader();
                while (dataReader.Read())
                {
	                pr = new Product
	                {
		                ProductName = dataReader["Prod_Name"].ToString(),
		                ProductPrice = "$" + dataReader["Prod_Price"]
	                };
	                _beer.Add(pr);
                }
                GVBeer.DataSource = _beer;
                dataReader.Close();
            }

            if (tabName == "Cocktails")
            {
                _cocktails = new List<Product>();
                const string query = "SELECT Prod_Name,Prod_Price FROM Products WHERE Prod_Type='Cocktail' ORDER BY Prod_Price*1 DESC";
                SetupSqlCommand(query);
                var dataReader = _cmd.ExecuteReader();
                while (dataReader.Read())
                {
	                pr = new Product
	                {
		                ProductName = dataReader["Prod_Name"].ToString(),
		                ProductPrice = "$" + dataReader["Prod_Price"]
	                };
	                _cocktails.Add(pr);
                }
                GVCocktail.DataSource = _cocktails;
                dataReader.Close();
            }

            if (tabName == "JuicePop")
            {
                _juicePop = new List<Product>();
                const string query = "SELECT Prod_Name,Prod_Price FROM Products WHERE Prod_Type='Pop' ORDER BY Prod_Price*1 DESC";
                SetupSqlCommand(query);
                var dataReader = _cmd.ExecuteReader();
                while (dataReader.Read())
                {
	                pr = new Product
	                {
		                ProductName = dataReader["Prod_Name"].ToString(),
		                ProductPrice = "$" + dataReader["Prod_Price"]
	                };
	                _juicePop.Add(pr);
                }
                GVJuice.DataSource = _juicePop;
                dataReader.Close();
            }
        }

        private void btnBarB_Click(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show(@"You will empty the checkout list \nAre you sure??", @"Warning!!!", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                var b = new Bartender(_plan);
                _plan.Controls.Remove(this);
                _plan.Controls.Add(b);
                ((Button)b.Controls["btnOrder"]).Text = @"Bar Order";
                ((Label)b.Controls["lbName"]).Text = lbName.Text;
                ((Label)b.Controls["lbTitle"]).Text = @"Bartender";
                ((Button)b.Controls["btnS"]).Text = @"Bartender Schedule";
                ((Label)b.Controls["lbID"]).Text = lbID.Text;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Selected)
                {
                    var txt = listView1.Items[i].Text;
                    listView1.Items[i].Remove();
                    double delPrice;
                    double.TryParse(txt.Substring(txt.LastIndexOf("$", StringComparison.Ordinal) + 1), out delPrice);
                    if (listView1.Items.Count == 0)
                    {
                        _totalSum = 0;
                        result.Text = @"$" + _totalSum;
                    }
                    else
                    {
                        _totalSum = _totalSum - delPrice;
                        result.Text = @"$" + Math.Round(_totalSum, 2);
                    }
                }
            }
        }





        private void GVWine_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            GridViewCellMouseClick(GVWine, e, _wine);
        }

        private void GVBeer_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            GridViewCellMouseClick(GVBeer, e, _beer);
        }

        private void GVCocktail_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            GridViewCellMouseClick(GVCocktail, e, _cocktails);
        }

        private void GVJuice_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            GridViewCellMouseClick(GVJuice, e, _juicePop);
        }

        private void btnGSCheck_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRoom.Text) || cbShip.SelectedItem == null || cbCruise.SelectedItem == null || listView1.Items.Count == 0)
            {

                if (string.CompareOrdinal(txtRoom.Text.TrimStart(), "630") > 0 || string.CompareOrdinal(txtRoom.Text.TrimStart(), "101") < 0)
                {
                    lbWarning.Text = @"Please choose a valid room!!";
                }
                else
                lbWarning.Text = @"Ship_id, Cuise_id, Room and Order cannot be empty!!";
            }

            else
            {
                lbWarning.Text = "";
                var dialog = MessageBox.Show(@"Checkout" + Environment.NewLine+@"Do you want to continue??", @"CheckOut", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    var query = "SELECT max(Purchase_Number) as number FROM Purchases";
                    
                    if (_connection != null)
                    {
                        _connection.Open();
                        SetupSqlCommand(query);
                        var dataReader = _cmd.ExecuteReader();
                        double pn = 0;
                        while (dataReader.Read())
                        {
                            pn = double.Parse(dataReader["number"].ToString()) + 1;
                        }                    
                        dataReader.Close();
                        var shipid = cbShip.Text;
                        var cruiseid = cbCruise.Text;
                        var roomnum = txtRoom.Text.TrimStart();
                        const string facility = "2";
                        var purchaseNum = pn.ToString(CultureInfo.CurrentCulture);

                        query = "INSERT INTO `Purchases`(`Room_Num`, `Purchase_Date`, `Purchase_Time`, `Facility_ID`, `Purchase_Number`, `TotalCost`, `Ship_ID`,`Cruise_ID`)"
                                      +   " VALUES ('"+ roomnum +"','" + DateTime.Now.ToString("yyyy-MM-dd")
                                      + "','" + DateTime.Now.ToString("HH:mm:ss", DateTimeFormatInfo.InvariantInfo) + "','"
                                      + facility + "','"
                                      + purchaseNum + "','"
                                      + result.Text.Substring(result.Text.LastIndexOf("$", StringComparison.Ordinal) + 1) + "','"
                                      + shipid + "','"
                                      + cruiseid + "')";
	                    SetupSqlCommand(query);
                        _cmd.ExecuteNonQuery();   
                        _connection.Close();
                        var b = new Bartender(_plan);
                        _plan.Controls.Remove(this);
                        _plan.Controls.Add(b);
                        ((Button)b.Controls["btnOrder"]).Text = @"Bar Order";
                        ((Label)b.Controls["lbName"]).Text = lbName.Text;
                        ((Label)b.Controls["lbTitle"]).Text = @"Bartender";
                        ((Button)b.Controls["btnS"]).Text = @"Bartender Schedule";
                        ((Label)b.Controls["lbID"]).Text = lbID.Text; 
                    }
                    else
                    {
	                    _connection?.Close();
	                    MessageBox.Show(@"Try to reconnect database server");
                    }              
                }
            } 
        }
    }
}
