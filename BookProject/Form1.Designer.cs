namespace BookProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_fName = new System.Windows.Forms.Label();
            this.lbl_lName = new System.Windows.Forms.Label();
            this.tb_fName = new System.Windows.Forms.TextBox();
            this.tb_lName = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_admin = new System.Windows.Forms.Button();
            this.btn_createAcc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_fName
            // 
            this.lbl_fName.AutoSize = true;
            this.lbl_fName.Location = new System.Drawing.Point(59, 71);
            this.lbl_fName.Name = "lbl_fName";
            this.lbl_fName.Size = new System.Drawing.Size(67, 15);
            this.lbl_fName.TabIndex = 1;
            this.lbl_fName.Text = "First Name:";
            // 
            // lbl_lName
            // 
            this.lbl_lName.AutoSize = true;
            this.lbl_lName.Location = new System.Drawing.Point(60, 120);
            this.lbl_lName.Name = "lbl_lName";
            this.lbl_lName.Size = new System.Drawing.Size(66, 15);
            this.lbl_lName.TabIndex = 2;
            this.lbl_lName.Text = "Last Name:";
            // 
            // tb_fName
            // 
            this.tb_fName.Location = new System.Drawing.Point(132, 68);
            this.tb_fName.Name = "tb_fName";
            this.tb_fName.Size = new System.Drawing.Size(127, 23);
            this.tb_fName.TabIndex = 3;
            // 
            // tb_lName
            // 
            this.tb_lName.Location = new System.Drawing.Point(132, 117);
            this.tb_lName.Name = "tb_lName";
            this.tb_lName.Size = new System.Drawing.Size(127, 23);
            this.tb_lName.TabIndex = 4;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(77, 164);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_admin
            // 
            this.btn_admin.Location = new System.Drawing.Point(172, 165);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(75, 23);
            this.btn_admin.TabIndex = 6;
            this.btn_admin.Text = "Admin";
            this.btn_admin.UseVisualStyleBackColor = true;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // btn_createAcc
            // 
            this.btn_createAcc.Location = new System.Drawing.Point(77, 206);
            this.btn_createAcc.Name = "btn_createAcc";
            this.btn_createAcc.Size = new System.Drawing.Size(170, 23);
            this.btn_createAcc.TabIndex = 7;
            this.btn_createAcc.Text = "Create Account";
            this.btn_createAcc.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 381);
            this.Controls.Add(this.btn_createAcc);
            this.Controls.Add(this.btn_admin);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tb_lName);
            this.Controls.Add(this.tb_fName);
            this.Controls.Add(this.lbl_lName);
            this.Controls.Add(this.lbl_fName);
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbl_fName;
        private Label lbl_lName;
        private TextBox tb_fName;
        private TextBox tb_lName;
        private Button btn_login;
        private Button btn_admin;
        private Button btn_createAcc;
    }
}