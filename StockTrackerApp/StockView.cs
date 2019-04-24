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
        List<BasicStockModel> stocks;
        StockModel stock = new StockModel();
        List<ChartModel> ChartValues;


        public StockView()
        {
            InitializeComponent();
        }

        public StockView(BasicStockModel st)
        {
            InitializeComponent();

            stock.StockId = st.StockId;
            stock.Name = st.Name;
            stock.Symbol = st.Symbol;
        }

        private void StockView_Load(object sender, EventArgs e)
        {
            // Load all stocks owned
            LoadStocks();

            //Update Display
            UpdateDiplay(stock);

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

                stock.StockId = bStock.StockId;
                stock.BrokerId = bStock.BrokerId;
                stock.Symbol = bStock.Symbol;
                stock.Name = bStock.Name;

                UpdateDiplay(stock);
            }
        }


        public void UpdateValue()
        {
            UpdateDiplay(stock);
        }


        /************************
          *
          * Private Methods 
          * 
          ************************/

        private void UpdateDiplay(StockModel model)
        {
            //Load Transaction History
            model.Transactions = LoadTransactions(model);

            decimal shares = CalcSharesOwned(model.Transactions);

            decimal avgPrice = CalcAvgSharePrice(model.Transactions,shares);

            // Add Values to Labels
            if (model != null)
            {
                lbl_SymbolValue.Text = model.Symbol;
                lbl_CompName.Text = model.Name;
                lbl_SharesOwned.Text = shares.ToString("N4");
                lbl_AvgPrice.Text = avgPrice.ToString("N4");
            }

            // Display Chart
            LoadChartingValues();
            UpdateChart();
        }

        // Method to load LIst of Stocks
        private void LoadStocks()
        {
            // Load Basic Stock List
            stocks = GlobalConfig.Connection.Stocks_LoadAll();

            // Update lst_stocks
            lst_Stocks.DataSource = null;
            lst_Stocks.DataSource = stocks;
            lst_Stocks.DisplayMember = "DisplayName";
            lst_Stocks.ValueMember = "StockId";
            lst_Stocks.SelectedIndex = -1;
        }

        // Method to Load Stocks Transactions
        private List<TransactionModel> LoadTransactions(StockModel m)
        {
            List<TransactionModel> Transactions;

            // Load Transaction List
            Transactions = GlobalConfig.Connection.Transactions_SingleStock_Load(m.StockId);

            lst_History.DataSource = null;
            lst_History.DataSource = Transactions;
            lst_History.DisplayMember = "DisplayHistory";
            lst_History.SelectedIndex = -1;

            return Transactions;

        }

        private decimal CalcSharesOwned(List<TransactionModel> trans)
        {
            decimal output = 0M;

            foreach (TransactionModel t in trans)
            {
                output += t.Shares;
            }

            return output;
        }

        private decimal CalcAvgSharePrice(List<TransactionModel> trans, decimal sh)
        {
            decimal output = 0M;

            foreach (TransactionModel t in trans)
            {
                output += t.Cost;
            }

            return output / sh;
        }

        private void LoadChartingValues()
        {
            ChartValues = new List<ChartModel>();
            ChartModel _chartValue;
            int counter = 0;
            
            List<ValuationModel> values = GlobalConfig.Connection.Valuation_Stock(stock.StockId);
            
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
