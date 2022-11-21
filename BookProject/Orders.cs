using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public Orders()
        {
            InitializeComponent();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
          
            this.Close();
            
        }

        private void btn_viewOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
