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
using StockTrackerProccesorLibrary;
using StockTrackerDataLibrary.Connectors;
using StockTrackerDataLibrary;

namespace StockTrackerApp
{
    public partial class DashBoard : Form, IValueUpdater
    {
        List<BasicStockModel> StocksList = new List<BasicStockModel>();
        BasicStockModel stock = new BasicStockModel();
        List<ChartModel> ChartValuations = new List<ChartModel>();

        private IStockRequester callingForm;

        // Default Constructor
        public DashBoard()
        {
            InitializeComponent();
        }

        // Constructor when Called from Another Form
        public DashBoard(IStockRequester caller )
        {
            InitializeComponent();
            callingForm = caller;

        }

        // Load Dashboard with Portfolio Information
        private void DashBoard_Load(object sender, EventArgs e)
        {
            LoadPortfolio();
            UpdateDisplay();   
            
        }

        // Update the Form
        private void UpdateDisplay()
        {
            lst_Portfolio.DataSource = null;
            lst_Portfolio.DataSource = StocksList;
            lst_Portfolio.DisplayMember = "DisplayName";
            lst_Portfolio.SelectedIndex = 0;
                        
            lbl_CurrentValue.Text= PortfolioValuation().ToString("C2");

            LoadPortfolioValuations();
            UpdateChart();
        }

        // Load Portfolio from Database
        private void LoadPortfolio()
        {
            StocksList = GlobalConfig.Connection.Stocks_LoadAll();
        }

        // Event Handler for when Stock Selection Changes
        // Passes the Stock back to the Calling Form (usually Main Form)
        private void lst_Portfolio_SelectedIndexChanged(object sender, EventArgs e)
        {
            BasicStockModel stock;
            stock = (BasicStockModel)lst_Portfolio.SelectedItem;

            //  ToDo - Fix Issue when Dashboard is Called
            // when either Stock View or Broker Form is open in the main panel.
            // Ie Second Call.  Error is "System.NullReferenceException: 'Object reference not set to an instance of an object.'"

            callingForm.StockSelected(stock);                        
        }        

        // Add New Stock Method
        private void lnk_AddNew_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewStockForm pForm = new NewStockForm();
            DialogResult result = new DialogResult();


            result = pForm.ShowDialog();

            // Check if new stock was added
            if (result == DialogResult.OK)
            {
                //Reload Portfolio
                LoadPortfolio();
                //Update Portfolio Value
                UpdateDisplay();
                //Reload Chart
            }
        }

        public void UpdateValue()
        {
            MessageBox.Show("Received Call to Update Portfolio Value");
        }

        // Total Portfolio Valuation
        private decimal PortfolioValuation()
        {
            // Local List to determine Current Portfolio Value
            List<ValuationModel> values = new List<ValuationModel>();

            // Retrieve the Last Valuation for Each Stock Owned
            foreach (BasicStockModel smodel in StocksList)
            {
                List<ValuationModel> vals;

                vals = GlobalConfig.Connection.Valuation_Stock(smodel.StockId);

                values.Add(vals.LastOrDefault());                
            }

            decimal total = 0;

            //Calculate the Value of the Portfolio
            foreach (ValuationModel model in values)
            {
                total += model.Value;
            }

            return total;

        }

        // Load Portfolio Valuations for Charting
        private void LoadPortfolioValuations()
        {
            List<ValuationModel> values;
            DateTime workingDate;
            ChartModel _chart = new ChartModel();

            decimal total = 0;

            values = GlobalConfig.Connection.Valuation_LoadAll();

            // ToDo - Fix Date Transfer From SQL to C#

            workingDate = values.First().ValuationDate;

            foreach (ValuationModel model in values)
            {
                if (model.ValuationDate == workingDate)
                {
                    total += model.Value;
                }
                else
                {
                    _chart.Vdate = workingDate;
                    _chart.Value = total;

                    ChartValuations.Add(_chart);

                    workingDate = model.ValuationDate;
                    total = model.Value;

                }
            }

        }

        // Wire up the Chart
        private void UpdateChart()
        {
            // Clear Data Source
            cht_ValueGraph.DataSource = null;

            cht_ValueGraph.DataSource = ChartValuations;
            cht_ValueGraph.Series["Value"].XValueMember = "Vdate";
            cht_ValueGraph.Series["Value"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            cht_ValueGraph.Series["Value"].YValueMembers = "Value";
            cht_ValueGraph.Series["Value"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
        }
    }
}
