using HighChartsMVC.Chart.Pie;
using HighChartsMVC.Data_Acces_Layer;
using HighChartsMVC.Models;
using HighChartsMVC.Models.ChartData;
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
            List<int> seriesData = _db.pieChartData.Select(o=>o.value).ToList();
            dataset.data = seriesData; 
            Colors bgColors = new Colors();
            dataset.backgroundColor =  bgColors.ChartColors;
            dataset.borderColor =bgColors.ChartColors;
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



