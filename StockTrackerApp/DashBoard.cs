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

namespace StockTrackerApp
{
    public partial class DashBoard : Form
    {
        List<BasicStockModel> stocks = new List<BasicStockModel>();
        BasicStockModel stock = new BasicStockModel();
        private IStockRequester callingForm;

        public DashBoard()
        {
            InitializeComponent();
        }

        public DashBoard(IStockRequester caller )
        {
            InitializeComponent();
            callingForm = caller;

        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            LoadPortfolio();
            UpdateDisplay();
            
        }

        private void UpdateDisplay()
        {
            lst_Portfolio.DataSource = null;
            lst_Portfolio.DataSource = stocks;
            lst_Portfolio.DisplayMember = "DisplayName";
            lst_Portfolio.SelectedIndex = 1;
            lst_Portfolio.SelectedIndex = 0;
        }

        private void LoadPortfolio()
        {
            //Test Load for Stocks
            LoadTestStocks();
           
        }
        private void lst_Portfolio_SelectedIndexChanged(object sender, EventArgs e)
        {
            BasicStockModel stock;
            stock = (BasicStockModel)lst_Portfolio.SelectedItem;

            //  ToDo - Fix Issue when Dashboard is Called
            // when either Stock View or Broker Form is open in the main panel.
            // Ie Second Call.  Error is "System.NullReferenceException: 'Object reference not set to an instance of an object.'"

            callingForm.StockSelected(stock);
                        
        }



        private void LoadTestStocks()
        {
            BasicStockModel stock1, stock2, stock3;
            stock1 = new BasicStockModel(1, "Apple", "APPL");
            stock2 = new BasicStockModel(2, "Coca-Cola", "COKE");
            stock3 = new BasicStockModel(3, "Ford", "F");
            stocks.Add(stock1);
            stocks.Add(stock2);
            stocks.Add(stock3);
        }

        
    }
}
