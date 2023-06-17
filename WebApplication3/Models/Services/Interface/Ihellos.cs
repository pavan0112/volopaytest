using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models.Modelclasses;

namespace WebApplication3.Models.Services.Interface
{
    public interface Ihellos
    {
        public int get();
        public int ti(DateTime d1, DateTime d2);
        public List<perc> getp();
        public List<int> getm(int year, string product);
        public string getq(DateTime d1, DateTime d2, int n);
    }
}
