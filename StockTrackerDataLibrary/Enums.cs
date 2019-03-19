using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackerDataLibrary
{
    public enum TransactionType
    {
        Buy = 1,
        Sale,
        Update,
        Split,
        Dividend          
    }

    public enum MyForms
    {
        DashBoard = 1,
        Broker,
        Stock
    }
}
