namespace StockTrackerApp
{
    partial class DashBoard
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
            this.lst_Portfolio = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lnk_AddNew = new System.Windows.Forms.LinkLabel();
            this.cht_ValueGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_CurrentValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cht_ValueGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // lst_Portfolio
            // 
            this.lst_Portfolio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lst_Portfolio.BackColor = System.Drawing.Color.FloralWhite;
            this.lst_Portfolio.FormattingEnabled = true;
            this.lst_Portfolio.ItemHeight = 21;
            this.lst_Portfolio.Location = new System.Drawing.Point(13, 74);
            this.lst_Portfolio.Name = "lst_Portfolio";
            this.lst_Portfolio.Size = new System.Drawing.Size(187, 382);
            this.lst_Portfolio.TabIndex = 0;
            this.lst_Portfolio.SelectedIndexChanged += new System.EventHandler(this.lst_Portfolio_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stocks Owned";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnk_AddNew
            // 
            this.lnk_AddNew.AutoSize = true;
            this.lnk_AddNew.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnk_AddNew.Location = new System.Drawing.Point(103, 54);
            this.lnk_AddNew.Name = "lnk_AddNew";
            this.lnk_AddNew.Size = new System.Drawing.Size(97, 17);
            this.lnk_AddNew.TabIndex = 2;
            this.lnk_AddNew.TabStop = true;
            this.lnk_AddNew.Text = "Add New Stock";
            this.lnk_AddNew.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_AddNew_LinkClicked);
            // 
            // cht_ValueGraph
            // 
            this.cht_ValueGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cht_ValueGraph.BackColor = System.Drawing.Color.AntiqueWhite;
            chartArea2.AxisY.IsStartedFromZero = false;
            chartArea2.BackColor = System.Drawing.Color.FloralWhite;
            chartArea2.BackSecondaryColor = System.Drawing.Color.FloralWhite;
            chartArea2.BorderWidth = 2;
            chartArea2.Name = "ChartArea1";
            this.cht_ValueGraph.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.AntiqueWhite;
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.IsTextAutoFit = false;
            legend2.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend2.Name = "Legend1";
            legend2.Position.Auto = false;
            legend2.Position.Height = 4F;
            legend2.Position.Width = 45.03043F;
            legend2.Position.X = 25F;
            legend2.Position.Y = 96F;
            this.cht_ValueGraph.Legends.Add(legend2);
            this.cht_ValueGraph.Location = new System.Drawing.Point(206, 13);
            this.cht_ValueGraph.Name = "cht_ValueGraph";
            this.cht_ValueGraph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.MidnightBlue;
            series3.Legend = "Legend1";
            series3.LegendText = "Valuation";
            series3.Name = "Value";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Red;
            series4.Legend = "Legend1";
            series4.LegendText = "Total Cost";
            series4.Name = "Costs";
            this.cht_ValueGraph.Series.Add(series3);
            this.cht_ValueGraph.Series.Add(series4);
            this.cht_ValueGraph.Size = new System.Drawing.Size(620, 473);
            this.cht_ValueGraph.TabIndex = 3;
            this.cht_ValueGraph.Text = "Portfolio Valuation";
            title2.BorderWidth = 2;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Portfolio Valuation";
            title2.Text = "Portfolio Value";
            this.cht_ValueGraph.Titles.Add(title2);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.Location = new System.Drawing.Point(9, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Value";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_CurrentValue
            // 
            this.lbl_CurrentValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_CurrentValue.BackColor = System.Drawing.Color.FloralWhite;
            this.lbl_CurrentValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_CurrentValue.Location = new System.Drawing.Point(73, 463);
            this.lbl_CurrentValue.Name = "lbl_CurrentValue";
            this.lbl_CurrentValue.Size = new System.Drawing.Size(127, 28);
            this.lbl_CurrentValue.TabIndex = 5;
            this.lbl_CurrentValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(838, 500);
            this.Controls.Add(this.lbl_CurrentValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cht_ValueGraph);
            this.Controls.Add(this.lnk_AddNew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_Portfolio);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cht_ValueGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_Portfolio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnk_AddNew;
        private System.Windows.Forms.DataVisualization.Charting.Chart cht_ValueGraph;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_CurrentValue;
    }
}