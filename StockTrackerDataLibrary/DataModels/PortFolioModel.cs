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

        public decimal CurrentValue
        {
            get { return CalcCurrentValue(); }
        }

        public List<ChartModel> ChartingValuesAll
        {
            get { return RetrieveCharting(); }
        }

        public PortFolioModel()
        {
            Load();
        }
       

        public void Load()
        {
            Stocks = GlobalConfig.Connection.Stocks_LoadAll();
        }

        private decimal CalcCurrentValue()

        {
            decimal output = 0M;

            foreach (StockModel st in Stocks)
            {
                output += GlobalConfig.Connection.Valuation_Stock(st.StockId).LastOrDefault().Value;
            }
            return output;
        }

        private List<ChartModel> RetrieveCharting()
        {
            // Load All Valuations
            List<ValuationModel> vals = GlobalConfig.Connection.Valuation_LoadAll();
                        
            //Create Output object
            List<ChartModel> Values = new List<ChartModel>();
            ChartModel _chart; // Temp variable to place daily value before adding to list

            _chart = new ChartModel();
            _chart.Date = vals.First().Date; //Set up Temp Chart Date to First Date of List
            _chart.Value = 0m;
            _chart.Cost = 0M;

            //Loop Through the list of Valuations
            foreach (ValuationModel vm in vals)
            {                
                if(vm != vals.Last())
                {
                    if (vm.Date == _chart.Date)
                    {
                        _chart.Value += vm.Value;
                        _chart.Cost += vm.Cost;
                    }
                    else
                    {
                        Values.Add(_chart);

                        _chart = new ChartModel();
                        _chart.Date = vm.Date;
                        _chart.Value += vm.Value;
                        _chart.Cost += vm.Cost;
                    }
                }
                else if(vm.Date == _chart.Date)
                {
                    _chart.Value += vm.Value;
                    _chart.Cost += vm.Cost;

                    Values.Add(_chart);
                }
                else
                {
                    Values.Add(_chart);

                    _chart = new ChartModel();
                    _chart.Date = vm.Date;
                    _chart.Value = vm.Value;
                    _chart.Cost = vm.Cost;

                    Values.Add(_chart);
                }
            }

            return Values;
        }
    }
}
