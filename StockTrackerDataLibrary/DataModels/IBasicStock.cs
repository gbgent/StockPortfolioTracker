using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackerDataLibrary.DataModels
{
    public interface IBasicStock
    {
        String Symbol { get; set; }

        String Name { get; set; }
    }
}
