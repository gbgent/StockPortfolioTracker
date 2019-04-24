namespace StockTrackerApp
{
    partial class StockUpdateForm
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
            System.Windows.Forms.TextBox tx_MultiPurpose;
            System.Windows.Forms.Label lbl_MultiPurpose;
            this.cb_Broker = new System.Windows.Forms.ComboBox();
            this.lbl_Broker = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_CurrentValue = new System.Windows.Forms.Label();
            this.lbl_SharesOwned = new System.Windows.Forms.Label();
            this.lbl_OldValuation = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.tx_TransPrice = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_TransDate = new System.Windows.Forms.DateTimePicker();
            this.pnl_Split = new System.Windows.Forms.Panel();
            this.pnl_Normal = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_NewShares = new System.Windows.Forms.TextBox();
            this.txt_OldShares = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            tx_MultiPurpose = new System.Windows.Forms.TextBox();
            lbl_MultiPurpose = new System.Windows.Forms.Label();
            this.pnl_Split.SuspendLayout();
            this.pnl_Normal.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_Broker
            // 
            this.cb_Broker.FormattingEnabled = true;
            this.cb_Broker.Location = new System.Drawing.Point(138, 81);
            this.cb_Broker.Name = "cb_Broker";
            this.cb_Broker.Size = new System.Drawing.Size(121, 29);
            this.cb_Broker.TabIndex = 52;
            // 
            // lbl_Broker
            // 
            this.lbl_Broker.Location = new System.Drawing.Point(9, 83);
            this.lbl_Broker.Name = "lbl_Broker";
            this.lbl_Broker.Size = new System.Drawing.Size(119, 24);
            this.lbl_Broker.TabIndex = 51;
            this.lbl_Broker.Text = "Broker";
            this.lbl_Broker.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Price
            // 
            this.lbl_Price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Price.Location = new System.Drawing.Point(158, 119);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(100, 21);
            this.lbl_Price.TabIndex = 50;
            this.lbl_Price.Text = "Price";
            this.lbl_Price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_CurrentValue
            // 
            this.lbl_CurrentValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_CurrentValue.ForeColor = System.Drawing.Color.Black;
            this.lbl_CurrentValue.Location = new System.Drawing.Point(139, 47);
            this.lbl_CurrentValue.Name = "lbl_CurrentValue";
            this.lbl_CurrentValue.Size = new System.Drawing.Size(119, 24);
            this.lbl_CurrentValue.TabIndex = 48;
            this.lbl_CurrentValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_SharesOwned
            // 
            this.lbl_SharesOwned.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_SharesOwned.ForeColor = System.Drawing.Color.Black;
            this.lbl_SharesOwned.Location = new System.Drawing.Point(139, 13);
            this.lbl_SharesOwned.Name = "lbl_SharesOwned";
            this.lbl_SharesOwned.Size = new System.Drawing.Size(119, 24);
            this.lbl_SharesOwned.TabIndex = 47;
            this.lbl_SharesOwned.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_OldValuation
            // 
            this.lbl_OldValuation.Location = new System.Drawing.Point(9, 47);
            this.lbl_OldValuation.Name = "lbl_OldValuation";
            this.lbl_OldValuation.Size = new System.Drawing.Size(119, 24);
            this.lbl_OldValuation.TabIndex = 46;
            this.lbl_OldValuation.Text = "Valuation";
            this.lbl_OldValuation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 24);
            this.label3.TabIndex = 45;
            this.label3.Text = "Shares Owned";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(300, 46);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(72, 28);
            this.btn_Cancel.TabIndex = 40;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // tx_TransPrice
            // 
            this.tx_TransPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tx_TransPrice.Location = new System.Drawing.Point(158, 145);
            this.tx_TransPrice.Name = "tx_TransPrice";
            this.tx_TransPrice.Size = new System.Drawing.Size(100, 29);
            this.tx_TransPrice.TabIndex = 44;
            this.tx_TransPrice.Text = "0.00";
            this.tx_TransPrice.Leave += new System.EventHandler(this.tx_TransPrice_Leave);
            // 
            // btn_Save
            // 
            this.btn_Save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(300, 12);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(72, 28);
            this.btn_Save.TabIndex = 39;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Location = new System.Drawing.Point(13, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 21);
            this.label1.TabIndex = 42;
            this.label1.Text = "Date";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtp_TransDate
            // 
            this.dtp_TransDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtp_TransDate.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_TransDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_TransDate.Location = new System.Drawing.Point(13, 145);
            this.dtp_TransDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_TransDate.Name = "dtp_TransDate";
            this.dtp_TransDate.ShowUpDown = true;
            this.dtp_TransDate.Size = new System.Drawing.Size(131, 29);
            this.dtp_TransDate.TabIndex = 41;
            // 
            // pnl_Split
            // 
            this.pnl_Split.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnl_Split.Controls.Add(this.label7);
            this.pnl_Split.Controls.Add(this.label6);
            this.pnl_Split.Controls.Add(this.txt_OldShares);
            this.pnl_Split.Controls.Add(this.txt_NewShares);
            this.pnl_Split.Controls.Add(this.label5);
            this.pnl_Split.Controls.Add(this.label4);
            this.pnl_Split.Controls.Add(this.label2);
            this.pnl_Split.Location = new System.Drawing.Point(264, 83);
            this.pnl_Split.Name = "pnl_Split";
            this.pnl_Split.Size = new System.Drawing.Size(116, 100);
            this.pnl_Split.TabIndex = 50;
            // 
            // pnl_Normal
            // 
            this.pnl_Normal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnl_Normal.Controls.Add(lbl_MultiPurpose);
            this.pnl_Normal.Controls.Add(tx_MultiPurpose);
            this.pnl_Normal.Location = new System.Drawing.Point(265, 111);
            this.pnl_Normal.Name = "pnl_Normal";
            this.pnl_Normal.Size = new System.Drawing.Size(115, 73);
            this.pnl_Normal.TabIndex = 50;
            // 
            // tx_MultiPurpose
            // 
            tx_MultiPurpose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            tx_MultiPurpose.Location = new System.Drawing.Point(7, 33);
            tx_MultiPurpose.Name = "tx_MultiPurpose";
            tx_MultiPurpose.Size = new System.Drawing.Size(100, 29);
            tx_MultiPurpose.TabIndex = 49;
            tx_MultiPurpose.Text = "0.00";
            // 
            // lbl_MultiPurpose
            // 
            lbl_MultiPurpose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            lbl_MultiPurpose.Location = new System.Drawing.Point(7, 7);
            lbl_MultiPurpose.Name = "lbl_MultiPurpose";
            lbl_MultiPurpose.Size = new System.Drawing.Size(100, 21);
            lbl_MultiPurpose.TabIndex = 43;
            lbl_MultiPurpose.Text = "Shares";
            lbl_MultiPurpose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Split Ratio";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "New";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Old";
            // 
            // txt_NewShares
            // 
            this.txt_NewShares.Location = new System.Drawing.Point(10, 62);
            this.txt_NewShares.Name = "txt_NewShares";
            this.txt_NewShares.Size = new System.Drawing.Size(38, 29);
            this.txt_NewShares.TabIndex = 3;
            // 
            // txt_OldShares
            // 
            this.txt_OldShares.Location = new System.Drawing.Point(71, 62);
            this.txt_OldShares.Name = "txt_OldShares";
            this.txt_OldShares.Size = new System.Drawing.Size(38, 29);
            this.txt_OldShares.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = ":";
            // 
            // StockUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 186);
            this.Controls.Add(this.pnl_Split);
            this.Controls.Add(this.pnl_Normal);
            this.Controls.Add(this.cb_Broker);
            this.Controls.Add(this.lbl_Broker);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.lbl_CurrentValue);
            this.Controls.Add(this.lbl_SharesOwned);
            this.Controls.Add(this.lbl_OldValuation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.tx_TransPrice);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_TransDate);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StockUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stock Price Update";
            this.pnl_Split.ResumeLayout(false);
            this.pnl_Split.PerformLayout();
            this.pnl_Normal.ResumeLayout(false);
            this.pnl_Normal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Broker;
        private System.Windows.Forms.Label lbl_Broker;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_CurrentValue;
        private System.Windows.Forms.Label lbl_SharesOwned;
        private System.Windows.Forms.Label lbl_OldValuation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox tx_TransPrice;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_TransDate;
        private System.Windows.Forms.Panel pnl_Split;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnl_Normal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_OldShares;
        private System.Windows.Forms.TextBox txt_NewShares;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}