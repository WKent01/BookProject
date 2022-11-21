namespace BookProject
{
    partial class Cart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_placeOrder = new System.Windows.Forms.Button();
            this.lbl_totalPrice = new System.Windows.Forms.Label();
            this.lbl_underscore = new System.Windows.Forms.Label();
            this.tb_totalPriceValue = new System.Windows.Forms.Label();
            this.lb_cart = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(29, 374);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(266, 42);
            this.btn_remove.TabIndex = 0;
            this.btn_remove.Text = "Remove Item";
            this.btn_remove.UseVisualStyleBackColor = true;
            // 
            // btn_placeOrder
            // 
            this.btn_placeOrder.Location = new System.Drawing.Point(354, 374);
            this.btn_placeOrder.Name = "btn_placeOrder";
            this.btn_placeOrder.Size = new System.Drawing.Size(266, 42);
            this.btn_placeOrder.TabIndex = 1;
            this.btn_placeOrder.Text = "Place Order";
            this.btn_placeOrder.UseVisualStyleBackColor = true;
            this.btn_placeOrder.Click += new System.EventHandler(this.btn_placeOrder_Click);
            // 
            // lbl_totalPrice
            // 
            this.lbl_totalPrice.AutoSize = true;
            this.lbl_totalPrice.Location = new System.Drawing.Point(451, 331);
            this.lbl_totalPrice.Name = "lbl_totalPrice";
            this.lbl_totalPrice.Size = new System.Drawing.Size(71, 15);
            this.lbl_totalPrice.TabIndex = 2;
            this.lbl_totalPrice.Text = "Total:          $";
            // 
            // lbl_underscore
            // 
            this.lbl_underscore.AutoSize = true;
            this.lbl_underscore.Location = new System.Drawing.Point(428, 310);
            this.lbl_underscore.Name = "lbl_underscore";
            this.lbl_underscore.Size = new System.Drawing.Size(192, 15);
            this.lbl_underscore.TabIndex = 4;
            this.lbl_underscore.Text = "_____________________________________";
            // 
            // tb_totalPriceValue
            // 
            this.tb_totalPriceValue.AutoSize = true;
            this.tb_totalPriceValue.Location = new System.Drawing.Point(592, 331);
            this.tb_totalPriceValue.Name = "tb_totalPriceValue";
            this.tb_totalPriceValue.Size = new System.Drawing.Size(28, 15);
            this.tb_totalPriceValue.TabIndex = 5;
            this.tb_totalPriceValue.Text = "0.00";
            this.tb_totalPriceValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lb_cart
            // 
            this.lb_cart.FormattingEnabled = true;
            this.lb_cart.ItemHeight = 15;
            this.lb_cart.Location = new System.Drawing.Point(29, 63);
            this.lb_cart.Name = "lb_cart";
            this.lb_cart.Size = new System.Drawing.Size(591, 244);
            this.lb_cart.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "My Cart:";
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(446, 22);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(174, 23);
            this.btn_return.TabIndex = 8;
            this.btn_return.Text = "Return to Store";
            this.btn_return.UseVisualStyleBackColor = true;
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_return;
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_cart);
            this.Controls.Add(this.tb_totalPriceValue);
            this.Controls.Add(this.lbl_underscore);
            this.Controls.Add(this.lbl_totalPrice);
            this.Controls.Add(this.btn_placeOrder);
            this.Controls.Add(this.btn_remove);
            this.Name = "Cart";
            this.Text = "Cart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_remove;
        private Button btn_placeOrder;
        private Label lbl_totalPrice;
        private Label lbl_underscore;
        private Label tb_totalPriceValue;
        private ListBox lb_cart;
        private Label label1;
        private Button btn_return;
    }
}