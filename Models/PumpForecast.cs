using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_Tutorial.Models
{
    public class PumpForecast
    {
        public int PumpForecastId { get; set; }
        public int PumpForecastData { get; set; }
        public Pump Pump { get; set; }
    }
}