using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MassFood.Models
{
    public class Foods
    {
        public int id { get; set; }
        public string name { get; set; }
        public string price { get; set; }
        public string category { get; set; }
        public string image { get; set; }
    }
}