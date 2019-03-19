using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackerDataLibrary
{
    //Enumerated Type for Stock Transactions
    public enum TransactionType
    {
        Buy = 1,
        Sale,
        Update,
        Split,
        Dividend          
    }

    //Enumerated Type of Databases.  Set up for
    //future expansion, ie Text, MySql, Azure, Amazon, etc
    public enum DatabaseType
    {
        Sql
    }
}
