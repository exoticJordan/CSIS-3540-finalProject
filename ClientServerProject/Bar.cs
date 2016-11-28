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

    public partial class Bar : UserControl
    {

        MySqlConnection connection;
        MySqlCommand cmd;
        private List<Product> Wine;
        private List<Product> Beer;
        private List<Product> Cocktails;
        private List<Product> JuicePop;
        private double totalSum = 0;
        Plan plan;
        public Bar(Plan p)
        {
            InitializeComponent();
            lbWarning.Text = "";
            plan = p;            
            string connectionString;
            connectionString = "SERVER=ec2-54-226-9-216.compute-1.amazonaws.com;"
                + " DATABASE=f2016_s1_user20; UID=f2016_s1_user20; PASSWORD=f2016_s1_user20;";
            cmd = new MySqlCommand();
            connection = new MySqlConnection(connectionString);
            connection.Open();
            if (connection != null)
            {
                showProduct("Wine");
                showProduct("Beer");
                showProduct("Cocktails");
                showProduct("JuicePop");
            }
            else { connection.Close(); MessageBox.Show("Try to reconnect database server"); }
            connection.Close();
        }



        private void setupSqlCommand(String query)
        {
            cmd.Connection = connection;
            cmd.CommandText = query;
        }

        private void gridViewCellMouseClick(DataGridView view, DataGridViewCellMouseEventArgs e, List<Product> list)
        {
            int row = e.RowIndex;
            double singlePrice;
            string name;
            name = view.Rows[row].Cells[0].Value.ToString();
            foreach (Product pd in list)
            {
                if (pd.ProductName == name)
                {
                    listView1.Items.Add(pd.ProductName + "      " + pd.ProductPrice);
                    Double.TryParse(pd.ProductPrice.Substring(1), out singlePrice);
                    totalSum += singlePrice;
                    result.Text = "$" + totalSum.ToString();
                }
            }
        }

        private void showProduct(String tabName)
        {
            Product pr;
            if (tabName == "Wine")
            {
                Wine = new List<Product>();
                string query = "SELECT Prod_Name,Prod_Price FROM Products WHERE Prod_Type='Wine' ORDER BY Prod_Price*1 DESC";
                setupSqlCommand(query);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    pr = new Product();
                    pr.ProductName = dataReader["Prod_Name"].ToString();
                    pr.ProductPrice = "$" + dataReader["Prod_Price"].ToString();
                    Wine.Add(pr);
                }
                GVWine.DataSource = Wine;
                dataReader.Close();
            }

            if (tabName == "Beer")
            {
                Beer = new List<Product>();
                string query = "SELECT Prod_Name,Prod_Price FROM Products WHERE Prod_Type='Beer' ORDER BY Prod_Price*1 DESC";
                setupSqlCommand(query);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    pr = new Product();
                    pr.ProductName = dataReader["Prod_Name"].ToString();
                    pr.ProductPrice = "$" + dataReader["Prod_Price"].ToString();
                    Beer.Add(pr);
                }
                GVBeer.DataSource = Beer;
                dataReader.Close();
            }

            if (tabName == "Cocktails")
            {
                Cocktails = new List<Product>();
                string query = "SELECT Prod_Name,Prod_Price FROM Products WHERE Prod_Type='Cocktail' ORDER BY Prod_Price*1 DESC";
                setupSqlCommand(query);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    pr = new Product();
                    pr.ProductName = dataReader["Prod_Name"].ToString();
                    pr.ProductPrice = "$" + dataReader["Prod_Price"].ToString();
                    Cocktails.Add(pr);
                }
                GVCocktail.DataSource = Cocktails;
                dataReader.Close();
            }

            if (tabName == "JuicePop")
            {
                JuicePop = new List<Product>();
                string query = "SELECT Prod_Name,Prod_Price FROM Products WHERE Prod_Type='Pop' ORDER BY Prod_Price*1 DESC";
                setupSqlCommand(query);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    pr = new Product();
                    pr.ProductName = dataReader["Prod_Name"].ToString();
                    pr.ProductPrice = "$" + dataReader["Prod_Price"].ToString();
                    JuicePop.Add(pr);
                }
                GVJuice.DataSource = JuicePop;
                dataReader.Close();
            }
        }

        private void btnBarB_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("You will empty the checkout list \nAre you sure??", "Warning!!!", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Bartender b = new Bartender(plan);
                plan.Controls.Remove(this);
                plan.Controls.Add(b);
                ((Button)b.Controls["btnOrder"]).Text = "Bar Order";
                ((Label)b.Controls["lbName"]).Text = lbName.Text;
                ((Label)b.Controls["lbTitle"]).Text = "Bartender";
                ((Button)b.Controls["btnS"]).Text = "Bartender Schedule";
                ((Label)b.Controls["lbID"]).Text = lbID.Text;
            }
            else
            {
                return;
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Selected)
                {
                    string txt = listView1.Items[i].Text;
                    listView1.Items[i].Remove();
                    double delPrice = 0;
                    Double.TryParse(txt.Substring(txt.LastIndexOf("$") + 1), out delPrice);
                    if (listView1.Items.Count == 0)
                    {
                        totalSum = 0;
                        result.Text = "$" + totalSum.ToString();
                    }
                    else
                    {
                        totalSum = totalSum - delPrice;
                        result.Text = "$" + Math.Round(totalSum, 2).ToString();
                    }
                }
            }
        }





        private void GVWine_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            gridViewCellMouseClick(GVWine, e, Wine);
        }

        private void GVBeer_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            gridViewCellMouseClick(GVBeer, e, Beer);
        }

        private void GVCocktail_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            gridViewCellMouseClick(GVCocktail, e, Cocktails);
        }

        private void GVJuice_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            gridViewCellMouseClick(GVJuice, e, JuicePop);
        }

        private void btnGSCheck_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRoom.Text) || cbShip.SelectedItem == null || cbCruise.SelectedItem == null || listView1.Items.Count == 0)
            {

                if (String.Compare(txtRoom.Text.TrimStart(), "630") > 0 || String.Compare(txtRoom.Text.TrimStart(), "101") < 0)
                {
                    lbWarning.Text = "Please choose a valid room!!";
                }
                else
                lbWarning.Text = "Ship_id, Cuise_id, Room and Order cannot be empty!!";
            }

            else
            {
                lbWarning.Text = "";
                DialogResult dialog = MessageBox.Show("Checkout \nDo you want to continue??", "CheckOut", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    string query = "SELECT max(Purchase_Number) as number FROM Purchases";
                    
                    if (connection != null)
                    {
                        connection.Open();
                        setupSqlCommand(query);
                        MySqlDataReader dataReader = cmd.ExecuteReader();
                        double PN = 0;
                        while (dataReader.Read())
                        {
                            PN = Double.Parse(dataReader["number"].ToString()) + 1;
                        }                    
                        dataReader.Close();
                        string shipid = cbShip.Text;
                        string cruiseid = cbCruise.Text;
                        string roomnum = txtRoom.Text.TrimStart();
                        string facility = "2";
                        string purchaseNum = PN.ToString();

                        query = "INSERT INTO `Purchases`(`Room_Num`, `Purchase_Date`, `Purchase_Time`, `Facility_ID`, `Purchase_Number`, `TotalCost`, `Ship_ID`,`Cruise_ID`)"
                                      +   " VALUES ('"+ roomnum +"','" + DateTime.Now.ToString("yyyy-MM-dd")
                                      + "','" + DateTime.Now.ToString("HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo) + "','"
                                      + facility + "','"
                                      + purchaseNum + "','"
                                      + result.Text.Substring(result.Text.LastIndexOf("$") + 1) + "','"
                                      + shipid + "','"
                                      + cruiseid + "')";
                        int v = 0;
                        setupSqlCommand(query);
                        v = cmd.ExecuteNonQuery();   
                        connection.Close();
                        Bartender b = new Bartender(plan);
                        plan.Controls.Remove(this);
                        plan.Controls.Add(b);
                        ((Button)b.Controls["btnOrder"]).Text = "Bar Order";
                        ((Label)b.Controls["lbName"]).Text = lbName.Text;
                        ((Label)b.Controls["lbTitle"]).Text = "Bartender";
                        ((Button)b.Controls["btnS"]).Text = "Bartender Schedule";
                        ((Label)b.Controls["lbID"]).Text = lbID.Text; 
                    }
                    else { connection.Close(); MessageBox.Show("Try to reconnect database server"); }              
                }
                else
                {
                        return;
                }
           } 
        }
    }
}
