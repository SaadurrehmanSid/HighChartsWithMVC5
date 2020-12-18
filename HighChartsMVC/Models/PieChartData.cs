using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HighChartsMVC.Models
{
    public class PieChartData
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int value { get; set; }
    }
}