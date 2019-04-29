using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace StockTrackerDataLibrary.DataModels
{
    public class PortFolioModel
    {
        public List<StockModel> Stocks = new List<StockModel>();

        public void Load()
        {
            Stocks = GlobalConfig.Connection.Stocks_LoadAll();
        }
    }
}
