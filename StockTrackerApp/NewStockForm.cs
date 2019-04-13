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
    public partial class NewStockForm : Form
    {
        List<BrokerageModel> Brokers = new List<BrokerageModel>();

        public NewStockForm()
        {
            InitializeComponent();
        }

        private void NewStockForm_Load(object sender, EventArgs e)
        {
            //Load Brokers
            //Add Brokers to Combo Box
            LoadBrokers();
        }



        private void btn_SearchSymbol_Click(object sender, EventArgs e)
        {
            // Use Web Api to find stock based on Stock Symbol
            // This to remain hidden until I find the proper Api
        }

        private void btn_SearchCompany_Click(object sender, EventArgs e)
        {
            //Use Web Api to Find Stock based on Company Name
            // This to remain hidden until I find the proper Api
        }

        // This method loads Brokerage Combo Box with
        // a list of brokerages
        private void LoadBrokers()
        {
            UseTempValues();
            //Clear the Current Data form Combo Box
            cb_Brokerage.DataSource = null;

            // Add the new list of Brokers
            cb_Brokerage.DataSource = Brokers;
            cb_Brokerage.DisplayMember = "BrokerageName";

        }

        // Return to Dashboard, no Information Saved
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            // Close this Form 
            this.Close();
        }

        //Clear the existing form
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            // Clear all Text Boxes

            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox)
                    ctl.Text = string.Empty;
                else if (ctl is DateTimePicker)
                {
                    //Create a Temp Date Time Picker Variable
                    DateTimePicker dtp = (DateTimePicker)ctl;

                    //Assign Current Date
                    dtp.Value = DateTime.Now;
                }
            }

            cb_Brokerage.SelectedIndex = 0;
        }

        private void UseTempValues()
        {
            BrokerageModel item1 = new BrokerageModel();
            BrokerageModel item2 = new BrokerageModel();

            item1.BrokerId = 1;
            item1.BrokerageName = "Ameritrade";
            item1.CommissionRate = 6.95M;

            item2.BrokerId = 2;
            item2.BrokerageName = "Etrade";
            item2.CommissionRate = 7.95M;

            Brokers.Add(item1);
            Brokers.Add(item2);
        }
    }
}
