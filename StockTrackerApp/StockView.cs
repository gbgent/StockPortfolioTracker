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
    public partial class StockView : Form, IValueUpdater
    {
        
        PortFolioModel Portfolio = new PortFolioModel();
        StockModel Stock = new StockModel();
        List<ChartModel> ChartValues;


        public StockView()
        {
            InitializeComponent();
        }

        public StockView(BasicStockModel st)
        {
            InitializeComponent();

            Stock.StockId = st.StockId;
            Stock.Name = st.Name;
            Stock.Symbol = st.Symbol;
        }

        private void StockView_Load(object sender, EventArgs e)
        {
            //Update Display
            UpdateDisplay();
        }

        // Method to Update all Information in Form
        private void UpdateDisplay()
        {
            // Load and Display Stock Portfolio
            Portfolio.Load();
            LoadPortfolioList();
            
            //Load and Display Selected Stock Information            
            this.Stock.LoadTransactions();
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
        }

            /************************
             *
             * Event Handlers  methods 
             * for Form Controls
             * 
             ************************/
        private void lst_Stocks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_Stocks.SelectedIndex >= 0) //Check for Non Focus Change
            {
                // Assign Selected stock to local variable Stock
                BasicStockModel bStock = (BasicStockModel)lst_Stocks.SelectedItem;

                Stock.StockId = bStock.StockId;
                Stock.BrokerId = bStock.BrokerId;
                Stock.Symbol = bStock.Symbol;
                Stock.Name = bStock.Name;

                UpdateDisplay();
            }
        }

        // Method to Receive
        public void UpdateValue()
        {
            UpdateDisplay();
        }
        
       // Method to load List of Stocks for lst_Stocks ListBox
        private void LoadPortfolioList()
        { 
            // Clear Data Source
            lst_Stocks.DataSource = null;

            //Add New Data Source
            lst_Stocks.DataSource = Portfolio.Stocks;
            lst_Stocks.DisplayMember = "DisplayName";
            lst_Stocks.ValueMember = "StockId";
            lst_Stocks.SelectedIndex = -1;
        } 


        private void LoadChartingValues()
        {
            ChartValues = new List<ChartModel>();
            ChartModel _chartValue;
            int counter = 0;

            List<ValuationModel> values = Stock.Value.HistoryAll(Stock);
                        
            foreach (ValuationModel vm in values)
            {
                // Initialize _chartValue
                _chartValue = new ChartModel();

                _chartValue.Vdate = vm.Date;
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
            cht_IndivStock.Series["Value"].XValueMember = "Vdate";
            cht_IndivStock.Series["Value"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            cht_IndivStock.Series["Cost"].XValueMember = "Vdate";
            cht_IndivStock.Series["Cost"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;

            //Set UP Y Axis
            cht_IndivStock.Series["Value"].YValueMembers = "Value";
            cht_IndivStock.Series["Value"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            cht_IndivStock.Series["Cost"].YValueMembers = "Cost";
            cht_IndivStock.Series["Cost"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;


        }
    }
}
