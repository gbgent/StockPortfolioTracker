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
    public partial class StockView : Form
    {
        BasicStockModel stock;

        public StockView()
        {
            InitializeComponent();
            //ToDo - Load List of Stocks Owned
            //ToDo - Display sent Stock Information
            
        }

        public StockView(BasicStockModel st)
        {
            InitializeComponent();

            stock = st;
        }

        private void UpdateDisplay (BasicStockModel model)
        {
            lbl_SymbolValue.Text = model.Symbol;
            lbl_CompName.Text = model.Name;

        }

        private void StockView_Load(object sender, EventArgs e)
        {
            UpdateDisplay(stock);
        }
    }
}
