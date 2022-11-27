using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Net.Mime.MediaTypeNames;

namespace BookProject
{
    public partial class Cart : Form

    {

        float price = 0;

        public Cart()
        {
            InitializeComponent();
        }

        public DataTable ExecuteQuery(string query)
        {
            SQLiteConnection con = new SQLiteConnection(@"data source =  C:\Users\kentw\source\repos\BookProject\BookProject\BookStore.db");
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);

            DataTable dt = new DataTable();
            try
            {
                adapter.Fill(dt);
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dt;
        }

        private void btn_placeOrder_Click(object sender, EventArgs e)
        {

            DateTime date = DateTime.Now;
            long CID = getCustomerID();

            String order_query = "INSERT INTO Orders (Order_Date, Order_Value, CustomerID) VALUES (\"" + date.ToString("yyyMMdd") + "\", " + price + ", " + CID + ")";
            ExecuteQuery(order_query);

            DataTable OrderID = ExecuteQuery("SELECT OrderID From Orders WHERE Orders.CustomerID = " + CID);  
            long OID = (long)OrderID.Rows[OrderID.Rows.Count - 1].ItemArray[0];

            foreach (String[] item in Customer_View.cart){
                String item_query = "INSERT INTO Order_Items (Item_Price, OrderID, CustomerID, Book) VALUES (" + item[5] + ", " + OID + ", " + CID + ", " + item[0] + ")";
                ExecuteQuery(item_query);
            }

            //MessageBox.Show("Order has been placed", "Order Status Update");
            this.Close();
        }

        private long getCustomerID()
        {
            String query = "SELECT CustomerID FROM Customer WHERE FName = \"" + Form1.FName + "\" AND Password = \"" + Form1.Pw + "\"";
            DataTable CustomerID = ExecuteQuery(query);


            return (long)CustomerID.Rows[0].ItemArray[0];
        }

        private void Cart_Load(object sender, EventArgs e)
        {

            

            foreach (String[] item in Customer_View.cart)
            {

                price += float.Parse(item[5]);

                String outp = item[0] + " " + item[1] + " " + item[2] + " " + item[3] + " " + item[4] + " " + item[5];

                lb_cart.Items.Add(outp);
                lbl_totalPrice.Text = price.ToString();
                

            }
        }

        private void lb_cart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_remove_Click(object sender, EventArgs e)
        {

            int spot = 0;

            try
            {
                foreach (String[] item in Customer_View.cart)
                {
                    if (item[0].Equals(lb_cart.Text.Substring(0, 4).Trim()))
                    {
                        //Customer_View.cart.Remove(item);
                        spot = Customer_View.cart.IndexOf(item);
                        price -= float.Parse(item[5]);
                    }
                }
            }catch(Exception ex) {
                //MessageBox.Show(ex.Message);
            }

            Customer_View.cart.RemoveAt(spot);
            lbl_totalPrice.Text = price.ToString();

            lb_cart.Items.Remove(lb_cart.Text);
            
            //MessageBox.Show(Customer_View.cart.Count.ToString());
        }
    }
}
