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
            this.btn_viewOrder = new System.Windows.Forms.Button();
            this.dg_OrderView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_OrderView)).BeginInit();
            this.SuspendLayout();
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
            // dg_OrderView
            // 
            this.dg_OrderView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_OrderView.Location = new System.Drawing.Point(12, 12);
            this.dg_OrderView.Name = "dg_OrderView";
            this.dg_OrderView.ReadOnly = true;
            this.dg_OrderView.RowTemplate.Height = 25;
            this.dg_OrderView.Size = new System.Drawing.Size(432, 399);
            this.dg_OrderView.TabIndex = 4;
            this.dg_OrderView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_OrderView_CellContentClick);
            // 
            // Orders
            // 
            this.AcceptButton = this.btn_viewOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 450);
            this.Controls.Add(this.dg_OrderView);
            this.Controls.Add(this.btn_viewOrder);
            this.Name = "Orders";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_OrderView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btn_viewOrder;
        private DataGridView dg_OrderView;
    }
}