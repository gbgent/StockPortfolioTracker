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
            get { return _stockId; }            
            set { _stockId = value; }
        }
        
        public String Symbol
        {
            get { return _symbol; }
            set { _symbol = value; }
        }

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string DisplayName
        { get {return $"{_name} - {_symbol}";}
        }

        //Default Constructor for Model
        public BasicStockModel()
        {
        }

        //Constructor passing Name and Symbol Only
        //Used with adding a new stock to the portfolio
        public BasicStockModel(string name, string sym)
        {
            _name = name;
            _symbol = sym;
        }

        //Constructor passing all three fields
        //Currently used for Testing.
        public BasicStockModel(int id, string name, string sym)
        {
            _stockId = id;
            _name = name;
            _symbol = sym;
        }



    }
}
