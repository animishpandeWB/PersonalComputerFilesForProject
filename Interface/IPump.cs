using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF_Tutorial.Models;

namespace EF_Tutorial.Interface
{
    public interface IPump
    {
        ICollection<Pump> GetPumps();
        ICollection<Pump> GetPumpByUserId(int userId);
        Pump GetPumpByPumpId(int pumpId);
        bool AddPump(Pump pump);
        bool DeletePump(int pumpId);
        bool Save();
    }
}