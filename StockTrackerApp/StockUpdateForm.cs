﻿using System;
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
using StockTrackerProccesorLibrary;


namespace StockTrackerApp
{
    /******Stock Pop Window
     *  This Form acts like a MessageBox but will receive input from user.
     *  It should only be used with the ShowDiaglog method when displaying.
     *  
     *  This Form will be used for the following Stock Options
     *        1) Purchase Additional Shares
     *        2) Sale Owned Shares
     *        3) Update Current Price
     *        4) Record Stock Split
     *        5) Record Dividend Payment
     *  
     *  This form will recieve a Stock's information by receiving BasicStockModel Data
     *  In addition it requires the Transaction Enumerated Type be sent.
     *  
     *  
     *********/
    public partial class StockUpdateForm : Form
    {
        // Class Level Variables
        public BasicStockModel Stock = new BasicStockModel();

        public StockUpdateForm()
        {
            InitializeComponent();
            Stock.SetTemp();
            SetupDividend();
        }
                
        public StockUpdateForm(BasicStockModel st, TransactionType type) // Will recieve the Basic Stock Data Class
        {
            InitializeComponent();
            
            //Set Stock to passed value
           Stock = st;

            switch (type)
            {
                case TransactionType.Buy:
                    SetupBuy();
                    break;
                case TransactionType.Sale:
                    SetupSale();
                    break;
                case TransactionType.Update:
                    SetupUpdate();
                    break;
                case TransactionType.Split:
                    SetupSplit();
                    break;
                case TransactionType.Dividend:
                    SetupDividend();
                    break;
            }
        } // End Ctor

        private void SetupDividend()
        {
            //Set Form Title
            this.Text = $"Enter Dividend for {Stock.Name}";

            //Hide Multi Purpose Label and Textbox
            lbl_MultiPurpose.Visible = false;
            tx_MultiPurpose.Visible = false;

            //Change Text for Price Label
            lbl_Price.Text = "Div/Share";


            //Hide the Broker Label and ComboBox
            lbl_Broker.Enabled = false;
            lbl_Broker.Visible = false;
            cb_Broker.Enabled = false;
            cb_Broker.Visible = false;

            //Adjust the Height of Form
            this.Height = this.Height - lbl_Broker.Height;

            DisplayCurrentValue();
        }

        private void SetupSplit()
        {
            //Set Form Title
            this.Text = $"Enter Stock Split for {Stock.Name}";

            //Change Text of Multi Purpose Label
            lbl_MultiPurpose.Text = "Old Shares";

            //Change Text for Price Label
            lbl_Price.Text = "New Shares";

           
            //Hide the Broker Label and ComboBox
            lbl_Broker.Enabled = false;
            lbl_Broker.Visible = false;
            cb_Broker.Enabled = false;
            cb_Broker.Visible = false;

            //Adjust the Height of Form
            this.Height = this.Height - lbl_Broker.Height;

            DisplayCurrentValue();
        }
    

        private void SetupUpdate()
        {
            //Set Form Title
            this.Text = $"Update Stock Price of {Stock.Name}";

            //Change Text of Multi Purpose Label
            lbl_MultiPurpose.Text = "New Value";

            // Disable Multi Purpose Text Box
            tx_MultiPurpose.Enabled = false;

            //Hide the Broker Label and ComboBox
            lbl_Broker.Enabled = false;
            lbl_Broker.Visible = false;
            cb_Broker.Enabled = false;
            cb_Broker.Visible = false;

            //Adjust the Height of Form
            this.Height = this.Height - lbl_Broker.Height;

            DisplayCurrentValue();
        }

        private void SetupSale()
        {
            //Set Form Title
            this.Text = $"Sale Shares of {Stock.Name}";

            //Hide the Broker Label and ComboBox
            lbl_Broker.Enabled = false;
            lbl_Broker.Visible = false;
            cb_Broker.Enabled = false;
            cb_Broker.Visible = false;

            //Adjust the Height of Form
            this.Height = this.Height - lbl_Broker.Height;

            DisplayCurrentValue();
        }

        private void SetupBuy()
        {
            //Set Form Title
            this.Text = $"Buy Additional Shares of {Stock.Name}";

            //Hide the Broker Label and ComboBox
            lbl_Broker.Enabled = false;
            lbl_Broker.Visible = false;
            cb_Broker.Enabled = false;
            cb_Broker.Visible = false;

            //Adjust the Height of Form
            this.Height = this.Height - lbl_Broker.Height;
            
            DisplayCurrentValue();
        }

        //Display Shares Owned and Stock's Value
        private void DisplayCurrentValue()
        {
            List<ValuationModel> Valuations = new List<ValuationModel>();
            Valuations = ValuationMethods.StockValue(Stock);
            ValuationModel currentValue = Valuations.LastOrDefault();

            //Display Shares Owned and Stock's Value
            lbl_SharesOwned.Text = currentValue.Shares.ToString("n");
            lbl_CurrentValue.Text = currentValue.Value.ToString("c");

        }

    }//End Class
}//End NameSpace