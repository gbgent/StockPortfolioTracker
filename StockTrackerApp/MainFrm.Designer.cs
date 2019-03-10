namespace StockTrackerApp
{
    partial class MainFrm
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
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.mnu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_FileDashBoard = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_FileBroker = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_FileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Stock_View = new System.Windows.Forms.ToolStripMenuItem();
            this.saleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_StockUpdateSingle = new System.Windows.Forms.ToolStripMenuItem();
            this.allStocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Stock_Buy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Stock_Sale = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Stock_Dividend = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Stock_Split = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_File,
            this.stockToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Margin = new System.Windows.Forms.Padding(3);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.MainMenu.Size = new System.Drawing.Size(837, 27);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // mnu_File
            // 
            this.mnu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_FileDashBoard,
            this.mnu_FileBroker,
            this.mnu_FileExit});
            this.mnu_File.Name = "mnu_File";
            this.mnu_File.Size = new System.Drawing.Size(39, 21);
            this.mnu_File.Text = "File";
            // 
            // mnu_FileDashBoard
            // 
            this.mnu_FileDashBoard.Name = "mnu_FileDashBoard";
            this.mnu_FileDashBoard.Size = new System.Drawing.Size(140, 22);
            this.mnu_FileDashBoard.Text = "DashBoard";
            this.mnu_FileDashBoard.Click += new System.EventHandler(this.mnu_FileDashBoard_Click);
            // 
            // mnu_FileBroker
            // 
            this.mnu_FileBroker.Name = "mnu_FileBroker";
            this.mnu_FileBroker.Size = new System.Drawing.Size(140, 22);
            this.mnu_FileBroker.Text = "Broker";
            this.mnu_FileBroker.Click += new System.EventHandler(this.mnu_FileBroker_Click);
            // 
            // mnu_FileExit
            // 
            this.mnu_FileExit.Name = "mnu_FileExit";
            this.mnu_FileExit.Size = new System.Drawing.Size(140, 22);
            this.mnu_FileExit.Text = "&Exit";
            this.mnu_FileExit.Click += new System.EventHandler(this.mnu_FileExit_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Stock_View,
            this.saleToolStripMenuItem,
            this.mnu_Stock_Buy,
            this.mnu_Stock_Sale,
            this.mnu_Stock_Dividend,
            this.mnu_Stock_Split});
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(51, 21);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // mnu_Stock_View
            // 
            this.mnu_Stock_View.Name = "mnu_Stock_View";
            this.mnu_Stock_View.Size = new System.Drawing.Size(180, 22);
            this.mnu_Stock_View.Text = "View";
            this.mnu_Stock_View.Click += new System.EventHandler(this.mnu_Stock_View_Click);
            // 
            // saleToolStripMenuItem
            // 
            this.saleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_StockUpdateSingle,
            this.allStocksToolStripMenuItem});
            this.saleToolStripMenuItem.Name = "saleToolStripMenuItem";
            this.saleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saleToolStripMenuItem.Text = "Update";
            // 
            // mnu_StockUpdateSingle
            // 
            this.mnu_StockUpdateSingle.Name = "mnu_StockUpdateSingle";
            this.mnu_StockUpdateSingle.Size = new System.Drawing.Size(180, 22);
            this.mnu_StockUpdateSingle.Text = "Single";
            this.mnu_StockUpdateSingle.Click += new System.EventHandler(this.mnu_StockUpdateSingle_Click);
            // 
            // allStocksToolStripMenuItem
            // 
            this.allStocksToolStripMenuItem.Name = "allStocksToolStripMenuItem";
            this.allStocksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.allStocksToolStripMenuItem.Text = "All Stocks";
            // 
            // mnu_Stock_Buy
            // 
            this.mnu_Stock_Buy.Name = "mnu_Stock_Buy";
            this.mnu_Stock_Buy.Size = new System.Drawing.Size(180, 22);
            this.mnu_Stock_Buy.Text = "Buy";
            // 
            // mnu_Stock_Sale
            // 
            this.mnu_Stock_Sale.Name = "mnu_Stock_Sale";
            this.mnu_Stock_Sale.Size = new System.Drawing.Size(180, 22);
            this.mnu_Stock_Sale.Text = "Sale";
            // 
            // mnu_Stock_Dividend
            // 
            this.mnu_Stock_Dividend.Name = "mnu_Stock_Dividend";
            this.mnu_Stock_Dividend.Size = new System.Drawing.Size(180, 22);
            this.mnu_Stock_Dividend.Text = "Dividend";
            // 
            // mnu_Stock_Split
            // 
            this.mnu_Stock_Split.Name = "mnu_Stock_Split";
            this.mnu_Stock_Split.Size = new System.Drawing.Size(180, 22);
            this.mnu_Stock_Split.Text = "Split";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // pnl_Main
            // 
            this.pnl_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Main.Location = new System.Drawing.Point(13, 44);
            this.pnl_Main.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(811, 500);
            this.pnl_Main.TabIndex = 1;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 566);
            this.Controls.Add(this.pnl_Main);
            this.Controls.Add(this.MainMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.MainMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(853, 604);
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Tracker";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnu_File;
        private System.Windows.Forms.ToolStripMenuItem mnu_FileDashBoard;
        private System.Windows.Forms.ToolStripMenuItem mnu_FileBroker;
        private System.Windows.Forms.ToolStripMenuItem mnu_FileExit;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_Stock_View;
        private System.Windows.Forms.ToolStripMenuItem saleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_StockUpdateSingle;
        private System.Windows.Forms.ToolStripMenuItem allStocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_Stock_Buy;
        private System.Windows.Forms.ToolStripMenuItem mnu_Stock_Sale;
        private System.Windows.Forms.ToolStripMenuItem mnu_Stock_Dividend;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.ToolStripMenuItem mnu_Stock_Split;
    }
}

