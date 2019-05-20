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
using StockTrackerProcessorLibrary;
using StockTrackerDataLibrary.Connectors;
using StockTrackerDataLibrary;

namespace StockTrackerApp
{
    public partial class DashBoard : Form, IValueUpdater, IStockRequester
    {
        PortFolioModel Portfolio= new PortFolioModel(); //Automaticallly Loads Stocks
        StockModel stock = new StockModel();

        List<ChartModel> ChartValuations = new List<ChartModel>();

        STProcessor proc = new STProcessor();
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
            // Load Stock Portfolio List on Form
            UpdatePortfolioList();

            UpdateDisplay();               
        }

        private void UpdatePortfolioList()
        {
            //Load Portfolio List Box
            proc.LoadPortfolioList(ref lst_Portfolio);

            // Set Portfolio to first stock
            lst_Portfolio.SelectedIndex = 0;
        }
        // Update the Form
        private void UpdateDisplay()
        {
            // Display the Current Value of the Portfolio
            lbl_CurrentValue.Text = Portfolio.CurrentValue.ToString("C2");

            //LoadPortfolioValuations();

            UpdateChart();
        }
       
        // Event Handler for when Stock Selection Changes
        // Passes the Stock back to the Calling Form (usually Main Form)
        private void lst_Portfolio_SelectedIndexChanged(object sender, EventArgs e)
        {
            StockModel stock;
            stock = (StockModel)lst_Portfolio.SelectedItem;

            callingForm.StockSelected(stock);                        
        }        

        // Add New Stock Method
        private void lnk_AddNew_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewStockForm pForm = new NewStockForm(this);
            DialogResult result = new DialogResult();


            result = pForm.ShowDialog();

            // Check if new stock was added
            if (result == DialogResult.OK)
            {
                //Update Portfolio
                UpdatePortfolioList();

                // Update Remainder of Display
                UpdateDisplay();                
            }
        }

        public void UpdateValue()
        {
            UpdateDisplay();
        }      
        
        // Wire up the Chart
        private void UpdateChart()
        {
            proc.ChartUpdate(ref cht_ValueGraph,Portfolio.ChartingValuesAll)
        }

        public void StockSelected(StockModel stock)
        {
            Portfolio = new PortFolioModel();

            // Load Stock Portfolio List on Form
            UpdatePortfolioList();

            UpdateDisplay();

        }
    }
}
