using System.Windows.Forms;
using System.Data.SQLite;


namespace BookProject
{
    public partial class Form1 : Form
    {

        string path = "BookStore.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\Bookstore.db";

        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);

            try
            {
                con.Open();
                MessageBox.Show("Connected");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}