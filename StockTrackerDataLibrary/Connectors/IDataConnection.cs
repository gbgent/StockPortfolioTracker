using StockTrackerDataLibrary.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackerDataLibrary.Connectors
{
    public interface IDataConnection
    {
        void Broker_AddNew(BrokerageModel model);

        void Broker_Update(BrokerageModel model);

        List<BrokerageModel> Broker_GetAll();
    }
}
