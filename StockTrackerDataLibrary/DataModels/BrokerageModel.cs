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
        private string _brokerageName;
        private string _brokerageAddress;
        private string _accountNum;
        private string _broker;
        private string _phoneNum;
        private string _email;
        private decimal _commissionRate;

        public int BrokerId
        {
            get { return _idNum; }
            set { _idNum = value; }
        }
                
        public string BrokerageName
        {
            get { return _brokerageName; }
            set { _brokerageName = value; }
        }

        public string BrokerageAddress
        {
            get { return _brokerageAddress; }
            set { _brokerageAddress = value; }
        }


        public string AccountNum
        {
            get { return _accountNum; }
            set { _accountNum = value; }
        }

        public string BrokerName
        {
            get { return _broker; }
            set { _broker = value; }
        }

        public string PhoneNum
        {
            get { return _phoneNum; }
            set { _phoneNum = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public decimal CommissionRate
        {
            get { return _commissionRate; }
            set { _commissionRate = value; }
        }


    }
}
