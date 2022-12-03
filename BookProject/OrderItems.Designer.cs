namespace BookProject
{
    partial class OrderItems
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
            this.dg_OrderItems = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_OrderItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_OrderItems
            // 
            this.dg_OrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_OrderItems.Location = new System.Drawing.Point(12, 12);
            this.dg_OrderItems.Name = "dg_OrderItems";
            this.dg_OrderItems.RowTemplate.Height = 25;
            this.dg_OrderItems.Size = new System.Drawing.Size(610, 452);
            this.dg_OrderItems.TabIndex = 0;
            this.dg_OrderItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_OrderItems_CellContentClick);
            // 
            // OrderItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 476);
            this.Controls.Add(this.dg_OrderItems);
            this.Name = "OrderItems";
            this.Text = "Order #XXXXX";
            this.Load += new System.EventHandler(this.OrderItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_OrderItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dg_OrderItems;
    }
}