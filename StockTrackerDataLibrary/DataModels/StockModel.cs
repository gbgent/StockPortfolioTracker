using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackerDataLibrary.DataModels
{
    public class StockModel :IBasicStock

    {
        private int _stockId;
        private int _brokerId;
        private string _symbol;
        private string _name;

       

        public int StockId 
        {
            get { return _stockId; }
            set { _stockId = value; }
        }
        public int BrokerId  
        {
            get { return _brokerId; }
            set { _brokerId = value; }
        }          
        public string Symbol 
        {
            get { return _symbol; }
            set { _symbol = value; }
        }
        public string Name 
        {
            get { return _name; }
            set { _name = value; }
        }
        public string DisplayName 
        {
            get { return $"{_name} - {_symbol}"; }
        }         

        public List<TransactionModel> Transactions = new List<TransactionModel>();

        public ValueModel Value = new ValueModel();

        // Method to Load Transactions
        public void LoadTransactions()
        {
            this.Transactions = GlobalConfig.Connection.Transactions_SingleStock_Load(this.StockId);
        }

        // Method to Calculate Current Shares Owned
        public decimal SharesOwned()
        {
            decimal output = 0M;

            // Make sure Lastest Transaction List is Loaded
            LoadTransactions();

            foreach (TransactionModel t in Transactions)
            {
                if (t.Type == TransactionType.Buy)
                    output += t.Shares;
                else if (t.Type == TransactionType.Sale)
                    output -= t.Shares;
                else if (t.Type == TransactionType.Split)
                    output = t.Shares;
            }

            return output;
        }

        // Method to Calculate Average Share Price
        public decimal AvgPrice()
        {
            decimal output = 0M;
            decimal shares = SharesOwned();

            foreach (TransactionModel t in Transactions)
            {
                if (t.Type == TransactionType.Buy)
                    output += t.Cost;
                else if (t.Type == TransactionType.Sale)
                    output -= t.Cost;
                else if (t.Type == TransactionType.Split)
                    output = t.Cost;
            }

            return output/shares;
        }
    }

   
}
