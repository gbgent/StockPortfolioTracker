using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockTrackerDataLibrary;
using StockTrackerDataLibrary.DataModels;


namespace StockTrackerProccesorLibrary
{
    public class ValuationMethods
    {
        // Stock Value Calculation for Entire Ownership
        public List<ValuationModel> StockValue(BasicStockModel model)
        {
            // Local Variables
            ValuationModel temp = new ValuationModel();
            List<ValuationModel> output = new List<ValuationModel>();
            List<TransactionModel> transactions = new List<TransactionModel>();
            
            //ToDo - Add Data Connection

            foreach( TransactionModel item in transactions)
            {
                //Process each Transaction by type
                temp = ProcessTransaction(item, temp);
                               
            }

            // Add Valuation Model to the List of Valuation model
            // (returns only the latest Valuation Value.
            output.Add(temp);

            return output;
        }

        // Stock Value Calculation to a specific date
        public List<ValuationModel> StockValue(BasicStockModel model, DateTime endDate)
        {
            // Local Variables
            ValuationModel temp = new ValuationModel();
            List<ValuationModel> output = new List<ValuationModel>();
            List<TransactionModel> transactions = new List<TransactionModel>();

            //ToDo - Add Data Connection

            foreach (TransactionModel item in transactions)
            {
                // Process only those transaction from beginning to 
                // the provided date
                while (item.Date <= endDate)

                {
                    //Process each Transaction by type
                    temp = ProcessTransaction(item, temp);
                }
            }

            // Add Valuation Model to the List of Valuation model
            // (returns the Valuation Value for the specific date)
            output.Add(temp);


            return output;
        }


        // Stock Value Calculation for a Date Range
        public List<ValuationModel> StockValue(BasicStockModel model, DateTime startDate, DateTime endDate)
        {
            // Local Variables
            ValuationModel temp = new ValuationModel();
            List<ValuationModel> output = new List<ValuationModel>();
            List<TransactionModel> transactions = new List<TransactionModel>();

            //ToDo - Add Data Connection

            foreach (TransactionModel item in transactions)
            {
                // Check for transactions before Start Date
                if (item.Date < startDate)
                    //Determine the Starting Valuation
                    temp = ProcessTransaction(item, temp);
                else if (item.Date >= startDate &&  item.Date <= endDate)
                {
                    // Add Last Valuation to List
                    output.Add(temp);

                    // Process each Transaction by type
                    temp = ProcessTransaction(item, temp);
                }
            }

            // Add the last valuation to the list
            output.Add(temp);

            return output;
        }

        public decimal PortfolioValue(List<BasicStockModel> stocks)
        {
            //Local Variables
            
            decimal output =0;
            
             // Get 

            return output;
        }

        private ValuationModel ProcessTransaction(TransactionModel tModel, ValuationModel vModel)
        {        
            switch (tModel.Type)
                {
                    case TransactionType.Buy:  
                        vModel.Shares += tModel.Shares;  // Add shares to shares owned
                        vModel.Price = tModel.Price;     // Change Current Price per share
                        vModel.ValuationDate = tModel.Date;
                        break;
                    case TransactionType.Sale:
                        vModel.Shares -= tModel.Shares;  // Subtract Shares from shares owned
                        vModel.Price = tModel.Price;     // Change the current price per share
                        vModel.ValuationDate = tModel.Date;
                        break;
                    case TransactionType.Split:
                        vModel.Shares = tModel.Shares;   // Set Shares to number after slpit
                        vModel.Price = tModel.Price;     // Change the current price to price after split
                        vModel.ValuationDate = tModel.Date;
                        break;
                    case TransactionType.Update:
                        vModel.Price = tModel.Price;     // Change current price to updated price
                    vModel.ValuationDate = tModel.Date;
                        break;
                }

            return vModel;
        }
    }
}
