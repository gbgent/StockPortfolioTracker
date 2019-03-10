using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackerDataLibrary.DataModels
{
    public class BasicStockModel
    {
        private string _symbol;
        private string _name;        

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
               
              

        public void SetTemp()
        {
            _symbol = "AAPL";
            _name = "Apple";            
        }
    }
}
