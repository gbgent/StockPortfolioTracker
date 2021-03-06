﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackerDataLibrary.DataModels
{
    public class ValuationModel : IValuation
    {
       
        private DateTime _date;
        private decimal _shares;       
        private decimal _price;
        private decimal _cost;

        public int ValuationID { get; set; }

        public int StockId { get; set; }
        
        public DateTime Date  
        {
            get { return _date; }
            set { _date = value; }
        }
             
        public decimal Shares  
        {
            get { return _shares; }
            set { _shares = value; }
        }
        
        public decimal Price  
        {
            get { return _price; }
            set { _price = value; }
        }
                
        public decimal Cost  
        {
            get { return _cost; }
            set { _cost = value; }
        }
        
        public decimal Value  
        {
            get { return _price * _shares;}
        }
    }
}
