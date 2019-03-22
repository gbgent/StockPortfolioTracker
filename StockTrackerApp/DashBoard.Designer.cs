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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lst_Portfolio = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lnk_AddNew = new System.Windows.Forms.LinkLabel();
            this.cht_Portfolio = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cht_Portfolio)).BeginInit();
            this.SuspendLayout();
            // 
            // lst_Portfolio
            // 
            this.lst_Portfolio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lst_Portfolio.FormattingEnabled = true;
            this.lst_Portfolio.ItemHeight = 21;
            this.lst_Portfolio.Location = new System.Drawing.Point(13, 74);
            this.lst_Portfolio.Name = "lst_Portfolio";
            this.lst_Portfolio.Size = new System.Drawing.Size(250, 382);
            this.lst_Portfolio.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stocks Owned";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnk_AddNew
            // 
            this.lnk_AddNew.AutoSize = true;
            this.lnk_AddNew.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnk_AddNew.Location = new System.Drawing.Point(166, 54);
            this.lnk_AddNew.Name = "lnk_AddNew";
            this.lnk_AddNew.Size = new System.Drawing.Size(97, 17);
            this.lnk_AddNew.TabIndex = 2;
            this.lnk_AddNew.TabStop = true;
            this.lnk_AddNew.Text = "Add New Stock";
            // 
            // cht_Portfolio
            // 
            this.cht_Portfolio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.cht_Portfolio.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.cht_Portfolio.Legends.Add(legend2);
            this.cht_Portfolio.Location = new System.Drawing.Point(294, 74);
            this.cht_Portfolio.Name = "cht_Portfolio";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            this.cht_Portfolio.Series.Add(series2);
            this.cht_Portfolio.Size = new System.Drawing.Size(494, 382);
            this.cht_Portfolio.TabIndex = 3;
            this.cht_Portfolio.Text = "chart1";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.Location = new System.Drawing.Point(13, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Current Valuation";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.Location = new System.Drawing.Point(161, 463);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "1,234,567.89";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cht_Portfolio);
            this.Controls.Add(this.lnk_AddNew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_Portfolio);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cht_Portfolio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_Portfolio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnk_AddNew;
        private System.Windows.Forms.DataVisualization.Charting.Chart cht_Portfolio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}