using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models.Entity
{
    public class data
    {
        public Decimal ID { set; get; }
        public DateTime date { set; get; }
        public string user { set; get; }
        public string department { get; set; }
        public string software { get; set; }
        public Decimal seats { get; set; }
        public Decimal amount { get; set; }
    }
}
