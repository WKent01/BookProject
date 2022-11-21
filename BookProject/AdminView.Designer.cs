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
            ((System.ComponentModel.ISupportInitialize)(this.dg_aTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_query
            // 
            this.btn_query.Location = new System.Drawing.Point(22, 249);
            this.btn_query.Name = "btn_query";
            this.btn_query.Size = new System.Drawing.Size(276, 23);
            this.btn_query.TabIndex = 0;
            this.btn_query.Text = "Run Query";
            this.btn_query.UseVisualStyleBackColor = true;
            // 
            // tb_aQuery
            // 
            this.tb_aQuery.Location = new System.Drawing.Point(22, 46);
            this.tb_aQuery.Multiline = true;
            this.tb_aQuery.Name = "tb_aQuery";
            this.tb_aQuery.Size = new System.Drawing.Size(276, 188);
            this.tb_aQuery.TabIndex = 1;
            // 
            // cb_tblSelect
            // 
            this.cb_tblSelect.FormattingEnabled = true;
            this.cb_tblSelect.Location = new System.Drawing.Point(157, 17);
            this.cb_tblSelect.Name = "cb_tblSelect";
            this.cb_tblSelect.Size = new System.Drawing.Size(141, 23);
            this.cb_tblSelect.TabIndex = 2;
            // 
            // lb_tblSelect
            // 
            this.lb_tblSelect.AutoSize = true;
            this.lb_tblSelect.Location = new System.Drawing.Point(25, 19);
            this.lb_tblSelect.Name = "lb_tblSelect";
            this.lb_tblSelect.Size = new System.Drawing.Size(126, 15);
            this.lb_tblSelect.TabIndex = 3;
            this.lb_tblSelect.Text = "Select a table to query:";
            // 
            // dg_aTable
            // 
            this.dg_aTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_aTable.Location = new System.Drawing.Point(304, 19);
            this.dg_aTable.Name = "dg_aTable";
            this.dg_aTable.RowTemplate.Height = 25;
            this.dg_aTable.Size = new System.Drawing.Size(305, 253);
            this.dg_aTable.TabIndex = 4;
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dg_aTable);
            this.Controls.Add(this.lb_tblSelect);
            this.Controls.Add(this.cb_tblSelect);
            this.Controls.Add(this.tb_aQuery);
            this.Controls.Add(this.btn_query);
            this.Name = "AdminView";
            this.Text = "AdminView";
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
    }
}