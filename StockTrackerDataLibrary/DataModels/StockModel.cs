using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackerDataLibrary.DataModels
{
    public class StockModel : BasicStockModel

    {
        public List<TransactionModel> Transactions = new List<TransactionModel>();
    }
}
