// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using EF_Tutorial.Data;
// using EF_Tutorial.Interface;
// using EF_Tutorial.Models;

// namespace EF_Tutorial.Repository
// {
//     public class PumpForecastRepository : IPumpForecast
//     {
//         private readonly DataContext _dataContext;

//         public PumpForecastRepository(DataContext dataContext)
//         {
//             _dataContext = dataContext;
//         }

//         public ICollection<PumpForecast> GetPumpForecastsByPumpId(int pumpId)
//         {
//             return _dataContext.PumpForecasts.Where(p => p.Pump.Id == pumpId).ToList();
//         }
//     }
// }