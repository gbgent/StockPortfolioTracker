﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackerDataLibrary.DataModels
{
    public class ChartModel
    {
        public DateTime Date { get; set; }

        public decimal Value { get; set;}

        public decimal Cost { get; set; }
    }
}
