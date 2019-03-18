using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockTrackerProccesorLibrary;
using StockTrackerDataLibrary;
using StockTrackerDataLibrary.DataModels;


namespace StockTrackerApp
{
    public partial class MainFrm : Form
    {
        BasicStockModel stock = new BasicStockModel(); 
        public MainFrm()
        {
            InitializeComponent();

            //Load testing Data
            LoadTestData();
        }

        private void LoadTestData()
        {
            stock.StockId = 1;
            stock.Symbol = "APPL";
            stock.Name = "Apple";
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            // Create an Instance of the Dashboard
            DashBoard nForm = new DashBoard();

            //Set New Form to show in Display
            // UpdateMainFormPanel(ref Form DisplayFrm);
            // Remove the Top Level desingation for the Form
            nForm.TopLevel = false;

            //Set the Border Style to None to remove normal window Borders
            nForm.FormBorderStyle = FormBorderStyle.None;

            //Anchor Form for Expansion and contraction of window
            nForm.Anchor = (AnchorStyles.Bottom |
                                          AnchorStyles.Left |
                                          AnchorStyles.Top |
                                          AnchorStyles.Right);

            // Add Form to Panel then Show Form
            pnl_Main.Controls.Add(nForm);
            nForm.Show();
        }

        private void mnu_FileDashBoard_Click(object sender, EventArgs e)
        {
            pnl_Main.Controls.Clear();

            // Create an Instance of the Dashboard
            DashBoard nForm = new DashBoard();

            //Set New Form to show in Display
            // UpdateMainFormPanel(ref Form DisplayFrm);
            // Remove the Top Level desingation for the Form
            nForm.TopLevel = false;

            //Set the Border Style to None to remove normal window Borders
            nForm.FormBorderStyle = FormBorderStyle.None;

            //Anchor Form for Expansion and contraction of window
            nForm.Anchor = (AnchorStyles.Bottom |
                            AnchorStyles.Left |
                            AnchorStyles.Top |
                            AnchorStyles.Right);

            // Add Form to Panel then Show Form
            pnl_Main.Controls.Add(nForm);
            nForm.Show();
        }

        private void mnu_FileBroker_Click(object sender, EventArgs e)
        {
            pnl_Main.Controls.Clear();

            BrokerForm nForm = new BrokerForm();

            // Remove the Top Level desingation for the Form
            nForm.TopLevel = false;

            //Set the Border Style to None to remove normal window Borders
            nForm.FormBorderStyle = FormBorderStyle.None;

            //Anchor Form for Expansion and contraction of window
            nForm.Anchor = (AnchorStyles.None );

            // Add Form to Panel then Show Form
            pnl_Main.Controls.Add(nForm);
            nForm.Show();

        }

        private void mnu_FileExit_Click(object sender, EventArgs e)
        {
            //Close the Application
            this.Close();
        }

        private void mnu_StockUpdateSingle_Click(object sender, EventArgs e)
        {
            //ToDo - code to find which Stock is Selected in dashboard
            //ToDo - get stock that is being viewed in Stock View

            //Create Instance of Pop Up Window Update Price
            StockUpdateForm frm = new StockUpdateForm(stock,TransactionType.Update);

            frm.ShowDialog();

        }

        private void mnu_Stock_View_Click(object sender, EventArgs e)
        {
            pnl_Main.Controls.Clear();

            //ToDo - Add coding to find the selected stock

            StockView nForm = new StockView(stock);

            // Remove the Top Level desingation for the Form
            nForm.TopLevel = false;

            //Set the Border Style to None to remove normal window Borders
            nForm.FormBorderStyle = FormBorderStyle.None;

            //Anchor Form for Expansion and contraction of window
            nForm.Anchor = (AnchorStyles.None);

            // Add Form to Panel then Show Form
            pnl_Main.Controls.Add(nForm);
            nForm.Show();
        }

        private void mnu_Stock_Buy_Click(object sender, EventArgs e)
        {
            //ToDo - code to find which Stock is Selected in dashboard
            //ToDo - get stock that is being viewed in Stock View

            //Create Instance of Pop Up Window Update Price
            StockUpdateForm frm = new StockUpdateForm(stock, TransactionType.Buy);

            frm.ShowDialog();
        }

        private void mnu_Stock_Sale_Click(object sender, EventArgs e)
        {
            //ToDo - code to find which Stock is Selected in dashboard
            //ToDo - get stock that is being viewed in Stock View

            //Create Instance of Pop Up Window Update Price
            StockUpdateForm frm = new StockUpdateForm(stock, TransactionType.Sale);

            frm.ShowDialog();
        }

        private void mnu_Stock_Dividend_Click(object sender, EventArgs e)
        {
            //ToDo - code to find which Stock is Selected in dashboard
            //ToDo - get stock that is being viewed in Stock View

            //Create Instance of Pop Up Window Update Price
            StockUpdateForm frm = new StockUpdateForm(stock, TransactionType.Dividend);

            frm.ShowDialog();
        }

        private void mnu_Stock_Split_Click(object sender, EventArgs e)
        {
            //ToDo - code to find which Stock is Selected in dashboard
            //ToDo - get stock that is being viewed in Stock View

            //Create Instance of Pop Up Window Update Price
            StockUpdateForm frm = new StockUpdateForm(stock, TransactionType.Split);

            frm.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string msg = ($"Stock Tracker\n\n" +
                            "Version: 1.0\n" +
                            "By: Gerald B. Glass");

            MessageBox.Show(msg, "About");
        }
    }
}
