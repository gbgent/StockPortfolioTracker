using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackerDataLibrary.DataModels
{
    public interface IValuation
    {
        
        DateTime ValuationDate { get; set; }

        decimal Value { get; set; }
        
        // Method to Determine the Valuation on a 
        // specific date.
        void GetValuation(DateTime vdate);

    }
}
