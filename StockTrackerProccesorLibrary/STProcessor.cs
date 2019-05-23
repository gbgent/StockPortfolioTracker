using StockTrackerDataLibrary;
using StockTrackerDataLibrary.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace StockTrackerProcessorLibrary
{
    public class STProcessor
    {
        PortFolioModel pf = new PortFolioModel();

        // Update Database of Stock Valuations
        public void UpDateValuations(ValuationModel model)  
        {
            // Check to see if Stock has Valuation for This Date
            List<ValuationModel> lvalues = GlobalConfig.Connection.Valuation_Stock(model.StockId);

            foreach (ValuationModel val in lvalues)
            {
                if (model.Date == val.Date) // Update this Valuation
                {
                    GlobalConfig.Connection.Stock_Valuation_Update(model);
                }
                else if (val == lvalues.LastOrDefault()) // Add new Valuation
                {
                    GlobalConfig.Connection.Valuation_AddNew(model);
                }
            }

            // Check Other Stocks Owned for Valuation on This Date

            List<StockModel> Stocks = GlobalConfig.Connection.Stocks_LoadAll();


            // Loop Through Each Stock Owned
            foreach (StockModel st in Stocks)
            {
                // Skip the Stock that was passed in
                if (st.StockId == model.StockId) continue;

                //Load All Valuations for this stock
                List<ValuationModel> stValues = GlobalConfig.Connection.Valuation_Stock(st.StockId);

                ValuationModel preValue = stValues.FirstOrDefault(); // Assign PreValue to first value
                                
                foreach (ValuationModel vModel in stValues)
                {
                    // If vModel date is less than model Date
                    // Assign to vModel to Previous Value
                    // And proceed to next record
                    if (vModel.Date < model.Date && vModel != stValues.LastOrDefault())
                        preValue = vModel;  

                    // If vModel Date equal Model Date Stock has valuation for this date
                    // Go To Next STock to check
                    else if (vModel.Date == model.Date)
                    {
                        break;
                    }
                    else  // vModel Date is Greater Than model Date
                    {
                        // Check For Model is Less than previous Date
                        // If true, Stock was purchased after Model's Date
                        if( model.Date < preValue.Date)
                        {
                            break;
                        }
                        else  // Model Date is between 
                        {
                            // Keep all of Previous Record Data
                            // except Date 
                            preValue.Date = model.Date;

                            // Add new Valuation Record
                            GlobalConfig.Connection.Valuation_AddNew(preValue);

                            break;
                        }                 
                    }                    
                }
            }
        }

        // Loads a List Box with the Stock Portfolio
        public void LoadPortfolioList(ref ListBox li) 
        {
            // Clear Data Source
            li.DataSource = null;

            //Reload Data Source
            li.DataSource = pf.Stocks;
            li.DisplayMember = "DisplayName";
            li.ValueMember = "StockId";

        }

        /// <summary>Plots points for Stock Valuation on Chart
        /// </summary>
        /// <param name="chart">Chart to Update</param>
        /// <param name="values">Valuations to Plot</param>
        public void ChartUpdate(ref Chart chart ,List<ChartModel> values)
        {
            // Clear the Chart Data
            chart.DataSource = null;

            // Load Chart with new values
            chart.DataSource = values;

            //Set up X Axis
            chart.Series["Value"].XValueMember = "Date";
            chart.Series["Value"].XValueType = System.Windows.Forms.DataVisualization.
                                                Charting.ChartValueType.DateTime;
            chart.Series["Cost"].XValueMember = "Date";
            chart.Series["Cost"].XValueType = System.Windows.Forms.DataVisualization.
                                                Charting.ChartValueType.DateTime;

            //Set up Y Axis
            chart.Series["Value"].YValueMembers = "Value";
            chart.Series["Value"].YValueType = System.Windows.Forms.DataVisualization.
                                                Charting.ChartValueType.Double;
            chart.Series["Cost"].YValueMembers = "Cost";
            chart.Series["Cost"].YValueType = System.Windows.Forms.DataVisualization.
                                                   Charting.ChartValueType.Double;
        }

        public ComboBox LoadBrokerComboBox()
        {
            ComboBox output = new ComboBox();

            //Ensure Combo Box is Empty
            output.DataSource = null;

            //Load Brokers into ComboBox
            output.DataSource = GlobalConfig.Connection.Broker_GetAll();

            //Assign Display and Value Members
            output.DisplayMember = "BrokerName";
            output.ValueMember = "BrokerId";

            //Return ComboBox
            return output;
        }
    }
}
