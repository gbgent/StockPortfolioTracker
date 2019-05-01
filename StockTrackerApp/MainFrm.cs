using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockTrackerDataLibrary;
using StockTrackerDataLibrary.DataModels;
using StockTrackerProcessorLibrary;


namespace StockTrackerApp
{
    public partial class MainFrm : Form , IStockRequester
    {

        MyForms currentForm = MyForms.DashBoard;
        StockModel stock = new StockModel();
        IValueUpdater calledForm;

        public MainFrm() 
        {
            InitializeComponent();
        }
        
        private void MainFrm_Load(object sender, EventArgs e) 
        {
            // Create an Instance of the Dashboard
            DashBoard nForm = new DashBoard(this);
            currentForm = MyForms.DashBoard;
            calledForm = nForm;

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
            currentForm = MyForms.DashBoard;
            nForm.Show();
            // Toggle Menu Item Visibility            
            ToggleMenuItems(currentForm);
        }

        private void mnu_FileDashBoard_Click(object sender, EventArgs e) 
        {
            //Adjust The Visiblity of Menu Items
            mnu_FileDashBoard.Visible = false;
            mnu_Stock.Visible = true;
            mnu_FileBroker.Visible = true;
            mnu_Stock_View.Visible = true;
            
            //Cleare the main Panel of controls
            pnl_Main.Controls.Clear();

            
            // Create an Instance of the Dashboard
            DashBoard nForm = new DashBoard(this);

            calledForm = nForm;

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
            currentForm = MyForms.DashBoard;
            nForm.Show();
            ToggleMenuItems(currentForm);
        }

        private void mnu_FileBroker_Click(object sender, EventArgs e) 
        {
            pnl_Main.Controls.Clear();

            //Load an Instance of Brokerage Form
            BrokerageForm nForm = new BrokerageForm();

            // Remove the Top Level desingation for the Form
            nForm.TopLevel = false;

            //Set the Border Style to None to remove normal window Borders
            nForm.FormBorderStyle = FormBorderStyle.None;

            //Anchor Form for Expansion and contraction of window
            nForm.Anchor = (AnchorStyles.None );

            // Add Form to Panel then Show Form
            pnl_Main.Controls.Add(nForm);
            currentForm = MyForms.Broker;
            nForm.Show();
            ToggleMenuItems(currentForm);
        }

        private void mnu_FileExit_Click(object sender, EventArgs e) 
        {
            //Close the Application
            this.Close();
        }
 
        private void mnu_Stock_View_Click(object sender, EventArgs e) 
        {
            pnl_Main.Controls.Clear();

            //Create New instance of Form StockView
            StockView nForm = new StockView(stock,this);

            //Set CalledForm for the IValueUpdater Interface
            calledForm = nForm;

            // Remove the Top Level desingation for the Form
            nForm.TopLevel = false;

            //Set the Border Style to None to remove normal window Borders
            nForm.FormBorderStyle = FormBorderStyle.None;

            //Anchor Form for Expansion and contraction of window
            nForm.Anchor = (AnchorStyles.None);

            // Add Form to Panel then Show Form
            pnl_Main.Controls.Add(nForm);
            currentForm = MyForms.Stock;
            nForm.Show();
            ToggleMenuItems(currentForm);
        }

        private void mnu_StockUpdateSingle_Click(object sender, EventArgs e) 
        {
            //ToDo - code to find which Stock is Selected in dashboard
            //ToDo - get stock that is being viewed in Stock View

            //Create Instance of Pop Up Window Update Price
            StockUpdateForm frm = new StockUpdateForm(stock, TransactionType.Update);

            if (frm.ShowDialog() == DialogResult.OK & currentForm != MyForms.Broker)
            {
                calledForm.UpdateValue();
            }

        }
        
        private void mnu_Stock_Buy_Click(object sender, EventArgs e) 
        {
            //ToDo - code to find which Stock is Selected in dashboard
            //ToDo - get stock that is being viewed in Stock View

            //Create Instance of Pop Up Window Update Price
            StockUpdateForm frm = new StockUpdateForm(stock, TransactionType.Buy);

            //Check to see if Valuation Need to be Updated
            if (frm.ShowDialog() == DialogResult.OK & currentForm != MyForms.Broker)
            {
                calledForm.UpdateValue();
            }
        }

        private void mnu_Stock_Sale_Click(object sender, EventArgs e) 
        {
            //ToDo - code to find which Stock is Selected in dashboard
            //ToDo - get stock that is being viewed in Stock View

            //Create Instance of Pop Up Window Update Price
            StockUpdateForm frm = new StockUpdateForm(stock, TransactionType.Sale);

            //Check to see if Valuation Need to be Updated
            if (frm.ShowDialog() == DialogResult.OK & currentForm != MyForms.Broker)
            {
                calledForm.UpdateValue();
            }
        }

        private void mnu_Stock_Dividend_Click(object sender, EventArgs e) 
        {
            //ToDo - code to find which Stock is Selected in dashboard
            //ToDo - get stock that is being viewed in Stock View

            //Create Instance of Pop Up Window Update Price
            StockUpdateForm frm = new StockUpdateForm(stock, TransactionType.Dividend);

            //Check to see if Valuation Need to be Updated
            if (frm.ShowDialog() == DialogResult.OK & currentForm != MyForms.Broker)
            {
                calledForm.UpdateValue();
            }
        }

        private void mnu_Stock_Split_Click(object sender, EventArgs e) 
        {
            //ToDo - code to find which Stock is Selected in dashboard
            //ToDo - get stock that is being viewed in Stock View

            //Create Instance of Pop Up Window Update Price
            StockUpdateForm frm = new StockUpdateForm(stock, TransactionType.Split);

            //Check to see if Valuation Need to be Updated
            if (frm.ShowDialog() == DialogResult.OK & currentForm != MyForms.Broker)
            {
                calledForm.UpdateValue();
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            string msg = ($"Stock Tracker\n\n" +
                            "Version: 1.0\n" +
                            "By: Gerald B. Glass");

            MessageBox.Show(msg, "About");
        }


        private void ToggleMenuItems(MyForms thisForm)
        {
            switch (thisForm)
            {
                case MyForms.Broker:
                    mnu_FileBroker.Visible = false;
                    mnu_FileDashBoard.Visible = true;
                    mnu_Stock.Visible = false;
                    break;
                case MyForms.DashBoard:
                    mnu_FileBroker.Visible = true;
                    mnu_FileDashBoard.Visible = false;
                    mnu_Stock.Visible = true;
                    mnu_Stock_View.Visible = true;
                    break;
                case MyForms.Stock:
                    mnu_FileBroker.Visible = true;
                    mnu_FileDashBoard.Visible = true;
                    mnu_Stock.Visible = true;
                    mnu_Stock_View.Visible = false;
                    break;
            }
            
        }

        private BasicStockModel GetSelectedStock () 
        {
            BasicStockModel output = new BasicStockModel();            

            switch (currentForm)
            {
                case MyForms.DashBoard:
                    
                    break;
                case MyForms.Stock:
                    break;
                default:
                    break;
            }


            return output;
        }

        // Method to Determine Stock Selected for Stock Menu Items
        // Is return from either Dashboard or StockView when they
        // are in the pnl_Main Area
        public void StockSelected(StockModel model) 
        {
            stock = model;
        }
    }
}
