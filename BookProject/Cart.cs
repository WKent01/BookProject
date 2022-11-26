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
using System.Windows.Forms.VisualStyles;
using static System.Net.Mime.MediaTypeNames;

namespace BookProject
{
    public partial class Cart : Form

    {

        double price = 0;

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

                price += Double.Parse(item[5]);

                String outp = item[0] + " " + item[1] + " " + item[2] + item[3] + " " + item[4] + " " + item[5];

                lb_cart.Items.Add(outp);
                lbl_totalPrice.Text = price.ToString();
                

            }
        }

        private void lb_cart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (String[] item in Customer_View.cart)
                {
                    if (item[0].Equals(lb_cart.Text.Substring(0, 4).Trim()))
                    {
                        Customer_View.cart.Remove(item);
                        price -= Double.Parse(item[5]);
                        lbl_totalPrice.Text = price.ToString();
                    }
                }
            }catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }

            lb_cart.Items.Remove(lb_cart.Text);
            
            //MessageBox.Show(Customer_View.cart.Count.ToString());
        }
    }
}
