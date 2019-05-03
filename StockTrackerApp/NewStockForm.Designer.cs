namespace StockTrackerApp
{
    partial class NewStockForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Brokerage = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Symbol = new System.Windows.Forms.TextBox();
            this.txt_Company = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_Purchase = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Shares = new System.Windows.Forms.TextBox();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_SearchCompany = new System.Windows.Forms.Button();
            this.btn_SearchSymbol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Brokerage ";
            // 
            // cb_Brokerage
            // 
            this.cb_Brokerage.FormattingEnabled = true;
            this.cb_Brokerage.Location = new System.Drawing.Point(108, 35);
            this.cb_Brokerage.Name = "cb_Brokerage";
            this.cb_Brokerage.Size = new System.Drawing.Size(215, 29);
            this.cb_Brokerage.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Symbol";
            // 
            // txt_Symbol
            // 
            this.txt_Symbol.Location = new System.Drawing.Point(108, 79);
            this.txt_Symbol.Name = "txt_Symbol";
            this.txt_Symbol.Size = new System.Drawing.Size(113, 29);
            this.txt_Symbol.TabIndex = 3;
            // 
            // txt_Company
            // 
            this.txt_Company.Location = new System.Drawing.Point(108, 125);
            this.txt_Company.Name = "txt_Company";
            this.txt_Company.Size = new System.Drawing.Size(233, 29);
            this.txt_Company.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Company";
            // 
            // dtp_Purchase
            // 
            this.dtp_Purchase.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Purchase.Location = new System.Drawing.Point(21, 215);
            this.dtp_Purchase.Name = "dtp_Purchase";
            this.dtp_Purchase.Size = new System.Drawing.Size(139, 29);
            this.dtp_Purchase.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Purchase Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Shares Purchased";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(384, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Price/Share";
            // 
            // txt_Shares
            // 
            this.txt_Shares.Location = new System.Drawing.Point(203, 215);
            this.txt_Shares.Name = "txt_Shares";
            this.txt_Shares.Size = new System.Drawing.Size(129, 29);
            this.txt_Shares.TabIndex = 12;
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(388, 215);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(105, 29);
            this.txt_Price.TabIndex = 13;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_Save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Save.Location = new System.Drawing.Point(71, 274);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(89, 28);
            this.btn_Save.TabIndex = 14;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_Clear.Location = new System.Drawing.Point(216, 274);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(89, 28);
            this.btn_Clear.TabIndex = 15;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(370, 274);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(89, 28);
            this.btn_Cancel.TabIndex = 16;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_SearchCompany
            // 
            this.btn_SearchCompany.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_SearchCompany.Location = new System.Drawing.Point(388, 125);
            this.btn_SearchCompany.Name = "btn_SearchCompany";
            this.btn_SearchCompany.Size = new System.Drawing.Size(146, 31);
            this.btn_SearchCompany.TabIndex = 7;
            this.btn_SearchCompany.Text = "Search Company";
            this.btn_SearchCompany.UseVisualStyleBackColor = false;
            this.btn_SearchCompany.Visible = false;
            this.btn_SearchCompany.Click += new System.EventHandler(this.btn_SearchCompany_Click);
            // 
            // btn_SearchSymbol
            // 
            this.btn_SearchSymbol.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_SearchSymbol.Location = new System.Drawing.Point(388, 79);
            this.btn_SearchSymbol.Name = "btn_SearchSymbol";
            this.btn_SearchSymbol.Size = new System.Drawing.Size(146, 31);
            this.btn_SearchSymbol.TabIndex = 6;
            this.btn_SearchSymbol.Text = "Search Symbol";
            this.btn_SearchSymbol.UseVisualStyleBackColor = false;
            this.btn_SearchSymbol.Visible = false;
            this.btn_SearchSymbol.Click += new System.EventHandler(this.btn_SearchSymbol_Click);
            // 
            // NewStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(562, 337);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.txt_Shares);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_Purchase);
            this.Controls.Add(this.btn_SearchCompany);
            this.Controls.Add(this.btn_SearchSymbol);
            this.Controls.Add(this.txt_Company);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Symbol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_Brokerage);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NewStockForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Stock";
            this.Load += new System.EventHandler(this.NewStockForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Brokerage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Symbol;
        private System.Windows.Forms.TextBox txt_Company;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_Purchase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Shares;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_SearchCompany;
        private System.Windows.Forms.Button btn_SearchSymbol;
    }
}