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

        void Stocks_AddNew(BasicStockModel model);

        List<StockModel> Stocks_LoadAll();

        void Transaction_AddNew(TransactionModel model);

        List<TransactionModel> Transactions_SingleStock_Load(int id);

        void Valuation_AddNew(ValuationModel model);

        List<ValuationModel> Valuation_Stock(int id);

        List<ValuationModel> Valuation_LoadAll();
    }
}
