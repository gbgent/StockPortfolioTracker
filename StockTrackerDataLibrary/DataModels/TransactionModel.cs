using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackerDataLibrary.DataModels
{
    public class TransactionModel
    {
        private int _transactionId;
        private DateTime _tDate;
        private decimal _shares;
        private decimal _price;
        private decimal _fee;

        public int TransactionId
        {
            get { return _transactionId; }
            set { _transactionId = value; }
        }        
       
        public int StockId;

        public int BrokerId;

        public TransactionType Type;

        public DateTime Date
        {
            get { return _tDate; }
            set { _tDate = value; }
        }
        
        public decimal Shares
        {
            get { return _shares; }
            set { _shares = value; }
        }
        
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
        
        public decimal Fee
        {
            get { return _fee; }
            set { _fee = value; }
        }

    }
}
