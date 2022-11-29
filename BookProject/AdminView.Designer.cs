namespace BookProject
{
    partial class AdminView
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
            this.btn_query = new System.Windows.Forms.Button();
            this.tb_aQuery = new System.Windows.Forms.TextBox();
            this.cb_tblSelect = new System.Windows.Forms.ComboBox();
            this.lb_tblSelect = new System.Windows.Forms.Label();
            this.dg_aTable = new System.Windows.Forms.DataGridView();
            this.lbl_or = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_aTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_query
            // 
            this.btn_query.Location = new System.Drawing.Point(15, 251);
            this.btn_query.Name = "btn_query";
            this.btn_query.Size = new System.Drawing.Size(276, 23);
            this.btn_query.TabIndex = 0;
            this.btn_query.Text = "Run Query";
            this.btn_query.UseVisualStyleBackColor = true;
            this.btn_query.Click += new System.EventHandler(this.btn_query_Click);
            // 
            // tb_aQuery
            // 
            this.tb_aQuery.Location = new System.Drawing.Point(15, 70);
            this.tb_aQuery.Multiline = true;
            this.tb_aQuery.Name = "tb_aQuery";
            this.tb_aQuery.Size = new System.Drawing.Size(276, 166);
            this.tb_aQuery.TabIndex = 1;
            // 
            // cb_tblSelect
            // 
            this.cb_tblSelect.FormattingEnabled = true;
            this.cb_tblSelect.Items.AddRange(new object[] {
            "Author",
            "Orders",
            "Customer",
            "Supplier",
            "Supplier_Rep",
            "Book_Categories",
            "Books",
            "Order_Items"});
            this.cb_tblSelect.Location = new System.Drawing.Point(150, 19);
            this.cb_tblSelect.Name = "cb_tblSelect";
            this.cb_tblSelect.Size = new System.Drawing.Size(141, 23);
            this.cb_tblSelect.TabIndex = 2;
            this.cb_tblSelect.SelectedIndexChanged += new System.EventHandler(this.cb_tblSelect_SelectedIndexChanged);
            // 
            // lb_tblSelect
            // 
            this.lb_tblSelect.AutoSize = true;
            this.lb_tblSelect.Location = new System.Drawing.Point(18, 21);
            this.lb_tblSelect.Name = "lb_tblSelect";
            this.lb_tblSelect.Size = new System.Drawing.Size(126, 15);
            this.lb_tblSelect.TabIndex = 3;
            this.lb_tblSelect.Text = "Select a table to query:";
            // 
            // dg_aTable
            // 
            this.dg_aTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_aTable.Location = new System.Drawing.Point(297, 21);
            this.dg_aTable.Name = "dg_aTable";
            this.dg_aTable.RowTemplate.Height = 25;
            this.dg_aTable.Size = new System.Drawing.Size(305, 253);
            this.dg_aTable.TabIndex = 4;
            // 
            // lbl_or
            // 
            this.lbl_or.AutoSize = true;
            this.lbl_or.Location = new System.Drawing.Point(110, 52);
            this.lbl_or.Name = "lbl_or";
            this.lbl_or.Size = new System.Drawing.Size(84, 15);
            this.lbl_or.TabIndex = 5;
            this.lbl_or.Text = "------ or ------";
            this.lbl_or.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 306);
            this.Controls.Add(this.lbl_or);
            this.Controls.Add(this.dg_aTable);
            this.Controls.Add(this.lb_tblSelect);
            this.Controls.Add(this.cb_tblSelect);
            this.Controls.Add(this.tb_aQuery);
            this.Controls.Add(this.btn_query);
            this.Name = "AdminView";
            this.Text = "AdminView";
            this.Load += new System.EventHandler(this.AdminView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_aTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_query;
        private TextBox tb_aQuery;
        private ComboBox cb_tblSelect;
        private Label lb_tblSelect;
        private DataGridView dg_aTable;
        private Label lbl_or;
    }
}