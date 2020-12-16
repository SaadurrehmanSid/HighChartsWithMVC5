using HighChartsMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HighChartsMVC.Data_Acces_Layer
{
    public class AppDbContext : DbContext
    {
        public DbSet<Analysis> Analyses{ get; set; }
}
}