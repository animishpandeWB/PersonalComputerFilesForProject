using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EF_Tutorial.Models
{
    public class Pump
    {
        [Key]
        public int Id { get; set; }
        public int PumpId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public bool Status { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        // public ICollection<PumpForecast>? PumpForecasts {get; set;}
        // public ICollection<JsonData>? JsonData { get; set; }
    }
}