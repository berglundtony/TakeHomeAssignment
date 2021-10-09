using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TakeHomeAssignment.Data
{
    public class ReturnRateInformation
    {
        public string MinRateText { get; set; }
        public double MinRate { get; set; }
        public string OnMin { get; set; }
        public string MinDate { get; set; }
        public string MaxRateText { get; set; }
        public double MaxRate { get; set; }
        public string OnMax { get; set; }
        public string MaxDate { get; set; }
        public string AvarageRateText { get; set; }
        public double AvarageRate { get; set; }
    }
}
