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

namespace StockTrackerApp
{
    public partial class DashBoard : Form
    {
        List<BasicStockModel> stocks = new List<BasicStockModel>();
        BasicStockModel stock = new BasicStockModel();

        public DashBoard()
        {
            InitializeComponent();
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
        }

        private void LoadPortfolio()
        {
            //Test Load for Stocks
            LoadTestStocks();
           
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
