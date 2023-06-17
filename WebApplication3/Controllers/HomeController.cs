using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;
using WebApplication3.Models.Modelclasses;
using WebApplication3.Models.Services.Interface;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Ihellos ser;

        public HomeController(ILogger<HomeController> logger, Ihellos ser1)
        {
            _logger = logger;
            ser = ser1;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult totalitems()
        {
            return View();
        }
        public IActionResult totalitems_(DateTime d1,DateTime d2)
        {
            int seats=ser.ti(d1, d2);
            ViewBag.seats = seats;
            return View();
        }
        public IActionResult percentage_of_department_wise_sold_items()
        {
            List<perc> r = new List<perc>();
            r = ser.getp();
            return View(r);
        }

        public IActionResult monthly_sales()
        {
            
            return View();
        }
        public IActionResult monthly_sales_(int year, string product)
        {
            List<int> a = ser.getm(year,product);
            ViewBag.a = a;
            return View();
        }

        public IActionResult nth_most_total_item()
        {
            
            return View();
        }
        public IActionResult nth_most_total_item_(DateTime d1, DateTime d2,int n)
        {
            string a = ser.getq(d1, d2, n);
            ViewBag.quantity = a;
            return View();
        }


        public IActionResult hello()
        {
            int a = ser.get();
            if (a == 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
