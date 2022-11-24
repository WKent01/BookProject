using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace BookProject
{
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();
        }

        private void btn_placeOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order has been placed", "Order Status Update");
            this.Close();
        }

        private void Cart_Load(object sender, EventArgs e)
        {

            

            foreach (String[] item in Customer_View.cart)
            {
                String outp = "";

                
                for(int i = 0; i < item.Length; i++)
                {
                    outp = outp + " " + item[i];

                    
                }


                lb_cart.Items.Add(outp);
                

            }
        }

        private void lb_cart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            
        }
    }
}
