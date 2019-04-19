﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockTrackerDataLibrary.DataModels;
using Dapper;

namespace StockTrackerDataLibrary.Connectors
{
    public class SqlConnector : IDataConnection
    {
        // Define Const String to match Connestion STring 
        // Name listed in App Config
        private const string db = "Stocks";

        // Method to add a Brokerage to Database
        public void Broker_AddNew(BrokerageModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@BrokerageName", model.BrokerageName);
                p.Add("@BrokerageAddress", model.BrokerageAddress);
                p.Add("@AccountNumber", model.AccountNum);
                p.Add("@BrokerName", model.BrokerName);
                p.Add("@PhoneNum", model.PhoneNum);
                p.Add("@Email", model.Email);
                p.Add("@CommissionRate", model.CommissionRate);
	            p.Add("@BrokerId", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.sp_Brokages_Insert", p, commandType: CommandType.StoredProcedure);

                model.BrokerId = p.Get<int>("@BrokerId");
            }
        }

        // Method to Update Brokerage Information
        public void Broker_Update(BrokerageModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@BrokerId",model.BrokerId);
                p.Add("@BrokerageName", model.BrokerageName);
                p.Add("@BrokerageAddress", model.BrokerageAddress);
                p.Add("@AccountNumber", model.AccountNum);
                p.Add("@BrokerName", model.BrokerName);
                p.Add("@PhoneNum", model.PhoneNum);
                p.Add("@Email", model.Email);
                p.Add("@CommissionRate", model.CommissionRate);
              

                connection.Execute("dbo.sp_Brokerages_Update", p, commandType: CommandType.StoredProcedure);
                                
            }
        }
        
        // Method to get a list of all Brokerages
        public List<BrokerageModel> Broker_GetAll()
        {
            List<BrokerageModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<BrokerageModel>("dbo.sp_Brokerages_Get_All").ToList();
            }

            return output;
        }

        //Method to Load Stock Portfolio
        public List<BasicStockModel> StockList_LoadAll()
        {
            List<BasicStockModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<BasicStockModel>("dbo.sp_StockList_Get_All").ToList();
            }

            return output;
        }

        // Method to load all transactions for a specific Stock
        public List<TransactionModel> Stock_Transactions_LoadAll(int id)
        {
            List<TransactionModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@StockId", id);

                output = connection.Query<TransactionModel>("dbo.sp_StockList_Get_All",
                                p,commandType: CommandType.StoredProcedure).ToList();
            }

            return output;
        }
    }
}
