using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackerDataLibrary.DataModels
{
    public interface IValuation
    {
        
        DateTime Date { get;}

        decimal Shares { get;}

        decimal Price { get;}

        decimal Value { get; }
                
    }
}
