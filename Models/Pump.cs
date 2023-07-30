using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_Tutorial.Models
{
    public class Pump
    {
        public int PumpId { get; set; }
        public int UserId { get; set; }
        public string PumpName { get; set; }
        public string PumpType { get; set; }
        public DateTime PumpTime { get; set; }
        public bool PumpStatus { get; set; }
        // public List<int> PumpForecast { get; set; }
        // public ICollection<PumpForecast> PumpForecasts { get; set; } = new List<PumpForecast>();
        public User User { get; set; } = null!;
    }
}