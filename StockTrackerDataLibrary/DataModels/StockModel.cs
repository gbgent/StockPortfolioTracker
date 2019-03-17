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

        public decimal Shares
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
                switch (trans.Type)
                {
                    case TransactionType.Buy:
                        output += trans.Shares;
                        break;
                    case TransactionType.Sale:
                        output -= trans.Shares;
                        break;
                    case TransactionType.Split:
                        output = trans.Shares;
                        break;
                }
            }

            return output;
        }
    }
}
