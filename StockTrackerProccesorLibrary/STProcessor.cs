using StockTrackerDataLibrary;
using StockTrackerDataLibrary.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockTrackerProcessorLibrary
{
    public class STProcessor
    {
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

    }
}
