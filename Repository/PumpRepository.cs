using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF_Tutorial.Data;
using EF_Tutorial.Interface;
using EF_Tutorial.Models;

namespace EF_Tutorial.Repository
{
    public class PumpRepository : IPump
    {
        private readonly DataContext _dataContext;
        public PumpRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        } 

        public ICollection<Pump> GetPumps()
        {
            return _dataContext.Pumps.OrderBy(p => p.PumpId).ToList();
        }

        public ICollection<Pump> GetPumpByUserId(int userId)
        {
            return _dataContext.Pumps.Where(p => p.User.UserId == userId).ToList();
        }
        
        public Pump GetPumpByPumpId(int pumpId)
        {
            return _dataContext.Pumps.Find(pumpId);
        }

        public bool AddPump(Pump pump) {
            if(pump == null) {
                throw new ArgumentNullException("Pump is null");
            }
            _dataContext.Add(pump);
            return Save();
        }

        public bool DeletePump(int pumpId) {
            var pump = GetPumpByPumpId(pumpId);
            _dataContext.Remove(pump);
            return Save();
        }

        public bool Save()
        {
            var saved = _dataContext.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}