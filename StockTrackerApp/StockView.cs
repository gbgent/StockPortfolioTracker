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
    public partial class StockView : Form, IValueUpdater, IStockRequester
    {
        
        PortFolioModel Portfolio = new PortFolioModel();
        StockModel Stock;
        List<ChartModel> ChartValues;
        bool FirstLoad = false;

        private IStockRequester callingForm;

        public StockView()
        {
            InitializeComponent();
            Stock = new StockModel();
        }

        public StockView(StockModel st, IStockRequester caller)
        {
            InitializeComponent();
            callingForm = caller;
            Stock = new StockModel();
            Stock = st;            
            Stock.Value.SetID(Stock.StockId);
            FirstLoad = true;
        }

        private void StockView_Load(object sender, EventArgs e)
        {
            // Load Stock Portfoilo List
            LoadPortfolioList();

            //Update Display
            UpdateDisplay();
        }

        // Method to Update all Information in Form
        private void UpdateDisplay()
        {
            
            //Load and Display Selected Stock Information            
            Stock.LoadTransactions();
            ShowStockInfo();

            // Display Transaction List
            DisplayTransactionHistory();
            
            // Display Chart
            LoadChartingValues();
            UpdateChart();
        }

        // Method to Display Basic Stock Information
        private void ShowStockInfo()
        {
            // Add Values to Labels
            if (Stock != null)
            {
                lbl_SymbolValue.Text = Stock.Symbol;
                lbl_CompName.Text = Stock.Name;
                lbl_SharesOwned.Text = Stock.SharesOwned().ToString("N4");
                lbl_AvgPrice.Text = Stock.AvgPrice().ToString("N4");
            }
        }

        // Method to Display All Stock Transactions (excluding Price Updates)
        private void DisplayTransactionHistory()
        {
            // Clear List data source
            lst_History.DataSource = null;

            // Add new data source
            lst_History.DataSource = Stock.Transactions;
            lst_History.DisplayMember = "DisplayHistory";
            lst_History.ValueMember = "TransactionId";
            lst_History.SelectedIndex = -1;
        }

            /************************
             *
             * Event Handlers  methods 
             * for Form Controls
             * 
             ************************/

         
        private void lst_Stocks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!FirstLoad) //Check for Non Focus Change
            {
                // Create New INstance of Stock Model
                Stock = new StockModel();

                // Assign Selected stock to local variable Stock
                StockModel bStock = (StockModel)lst_Stocks.SelectedItem;

                StockSelected(bStock);
                                
                Stock.StockId = bStock.StockId;
                Stock.BrokerId = bStock.BrokerId;
                Stock.Symbol = bStock.Symbol;
                Stock.Name = bStock.Name;
                //FirstLoad = true;
                UpdateDisplay();
            }
        }

        // Method to Receive
        public void UpdateValue()
        {
            UpdateDisplay();
        }
        
       // Method to load List of Stocks for lst_Stocks ListBox
        private void LoadPortfolioList()  //Good
        { 
            // Clear Data Source
            lst_Stocks.DataSource = null;

            //Add New Data Source
            lst_Stocks.DataSource = Portfolio.Stocks;
            lst_Stocks.DisplayMember = "DisplayName";
            lst_Stocks.ValueMember = "StockId";
            lst_Stocks.SelectedValue = Stock.StockId;
            FirstLoad = false;
        } 


        private void LoadChartingValues()
        {
            ChartValues = new List<ChartModel>();
            ChartModel _chartValue;
            int counter = 0;

            List<ValuationModel> values = Stock.Value.HistoryAll;
                        
            foreach (ValuationModel vm in values)
            {
                // Initialize _chartValue
                _chartValue = new ChartModel();

                _chartValue.Date = vm.Date;
                _chartValue.Value = vm.Value;
                _chartValue.Cost = vm.Cost;

                ChartValues.Insert(counter, _chartValue);

                counter++;
            }
        }

        private void UpdateChart ()
        {
            cht_IndivStock.DataSource = null;

            // Set up the X Axis 
            cht_IndivStock.DataSource = ChartValues;
            cht_IndivStock.Series["Value"].XValueMember = "Date";
            cht_IndivStock.Series["Value"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            cht_IndivStock.Series["Cost"].XValueMember = "Date";
            cht_IndivStock.Series["Cost"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;

            //Set UP Y Axis
            cht_IndivStock.Series["Value"].YValueMembers = "Value";
            cht_IndivStock.Series["Value"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            cht_IndivStock.Series["Cost"].YValueMembers = "Cost";
            cht_IndivStock.Series["Cost"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;


        }

        public void StockSelected(StockModel stock)
        {
            callingForm.StockSelected(stock);
        }
    }
}
