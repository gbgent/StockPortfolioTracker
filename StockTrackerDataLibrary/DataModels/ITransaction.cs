using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackerDataLibrary.DataModels
{
    public interface ITransaction
    {
        int TransactionId { get; set; }

        TransactionType Type { get; set; }

        DateTime Date { get; set; }

        decimal Shares { get; set; }

        decimal Price { get; set; }

        decimal Fee { get; set; }

        decimal Cost { get; }
    }
}
