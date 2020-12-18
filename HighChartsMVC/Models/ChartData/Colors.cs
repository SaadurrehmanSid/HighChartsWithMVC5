using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HighChartsMVC.Models.ChartData
{
    public class Colors
    {
        public Colors()
        {
            ChartColors = new List<string>()
            {
                           "rgba(255, 99, 132, 0.2)",
                            "rgba(54, 162, 235, 0.2)",
                            "rgba(255, 206, 86, 0.2)",
                            "rgba(75, 192, 192, 0.2)",
                            "rgba(153, 102, 255, 0.2)",
                            "rgba(255, 159, 64, 0.2)",
                             "rgba(205, 199, 134, 0.2)",
                              "rgba(255, 219, 162, 0.2)",
                               "rgba(215, 79, 142, 0.2)",
                                "rgba(251, 199, 162, 0.2)",
                                 "rgba(255, 169, 182, 0.2)",
                                  "rgba(222, 111, 000, 0.2)",
            };
        }
        public List<string> ChartColors { get; set; }
    }
}