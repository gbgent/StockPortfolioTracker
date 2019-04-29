using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackerDataLibrary.DataModels
{
    public class ValueModel
    {
        // Private Variables
        private int _stockId;
       

        // Public Properties
        public ValuationModel Current;

        public List<ValuationModel> All;
        
        // Constructors
        public ValueModel()
        {
        }

        public ValueModel(int id)
        {
            _stockId = id;
            CalcCurrentValue();
            CalAllValues();
        }


        // Public Methods
        public void SetID (int id)
        {
            _stockId = id;
            CalcCurrentValue();
            CalAllValues();
        }

        private void CalcCurrentValue()
        {
            List<ValuationModel> vals = GlobalConfig.Connection.Valuation_Stock(_stockId);

            Current = vals.LastOrDefault();
                        
        }


        private void CalAllValues()
        {
            List<ValuationModel> vals = GlobalConfig.Connection.Valuation_Stock(_stockId);

            All = vals;
        }
    }
}
