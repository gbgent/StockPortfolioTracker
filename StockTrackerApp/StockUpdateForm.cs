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

        BrokerageModel broker;

        TransactionType tType;

        public StockUpdateForm()
        {
            InitializeComponent();           
        }
                
        public StockUpdateForm(BasicStockModel st, TransactionType type) // Will recieve the Basic Stock Data Class
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

        private void SetupDividend()
        {
            //Set Form Title
            this.Text = $"Enter Dividend for {Stock.Name}";

            //Hide Multi Purpose Label and Textbox
            //Change Panel Controls Properties
            Label lb = new Label();
            TextBox txbox = new TextBox();

            foreach (Control ctl in pnl_Normal.Controls)
            {
                if (ctl is Label)
                {
                    lb = (Label)ctl;
                }
                else if (ctl is TextBox)
                {
                    txbox = (TextBox)ctl;
                }
            }
            lb.Visible = false;
            txbox.Visible = false;

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
            pnl_Split.Visible = false;
            
            DisplayCurrentValue();
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

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            // Close the Current Form
            this.Close();
            
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            //Create Instances of Transaction and Valuation
            TransactionModel transaction = new TransactionModel();
            ValuationModel valuation = new ValuationModel();
            decimal shares = 0M;
            decimal price = Decimal.Parse(tx_TransPrice.Text);
            broker = (BrokerageModel)cb_Broker.SelectedItem;

            foreach (Control ctl in pnl_Normal.Controls)
            {
                if(ctl is TextBox)
                {
                    shares = Decimal.Parse(ctl.Text);
                }
            }

            switch (tType)
            {
                case TransactionType.Buy:

                    //Load Information and Valuation into Correct variables
                    transaction = RetrieveTransactionData(shares, price);                   
                    valuation = CalculateCurrentValue(shares, price, broker.CommissionRate);

                    //Save Transaction and Valuation to Database
                    GlobalConfig.Connection.Transaction_AddNew(transaction);
                    GlobalConfig.Connection.Valuation_AddNew(valuation);

                    break;

                case TransactionType.Sale:
                    //Load Information and Valuation into Correct variables
                    transaction = RetrieveTransactionData(price, shares);
                    valuation = CalculateCurrentValue(price,  -shares);

                    //Save Transaction and Valuation to Database
                    GlobalConfig.Connection.Transaction_AddNew(transaction);
                    GlobalConfig.Connection.Valuation_AddNew(valuation);

                    break;

                case TransactionType.Update:
                    //Load  Valuation into Correct variable
                    valuation = CalculateCurrentValue(price);
                    //Save Valuation to Database
                    GlobalConfig.Connection.Valuation_AddNew(valuation);
                    break;

                case TransactionType.Split:
                   // Uses Date, Price, Old Shares, New Shares
                   Decimal oldShares, newShares = 0m;

                    foreach (Control ctl in pnl_Split.Controls)
                    {
                        if(ctl is TextBox)
                        {
                            if(ctl.Name.Contains("Old"))
                            {
                                oldShares = Decimal.Parse(ctl.Text);
                            }
                            else if (ctl.Name.Contains("New"))
                            {
                                newShares = Decimal.Parse(ctl.Text);
                            }
                        }
                    }
                    break;

                case TransactionType.Dividend:
                    // Uses only Date and Price (Price is Dividend per Share)
                    break;
            }            
        }

        // Method to Gather Transaction Information
        private TransactionModel RetrieveTransactionData(decimal p, decimal s)
        {
            TransactionModel t = new TransactionModel
            {
                StockId = Stock.StockId,
                BrokerId = broker.BrokerId,
                Type = tType,
                Date = dtp_TransDate.Value.Date,
                Shares = s,
                Price = p,
                Fee = broker.CommissionRate
            };

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
        private void CalcStockSplit(decimal p, decimal ns, decimal os, decimal so)
        {
            // Record Transaction Information
            TransactionModel trans = new TransactionModel
            {
                StockId = Stock.StockId,
                BrokerId = 0,
                Type = tType,
                Date = dtp_TransDate.Value.Date,

                // New Shares will equal one of the following
                // if ration  New Share is greater than old shares
                //     return shares owned times new shares
                // else 
                //     return shares owned divided by old shares
                Shares = ns > os ? so * ns : so / os,
                Price = p,
                Fee = 0
            };
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tx_TransPrice_Leave(object sender, EventArgs e)
        {
            if (tType == TransactionType.Update)
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
    }//End Class
}//End NameSpace
