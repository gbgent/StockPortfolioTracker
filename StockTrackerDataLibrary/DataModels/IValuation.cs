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

        decimal Shares { get; set; }

        decimal Price { get; set; }

        decimal Value { get; }
                
    }
}
