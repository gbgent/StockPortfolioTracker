namespace StockTrackerApp
{
    partial class BrokerageForm
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
            this.cb_Select = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_BrokerageName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.gb_BrokerageInfo = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_AccountNum = new System.Windows.Forms.TextBox();
            this.gp_BrokerInfo = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_PhoneNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_BrokerName = new System.Windows.Forms.TextBox();
            this.chk_Edit = new System.Windows.Forms.CheckBox();
            this.btn_New = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Revert = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_CommissionRate = new System.Windows.Forms.TextBox();
            this.gb_BrokerageInfo.SuspendLayout();
            this.gp_BrokerInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_Select
            // 
            this.cb_Select.FormattingEnabled = true;
            this.cb_Select.Items.AddRange(new object[] {
            "Select a Brokerage",
            "-",
            "E-Trade",
            "AmeriTrade",
            "Charles Swab"});
            this.cb_Select.Location = new System.Drawing.Point(37, 28);
            this.cb_Select.Name = "cb_Select";
            this.cb_Select.Size = new System.Drawing.Size(159, 29);
            this.cb_Select.TabIndex = 0;
            this.cb_Select.Text = "Select a Brokerage";
            this.cb_Select.SelectedIndexChanged += new System.EventHandler(this.cb_Select_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // txt_BrokerageName
            // 
            this.txt_BrokerageName.Location = new System.Drawing.Point(120, 45);
            this.txt_BrokerageName.Name = "txt_BrokerageName";
            this.txt_BrokerageName.Size = new System.Drawing.Size(177, 29);
            this.txt_BrokerageName.TabIndex = 0;
            this.txt_BrokerageName.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Address";
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(120, 102);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(177, 107);
            this.txt_Address.TabIndex = 1;
            this.txt_Address.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            // 
            // gb_BrokerageInfo
            // 
            this.gb_BrokerageInfo.Controls.Add(this.label3);
            this.gb_BrokerageInfo.Controls.Add(this.txt_AccountNum);
            this.gb_BrokerageInfo.Controls.Add(this.label1);
            this.gb_BrokerageInfo.Controls.Add(this.txt_Address);
            this.gb_BrokerageInfo.Controls.Add(this.txt_BrokerageName);
            this.gb_BrokerageInfo.Controls.Add(this.label2);
            this.gb_BrokerageInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gb_BrokerageInfo.Location = new System.Drawing.Point(12, 84);
            this.gb_BrokerageInfo.Name = "gb_BrokerageInfo";
            this.gb_BrokerageInfo.Size = new System.Drawing.Size(314, 279);
            this.gb_BrokerageInfo.TabIndex = 1;
            this.gb_BrokerageInfo.TabStop = false;
            this.gb_BrokerageInfo.Text = "Brokerage Infomation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 42);
            this.label3.TabIndex = 5;
            this.label3.Text = "Account\r\nNumber";
            // 
            // txt_AccountNum
            // 
            this.txt_AccountNum.Location = new System.Drawing.Point(120, 227);
            this.txt_AccountNum.Name = "txt_AccountNum";
            this.txt_AccountNum.Size = new System.Drawing.Size(177, 29);
            this.txt_AccountNum.TabIndex = 2;
            this.txt_AccountNum.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            // 
            // gp_BrokerInfo
            // 
            this.gp_BrokerInfo.Controls.Add(this.label6);
            this.gp_BrokerInfo.Controls.Add(this.txt_Email);
            this.gp_BrokerInfo.Controls.Add(this.label5);
            this.gp_BrokerInfo.Controls.Add(this.txt_PhoneNum);
            this.gp_BrokerInfo.Controls.Add(this.label4);
            this.gp_BrokerInfo.Controls.Add(this.txt_BrokerName);
            this.gp_BrokerInfo.Location = new System.Drawing.Point(358, 84);
            this.gp_BrokerInfo.Name = "gp_BrokerInfo";
            this.gp_BrokerInfo.Size = new System.Drawing.Size(314, 190);
            this.gp_BrokerInfo.TabIndex = 2;
            this.gp_BrokerInfo.TabStop = false;
            this.gp_BrokerInfo.Text = "Broker Information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "E-Mail";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(93, 139);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(177, 29);
            this.txt_Email.TabIndex = 2;
            this.txt_Email.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phone";
            // 
            // txt_PhoneNum
            // 
            this.txt_PhoneNum.Location = new System.Drawing.Point(93, 90);
            this.txt_PhoneNum.Name = "txt_PhoneNum";
            this.txt_PhoneNum.Size = new System.Drawing.Size(177, 29);
            this.txt_PhoneNum.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name";
            // 
            // txt_BrokerName
            // 
            this.txt_BrokerName.Location = new System.Drawing.Point(93, 41);
            this.txt_BrokerName.Name = "txt_BrokerName";
            this.txt_BrokerName.Size = new System.Drawing.Size(177, 29);
            this.txt_BrokerName.TabIndex = 0;
            this.txt_BrokerName.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            // 
            // chk_Edit
            // 
            this.chk_Edit.AutoSize = true;
            this.chk_Edit.Location = new System.Drawing.Point(531, 32);
            this.chk_Edit.Name = "chk_Edit";
            this.chk_Edit.Size = new System.Drawing.Size(141, 25);
            this.chk_Edit.TabIndex = 0;
            this.chk_Edit.TabStop = false;
            this.chk_Edit.Text = "Edit Information";
            this.chk_Edit.UseVisualStyleBackColor = true;
            this.chk_Edit.CheckedChanged += new System.EventHandler(this.chk_Edit_CheckedChanged);
            // 
            // btn_New
            // 
            this.btn_New.Location = new System.Drawing.Point(301, 381);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(90, 35);
            this.btn_New.TabIndex = 5;
            this.btn_New.Text = "New";
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(189, 381);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(90, 35);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Revert
            // 
            this.btn_Revert.Location = new System.Drawing.Point(413, 381);
            this.btn_Revert.Name = "btn_Revert";
            this.btn_Revert.Size = new System.Drawing.Size(90, 35);
            this.btn_Revert.TabIndex = 6;
            this.btn_Revert.Text = "Revert";
            this.btn_Revert.UseVisualStyleBackColor = true;
            this.btn_Revert.Click += new System.EventHandler(this.btn_Revert_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(377, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Commission Rate";
            // 
            // txt_CommissionRate
            // 
            this.txt_CommissionRate.Location = new System.Drawing.Point(513, 301);
            this.txt_CommissionRate.Name = "txt_CommissionRate";
            this.txt_CommissionRate.Size = new System.Drawing.Size(115, 29);
            this.txt_CommissionRate.TabIndex = 3;
            // 
            // BrokerageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 427);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Revert);
            this.Controls.Add(this.txt_CommissionRate);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.chk_Edit);
            this.Controls.Add(this.gp_BrokerInfo);
            this.Controls.Add(this.gb_BrokerageInfo);
            this.Controls.Add(this.cb_Select);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BrokerageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Brokerage Information";
            this.Load += new System.EventHandler(this.BrokerageForm_Load);
            this.gb_BrokerageInfo.ResumeLayout(false);
            this.gb_BrokerageInfo.PerformLayout();
            this.gp_BrokerInfo.ResumeLayout(false);
            this.gp_BrokerInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Select;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_BrokerageName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.GroupBox gb_BrokerageInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_AccountNum;
        private System.Windows.Forms.GroupBox gp_BrokerInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_PhoneNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_BrokerName;
        private System.Windows.Forms.CheckBox chk_Edit;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Revert;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_CommissionRate;
    }
}