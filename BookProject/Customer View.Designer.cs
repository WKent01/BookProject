namespace BookProject
{
    partial class Customer_View
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
            this.cb_sortBy = new System.Windows.Forms.ComboBox();
            this.lbl_sortBy = new System.Windows.Forms.Label();
            this.rb_ascending = new System.Windows.Forms.RadioButton();
            this.rb_descending = new System.Windows.Forms.RadioButton();
            this.btn_search = new System.Windows.Forms.Button();
            this.tb_keyWord = new System.Windows.Forms.TextBox();
            this.btn_addToCart = new System.Windows.Forms.Button();
            this.lbl_userName = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_viewCart = new System.Windows.Forms.Button();
            this.btn_account = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dg_shopView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_shopView)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_sortBy
            // 
            this.cb_sortBy.FormattingEnabled = true;
            this.cb_sortBy.Items.AddRange(new object[] {
            "",
            "ISBN",
            "Title",
            "FName",
            "LName",
            "Publication_Date",
            "Price"});
            this.cb_sortBy.Location = new System.Drawing.Point(96, 64);
            this.cb_sortBy.Name = "cb_sortBy";
            this.cb_sortBy.Size = new System.Drawing.Size(121, 23);
            this.cb_sortBy.TabIndex = 0;
            // 
            // lbl_sortBy
            // 
            this.lbl_sortBy.AutoSize = true;
            this.lbl_sortBy.Location = new System.Drawing.Point(43, 72);
            this.lbl_sortBy.Name = "lbl_sortBy";
            this.lbl_sortBy.Size = new System.Drawing.Size(47, 15);
            this.lbl_sortBy.TabIndex = 1;
            this.lbl_sortBy.Text = "Sort by:";
            // 
            // rb_ascending
            // 
            this.rb_ascending.AutoSize = true;
            this.rb_ascending.Location = new System.Drawing.Point(227, 65);
            this.rb_ascending.Name = "rb_ascending";
            this.rb_ascending.Size = new System.Drawing.Size(81, 19);
            this.rb_ascending.TabIndex = 2;
            this.rb_ascending.TabStop = true;
            this.rb_ascending.Text = "Ascending";
            this.rb_ascending.UseVisualStyleBackColor = true;
            // 
            // rb_descending
            // 
            this.rb_descending.AutoSize = true;
            this.rb_descending.Location = new System.Drawing.Point(314, 64);
            this.rb_descending.Name = "rb_descending";
            this.rb_descending.Size = new System.Drawing.Size(87, 19);
            this.rb_descending.TabIndex = 3;
            this.rb_descending.TabStop = true;
            this.rb_descending.Text = "Descending";
            this.rb_descending.UseVisualStyleBackColor = true;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(326, 34);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tb_keyWord
            // 
            this.tb_keyWord.Location = new System.Drawing.Point(43, 35);
            this.tb_keyWord.Name = "tb_keyWord";
            this.tb_keyWord.Size = new System.Drawing.Size(277, 23);
            this.tb_keyWord.TabIndex = 5;
            // 
            // btn_addToCart
            // 
            this.btn_addToCart.Location = new System.Drawing.Point(12, 400);
            this.btn_addToCart.Name = "btn_addToCart";
            this.btn_addToCart.Size = new System.Drawing.Size(162, 38);
            this.btn_addToCart.TabIndex = 6;
            this.btn_addToCart.Text = "Add to Cart";
            this.btn_addToCart.UseVisualStyleBackColor = true;
            // 
            // lbl_userName
            // 
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.Location = new System.Drawing.Point(565, 9);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(37, 15);
            this.lbl_userName.TabIndex = 8;
            this.lbl_userName.Text = "Clyde";
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(658, 400);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(130, 38);
            this.btn_logout.TabIndex = 9;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            // 
            // btn_viewCart
            // 
            this.btn_viewCart.Location = new System.Drawing.Point(184, 400);
            this.btn_viewCart.Name = "btn_viewCart";
            this.btn_viewCart.Size = new System.Drawing.Size(165, 38);
            this.btn_viewCart.TabIndex = 10;
            this.btn_viewCart.Text = "View Cart";
            this.btn_viewCart.UseVisualStyleBackColor = true;
            this.btn_viewCart.Click += new System.EventHandler(this.btn_viewCart_Click);
            // 
            // btn_account
            // 
            this.btn_account.Location = new System.Drawing.Point(565, 35);
            this.btn_account.Name = "btn_account";
            this.btn_account.Size = new System.Drawing.Size(152, 23);
            this.btn_account.TabIndex = 11;
            this.btn_account.Text = "Account Settings";
            this.btn_account.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(565, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "View Order History";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dg_shopView
            // 
            this.dg_shopView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_shopView.Location = new System.Drawing.Point(12, 104);
            this.dg_shopView.Name = "dg_shopView";
            this.dg_shopView.ReadOnly = true;
            this.dg_shopView.RowTemplate.Height = 25;
            this.dg_shopView.Size = new System.Drawing.Size(776, 281);
            this.dg_shopView.TabIndex = 13;
            // 
            // Customer_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dg_shopView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_account);
            this.Controls.Add(this.btn_viewCart);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.lbl_userName);
            this.Controls.Add(this.btn_addToCart);
            this.Controls.Add(this.tb_keyWord);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.rb_descending);
            this.Controls.Add(this.rb_ascending);
            this.Controls.Add(this.lbl_sortBy);
            this.Controls.Add(this.cb_sortBy);
            this.Name = "Customer_View";
            this.Text = "Customer View";
            this.Load += new System.EventHandler(this.Customer_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_shopView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cb_sortBy;
        private Label lbl_sortBy;
        private RadioButton rb_ascending;
        private RadioButton rb_descending;
        private Button btn_search;
        private TextBox tb_keyWord;
        private Button btn_addToCart;
        private Label lbl_userName;
        private Button btn_logout;
        private Button btn_viewCart;
        private Button btn_account;
        private Button button1;
        private DataGridView dg_shopView;
    }
}