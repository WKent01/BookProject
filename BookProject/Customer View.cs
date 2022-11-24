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
    public partial class Customer_View : Form
    {

        private string query = "";

        public Customer_View()
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


        private void btn_viewCart_Click(object sender, EventArgs e)
        {
            Cart c1 = new Cart();
            c1.Show();
            
        }

        private void Customer_View_Load(object sender, EventArgs e)
        {
            lbl_userName.Text = Form1.FName;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            query = "SELECT ISBN, Title, FName, LName, Publication_Date, Price FROM Books\nINNER JOIN Author ON Books.AuthorID = Author.AuthorID ";

            if(cb_sortBy.SelectedIndex > 1) {
                query += "WHERE " + cb_sortBy.Text + " LIKE \"%" + tb_keyWord.Text.Trim() + "%\"";
            }


            try
            {
                dg_shopView.Columns.Clear();
                dg_shopView.DataSource = ExecuteQuery(query);

            }catch(SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
