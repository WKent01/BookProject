using System.Windows.Forms;
using System.Data.SQLite;
using Microsoft.Data.SqlClient;
using System.Data;

namespace BookProject
{
    public partial class Form1 : Form
    {

        //string path = "BookStore.db";
        //string cs = @"URI=file:" + Application.StartupPath + "\\Bookstore.db";
        public static String FName = "";
        public static String Pw = "";

        //SQLiteConnection con;
        // SQLiteCommand cmd;
        //SQLiteDataReader dr;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            AdminView av1 = new AdminView();
            av1.Show();
        }

        private Boolean login()
        {
            SQLiteConnection con = new SQLiteConnection(@"data source =  D:\AA School\AAA CURRENT CLASSES\CSCI 4325 Database Management Systems\Database Project\BookProject\BookStore.db");
            con.Open();

            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Customer WHERE FName = \"" + tb_fName.Text.Trim() + "\" AND Password = \"" + tb_Password.Text.Trim() + "\"", con);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();

            try
            {
                da.Fill(dt);

                return dt.Rows.Count > 0;

            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return false;


        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            if (login())
            {
                Customer_View shop1 = new Customer_View(this);
                FName = tb_fName.Text.Trim();
                Pw = tb_Password.Text.Trim();
                shop1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid login");
            }
        }

        private void btn_createAcc_Click(object sender, EventArgs e)
        {
            CreateAcc create = new CreateAcc(this);
            create.Show();
        }
    }
}