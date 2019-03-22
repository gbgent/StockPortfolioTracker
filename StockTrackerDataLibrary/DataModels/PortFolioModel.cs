using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace StockTrackerDataLibrary.DataModels
{
    public class PortFolioModel
    {
        int PortId;

        BasicStockModel Stock;

        public ValuationModel Value
        { get { return GetCurrentValue(); }
        }


        private ValuationModel GetCurrentValue()
        {
            ValuationModel output;

            output = StockTrackerProccesorLibrary.ValuationMethods.PortFolioValue(Stock);
            return output;
        }
    }
}
