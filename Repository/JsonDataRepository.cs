using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using EF_Tutorial.Models;
using EF_Tutorial.Data;
using EF_Tutorial.Interface;


namespace EF_Tutorial.Repository
{
    public class JsonDataRepository : IJsondata
    {
        private readonly DataContext _dataContext;
        int jsonDataId = 1;

        public JsonDataRepository(DataContext dataContext) {
            _dataContext = dataContext;
        }
        

        public ICollection<JsonData> GetJsonData() 
        {
            return _dataContext.JsonData.OrderBy(j => j.id).ToList();
        }

        public ICollection<JsonData> GetJsonDataById(int id)
        {
            return _dataContext.JsonData.Where(j => j.jsonId == id).ToList();
        }

        public bool Save()
        {
            var saved = _dataContext.SaveChanges();
            return saved > 0 ? true : false;
        }
        
    }
}