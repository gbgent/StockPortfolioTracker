using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackerDataLibrary.DataModels
{
    public class BrokerageModel
    {
        private int _idNum;
        private string _name;
        private string _broker;
        private bool _isFixedRate;
        private decimal _commissionRate;

        public int IDNum
        {
            get { return _idNum; }
            set { _idNum = value; }
        }
                
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        
        public string Broker
        {
            get { return _broker; }
            set { _broker = value; }
        }
        
        public bool IsFixedRate
        {
            get { return _isFixedRate; }
            set { _isFixedRate = value; }
        }
        
        public decimal CommissionRate
        {
            get { return _commissionRate; }
            set { _commissionRate = value; }
        }


    }
}
