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
        private readonly IJsondata _jsonInterface;

        // private int jsonDataId = 16;


        public PumpRepository(DataContext dataContext, IJsondata jsonInterface)
        {
            _dataContext = dataContext;
            _jsonInterface = jsonInterface;
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
            return _dataContext.Pumps.Where(p => p.PumpId == pumpId).FirstOrDefault();
        }

        public bool AddPump(Pump pump)
        {
            if (pump == null)
            {
                throw new ArgumentNullException("Pump is null");
            }
            var addJsonData = new List<JsonData>();
            // jsonDataId = jsonDataId++;
            for (var i = 1; i < 8; i++)
            {
                Random rnd = new Random();
                addJsonData.Add(new JsonData
                {
                    jsonId = pump.PumpId,
                    date = "2022-03-" + "0" + i,
                    value1 = rnd.Next(100, 151),
                    value2 = rnd.Next(100, 151)
                });
            }
            foreach (var d in addJsonData)
            {
                _dataContext.Add(d);
            }
            _dataContext.Add(pump);
            return Save();
        }

        public bool DeletePump(int pumpId)
        {
            var pump = GetPumpByPumpId(pumpId);
            var jsonDataRemove = _jsonInterface.GetJsonDataById(pumpId);

            foreach (var j in jsonDataRemove)
            {
                _dataContext.Remove(j);
            }
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