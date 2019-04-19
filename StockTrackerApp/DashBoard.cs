﻿using StockTrackerDataLibrary.DataModels;
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

namespace StockTrackerApp
{
    public partial class DashBoard : Form, IValueUpdater
    {
        List<BasicStockModel> StocksList = new List<BasicStockModel>();
        BasicStockModel stock = new BasicStockModel();
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
            lst_Portfolio.SelectedIndex = 1;
            lst_Portfolio.SelectedIndex = 0;
        }

        private void LoadPortfolio()
        {
            //Test Load for Stocks
            LoadTestStocks();

            // ToDo - Add Code to load Portfolio from Database
            //StocksList = StockList_LoadAll();

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


        // Test Data for Creation and testing
        // Of program.  Used until testing of 
        // Data base.
        private void LoadTestStocks()
        {
            BasicStockModel stock1, stock2, stock3;
            stock1 = new BasicStockModel(1, "Apple", "APPL");
            stock2 = new BasicStockModel(2, "Coca-Cola", "COKE");
            stock3 = new BasicStockModel(3, "Ford", "F");
            StocksList.Add(stock1);
            StocksList.Add(stock2);
            StocksList.Add(stock3);
        }

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

                //Reload Chart
            }
        }

        public void UpdateValue()
        {
            MessageBox.Show("Received Call to Update Portfolio Value");
        }

        // ToDo - Work on Portfolio Evaulation
        // ToDo - Wire up the Chart

    }
}
