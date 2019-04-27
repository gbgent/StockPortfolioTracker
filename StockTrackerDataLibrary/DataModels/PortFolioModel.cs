using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace StockTrackerDataLibrary.DataModels
{
    public class PortFolioModel

    {
        public List<StockModel> Stocks;

        public void Load()
        {
            //Load All Stocks Owned
            Stocks = GlobalConfig.Connection.Stocks_LoadAll();
        }

        public decimal CurrentValue()
        {
            decimal total = 0M;

            // Load for update list of stocks
            Load();

            // Recurse through all Stocks for Total Value

            foreach (StockModel st in Stocks)
            {
                total += st.Value.Current(st);
            }

            return total;
        }

        public List<PortValueModel> HistoricalValuesAll()
        {
            // List of the Sum of each Daily Transactions  Also the Return Item
            List<PortValueModel> DailyValues = new List<PortValueModel>();

            // Other Local Variables
            int counter = 0;            
            PortValueModel _value = new PortValueModel();

            // Load All Valuations
            List<ValuationModel> values = GlobalConfig.Connection.Valuation_LoadAll();

            //Assign First Date as the beginning Working Date
            _value.Date = values.First().Date;


            foreach (ValuationModel vm in values)
            {
                
                if (vm != values.Last()) //Check for last Record Processing
                {
                    if (vm.Date == _value.Date)  //Add Value and Cost to Total for date
                    {
                        _value.Value += vm.Value;
                        _value.Cost += vm.Cost;                        
                    }
                    else
                    {
                        // Add Current Daily Value to List of Daily Values
                        DailyValues.Insert(counter, _value);

                        //Create new iinstance of PortValueModel
                        _value = new PortValueModel()
                        {
                            Date = vm.Date,
                            Value = vm.Value,
                            Cost = vm.Cost
                        };

                        //Increase Counter
                        counter++;
                    }
                }
                else
                {
                    if(vm.Date == _value.Date) // Last Record is Same Day
                    {
                        _value.Value += vm.Value;
                        _value.Cost = vm.Cost;

                        DailyValues.Insert(counter, _value);
                    }
                    else
                    {
                        DailyValues.Insert(counter, _value);

                        _value = new PortValueModel()
                        {
                            Date = vm.Date,
                            Value = vm.Value,
                            Cost = vm.Cost
                        };

                        counter++;

                        DailyValues.Insert(counter, _value);
                       
                    }
                }                
            }

            return DailyValues;
        }
    }

    public class PortValueModel
    {
        public DateTime Date { get; set; }

        public decimal Value { get; set; }

        public decimal Cost { get; set; }
    }

}
