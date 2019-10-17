using LinqToExcel;
using Microsoft.Ajax.Utilities;
using NBA.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Web;

namespace NBA.Data
{
    public class NBAContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Stat> Stats { get; set; }

        public NBAContext()
        {
            ExcelQueryFactory excel = new ExcelQueryFactory("C:/Users/fmons/source/repos/NBA/NBA/Data/players.xlsx");

            var Players = from p in excel.Worksheet<Player>("Hoja1")
                          select p;
            
            Players.ForEach(p => this.Players.Add(p));

            ExcelQueryFactory excel2 = new ExcelQueryFactory("/Data/playerstats.xlsx");

            var Stats = from s in excel2.Worksheet<Stat>("Hoja1")
                          select s;

            Stats.ForEach(s => this.Stats.Add(s));

            this.SaveChanges();
        }
    }
}
    