using System.Windows.Forms;
using System.Data.SQLite;


namespace BookProject
{
    public partial class Form1 : Form
    {

        string path = "BookStore.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\Bookstore.db";

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
            this.Hide();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Customer_View shop1 = new Customer_View();
            shop1.Show();
            this.Hide();
        }
    }
}