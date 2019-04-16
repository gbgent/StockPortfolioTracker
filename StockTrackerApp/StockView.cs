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
        StockModel stock = new StockModel();

        public StockView()
        {
            InitializeComponent();
            //ToDo - Load List of Stocks Owned
                    
            
        }

        public StockView(BasicStockModel st)
        {
            InitializeComponent();
            
            stock.StockId = st.StockId;
            stock.Name = st.Name;
            stock.Symbol = st.Symbol;
        }

        public void UpdateValue()
        {
            MessageBox.Show("Received Call to Update Portfolio Value");
        }

        private void StockView_Load(object sender, EventArgs e)
        {
            UpdateDiplay(stock);

        }
        private void UpdateDiplay(StockModel model)
        {
            if(model != null)
            {
                lbl_SymbolValue.Text = model.Symbol;
                lbl_CompName.Text = model.Name;
                lbl_SharesOwned.Text = model.Shares.ToString("n4");
                lbl_AvgPrice.Text = model.AvgPrice.ToString("n4");
            }
        }

     
    }
}
