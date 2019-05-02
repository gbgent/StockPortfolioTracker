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
        public StockModel Stock = new StockModel();
               
        BrokerageModel broker;

        TransactionType tType;

        STProcessor Processor = new STProcessor();

        // Default Constructor
        public StockUpdateForm()
        {
            InitializeComponent();           
        }
        
        // Preferred Constructor
        public StockUpdateForm(StockModel st, TransactionType type) // Will recieve the Basic Stock Data Class
        {
            InitializeComponent();
            
            //Set passed value to class variables
            Stock = st;
            tType = type;

            switch (tType)
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
        } // End Constructor

        /**************************
         * 
         * Methods for Setting up
         * Form for specific Function
         * 
         **************************/
        private void SetupDividend()
        {
            //Set Form Title
            this.Text = $"Enter Dividend for {Stock.Name}";

            // Hide the Shares Panels
            pnl_Split.Visible = false;
            pnl_Normal.Visible = false;
                     

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
            pnl_Normal.Visible = false;
            pnl_Split.Visible = true;

            //Hide the Broker Label and ComboBox
            lbl_Broker.Enabled = false;
            lbl_Broker.Visible = false;
            cb_Broker.Enabled = false;
            cb_Broker.Visible = false;
                    

            DisplayCurrentValue();
        }
    
        private void SetupUpdate()
        {
            //Set Form Title
            this.Text = $"Update Stock Price of {Stock.Name}";
            pnl_Split.Visible = false;

            //Change Panel Controls Properties
            Label lb = new Label();
            TextBox txbox = new TextBox();

            foreach (Control ctl in pnl_Normal.Controls)
            {
                if(ctl is Label)
                {
                    lb = (Label)ctl;
                }
                else if (ctl is TextBox)
                {
                    txbox = (TextBox)ctl;
                }
            }

           lb.Text = "New Value";
           
            // Disable Multi Purpose Text Box
            txbox.Enabled = false;

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
            pnl_Split.Visible = false;

            DisplayCurrentValue();

            List<BrokerageModel> brokers = GlobalConfig.Connection.Broker_GetAll();

            cb_Broker.DataSource = null;
            cb_Broker.DataSource = brokers;
            cb_Broker.DisplayMember = "BrokerageName";
            cb_Broker.ValueMember = "BrokerId";
        }

        private void SetupBuy()
        {
            //Set Form Title
            this.Text = $"Buy Additional Shares of {Stock.Name}";
            pnl_Split.Visible = false;
            
            DisplayCurrentValue();

            //Load Brokers in Combo Box
            List<BrokerageModel> brokers = GlobalConfig.Connection.Broker_GetAll();

            cb_Broker.DataSource = null;
            cb_Broker.DataSource = brokers;
            cb_Broker.DisplayMember = "BrokerageName";
            cb_Broker.ValueMember = "BrokerId";

        }

        //Display Shares Owned and Stock's Value
        private void DisplayCurrentValue()
        {
            List<ValuationModel> Valuations = new List<ValuationModel>();
            Valuations = GlobalConfig.Connection.Valuation_Stock(Stock.StockId);
            ValuationModel currentValue = Valuations.LastOrDefault();

            //Display Shares Owned and Stock's Value
            lbl_SharesOwned.Text = currentValue.Shares.ToString("n");
            lbl_CurrentValue.Text = currentValue.Value.ToString("c");

        }

        /**************************
         * 
         * Methods for Buttons
         * 
         **************************/

        // Cancel Button Click Event Handler
        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            // Close the Current Form
            this.Close();
            
        }

        // Save Button Click Event Handler
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            //Create Instances of Transaction and Valuation
            TransactionModel transaction = new TransactionModel();
            ValuationModel valuation = new ValuationModel();
            decimal shares = 0m;
            decimal price = Decimal.Parse(tx_TransPrice.Text);
            broker = (BrokerageModel)cb_Broker.SelectedItem;
                       
            switch (tType)
            {
                case TransactionType.Buy:
                    {
                        shares = GetShares();
                        //Load Information and Valuation into Correct variables
                        transaction = CreateTransaction(price, shares, broker.BrokerId);
                        valuation = CalculateCurrentValue(price, shares, broker.CommissionRate);

                        //Save Transaction and Valuation to Database
                        GlobalConfig.Connection.Transaction_AddNew(transaction);
                        
                        // Upate Valuations
                        Processor.UpDateValuations(valuation);
                        break;
                    }
                case TransactionType.Sale:
                    {
                        shares = GetShares();

                        //Load Information and Valuation into Correct variables
                        transaction = CreateTransaction(price, shares, broker.BrokerId);
                        valuation = CalculateCurrentValue(price, -shares);

                        //Save Transaction and Valuation to Database
                        GlobalConfig.Connection.Transaction_AddNew(transaction);
                        
                        // CUPdate valuations
                        Processor.UpDateValuations(valuation);
                        break;
                    }

                case TransactionType.Update:
                    {
                        //Load  Valuation into Correct variable
                        valuation = CalculateCurrentValue(price);
                        //Save Valuation to Database and Update other Stocks
                        Processor.UpDateValuations(valuation);
                        break;
                    }

                case TransactionType.Split:
                    {
                        // Uses Date, Price, Old Shares, New Shares
                        Decimal oldShares =0m, newShares = 0m;
                        decimal sharesowned = Decimal.Parse(lbl_SharesOwned.Text);

                        foreach (Control ctl in pnl_Split.Controls)
                        {
                            if (ctl is TextBox)
                            {
                                if (ctl.Name.Contains("Old"))
                                {
                                    oldShares = Decimal.Parse(ctl.Text);
                                }
                                else if (ctl.Name.Contains("New"))
                                {
                                    newShares = Decimal.Parse(ctl.Text);
                                }
                            }
                        }
                        //Create Transaction
                        transaction = CalcStockSplit(price, newShares, oldShares, sharesowned);
                        transaction.BrokerId = 4; // This should be 0 for stock splits and dividends

                        // Save Transaction
                        GlobalConfig.Connection.Transaction_AddNew(transaction);
                        break;
                    }

                case TransactionType.Dividend:
                    {
                        broker = GlobalConfig.Connection.Broker_GetAll().FirstOrDefault();
                        // Uses only Date and Price (Price is Dividend per Share)
                        transaction = CreateTransaction(price, 0, 0);
                        transaction.BrokerId = 4; // Set to Admin Broker Id
                        transaction.Fee = 0M; // Set to NO Broker Fee

                        GlobalConfig.Connection.Transaction_AddNew(transaction);
                        break;
                    }
            }            
        }

        // Method to Gather Transaction Information
        private TransactionModel CreateTransaction(decimal p, decimal s, int bId)
        {
            TransactionModel t = new TransactionModel();

            t.StockId = Stock.StockId;
            t.BrokerId = bId;
            t.Type = tType;
            t.Date = dtp_TransDate.Value.Date;
            t.Shares = s;
            t.Price = p;
            t.Fee = broker.CommissionRate;
            
            return t;
        }

        // Method to Update Current Valuation
        private ValuationModel CalculateCurrentValue(decimal p, decimal s= 0M, decimal f=0M)
        {             
            List<ValuationModel> values = GlobalConfig.Connection.Valuation_Stock(Stock.StockId);

            ValuationModel lastValue = values.LastOrDefault();
                        
            lastValue.Date = dtp_TransDate.Value.Date;
            lastValue.Shares += s;
            lastValue.Price = p;
            lastValue.Cost += (s * p) + f;

            return lastValue;
        }

        // Method to Handle Stock Splits
        // P = Price, NS = New Shares, OS = Old Shares, SO = Shares Owned
        private TransactionModel CalcStockSplit(decimal p, decimal ns, decimal os, decimal so)
        {
            // Record Transaction Information
            TransactionModel trans = new TransactionModel
            {
                StockId = Stock.StockId,
                BrokerId = 0,
                Type = tType,
                Date = dtp_TransDate.Value.Date,

                // New Shares will equal one of the following
                // if  New Share is greater than old shares
                //     return shares owned times new shares
                // else 
                //     return shares owned divided by old shares
                Shares = ns > os ? so * ns : so / os,
                Price = p,
                Fee = 0
            };

            return trans;
        }

        private void NumTextBox_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            decimal output;
            if (!Decimal.TryParse(tb.Text,out output))
            {
                MessageBox.Show("Please Enter A Number!!", "Invalid Input");
                tb.Text = string.Empty;
                tb.Focus();
            }
            if (tType == TransactionType.Update && tb.Name == "tx_TransPrice")
            {
                TextBox txtbox = new TextBox();
                foreach (Control ctl in pnl_Normal.Controls)
                {
                    if (ctl is TextBox)
                    {
                        txtbox = (TextBox)ctl;
                    }
                }

                decimal Shares = Decimal.Parse(lbl_SharesOwned.Text);
                decimal Price = Decimal.Parse(tx_TransPrice.Text);

                txtbox.Text = (Shares * Price).ToString("c");
            }
        }

        private decimal GetShares()
        {
            decimal output = 0m;

            foreach (Control ctl in pnl_Normal.Controls)
                if (ctl is TextBox)
                {
                    output = decimal.Parse(ctl.Text);
                }
            return output;
        }

       
    }//End Class
}//End NameSpace
