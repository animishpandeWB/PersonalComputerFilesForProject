using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_Tutorial.Models
{
    public class PumpForecast
    {
        public int Id {get; set;}
        public string Day {get; set;}
        public int Forecast {get; set;}
        public int PumpId {get; set;}
        public Pump Pump {get; set;}

    }
}