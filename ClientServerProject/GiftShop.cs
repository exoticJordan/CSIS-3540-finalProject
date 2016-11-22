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
    public partial class GiftShop : UserControl
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        private List<Product> clothes;
        private List<Product> cups;
        private List<Product> jewelry;
        private List<Product> books;
        Plan plan;
        public GiftShop(Plan p)
        {
            plan = p;
            InitializeComponent();
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




            /*  string query = "SELECT Prod_Name,Prod_Price FROM Products WHERE Prod_Type='Clothes'";
              if (products == null)
                  products = new List<Product>();
              else
                  products.Clear();

              if (connection != null)
              {
                  Product pr;
                  GVClothes.Rows.Clear();
                  connection.Open();
                  setupSqlCommand(query);
                  MySqlDataReader dataReader = cmd.ExecuteReader();

                  while (dataReader.Read())
                  {
                      pr = new Product();
                      pr.ProductName = dataReader["Prod_Name"].ToString();
                      pr.ProductPrice = dataReader["Prod_Price"].ToString();
                      products.Add(pr);                        
                  }
                  GVClothes.DataSource = products;
                  dataReader.Close();
              }
              else{connection.Close();MessageBox.Show("Try to reconnect database server");}   */


        }

        private void GVClothes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            int row = e.RowIndex;
            string name;
            name = GVClothes.Rows[row].Cells[0].Value.ToString();

            foreach (Product pd in clothes)
            {
                if(pd.ProductName == name)
                {
                    listViewCheck.Items.Add(pd.ProductPrice);
                }
            }  
        }

        private void showProduct(String tabName)
        {
            /*  if (products == null)
                  products = new List<Product>();
              else
                  products.Clear();  */
            Product pr;
            //  GVClothes.Rows.Clear();
            // string query = "SELECT Prod_Name,Prod_Price FROM Products WHERE Prod_Type='" + tabName + "'";
            /*   setupSqlCommand(query);
               MySqlDataReader dataReader = cmd.ExecuteReader();            
               while (dataReader.Read())
               {
                   pr = new Product();
                   pr.ProductName = dataReader["Prod_Name"].ToString();
                   pr.ProductPrice = dataReader["Prod_Price"].ToString();
                   products.Add(pr);
               } */
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
            Bartender b = new Bartender(plan);
            plan.Controls.Remove(this);
            plan.Controls.Add(b);
            ((Button)b.Controls["btnOrder"]).Text = "Gift Order";
            ((Label)b.Controls["lbName"]).Text = lbName.Text;
            ((Label)b.Controls["lbTitle"]).Text = "Gift Cashier";
            ((Button)b.Controls["btnS"]).Text = "Gift Cashier Schedule";
        }


    }
}
