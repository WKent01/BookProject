using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookProject
{
    public partial class Orders : Form
    {

        long OID = 0;
        public Orders()
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


        private void btn_return_Click(object sender, EventArgs e)
        {
          
            this.Close();
            
        }

        private void btn_viewOrder_Click(object sender, EventArgs e)
        {
   
            OrderItems item_list = new OrderItems(OID);
            item_list.Show();
        }



        private long getCustomerID()
        {
            String query = "SELECT CustomerID FROM Customer WHERE FName = \"" + Form1.FName + "\" AND Password = \"" + Form1.Pw + "\"";
            DataTable CustomerID = ExecuteQuery(query);


            return (long)CustomerID.Rows[0].ItemArray[0];
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            long CID = getCustomerID();

            String query = "Select OrderID, Order_Date, Order_Value FROM Orders WHERE CustomerID = " + CID;

            try
            {
                dg_OrderView.Columns.Clear();
                dg_OrderView.DataSource = ExecuteQuery(query);

            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dg_OrderView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OID = (long)dg_OrderView.Rows[e.RowIndex].Cells[0].Value;
            //MessageBox.Show(OID.ToString());
        }
    }
}
