using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackerDataLibrary.DataModels
{
    public class StockModel : BasicStockModel, IValuation
    {
        private ValuationModel _valuation = new ValuationModel();

        public DateTime Date
        {
            get
            {
                _valuation = CurrentValue(StockId); //May place into a constructor
                return _valuation.Date;
            }            
        }

        public decimal Shares
        {
            get { return _valuation.Shares; }
        }

        public decimal Price
        {
            get { return _valuation.Price; }
        }

        public decimal Value
        {
            get { return _valuation.Value; }
        }

        
        public decimal AvgPrice
        { get; }
        
        //ToDo - Add Method to Determine Total Cost of Shares Purchased

        static private ValuationModel CurrentValue(int id)
        {
            // Local Variables
            ValuationModel temp = new ValuationModel();
            List<ValuationModel> output = new List<ValuationModel>();
            List<TransactionModel> transactions = new List<TransactionModel>();

            //ToDo - Add Data Connection

            foreach (TransactionModel item in transactions)
            {
                //Process each Transaction by type
                temp = ProcessTransaction(item, temp);

            }

            // Add Valuation Model to the List of Valuation model
            // (returns only the latest Valuation Value.
            output.Add(temp);

            return output.LastOrDefault();
        }

        static private ValuationModel ProcessTransaction(TransactionModel tModel, ValuationModel vModel)
        {   /*  This procedure steps through each transaction for a 
            *   thiswstock and then adjusts the number of shares owned
            *   and the price at the time of the transaction.  This is done
            *   using the Enumerated TransactionType which was made global.
            */
            switch (tModel.Type)
            {
                case TransactionType.Buy:
                    vModel.Shares += tModel.Shares;  // Add shares to shares owned
                    vModel.Price = tModel.Price;     // Change Current Price per share
                    vModel.Date = tModel.Date;
                    break;
                case TransactionType.Sale:
                    vModel.Shares -= tModel.Shares;  // Subtract Shares from shares owned
                    vModel.Price = tModel.Price;     // Change the current price per share
                    vModel.Date = tModel.Date;
                    break;
                case TransactionType.Split:
                    vModel.Shares = tModel.Shares;   // Set Shares to number after slpit
                    vModel.Price = tModel.Price;     // Change the current price to price after split
                    vModel.Date = tModel.Date;
                    break;
                case TransactionType.Update:
                    vModel.Price = tModel.Price;     // Change current price to updated price
                    vModel.Date = tModel.Date;
                    break;
            }

            return vModel;
        }
    }
}
