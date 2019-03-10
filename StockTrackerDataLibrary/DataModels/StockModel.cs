using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackerDataLibrary.DataModels
{
    public class StockModel
    {
        public BasicStockModel Stock;

        public List<BrokerageModel> Brokers;              

        public decimal MyProperty
        {
            get { return TotalShares(); }            
        }

        private List<TransactionModel> Transactions;


        //Private Methods

        //Method Total Shares
        //Returns the total Shares Currently Owned

        private decimal TotalShares()
        {
            decimal output = 0;

            foreach (TransactionModel trans in Transactions)
            {
                //ToDo - Finish ForEach Loop after Creating Transaction Types
                //Select STatement on Transaction Type
                //Case Buy - Add to Shares
                //Case Sale - Subtract for Shares
                //Case Split - Shares equal Trans action Shares
                //Default do nothing
            }

            return output;
        }
    }
}
