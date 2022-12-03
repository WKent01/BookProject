using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookProject
{
    public partial class OrderItems : Form
    {

        long orderID;
        public OrderItems(long orderID)
        {
            InitializeComponent();
            this.orderID = orderID;
        }

        public DataTable ExecuteQuery(string query)
        {
            SQLiteConnection con = new SQLiteConnection(@"data source =  D:\AA School\AAA CURRENT CLASSES\CSCI 4325 Database Management Systems\Database Project\BookProject\BookStore.db");
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

        private void OrderItems_Load(object sender, EventArgs e)
        {
            String query = "SELECT Item_Price, Title OrderID From Order_Items INNER JOIN Books ON Books.ISBN = Order_Items.Book WHERE Order_Items.OrderID = " + orderID;
            DataTable items = ExecuteQuery(query);
            dg_OrderItems.DataSource = items;
        }

        private void dg_OrderItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
