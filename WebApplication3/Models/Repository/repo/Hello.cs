using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models.Entity;
using WebApplication3.Models.Modelclasses;
using WebApplication3.Models.Repository.Interface;

namespace WebApplication3.Models.Repository.repo
{
    public class Hello : Ihello
    {
        private readonly MyDBContext context;
        public Hello(MyDBContext c)
        {
            context = c;
        }
        public int get()
        {
            return 1;
        }
        public int ti(DateTime d1,DateTime d2)
        {
            List<data> r = new List<data>();
            r = context.datas.Where(a => a.date > d1 & a.date < d2).ToList();
            Decimal sum = 0;
            foreach(data w in r)
            {
                sum = sum + w.seats;
            }
            return (int)sum;
        }
        public List<perc> getp()
        {
            perc pre1 = new perc();
            perc pre2 = new perc();
            perc pre3 = new perc();
            perc pre4 = new perc();
            perc pre5 = new perc();
            List<perc> a = new List<perc>();
            List<data> r1 = new List<data>();
            List<data> r2 = new List<data>();
            List<data> r3 = new List<data>();
            List<data> r4 = new List<data>();
            List<data> r5 = new List<data>();
            List<data> r = new List<data>();
            r = context.datas.ToList();
            Decimal sum = 0;
            foreach (data w in r)
            {
                sum = sum + w.seats;
            }
            r1 = context.datas.Where(a => a.department == "Tech").ToList();
            Decimal s = 0;
            foreach (data w in r1)
            {
                s = s + w.seats;
            }
            pre1.department = "Tech";
            pre1.seats = (int)s;
            pre1.percentage = 100*((float)s /(float) sum);
            a.Add(pre1);

            r2 = context.datas.Where(a => a.department == "Customer Success").ToList();
            s = 0;
            foreach (data w in r2)
            {
                s = s + w.seats;
            }
            pre2.department = "Customer Success";
            pre2.seats = (int)s;
            pre2.percentage = 100 * ((float)s / (float)sum);
            a.Add(pre2);


            r3 = context.datas.Where(a => a.department == "Sales").ToList();
            s = 0;
            foreach (data w in r3)
            {
                s = s + w.seats;
            }
            pre3.department = "Sales";
            pre3.seats = (int)s;
            pre3.percentage = 100 * ((float)s / (float)sum);
            a.Add(pre3);


            r4 = context.datas.Where(a => a.department == "HR").ToList();
            s = 0;
            foreach (data w in r4)
            {
                s = s + w.seats;
            }
            pre4.department = "HR";
            pre4.seats = (int)s;
            pre4.percentage = 100 * ((float)s / (float)sum);
            a.Add(pre4);


            r5 = context.datas.Where(a => a.department == "Marketting").ToList();
            s = 0;
            foreach (data w in r5)
            {
                s = s + w.seats;
            }
            pre5.department = "Marketting";
            pre5.seats = (int)s;
            pre5.percentage = 100 * ((float)s / (float)sum);
            a.Add(pre5);
            return a;
        }
        public List<int> getm(int year,string product)
        {
            List<int> a = new List<int>();
            List<data> r = new List<data>();
            DateTime d1 = new DateTime(year, 1, 1);
            DateTime d2 = new DateTime(year, 2, 1);
            r = context.datas.Where(a => a.software==product & a.date>d1 & a.date<d2).ToList();
            Decimal sum = 0;
            foreach (data w in r)
            {
                sum = sum + w.amount;
            }
            a.Add( (int)sum);


            d1 = new DateTime(year, 2, 1);
            d2 = new DateTime(year, 3, 1);
            r = context.datas.Where(a => a.software == product & a.date > d1 & a.date < d2).ToList();
            sum = 0;
            foreach (data w in r)
            {
                sum = sum + w.amount;
            }
            a.Add((int)sum);

            d1 = new DateTime(year, 3, 1);
            d2 = new DateTime(year, 4, 1);
            r = context.datas.Where(a => a.software == product & a.date > d1 & a.date < d2).ToList();
            sum = 0;
            foreach (data w in r)
            {
                sum = sum + w.amount;
            }
            a.Add((int)sum);

            d1 = new DateTime(year, 4, 1);
            d2 = new DateTime(year, 5, 1);
            r = context.datas.Where(a => a.software == product & a.date > d1 & a.date < d2).ToList();
            sum = 0;
            foreach (data w in r)
            {
                sum = sum + w.amount;
            }
            a.Add((int)sum);

            d1 = new DateTime(year, 5, 1);
            d2 = new DateTime(year, 6, 1);
            r = context.datas.Where(a => a.software == product & a.date > d1 & a.date < d2).ToList();
            sum = 0;
            foreach (data w in r)
            {
                sum = sum + w.amount;
            }
            a.Add((int)sum);
            d1 = new DateTime(year, 6, 1);
            d2 = new DateTime(year, 7, 1);
            r = context.datas.Where(a => a.software == product & a.date > d1 & a.date < d2).ToList();
            sum = 0;
            foreach (data w in r)
            {
                sum = sum + w.amount;
            }
            a.Add((int)sum);

            d1 = new DateTime(year, 7, 1);
            d2 = new DateTime(year, 8, 1);
            r = context.datas.Where(a => a.software == product & a.date > d1 & a.date < d2).ToList();
            sum = 0;
            foreach (data w in r)
            {
                sum = sum + w.amount;
            }
            a.Add((int)sum);

            d1 = new DateTime(year, 8, 1);
            d2 = new DateTime(year, 9, 1);
            r = context.datas.Where(a => a.software == product & a.date > d1 & a.date < d2).ToList();
            sum = 0;
            foreach (data w in r)
            {
                sum = sum + w.amount;
            }
            a.Add((int)sum);


            d1 = new DateTime(year, 9, 1);
            d2 = new DateTime(year, 10, 1);
            r = context.datas.Where(a => a.software == product & a.date > d1 & a.date < d2).ToList();
            sum = 0;
            foreach (data w in r)
            {
                sum = sum + w.amount;
            }
            a.Add((int)sum);
            d1 = new DateTime(year, 10, 1);
            d2 = new DateTime(year, 11, 1);
            r = context.datas.Where(a => a.software == product & a.date > d1 & a.date < d2).ToList();
            sum = 0;
            foreach (data w in r)
            {
                sum = sum + w.amount;
            }
            a.Add((int)sum);

            d1 = new DateTime(year, 11, 1);
            d2 = new DateTime(year, 12, 1);
            r = context.datas.Where(a => a.software == product & a.date > d1 & a.date < d2).ToList();
            sum = 0;
            foreach (data w in r)
            {
                sum = sum + w.amount;
            }
            a.Add((int)sum);
            d1 = new DateTime(year, 12, 1);
            d2 = new DateTime(year, 12, 31);
            r = context.datas.Where(a => a.software == product & a.date > d1 & a.date < d2).ToList();
            sum = 0;
            foreach (data w in r)
            {
                sum = sum + w.amount;
            }
            a.Add((int)sum);
            return a;
        }
        public string getq(DateTime d1,DateTime d2,int n)
        {
            string ans="";
            List<pq> z = new List<pq>();
            var soft = new string[] { "Height", "Google", "Figma", "Zapier", "Zoho Crm", "Circleci", "Appolo", "Notion", "Sentry", "Apple", "Discord", "Teams", "Fullstory", "Outplay", "Slack", "Github" };
            List<string> s = new List<string>(soft);
            for (int i = 0; i < 16; i++) {
                pq x = new pq();
                List<data> r = new List<data>();
                r = context.datas.Where(a => a.software == soft[i] & a.date > d1 & a.date < d2).ToList();
                int sum = 0;
                foreach (data w in r)
                {
                    sum = sum + (int)w.amount;
                }
                x.p = soft[i];
                x.q = sum;
                z.Add(x);
            }
            z.Sort((l, y) => ((int)l.q).CompareTo((int)y.q));
            ans = z[n - 1].p;
            return ans;
        }
    }
}
