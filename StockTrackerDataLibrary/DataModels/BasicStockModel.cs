using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackerDataLibrary.DataModels
{
    public class BasicStockModel :IBasicStock
    {
        private int _stockId;
        private string _symbol;
        private string _name;


        public int StockId
        {
            get
            { return _stockId; }
            set
            { _stockId = value; }
        }

        public String Symbol
        { get
            { return _symbol; }
            set
            { _symbol = value; }
        }

        public String Name
        {
            get
            { return _name; }
            set
            { _name = value; }
        }

        public string DisplayName
        { get { return $"{_name} - {_symbol}";} }

        // Default Contructor
        public BasicStockModel()
        {

        }

        //Constructor with Symbol and Name being passed in.
        public BasicStockModel(string sym, string name)
        {
            _symbol = sym;
            _name = name;

        }

        public BasicStockModel(int num, string sym, string name)
        {
            _stockId = num;
            _symbol = sym;
            _name = name;
        }

        public void SetTemp()
        {
            _stockId = 1;
            _symbol = "AAPL";
            _name = "Apple";            
        }
    }
}
