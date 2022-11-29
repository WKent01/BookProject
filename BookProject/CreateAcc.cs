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
    public partial class CreateAcc : Form
    {

        Form1 opener;
        public CreateAcc(Form1 opener)
        {
            InitializeComponent();
            this.opener = opener;
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

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_createAcc_Click(object sender, EventArgs e)
        {
            String customer_query = "INSERT INTO Customer (FName, LName, Password) VALUES(\"" + tb_fName.Text.Trim() + "\", \"" + tb_lName.Text.Trim() + "\", \"" + tb_password.Text.Trim() + "\")";
            String contact_id_query = "SELECT CustomerID FROM Customer WHERE Fname = \"" + tb_fName.Text.Trim() + "\" AND Password = \"" + tb_password.Text.Trim() + "\"";
            ExecuteQuery(customer_query);
            DataTable customer = ExecuteQuery(contact_id_query);
            long CID = (long)customer.Rows[0].ItemArray[0];

            String contact_details_query = "INSERT INTO Customer_Contact_Details (ContactID, Address, Email, Phone) VALUES (" + CID + ", \"" + tb_address.Text.Trim() + "\", \"" + tb_email.Text.Trim() + "\", \"" + tb_phone.Text.Trim() + "\")";
            ExecuteQuery(contact_details_query);

            MessageBox.Show("Account created");

            this.Close();
        }

        private void lbl_address_Click(object sender, EventArgs e)
        {

        }

        private void CreateAcc_Load(object sender, EventArgs e)
        {

        }
    }
}
