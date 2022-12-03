using Microsoft.Data.Sqlite;
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
    public partial class AdminView : Form
    {

        public AdminView()
        {
            InitializeComponent();
        }
        public static DataTable ExecuteQuery(string query)
        {
            SQLiteConnection con = new SQLiteConnection(@"data source =  D:\AA School\AAA CURRENT CLASSES\CSCI 4325 Database Management Systems\Database Project\BookProject\BookStore.db");
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);

            DataTable dt = new DataTable();
            try
            {
                adapter.Fill(dt);
            }catch(SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dt;
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            try
            {
                //dg_aTable.DataSource = null;
                dg_aTable.Columns.Clear();
                dg_aTable.DataSource = ExecuteQuery(tb_aQuery.Text);
            }
            catch (SqliteException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cb_tblSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dg_aTable.Columns.Clear();
                dg_aTable.DataSource = ExecuteQuery("SELECT * FROM " + cb_tblSelect.Text);
            }
            catch(SqliteException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AdminView_Load(object sender, EventArgs e)
        {

        }
    }
}
