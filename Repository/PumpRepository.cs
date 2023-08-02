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
            return _dataContext.Pumps.OrderBy(p => p.Id).ToList();
        }

        public ICollection<Pump> GetPumpByUserId(int userId)
        {
            return _dataContext.Pumps.Where(p => p.User.Id == userId).ToList();
        }
    }
}