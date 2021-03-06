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
    public partial class GiftShop : UserControl
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        private List<Product> clothes;
        private List<Product> cups;
        private List<Product> jewelry;
        private List<Product> books;
        private double totalSum = 0;
        Plan plan;


        public GiftShop(Plan p)
        {
            plan = p;
            InitializeComponent();
            lbWarning.Text = "";
            cmd = new MySqlCommand();
            string connectionString;
            connectionString = "SERVER=ec2-54-226-9-216.compute-1.amazonaws.com;"
                + " DATABASE=f2016_s1_user20; UID=f2016_s1_user20; PASSWORD=f2016_s1_user20;";
            connection = new MySqlConnection(connectionString);
            connection.Open();
            if (connection != null)
            {
                showProduct("Clothes");
                showProduct("Cups");
                showProduct("Jewelry");
                showProduct("Books");
            }
            else { connection.Close(); MessageBox.Show("Try to reconnect database server"); }
            connection.Close();
        }

        private void GVClothes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            gridViewDoubleClick(GVClothes, e, clothes);
        }

        private void GVCups_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            gridViewDoubleClick(GVCups, e, cups);
        }

        private void GVJewelry_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            gridViewDoubleClick(GVJewelry, e, jewelry);
        }

        private void GVBooks_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            gridViewDoubleClick(GVBooks, e, books);
        }


        private void gridViewDoubleClick(DataGridView view, DataGridViewCellMouseEventArgs e, List<Product> list)
        {
            int row = e.RowIndex;
            double singlePrice;
            string name;
            name = view.Rows[row].Cells[0].Value.ToString();
            foreach (Product pd in list)
            {
                if (pd.ProductName == name)
                {                   
                    listViewCheck.Items.Add(pd.ProductName + "      " + pd.ProductPrice);
                    Double.TryParse(pd.ProductPrice.Substring(1), out singlePrice);
                    totalSum += singlePrice;
                    result.Text = "$" + totalSum.ToString();
                }
            }
        }

        private void showProduct(String tabName)
        {  
            Product pr;
            if (tabName == "Clothes")
            {
                clothes = new List<Product>();
                string query = "SELECT Prod_Name,Prod_Price FROM Products WHERE Prod_Type='Clothes' ORDER BY Prod_Price*1 DESC";
                setupSqlCommand(query);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    pr = new Product();
                    pr.ProductName = dataReader["Prod_Name"].ToString();
                    pr.ProductPrice = "$" + dataReader["Prod_Price"].ToString();
                    clothes.Add(pr);
                }
                GVClothes.DataSource = clothes;
                dataReader.Close();
            }
            if (tabName == "Cups")
            {
                cups = new List<Product>();
                string query = "SELECT Prod_Name,Prod_Price FROM Products WHERE Prod_Type='Cups' ORDER BY Prod_Price*1 DESC";
                setupSqlCommand(query);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    pr = new Product();
                    pr.ProductName = dataReader["Prod_Name"].ToString();
                    pr.ProductPrice = "$" + dataReader["Prod_Price"].ToString();
                    cups.Add(pr);
                }
                GVCups.DataSource = cups;
                dataReader.Close();
            }
            if (tabName == "Jewelry")
            {
                jewelry = new List<Product>();
                string query = "SELECT Prod_Name,Prod_Price FROM Products WHERE Prod_Type='Jewelry' ORDER BY Prod_Price*1 DESC";
                setupSqlCommand(query);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    pr = new Product();
                    pr.ProductName = dataReader["Prod_Name"].ToString();
                    pr.ProductPrice = "$" + dataReader["Prod_Price"].ToString();
                    jewelry.Add(pr);
                }
                GVJewelry.DataSource = jewelry;
                dataReader.Close();
            }
            if (tabName == "Books")
            {
                books = new List<Product>();
                string query = "SELECT Prod_Name,Prod_Price FROM Products WHERE Prod_Type='Books' ORDER BY Prod_Price*1 DESC";
                setupSqlCommand(query);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    pr = new Product();
                    pr.ProductName = dataReader["Prod_Name"].ToString();
                    pr.ProductPrice = "$" + dataReader["Prod_Price"].ToString();
                    books.Add(pr);
                }
                GVBooks.DataSource = books;
                dataReader.Close();
            }
        }

        private void setupSqlCommand(String query)
        {
            cmd.Connection = connection;
            cmd.CommandText = query;
        }

        private void btnGSBack_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("You will empty the checkout list \nAre you sure??", "Warning!!!", MessageBoxButtons.YesNo);
            if(dialog == DialogResult.Yes)
            {
                Bartender b = new Bartender(plan);
                plan.Controls.Remove(this);
                plan.Controls.Add(b);
                ((Button)b.Controls["btnOrder"]).Text = "Gift Order";
                ((Label)b.Controls["lbName"]).Text = lbName.Text;
                ((Label)b.Controls["lbTitle"]).Text = "Gift Cashier";
                ((Button)b.Controls["btnS"]).Text = "Gift Cashier Schedule";
                ((Label)b.Controls["lbID"]).Text = lbID.Text;
            }
            else
            {
                return;
            }
           
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            
              for (int i=0; i < listViewCheck.Items.Count; i++)
                {
                    if (listViewCheck.Items[i].Selected)
                    {
                     string txt = listViewCheck.Items[i].Text;
                     listViewCheck.Items[i].Remove();
                     double delPrice = 0;
                     Double.TryParse(txt.Substring(txt.LastIndexOf("$") + 1), out delPrice);
                    if (listViewCheck.Items.Count == 0) {
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

        private void btnGSCheck_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRoom.Text) || cbShip.SelectedItem == null || cbCruise.SelectedItem == null || listViewCheck.Items.Count == 0)
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
                DialogResult dialog = MessageBox.Show("Checkout \nDo you want to continue??", "Message", MessageBoxButtons.YesNo);
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
                        string facility = "1";
                        string purchaseNum = PN.ToString();

                        query = "INSERT INTO `Purchases`(`Room_Num`, `Purchase_Date`, `Purchase_Time`, `Facility_ID`, `Purchase_Number`, `TotalCost`, `Ship_ID`,`Cruise_ID`)"
                                      + " VALUES ('" + roomnum + "','" + DateTime.Now.ToString("yyyy-MM-dd")
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
                        ((Button)b.Controls["btnOrder"]).Text = "Gift Order";
                        ((Label)b.Controls["lbName"]).Text = lbName.Text;
                        ((Label)b.Controls["lbTitle"]).Text = "Giftshop Cashier";
                        ((Button)b.Controls["btnS"]).Text = "Gift Cashier Schedule";
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
