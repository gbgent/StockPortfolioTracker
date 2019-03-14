using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackerDataLibrary.DataModels
{
    class ValuationModel : IBasicStock, IValuation
    {
        private string _symbol;
        private string _name;
        private DateTime _date;
        private decimal _value;

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

        public DateTime ValuationDate
        {
            get { return _date; }
            set { _date = value; }
        }

        public decimal Value
        {
            get { return _value; }
            set { _value = value; }
        }

        // Method to Determine the Valuation on a 
        // specific date.
        public void GetValuation(DateTime vdate)
        {
            List<TransactionModel> trans = new List<TransactionModel>();
            decimal shares = 0;  //Number Shares Owned

            //ToDo - Create Connector to Pull transaction from beginning to date provided

            // Check Each Transaction for Stock to determine
            // Number of Shares own, and Stock Price on date requested
            foreach (TransactionModel item in trans)
            {
                switch (item.Type)
                {
                    case TransactionType.Buy:
                        shares += item.Shares;
                        break;
                    case TransactionType.Sale:
                        shares -= item.Shares;
                        break;
                    case TransactionType.Update:
                        _value = item.Price * shares;
                        break;
                    case TransactionType.Split:
                        shares = item.Shares;
                        break;
                }
            }

        }
    }
}
