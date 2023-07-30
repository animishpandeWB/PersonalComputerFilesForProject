// using System;
// using System.Collections.Generic;
// using System.ComponentModel.DataAnnotations;
// using System.Linq;
// using System.Threading.Tasks;

// namespace EF_Tutorial.Models
// {
//     public class PumpForecast
//     {
//         [Key]
//         public int PumpForecastId { get; set; }
//         public required List<int> PumpForecastData { get; set; }
//         public int PumpId { get; set; }
//         public Pump Pump { get; set; } = null!;
//     }
// }