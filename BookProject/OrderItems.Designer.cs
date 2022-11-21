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
            this.lv_orderItems = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lv_orderItems
            // 
            this.lv_orderItems.Location = new System.Drawing.Point(12, 12);
            this.lv_orderItems.Name = "lv_orderItems";
            this.lv_orderItems.Size = new System.Drawing.Size(611, 426);
            this.lv_orderItems.TabIndex = 0;
            this.lv_orderItems.UseCompatibleStateImageBehavior = false;
            // 
            // OrderItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 476);
            this.Controls.Add(this.lv_orderItems);
            this.Name = "OrderItems";
            this.Text = "Order #XXXXX";
            this.ResumeLayout(false);

        }

        #endregion

        private ListView lv_orderItems;
    }
}