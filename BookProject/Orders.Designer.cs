namespace BookProject
{
    partial class Orders
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
            this.lv_orderHist = new System.Windows.Forms.ListView();
            this.btn_viewOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_orderHist
            // 
            this.lv_orderHist.Location = new System.Drawing.Point(12, 12);
            this.lv_orderHist.Name = "lv_orderHist";
            this.lv_orderHist.Size = new System.Drawing.Size(432, 389);
            this.lv_orderHist.TabIndex = 2;
            this.lv_orderHist.UseCompatibleStateImageBehavior = false;
            // 
            // btn_viewOrder
            // 
            this.btn_viewOrder.Location = new System.Drawing.Point(12, 417);
            this.btn_viewOrder.Name = "btn_viewOrder";
            this.btn_viewOrder.Size = new System.Drawing.Size(432, 23);
            this.btn_viewOrder.TabIndex = 3;
            this.btn_viewOrder.Text = "View Order";
            this.btn_viewOrder.UseVisualStyleBackColor = true;
            this.btn_viewOrder.Click += new System.EventHandler(this.btn_viewOrder_Click);
            // 
            // Orders
            // 
            this.AcceptButton = this.btn_viewOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 450);
            this.Controls.Add(this.btn_viewOrder);
            this.Controls.Add(this.lv_orderHist);
            this.Name = "Orders";
            this.Text = "Orders";
            this.ResumeLayout(false);

        }

        #endregion
        private ListView lv_orderHist;
        private Button btn_viewOrder;
    }
}