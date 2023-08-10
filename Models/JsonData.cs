using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Json;

namespace EF_Tutorial.Models
{
    public class JsonData
    {
        [Key]
        public int id {get; set;}
        public int jsonId {get; set;}
        public string date {get; set;}
        public int value1 {get; set;}
        public int value2 {get; set;}


    }
}