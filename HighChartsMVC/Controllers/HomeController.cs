using HighChartsMVC.Chart.Pie;
using HighChartsMVC.Data_Acces_Layer;
using HighChartsMVC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HighChartsMVC.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _db;
        public HomeController()
        {
            _db = new AppDbContext();
        }
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult SeriesData() 
        {
            var pieChartData = _db.pieChartData.Select(i => new  { i.name, i.value }).ToList();

            Pie pie = new Pie();
            pie.type =  (ChartEnums.pie).ToString();
            Data data = new Data();
            List<string> result = _db.pieChartData.Select(o => o.name.ToString()).ToList();
            data.labels = result;
            Dataset dataset = new Dataset();
            dataset.label = "# of Votes";
            dataset.data = new List<int>() { 12, 19, 3, 5, 2, 3 };
            dataset.backgroundColor = new List<string>() {"rgba(255, 99, 132, 0.2)",
                            "rgba(54, 162, 235, 0.2)",
                            "rgba(255, 206, 86, 0.2)",
                            "rgba(75, 192, 192, 0.2)",
                            "rgba(153, 102, 255, 0.2)",
                            "rgba(255, 159, 64, 0.2)" };
            dataset.borderColor = new List<string>() {"rgba(255, 99, 132, 1)",
                            "rgba(54, 162, 235, 1)",
                            "rgba(255, 206, 86, 1)",
                            "rgba(75, 192, 192, 1)",
                            "rgba(153, 102, 255, 1)",
                            "rgba(255, 159, 64, 1)" };
            dataset.borderWidth = 1;
            data.datasets = new List<Dataset>() { dataset };
            Options options = new Options();
            options.scales = new Scales() { yAxes = new List<YAxis>() { new YAxis() { ticks = new Ticks() { beginAtZero = true } } }};
            pie.data = data;
            pie.options = options;
            string jsonData = JsonConvert.SerializeObject(pie);
            return Json(jsonData,JsonRequestBehavior.AllowGet);
        }



        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}



