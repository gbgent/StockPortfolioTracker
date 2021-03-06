﻿namespace StockTrackerApp
{
    partial class StockView
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.lst_Stocks = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cht_IndivStock = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.lst_History = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_AvgPrice = new System.Windows.Forms.Label();
            this.lbl_SymbolValue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_SharesOwned = new System.Windows.Forms.Label();
            this.lbl_CompName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cht_IndivStock)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lst_Stocks
            // 
            this.lst_Stocks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lst_Stocks.BackColor = System.Drawing.Color.FloralWhite;
            this.lst_Stocks.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_Stocks.FormattingEnabled = true;
            this.lst_Stocks.ItemHeight = 17;
            this.lst_Stocks.Location = new System.Drawing.Point(8, 31);
            this.lst_Stocks.Name = "lst_Stocks";
            this.lst_Stocks.Size = new System.Drawing.Size(182, 208);
            this.lst_Stocks.TabIndex = 0;
            this.lst_Stocks.SelectedIndexChanged += new System.EventHandler(this.lst_Stocks_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "  List of Stocks";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cht_IndivStock);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(209, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 476);
            this.panel1.TabIndex = 2;
            // 
            // cht_IndivStock
            // 
            this.cht_IndivStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cht_IndivStock.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cht_IndivStock.BackSecondaryColor = System.Drawing.Color.SeaShell;
            chartArea2.AxisX.IsStartedFromZero = false;
            chartArea2.AxisX2.IsStartedFromZero = false;
            chartArea2.AxisY.IsStartedFromZero = false;
            chartArea2.AxisY2.IsStartedFromZero = false;
            chartArea2.BackColor = System.Drawing.Color.FloralWhite;
            chartArea2.BorderColor = System.Drawing.Color.Bisque;
            chartArea2.BorderWidth = 2;
            chartArea2.Name = "ChartArea1";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 80F;
            chartArea2.Position.Width = 98F;
            chartArea2.Position.Y = 15F;
            this.cht_IndivStock.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.AntiqueWhite;
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            legend2.IsTextAutoFit = false;
            legend2.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend2.Name = "Legend1";
            legend2.Position.Auto = false;
            legend2.Position.Height = 7F;
            legend2.Position.Width = 40F;
            legend2.Position.X = 25F;
            legend2.Position.Y = 93F;
            this.cht_IndivStock.Legends.Add(legend2);
            this.cht_IndivStock.Location = new System.Drawing.Point(3, 121);
            this.cht_IndivStock.Name = "cht_IndivStock";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Value";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Cost";
            this.cht_IndivStock.Series.Add(series3);
            this.cht_IndivStock.Series.Add(series4);
            this.cht_IndivStock.Size = new System.Drawing.Size(610, 351);
            this.cht_IndivStock.TabIndex = 11;
            this.cht_IndivStock.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Valuation";
            title2.Position.Auto = false;
            title2.Position.Height = 16F;
            title2.Position.Width = 94F;
            title2.Position.X = 3F;
            title2.Position.Y = 2F;
            title2.Text = "Stock Value";
            this.cht_IndivStock.Titles.Add(title2);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Transactions";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lst_History
            // 
            this.lst_History.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lst_History.BackColor = System.Drawing.Color.FloralWhite;
            this.lst_History.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_History.FormattingEnabled = true;
            this.lst_History.ItemHeight = 17;
            this.lst_History.Location = new System.Drawing.Point(8, 276);
            this.lst_History.Name = "lst_History";
            this.lst_History.Size = new System.Drawing.Size(182, 208);
            this.lst_History.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl_AvgPrice);
            this.groupBox1.Controls.Add(this.lbl_SymbolValue);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbl_SharesOwned);
            this.groupBox1.Controls.Add(this.lbl_CompName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Company Information";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Symbol:";
            // 
            // lbl_AvgPrice
            // 
            this.lbl_AvgPrice.BackColor = System.Drawing.Color.FloralWhite;
            this.lbl_AvgPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_AvgPrice.Location = new System.Drawing.Point(392, 66);
            this.lbl_AvgPrice.Name = "lbl_AvgPrice";
            this.lbl_AvgPrice.Size = new System.Drawing.Size(128, 21);
            this.lbl_AvgPrice.TabIndex = 7;
            // 
            // lbl_SymbolValue
            // 
            this.lbl_SymbolValue.BackColor = System.Drawing.Color.FloralWhite;
            this.lbl_SymbolValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_SymbolValue.Location = new System.Drawing.Point(87, 35);
            this.lbl_SymbolValue.Name = "lbl_SymbolValue";
            this.lbl_SymbolValue.Size = new System.Drawing.Size(67, 21);
            this.lbl_SymbolValue.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(263, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Avg Share Price:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(187, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Name:";
            // 
            // lbl_SharesOwned
            // 
            this.lbl_SharesOwned.BackColor = System.Drawing.Color.FloralWhite;
            this.lbl_SharesOwned.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_SharesOwned.Location = new System.Drawing.Point(123, 66);
            this.lbl_SharesOwned.Name = "lbl_SharesOwned";
            this.lbl_SharesOwned.Size = new System.Drawing.Size(135, 21);
            this.lbl_SharesOwned.TabIndex = 5;
            // 
            // lbl_CompName
            // 
            this.lbl_CompName.BackColor = System.Drawing.Color.FloralWhite;
            this.lbl_CompName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_CompName.Location = new System.Drawing.Point(253, 34);
            this.lbl_CompName.Name = "lbl_CompName";
            this.lbl_CompName.Size = new System.Drawing.Size(267, 21);
            this.lbl_CompName.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Shares Owned:";
            // 
            // StockView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(834, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lst_History);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_Stocks);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StockView";
            this.Text = "Stock View";
            this.Load += new System.EventHandler(this.StockView_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cht_IndivStock)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lst_Stocks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_CompName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_SymbolValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_SharesOwned;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_AvgPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lst_History;
        private System.Windows.Forms.DataVisualization.Charting.Chart cht_IndivStock;
    }
}