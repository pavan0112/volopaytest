using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models.Modelclasses;
using WebApplication3.Models.Repository.Interface;
using WebApplication3.Models.Services.Interface;

namespace WebApplication3.Models.Services.service
{
    public class Hellos : Ihellos
    {
        private readonly Ihello trepo;
        public Hellos(Ihello a)
        {
            trepo = a;
        }
        public int get()
        {
            return trepo.get();
        }
        public int ti(DateTime d1, DateTime d2)
        {
            return trepo.ti(d1, d2);
        }
        public List<perc> getp()
        {
            return trepo.getp();
        }
        public List<int> getm(int year, string product)
        {
            return trepo.getm(year, product);
        }
        public string getq(DateTime d1, DateTime d2, int n)
        {
            return trepo.getq(d1, d2, n);
        }
    }
}
