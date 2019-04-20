using StockTrackerDataLibrary;
using StockTrackerDataLibrary.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockTrackerApp
{
    public partial class NewStockForm : Form
    {
        // Class Variables
        List<BrokerageModel> Brokers = new List<BrokerageModel>();
        BasicStockModel stock = new BasicStockModel();
        TransactionModel trans = new TransactionModel();
        ValuationModel value = new ValuationModel();


        // Error Messages
        const string MissingDataMsg = "All Fields Must be Filled In";
        
        // Default Constructor
        public NewStockForm()
        {
            InitializeComponent();
        }

        // On Load Method
        private void NewStockForm_Load(object sender, EventArgs e)
        {
            // Load Broker Combo Box with List of Brokers
            LoadBrokers();
        }

        // Method to handle Search Symbol Button
        private void btn_SearchSymbol_Click(object sender, EventArgs e)
        {
            // Use Web Api to find stock based on Stock Symbol
            // This to remain hidden until I find the proper Api
        }

        // Method to handle Search Company Button
        private void btn_SearchCompany_Click(object sender, EventArgs e)
        {
            //Use Web Api to Find Stock based on Company Name
            // This to remain hidden until I find the proper Api
        }
        
        // Method to handle Save Button Click
        private void btn_Save_Click(object sender, EventArgs e)
        {
            // ToDo - Add Error Checking for Existing Stock

            // Check that All Fields have values
            if (IsMissingInput())
            {
                DisplayError(MissingDataMsg);
                this.DialogResult = DialogResult.None;
            }
            else
            {
                // Gather Information 
                GatherStockInfo();

                // Save Basic Stock Info to Database
                GlobalConfig.Connection.Stocks_AddNew(stock);

                // Gather Transaction Information
                GatherTransactionInfo();
                // Save Transaction to Database
                GlobalConfig.Connection.Transaction_AddNew(trans);

                // Gater Valuation Information
                GatherValuationInfo();

                // Save Valuation to Database
                GlobalConfig.Connection.Valuation_AddNew(value);
            }

        }

        // Return to Dashboard, no Information Saved
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            // Close this Form 
            this.Close();
        }

        // Clear the existing form
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            // Clear all Text Boxes

            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox)
                    ctl.Text = string.Empty;
                else if (ctl is DateTimePicker)
                {
                    //Create a Temp Date Time Picker Variable
                    DateTimePicker dtp = (DateTimePicker)ctl;

                    //Assign Current Date
                    dtp.Value = DateTime.Now;
                }
            }

            cb_Brokerage.SelectedIndex = 0;
        }

        // This method loads Brokerage Combo Box with
        // a list of brokerages
        private void LoadBrokers()
        {
            List<BrokerageModel> Brokers = new List<BrokerageModel>();

            // Retrieve Brokers from Database
            Brokers = GlobalConfig.Connection.Broker_GetAll();

            //Clear the Current Data form Combo Box
            cb_Brokerage.DataSource = null;

            // Add the new list of Brokers
            cb_Brokerage.DataSource = Brokers;
            cb_Brokerage.DisplayMember = "BrokerageName";
            cb_Brokerage.ValueMember = "BrokerId";
            cb_Brokerage.SelectedIndex = 0;

        }

        // Method to Check All Fields have Values
        private bool IsMissingInput()
        {
            bool output = false;

            foreach (Control ctl in Controls)
            {
                if (ctl is TextBox & ctl.Text == string.Empty)
                {
                    output = true;
                }
            }
            return output;
        }

        // Method to Display Errors
        private void DisplayError(string msg)
        {
            MessageBox.Show(msg, "Error");
        }

        // Method to gather information from Fields
        private void GatherStockInfo()
        {
            // Information for the Stock
            stock.BrokerId= int.Parse(cb_Brokerage.SelectedValue.ToString());
            stock.Symbol = txt_Symbol.Text;
            stock.Name = txt_Company.Text;

            
        }

        // Method to Gather Information for Transaction
        private void GatherTransactionInfo()
        {
            // Get the broker Information
            BrokerageModel broker;
            broker = (BrokerageModel)cb_Brokerage.SelectedItem;

            //Information for the Purchase Transaction
            trans.StockId = stock.StockId;
            trans.BrokerId = stock.BrokerId;
            trans.Type = TransactionType.Buy;
            trans.Date = dtp_Purchase.Value.Date;
            trans.Shares = decimal.Parse(txt_Shares.Text);
            trans.Price = decimal.Parse(txt_Price.Text);
            trans.Fee = broker.CommissionRate;
        }

        // Method to Gather Valuation Information of Transaction
        private void GatherValuationInfo()
        {
            value.StockId = stock.StockId;
            value.ValuationDate = trans.Date;
            value.Shares = trans.Shares;
            value.Price = trans.Price;
        }
    }
}
