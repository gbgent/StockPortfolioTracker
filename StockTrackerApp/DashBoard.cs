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

namespace StockTrackerApp
{
    public partial class DashBoard : Form
    {
        List<BasicStockModel> Stocks = new List<BasicStockModel>();

        public DashBoard()
        {
            InitializeComponent();
        }

        private void loadlstPortfolio ()
        {
            //Load Test Items
            LoadTestData();

            lst_Portfolio.DataSource = null;
            lst_Portfolio.DataSource = Stocks;
            lst_Portfolio.DisplayMember = "DisplayName";
            lst_Portfolio.SelectedIndex = -1;
        }

        private void LoadTestData()
        {
            BasicStockModel stock1, stock2, stock3;
            Stocks.Add(stock1 = new BasicStockModel("APPL", "Apple"));
            Stocks.Add(stock2 = new BasicStockModel("COKE", "Coca-Cola"));
            Stocks.Add(stock3 = new BasicStockModel("F", "Ford"));

        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            loadlstPortfolio();
        }
    }
}
