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
        Sale = 2,
        Update = 3,
        Split = 4,
        Dividend = 5          
    }

    public enum MyForms
    {
        DashBoard = 1,
        Broker = 2,
        Stock = 3
    }

    // This Enum is for the Database Connections
    // It is set up to allow for expansion to
    // another Database, IE MYSql, Amazon, MariaDb, etc.
    public enum DatabaseType
    {
        Sql = 1
    }
}
