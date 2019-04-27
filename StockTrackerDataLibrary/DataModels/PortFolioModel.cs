using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace StockTrackerDataLibrary.DataModels
{
    public class PortFolioModel
    {
        public List<BasicStockModel> Stocks = new List<BasicStockModel>();

        public void Load()
        {
            Stocks = GlobalConfig.Connection.Stocks_LoadAll();
        }
    }
}
