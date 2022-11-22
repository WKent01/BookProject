using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookProject
{
    public partial class Customer_View : Form
    {
        public Customer_View()
        {
            InitializeComponent();
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
    }
}
